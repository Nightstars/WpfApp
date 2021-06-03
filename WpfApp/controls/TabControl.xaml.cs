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
    /// TabControl.xaml 的交互逻辑
    /// </summary>
    public partial class TabControl : Window
    {
        public TabControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object content=tabSystem.SelectedContent;
            tabSystem.SelectedIndex = 0;
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
                if (tabSystem.SelectedIndex < tabSystem.Items.Count - 1)
                    tabSystem.SelectedIndex += 1;
                else
                    tabSystem.SelectedIndex = 0;
            //tabSystem.SelectedItem = tabSystem.Items[2];          
        }
    }
}
