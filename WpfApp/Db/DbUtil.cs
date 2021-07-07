using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Db
{
    public class DbUtil
    {
        //创建SqlSugarClient 
        public SqlSugarClient GetInstance()
        {
            //创建数据库对象
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=192.168.0.50,3306;userid=christ;pwd=Ihavenoidea@0;database=test;",//连接符字串
                DbType = DbType.MySql,
                IsAutoCloseConnection = true
            });

            //添加Sql打印事件，开发中可以删掉这个代码
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql);
            };
            return db;
        }
    }
}
