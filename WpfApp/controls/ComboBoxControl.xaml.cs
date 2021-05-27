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
    /// ComboBoxControl.xaml 的交互逻辑
    /// </summary>
    public partial class ComboBoxControl : Window
    {
        public ComboBoxControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ClassInfo> classInfos = new ComboBoxServices().GetClassInfos();
            //course.ItemsSource = classInfos;
            course.SelectedValuePath = "Id";
            course.DisplayMemberPath = "Name";

            //foreach (ClassInfo classInfo in classInfos)
            //{
            //    course.Items.Add(classInfo);
            //}
            //course.Items.Add(new ClassInfo { 
            //    Id=4,
            //    Name="化学"
            //});

            course.DataContext = classInfos;
        }

        private void rmItem_Click(object sender, RoutedEventArgs e)
        {
            course.Items.RemoveAt(1);
        }

        private void course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((course.SelectedItem as ClassInfo).Name);
        }
    }
}
