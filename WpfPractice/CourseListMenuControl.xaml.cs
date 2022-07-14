// Copyright © 2022 Tsubasa co., Ltd. All rights reserved.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPractice
{
    /// <summary>
    /// 学科選択メニュー
    /// </summary>
    public partial class CourseListMenuControl : UserControl
    {
        public CourseListMenuControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// [今だけ] 学科を定義した json を落としてロードする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Drop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop, true) as string[];
            var path = files?.FirstOrDefault();
            if (path != null && File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var root = System.Text.Json.JsonSerializer.Deserialize<CourseDataRoot>(json);
                loadCourseList(root?.course_list);
            }
        }

        /// <summary>
        /// 学科データから学科選択メニューを構築
        /// 中身の Button は今だけの仮実装
        /// </summary>
        /// <param name="list"></param>
        private void loadCourseList(CourseData[]? list)
        {
            if (list == null) return;
            var group = list.GroupBy(o => o.course_code);
            foreach (var course in group)
            {
                var capital = course.FirstOrDefault();
                if (capital == null) continue;
                var button = new Button()
                {
                    Content = $"[{capital.course_code}] {capital.course_name}",
                    Height = 30
                };
                button.Click += (s, e) => {
                    MessageBox.Show($"{capital.course_name} : {course.Count()} sub items");
                };
                CourseListPanel.Children.Add(button);
            }

            MessageBox.Show($"Loaded {group.Count()} items");
        }
    }
}
