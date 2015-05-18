using System;
using System.Windows;

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
    }
}