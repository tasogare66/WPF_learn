using System;
using System.Windows;
using System.Windows.Threading;
using System.IO;

namespace EssentialWPF
{
    partial class MyApp : Application
    {
        private Exception _lastError;
        public Exception LastError
        {
            get { return _lastError; }
            set { _lastError = value; }
        }
        
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
            using (StreamWriter errorLog =
                new StreamWriter("error.log", true))
            {
                errorLog.WriteLine("Error @ " + DateTime.Now.ToString("R"));
                errorLog.WriteLine(e.Exception.ToString());
            }
            e.Handled = true;
            this.Properties["LastError"] = e.Exception;
            this.LastError = e.Exception;
            MessageBox.Show("ÉGÉâÅ[Ç™î≠ê∂ÇµÇ‹ÇµÇΩÅB");
        }
    }
}