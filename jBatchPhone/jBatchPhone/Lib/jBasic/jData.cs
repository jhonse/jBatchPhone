using jBatchPhone.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jBatchPhone.Lib.jBasic
{
    class jData
    {
        /// <summary>
        /// 获得配置信息
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string getBasicIniSetting(string Section, string Key)
        {
            string initDir = System.Environment.CurrentDirectory + @"\INI";
            jFile.initDir(initDir);
            return jIni.ReadIniData(Section, Key, String.Empty, initDir+@"\basic.ini");
        }

        /// <summary>
        /// 设置配置信息
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static bool setBasicIniSetting(string Section, string Key, string Value)
        {
            string initDir = System.Environment.CurrentDirectory + @"\INI";
            jFile.initDir(initDir);
            return jIni.WriteIniData(Section, Key, Value, initDir + @"\basic.ini");
        }
    }
}
