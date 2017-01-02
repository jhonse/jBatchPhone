using jBatchPhone.Lib.jBasic;
using jBatchPhone.Lib.jControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jBatchPhone.Lib
{
    class jOs
    {
        private jSimulatorList simulatorList;

        public jOs(TabPage tpSimulator)
        {
            simulatorList = new jSimulatorList(tpSimulator);
            simulatorList.init();
        }

        /// <summary>
        /// 获得基本配置文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string getBasicIniSetting(string Section, string Key)
        {
            return jData.getBasicIniSetting(Section, Key);
        }

        /// <summary>
        /// 设置基本配置文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool setBasicIniSetting(string Section, string Key, string Value)
        {
            return jData.setBasicIniSetting(Section, Key, Value);
        }

        /// <summary>
        /// 更新模拟器列表数据
        /// </summary>
        public void updateSimulatorData()
        {
            simulatorList.initData();
        }
    }
}
