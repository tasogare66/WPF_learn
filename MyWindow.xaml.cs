using System;
using System.Windows.Controls;
using System.Windows;

namespace EssentialWPF
{
    public partial class MyWindow : Window
    {
        public MyWindow()
        {
            InitializeComponent();
        }
        void HowdyClicked(object sender, RoutedEventArgs e)
        {
            _text1.Text = "C#‚©‚ç‚±‚ñ‚É‚¿‚Í";
        }
    }
}