using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jBatchPhone.Util
{
    class jFile
    {
        /// <summary>
        /// 获得所有目录
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string[] getAllDirName(string Path)
        {
            if (Directory.Exists(Path))
            {
                return Directory.GetDirectories(Path);
            }else
            {
                return new string[0];
            }
        }

        /// <summary>
        /// 初始化指定目录
        /// </summary>
        /// <param name="dirPath"></param>
        public static void initDir(string dirPath)
        {
            if (!Directory.Exists(dirPath)){
                Directory.CreateDirectory(dirPath);
            }
        }
    }
}
