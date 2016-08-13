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

                FileOp.CopyConfigFile(xmlfile, copyfile);
                AppConfig.UpdateTime(copyfile);
                FileOp.Remove(path);
                RegistryOp.DeleteKey();
                GenConfigFile.ExecuteProgram(program);
                FileOp.CopyConfigFile(copyfile, xmlfile);
                //FileOp.DeleteCopyFile(copyfile);
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
