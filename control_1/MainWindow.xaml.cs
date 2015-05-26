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

namespace control_1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void ChangeIt(object sender, RoutedEventArgs e)
        {
            ControlTemplate template = new ControlTemplate(typeof(Button));
            // 不可視の楕円形を作成する テンプレート
            template.VisualTree = new FrameworkElementFactory(typeof(Ellipse));
            template.VisualTree.SetValue(Ellipse.FillProperty, Brushes.Blue);
            template.VisualTree.SetValue(Ellipse.WidthProperty, 75.0);
            template.VisualTree.SetValue(Ellipse.HeightProperty, 23.0);
            ((Button)sender).Template = template;
        }
    }
}
