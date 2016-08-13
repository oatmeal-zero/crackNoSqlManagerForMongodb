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
    /// 更改appConfig配置文件到最新的日期
    /// </summary>
    class ChangeTime
    {
        public static void ChangeConfigTime(string xmlfile)
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
    }
}
