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
using WpfApp.Db;
using WpfApp.model;

namespace WpfApp.controls
{
    /// <summary>
    /// ListViewControl.xaml 的交互逻辑
    /// </summary>
    public partial class ListViewControl : Window
    {
        private List<UserInfo> userInfos;
        public ListViewControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //userList.ItemsSource = GetUserList();
            userList.DataContext = GetUserList();
        }

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        private List<UserInfo> GetUserList()
        {
            var Db = new DbUtil().GetInstance();
            var list=Db.Queryable<UserInfo>().ToList();
            return list;
        }
    }
}
