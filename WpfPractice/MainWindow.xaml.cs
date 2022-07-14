using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        //チェンジボタン押下時、の表示切替
        private void btnChange_click(object sender, EventArgs e)
        {
            Visibility visi = Visibility.Visible;
            Visibility hidd = Visibility.Hidden;
            Grid grid = new Grid();
            Grid grid1 = new Grid();
            //表示しているほうは非表示に
            if (ContentsRoot.Visibility == visi)
            {

                grid.Visibility = hidd;
                grid1.Visibility = visi;
            }
            else
            {
                grid.Visibility = visi;
                grid1.Visibility = hidd;
            }
            //それぞれにvisivlity振り分け
            ContentsRoot.Visibility = grid.Visibility;
            ContentsRoot2.Visibility = grid1.Visibility;
        }
        //クリアボタン押下時、画像やjsonのクリア処理
        private void btnClear_click(object sender, EventArgs e)
        { 
            //一度削除して、作り直す
            //中身の要素のみを削除する方法は発見出来なかった
            PictureFrame pf = new PictureFrame();
            ContentsRoot2.Children.Remove(pf);
            pf.Width = 300;
            pf.Height = 200;
            ContentsRoot2.Children.Add(pf);

            CourseListMenuControl cmc = new CourseListMenuControl();
            ContentsRoot.Children.Remove(cmc);
            cmc.Width = 220;
            cmc.HorizontalAlignment = HorizontalAlignment.Left;
            ContentsRoot.Children.Add(cmc);

        }
    }
}
