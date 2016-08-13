using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackNoSqlManagerForMongodb
{
    /// <summary>
    /// 删除指定目录
    /// </summary>
    class RmDir
    {
        public static void Remove(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                dir.Delete(true);
                Console.WriteLine("删除“{0}”目录成功！", path);
            }
            catch (Exception e)
            {
                Console.WriteLine("无法删除“{0}”目录，原因：", path);
                Console.WriteLine(e.Message);
            }
        }
    }
}
