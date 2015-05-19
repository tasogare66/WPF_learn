using System;
using System.Collections.Generic;
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
using System.Configuration;

namespace application_2
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
    }

    public class AppSettings : ApplicationSettingsBase
    {
        public AppSettings() : base() 
        {
        }

        [UserScopedSetting]
        [DefaultSettingValue("0")]
        public int RunCount
        {
            get { return (int)this["RunCount"];  }
            set { this["RunCount"] = value;  }
        }
    }
}
