using System.Windows;
using System;

class Program
{
    [STAThread]
    static void Main()
    {
        Application app = new Application();
        Window w = new Window();
        w.Title = "Hello World";
        app.Run(w);
    }
}