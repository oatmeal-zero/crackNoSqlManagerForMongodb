using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CrackNoSqlManagerForMongodb
{
    /// <summary>
    /// 读取配置文件
    /// </summary>
    public class Config
    {
        string path;
        string program;

        public string Path
        {
            get
            {
                return path;
            }
        }

        public string Program
        {
            get { return program; }
        }

        public Config()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode node;
            try
            {
                doc.Load("config.xml");
                node = doc.SelectSingleNode("/root/path");
                path = node.InnerText;
                node = doc.SelectSingleNode("/root/program");
                program = node.InnerText;
            }
            catch (Exception e)
            {
                Console.WriteLine("无法读取配置文件，原因：");
                Console.WriteLine(e.Message);
                throw;
            }
        }


    }
}
