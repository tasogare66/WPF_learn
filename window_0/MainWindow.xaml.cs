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
using System.ComponentModel;

namespace window_0
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        static int _createCount;
        public MainWindow()
        {
            InitializeComponent();
            //Title = "ウィ"
            _createCount++;
        }

        void NewWindowClicked(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        void ListOpenWindows(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Window openWindow in Application.Current.Windows)
            {
                sb.AppendLine(openWindow.Title);
            }
            MessageBox.Show(sb.ToString(), "Open Windows");
        }

        void WindowLoaded(object sender, RoutedEventArgs e)
        {
            Title = "このウィドウがロードされた日時: " + DateTime.Now;
        }

        void WindowClosing(object sender, CancelEventArgs e)
        {
            if( MessageBox.Show("本当にとじますか？",
                "確認",
                MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                // ウィンドウが閉じる
            }
        }

        void ShowMethod(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Title = "Show";
            w.Show();
        }

        void UseVisibilityProperty(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Title = "Visiblity = Visible";
            w.Visibility = Visibility.Visible;
        }

        void ShowDialogMethod(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Title = "ShowDialog";
            w.Owner = this;
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            w.ShowInTaskbar = false;
            w.ShowDialog();
        }

        void ShowOwner(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Owner = this;
            w.Title = "ShowOwner";
            w.Show();
        }
    }
}
