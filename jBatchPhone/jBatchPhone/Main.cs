using jBatchPhone.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jBatchPhone
{
    public partial class Main : Form
    {
        private jOs jos;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //初始化
            jos = new jOs(tpSimulator);
            //初始化自身控件数据
            tbBasicSimulatorExeDir.Text = jos.getBasicIniSetting("模拟器设置", "tbBasicSimulatorExeDir");
        }

        private void btnBasicSimulatorChoise_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择模拟器安装目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                tbBasicSimulatorExeDir.Text = foldPath;
                jos.setBasicIniSetting("模拟器设置", "tbBasicSimulatorExeDir", foldPath);
                jos.updateSimulatorData();
            }
        }
    }
}
