using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace CrackNoSqlManagerForMongodb
{
    /// <summary>
    /// 删除注册表键值
    /// </summary>
    class DeleteRegisterKey
    {
        public static void DeleteKey()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser;
                key.DeleteSubKeyTree("Software\\NoSQL Manager Group");
                key.Close();
                Console.WriteLine("删除注册表键值成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine("无法删除注册表键，原因：");
                Console.WriteLine(e.Message);
            }
        }
    }
}
