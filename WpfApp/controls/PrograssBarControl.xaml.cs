using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// PrograssBarControl.xaml 的交互逻辑
    /// </summary>
    public partial class PrograssBarControl : Window
    {
        public PrograssBarControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double max = pbar1.Maximum;
            Task.Run(() => {
                for(int i = 0; i <= max; i++)
                {
                    pbar1.Dispatcher.Invoke(() =>
                    {
                        pbar1.Value = i;
                        pgs.Text = pbar1.Value + "%";
                    });
                    
                    Thread.Sleep(200);
                }
            });
        }

        private void pbar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //pgs.Text = e.NewValue + "%";
        }
    }
}
