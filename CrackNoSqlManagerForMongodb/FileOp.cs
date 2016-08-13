using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackNoSqlManagerForMongodb
{
    /// <summary>
    /// 文件操作类
    /// </summary>
    class FileOp
    {
        /// <summary>
        /// 删除指定目录
        /// NoSQL Manager Group
        /// </summary>
        /// <param name="path">待删除的目录</param>
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

        public static void CopyConfigFile(string xmlfile, string copyfile)
        {
            try
            {
                File.Copy(xmlfile, copyfile, true);
            }
            catch (Exception e)
            {
                Console.WriteLine("无法备份配置文件，原因：");
                Console.WriteLine(e.Message);
                throw new Exception("请确保配置目录的位置正确，然后再试！");
            }
        }

        public static void DeleteCopyFile(string copyfile)
        {
            try
            {
                File.Delete(copyfile);
            }
            catch (Exception e)
            {
                Console.WriteLine("无法删除临时配置文件，原因：");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 判断指定的目录是否存在
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool PathExists(string path)
        {
            return Directory.Exists(path);
        }
    }
}
