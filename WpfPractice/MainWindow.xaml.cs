﻿using System;
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

            ContentsRoot.Visibility = grid.Visibility;
            ContentsRoot2.Visibility = grid1.Visibility;
        }
        //クリアボタン押下時、画像やjsonのクリア処理
        private void btnClear_click(object sender, EventArgs e)
        { 
            PictureFrame pf = new PictureFrame(); 
            Image? img = new Image();

            pf.PicturePanel.Children.Add(img) ;

        }
    }
}