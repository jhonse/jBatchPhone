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
                    string[] saveInfo = new string[4];
                    DirectoryInfo folder = new DirectoryInfo(n);
                    string IPAndPort = getSimulatorIPAndPort(n, folder.Name);
                    saveInfo[0] = folder.Name;
                    saveInfo[1] = n;
                    saveInfo[2] = IPAndPort;
                    if (checkConnectionSimulator(IPAndPort))
                    {
                        saveInfo[3] = "开启";
                    }
                    else
                    {
                        saveInfo[3] = "未开启";
                    }
                    Noxes.Add(saveInfo);
                }
                getAllConnectionSimulator();
            }
            return Noxes;
        }

        public static void createSimulator()
        {

        }

        /// <summary>
        /// 获得所有开启的模拟器
        /// </summary>
        /// <returns></returns>
        private static List<string> getAllConnectionSimulator()
        {
            List<string> retValue = new List<string>();
            List<string> Connections = jCmd.init(@"D:\Install\Nox\bin\nox_adb devices");
            foreach(string con in Connections)
            {
                if (con.Contains("\tdevice"))
                {
                    string IPAndPort = con.Substring(0,con.Length- "\tdevice".Length);
                    if (!IPAndPort.Equals(""))
                    {
                        retValue.Add(IPAndPort);
                    }
                }
            }
            return retValue;
        }

        /// <summary>
        /// 检查模拟器是否开启
        /// </summary>
        /// <param name="IPAndPort"></param>
        /// <returns></returns>
        private static bool checkConnectionSimulator(string IPAndPort)
        {
            bool retValue = false;
            List<string> Connections = jCmd.init(@"D:\Install\Nox\bin\nox_adb devices");
            foreach (string con in Connections)
            {
                if (con.Contains("\tdevice"))
                {
                    string _IPAndPort = con.Substring(0, con.Length - "\tdevice".Length);
                    if(_IPAndPort == IPAndPort)
                    {
                        retValue = true;
                        break;
                    }
                }
            }
            return retValue;
        }

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
                    
                    XmlNode Forwarding = xmlDoc.DocumentElement.FirstChild.ChildNodes[2].ChildNodes[11].ChildNodes[0].ChildNodes[1].ChildNodes[4];
                    if(Forwarding != null)
                    {
                        string IP = Forwarding.Attributes["hostip"].Value;
                        string Port = Forwarding.Attributes["hostport"].Value;
                        return IP + ":" + Port;
                    }
                    else
                    {
                        return String.Empty;
                    }
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
