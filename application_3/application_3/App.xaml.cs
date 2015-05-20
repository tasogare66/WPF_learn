using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows;

namespace application_3
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += AppStartup;
        }

        void AppStartup(object sender, StartupEventArgs args)
        {
            MainWindow w0 = (MainWindow)Application.LoadComponent( new Uri("MainWindow.xaml", UriKind.Relative));
            w0.Show();

            MainWindow w1 = new MainWindow();
            w1.Show();
        }

    }
}
