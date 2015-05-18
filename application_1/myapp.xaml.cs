using System;
using System.Windows;

namespace EssentialWPF
{
    partial class MyApp : Application
    {
        public MyApp()
        {
            Window w = new Window();
            w.Title = "Hello World";
            w.Show();
        }
    }
}