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
    /// PictureFrame.xaml の相互作用ロジック
    /// </summary>
    public partial class PictureFrame : UserControl
    {
        public PictureFrame()
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
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            var fileName = files[0];
            
            Image img =new Image();
            img.Source = new BitmapImage(new Uri(fileName));
            StackPanel pp = new StackPanel();
            pp.Children.Add(img);
            Content = pp;
            
        }
    }
}
