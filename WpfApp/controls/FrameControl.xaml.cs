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
using System.Windows.Shapes;

namespace WpfApp.controls
{
    /// <summary>
    /// FrameControl.xaml 的交互逻辑
    /// </summary>
    public partial class FrameControl : Window
    {
        public FrameControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //framePage.Source = new Uri("RoleINfoPage.xaml",UriKind.Relative
            //
            RoleInfoPage roleInfoPage = new RoleInfoPage();
            framePage.Navigate(roleInfoPage);
            string ss = "aaa";
            framePage.Navigate(roleInfoPage, ss);
        }
    }
}
