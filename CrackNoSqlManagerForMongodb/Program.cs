using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackNoSqlManagerForMongodb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Config config = new Config();
                string path = config.Path;
                string program = config.Program;
                string xmlfile = path + "\\NoSQL Manager for MongoDB\\appConfig.xml";
                string copyfile = System.Environment.CurrentDirectory + "\\appConfig.xml";

                ChangeTime.CopyConfigFile(xmlfile, copyfile);
                ChangeTime.ChangeConfigTime(copyfile);
                RmDir.Remove(path);
                DeleteRegisterKey.DeleteKey();
                GenConfigFile.ExecuteProgram(program);
                ChangeTime.CopyConfigFile(copyfile, xmlfile);
                //ChangeTime.DeleteCopyFile(copyfile);
                Console.WriteLine("破解成功，请按回车键退出！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
