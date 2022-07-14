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
        /// ドロップしたファイルをパネルに適用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Drop(object sender, DragEventArgs e)
        {
            //ファイルを取得
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //複数あったら一つ目のみ
            var fileName = files[0];
            //Image型にして今回のファイル格納
            Image img =new Image();
            img.Source = new BitmapImage(new Uri(fileName));
            //パネルに反映
            StackPanel pp = new StackPanel();
            pp.Children.Add(img);
            Content = pp;
            
        }
    }
}
