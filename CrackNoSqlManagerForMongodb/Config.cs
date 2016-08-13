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
            GuessPath();
            XmlDocument doc = new XmlDocument();
            XmlNode node;
            try
            {
                doc.Load("config.xml");
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
        /// <summary>
        /// 猜测appConfig.xml所在目录
        /// 1.用户应用数据目录
        /// 2.公共用户应用数据目录
        /// </summary>
        private void GuessPath()
        {
            string groupPath = "\\NoSQL Manager Group";
            string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string CommonApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (FileOp.PathExists(ApplicationData + groupPath))
            {
                path = ApplicationData + groupPath;
            }
            else
            {
                path = CommonApplicationData + groupPath;
            }
        }
    }
}
