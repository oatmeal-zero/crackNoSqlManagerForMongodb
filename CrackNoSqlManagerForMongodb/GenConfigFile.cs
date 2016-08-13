using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CrackNoSqlManagerForMongodb
{
    /// <summary>
    /// 让NoSQL Manager for MongoDB自己生成配置文件
    /// </summary>
    class GenConfigFile
    {
        public static void ExecuteProgram(string program)
        {
            string fileName = program;
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = fileName;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.Arguments = "";
            p.Start();
            Console.WriteLine("NoSQL Manager for MongoDB正在运行...");
            Console.WriteLine("请关闭NoSQL Manager for MongoDB以继续...");
            p.WaitForExit();
        }
    }
}
