using System;
using System.Windows;
using System.Windows.Threading;

namespace EssentialWPF
{
    partial class MyApp : Application
    {
        public MyApp()
        {
        }

        void MyApp_Startup(object sender, StartupEventArgs e)
        {
            Window w = new Window();
            w.Title = "Hello World";
            w.Show();
        }

        void Failure(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // カスタムロジック
        }
    }
}