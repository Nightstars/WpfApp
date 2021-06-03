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
    /// GroupBoxControl.xaml 的交互逻辑
    /// </summary>
    public partial class GroupBoxControl : Window
    {
        public GroupBoxControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtpassword.Password);
            StackPanel spfirst = gbinfo.Content as StackPanel;
            foreach(var ele in spfirst.Children)
            {
                StackPanel sp = ele as StackPanel;
                foreach (var item in sp.Children)
                {
                    if(item is TextBox)
                    {
                        MessageBox.Show((item as TextBox).Text);
                    }
                }
            }
        }
    }
}
