using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace control_0
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StackPanel panel = new StackPanel();

            ContentPresenter intPresenter = new ContentPresenter();
            intPresenter.Content = 5;
            panel.Children.Add(intPresenter);

            ContentPresenter datePresenter = new ContentPresenter();
            datePresenter.Content = DateTime.Now;
            panel.Children.Add(datePresenter);

            ContentPresenter elementPresenter = new ContentPresenter();
            elementPresenter.Content = new Button();
            panel.Children.Add(elementPresenter);

            ListBox l = new ListBox();
            l.Items.Add("Hello");
            l.Items.Add("There");
            l.Items.Add("World");
            panel.Children.Add(l);

            Content = panel;
        }
    }
}
