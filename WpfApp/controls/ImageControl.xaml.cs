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
    /// ImageControl.xaml 的交互逻辑
    /// </summary>
    public partial class ImageControl : Window
    {
        public ImageControl()
        {
            InitializeComponent();
        }

        private void changeImg_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("../imgs/gradient2-alt.jpg",UriKind.Relative));
        }

        private void showImg_Click(object sender, RoutedEventArgs e)
        {
            pic.Source = new BitmapImage(new Uri("pack://application:,,,/imgs/gradient2-alt.jpg", UriKind.Absolute));
        }

        private void showPic_Click(object sender, RoutedEventArgs e)
        {
            icon.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/imgs/afae0e0880b05feae6dbcd4a6b210a51.jpg"));
        }
    }
}
