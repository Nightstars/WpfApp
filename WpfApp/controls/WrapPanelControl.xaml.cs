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
    /// WrapPanelControl.xaml 的交互逻辑
    /// </summary>
    public partial class WrapPanelControl : Window
    {
        public WrapPanelControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i <= 20; i++)
            {
                Button button = new Button();
                button.Content = $"Btn{i.ToString("00")}号";
                button.Background = new SolidColorBrush(Colors.GreenYellow);
                button.Name = $"btn{i}";
                button.Margin = new Thickness(5);
                wpPanel1.Children.Add(button);
            }

            for (int i = 0; i <= 20; i++)
            {
                Button button = new Button();
                button.Content = $"Btn{i.ToString("00")}号";
                button.Background = new SolidColorBrush(Colors.BlueViolet);
                button.Name = $"btn{i}";
                button.Margin = new Thickness(5);
                wpPanel2.Children.Add(button);
            }
        }
    }
}
