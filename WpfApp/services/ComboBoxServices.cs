using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.model;

namespace WpfApp.services
{
    class ComboBoxServices
    {
        public List<ClassInfo> GetClassInfos()
        {
            List<ClassInfo> classInfos = new List<ClassInfo>();
            classInfos.AddRange(new ClassInfo[]
            {
                new ClassInfo()
                {
                    Id=0,
                    Name="请选择"
                },
                new ClassInfo()
                {
                    Id=1,
                    Name="语文"
                },
                new ClassInfo()
                {
                    Id=2,
                    Name="数学"
                },
                new ClassInfo()
                {
                    Id=3,
                    Name="英语"
                },
                new ClassInfo()
                {
                    Id=3,
                    Name="物理"
                }
            });
            return classInfos;
        }
    }
}
