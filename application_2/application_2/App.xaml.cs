using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows;

namespace application_2
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        AppSettings _settings = new AppSettings();
        public AppSettings Settings
        {
            get { return _settings; }
        }
        
        public App()
        {
            this.Exit += MyApp_Exit;
            this.Startup += AppStartup;
        }

        void MyApp_Exit(object sender, ExitEventArgs e)
        {
            Settings.Save();
        }

        void AppStartup(object sender, StartupEventArgs args)
        {
            Window w = new Window();
            w.Title = "実行回数は" + (Settings.RunCount++) + "回です!";
            w.Show();
        }
    }
}
