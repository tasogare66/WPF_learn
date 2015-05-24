using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace window_3
{
    /// <summary>
    /// name.xaml の相互作用ロジック
    /// </summary>
    public partial class name : Page
    {
        public name()
        {
            InitializeComponent();
        }

        void Navigate(object sender, RoutedEventArgs e)
        {
            var hello = new hello();

            hello.Name = _nameBox.Text;
            NavigationService.Navigate(hello);
        }

        NavigationService _navigation;

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            _navigation = this.NavigationService;
            _navigation.Navigating += Page_Navigating;
            _navigation.Navigated += Page_Navigated;
        }

        void Page_Navigated(object sender, NavigationEventArgs e)
        {
            _navigation.RemoveBackEntry();  // エントリ削除
            
            _navigation.Navigating -= Page_Navigating;
            _navigation.Navigated -= Page_Navigated;
            _navigation = null;
        }

        void Page_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.New &&
                _nameBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }
    }
}
