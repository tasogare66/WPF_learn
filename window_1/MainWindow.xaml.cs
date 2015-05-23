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

namespace window_1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Navigate(new Page1());
        }
    }

    public class Page1 : Page
    {
        public Page1()
        {
            TextBlock block = new TextBlock();
            Hyperlink link = new Hyperlink();
            link.Click += LinkClicked;
            link.Inlines.Add("クリックしてページ２に移動");
            block.Inlines.Add(link);
            Content = block;
            this.WindowTitle = "ページ１";
        }

        void LinkClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
    }

    public class Page2 : Page
    {
        public Page2()
        {
            this.WindowTitle = "ページ２";
        }
    }

}
