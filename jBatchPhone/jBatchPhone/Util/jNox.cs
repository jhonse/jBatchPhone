using jBatchPhone.Lib.jBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace jBatchPhone.Util
{
    class jNox
    {
        /// <summary>
        /// 检查是否配置模拟器执行路径
        /// </summary>
        /// <returns></returns>
        public static bool checkIniSetting()
        {
            string ExePath = jData.getBasicIniSetting("模拟器设置", "tbBasicSimulatorExeDir");
            if (!ExePath.Equals(""))
            {
                return true;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得所有模拟器
        /// </summary>
        /// <param name="ExePath"></param>
        /// <returns></returns>
        public static List<string[]> getAllNox()
        {
            List<string[]> Noxes = new List<string[]>();
            string ExePath = jData.getBasicIniSetting("模拟器设置", "tbBasicSimulatorExeDir");
            if (!ExePath.Equals(""))
            {
                string[] Nox = jFile.getAllDirName(ExePath + @"\bin\BignoxVMS");
                foreach(string n in Nox)
                {
                    string[] saveInfo = new string[3];
                    DirectoryInfo folder = new DirectoryInfo(n);
                    string IPAndPort = getSimulatorIPAndPort(n, folder.Name);
                    saveInfo[0] = folder.Name;
                    saveInfo[1] = n;
                    Noxes.Add(saveInfo);
                }
            }
            return Noxes;
        }

        public static void createSimulator()
        {

        }

        /*private static List<string> getAllConnectionSimulator()
        {
            List<string> Connections = jCmd.init(@"D:\Install\Nox\bin\nox_adb devices");

        }*/

        /// <summary>
        /// 获得模拟器的IP和端口
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string getSimulatorIPAndPort(string dir, string name)
        {
            if (File.Exists(dir + "/" + name + ".vbox"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(dir + "/" + name + ".vbox");
                    XmlNode VirtualBox = xmlDoc.LastChild;
                    XmlNode Machine = VirtualBox.SelectSingleNode("Machine");
                    return String.Empty;
                }
                catch (Exception)
                {
                    return String.Empty;
                }
            }else
            {
                return String.Empty;
            }
        }
    }
}
