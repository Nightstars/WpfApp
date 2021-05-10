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

namespace WpfApp.Users
{
    /// <summary>
    /// UserWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string uname = username.Text.Trim();
            string upwd = password.Password.Trim();
            MessageBox.Show($"登录成功,{uname} {upwd}", "登录提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as RadioButton).Content.ToString(), "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RadioButton rbtn = new RadioButton();
            rbtn.Content = "主任";
            rbtn.GroupName = "role";
            rbtn.Margin = new Thickness(260,85,0,0);
            rbtn.HorizontalAlignment = HorizontalAlignment.Left;
            rbtn.VerticalAlignment = VerticalAlignment.Top;
            rbtn.Checked += RadioButton_Checked;
            container.Children.Add(rbtn);
        }
    }
}
