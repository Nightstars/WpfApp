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
    /// CheckBoxControl.xaml 的交互逻辑
    /// </summary>
    public partial class CheckBoxControl : Window
    {
        public CheckBoxControl()
        {
            InitializeComponent();
        }

        private void getBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(chkSport.IsChecked.ToString());
            //获取窗口中所有勾选的CheckBox的Content
            string str = null;
            foreach (UIElement item in container.Children)
            {
                if(item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    if (chk.IsChecked==true)
                    {
                        if (!string.IsNullOrWhiteSpace(str))
                            str += ",";
                        str += chk.Content.ToString();
                    }
                }
            }
            MessageBox.Show(str);
        }

        private void getBtn_Click_1(object sender, RoutedEventArgs e)
        {
            string str = null;
            foreach (UIElement item in box.Children)
            {
                if (item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    if (chk.IsChecked == true)
                    {
                        if (!string.IsNullOrWhiteSpace(str))
                            str += ",";
                        str += chk.Content.ToString();
                    }
                }
            }
            MessageBox.Show(str);
        }

        private void getBtn1_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "篮球", "足球", "网球", "羽毛球", "乒乓球" };
            for (int i = 0; i < names.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = names[i];
                checkBox.HorizontalAlignment = HorizontalAlignment.Left;
                checkBox.VerticalAlignment = VerticalAlignment.Top;
                checkBox.Margin = new Thickness(50, 100 + 30 * i, 0, 0);
                box.Children.Add(checkBox);
            }
        }
    }
}
