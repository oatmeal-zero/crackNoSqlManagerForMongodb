using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CrackNoSqlManagerForMongodb
{
    /// <summary>
    /// NoSQL Manager For Mongodb配置文件操作类
    /// </summary>
    class AppConfig
    {
        /// <summary>
        /// 更改appConfig.xml配置文件到最新的日期
        /// </summary>
        /// <param name="xmlfile"></param>
        public static void UpdateTime(string xmlfile)
        {
            XmlDocument doc = new XmlDocument();
            string now = DateTime.Now.Date.ToString("yyyy-MM-dd");
            XmlNode node;
            try
            {
                doc.Load(xmlfile);
                node = doc.SelectSingleNode("/ROOT/FirstRun");
                node.InnerText = now;
                node = doc.SelectSingleNode("/ROOT/BuyReminderShowDate");
                node.InnerText = now;
                node = doc.SelectSingleNode("/ROOT/LastUpdateCheckDate");                
                node.InnerText = now;
                doc.Save(xmlfile);
                //Console.WriteLine("appConfig.xml的时间已经更新到最新！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
