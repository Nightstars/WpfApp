using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp.controls
{
    /// <summary>
    /// CalendatControl.xaml 的交互逻辑
    /// </summary>
    public partial class CalendatControl : Window
    {
        public CalendatControl()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            txtStart.Text = calDate.SelectedDates.First().ToShortDateString();
            txtEnd.Text = calDate.SelectedDates.Last().ToShortDateString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtSelf.Text = calDate.SelectedDate.Value.ToLongDateString();
        }

        private void calDate_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.Captured is CalendarItem)
                Mouse.Capture(null);
        }
    }
}
