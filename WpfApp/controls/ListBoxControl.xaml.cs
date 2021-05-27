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
using WpfApp.model;
using WpfApp.services;

namespace WpfApp.controls
{
    /// <summary>
    /// ListBoxControl.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxControl : Window
    {
        public ListBoxControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBoxServices comboBoxServices = new ComboBoxServices();
            //lbClasses.ItemsSource = comboBoxServices.GetClassInfos();
            lbClasses.DataContext = comboBoxServices.GetClassInfos();
            lbClasses.DisplayMemberPath = "Name";
            lbClasses.SelectedValuePath = "Id";
            lbClasses.SelectedIndex = 0;
            //lbClasses.Items.Add(11);
            //lbClasses.Items.Add("aaa");
        }

        private void lbClasses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(lbClasses.SelectedItem.ToString());
            ClassInfo selItem = lbClasses.SelectedItem as ClassInfo;
            MessageBox.Show(selItem.Name);
        }
    }
}
