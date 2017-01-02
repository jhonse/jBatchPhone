using jBatchPhone.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace jBatchPhone.Lib.jControl
{
    class jSimulatorList
    {
        private TabPage _tpMain;
        private ListView _lvSimulator;

        public jSimulatorList(TabPage tpMain)
        {
            this._tpMain = tpMain;
        }

        public void init()
        {
            Thread tInit = new Thread(initThread);
            tInit.IsBackground = true;
            tInit.Start();
        }

        private void initThread()
        {
            this._lvSimulator = new ListView();
            this._lvSimulator.Dock = DockStyle.Fill;
            this._lvSimulator.Location = new System.Drawing.Point(0, 0);
            this._lvSimulator.Name = "Simulator";
            this._lvSimulator.Size = new System.Drawing.Size(656, 97);
            this._lvSimulator.TabIndex = 0;
            this._lvSimulator.UseCompatibleStateImageBehavior = false;
            this._lvSimulator.View = View.Details;
            this._lvSimulator.FullRowSelect = true;
            this._lvSimulator.GridLines = true;
            this._lvSimulator.MultiSelect = true;
            //this._lvSimulator.CheckBoxes = true;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 25);
            this._lvSimulator.SmallImageList = imgList;
            this._lvSimulator.Columns.Add("模拟器名称", this._tpMain.Width / 5, HorizontalAlignment.Center);
            this._lvSimulator.Columns.Add("模拟器路径", this._tpMain.Width / 5, HorizontalAlignment.Center);
            this._lvSimulator.Columns.Add("IP:端口", 80, HorizontalAlignment.Center);
            this._lvSimulator.Columns.Add("执行任务", 80, HorizontalAlignment.Center);
            this._lvSimulator.Columns.Add("执行时间", 80, HorizontalAlignment.Center);
            this._lvSimulator.Columns.Add("执行状态", 80, HorizontalAlignment.Center);
            this._tpMain.Controls.Add(this._lvSimulator);
            initData();
        }

        public void initData()
        {
            Thread tInit = new Thread(initDataThread);
            tInit.IsBackground = true;
            tInit.Start();
        }

        private void initDataThread()
        {
            List<string[]> Data = jNox.getAllNox();
            foreach(string[] d in Data)
            {
                ListViewItem lvi = new ListViewItem();

                //lvi.BackColor = Color.DarkOrange;
                //lvi.ForeColor = Color.DarkGray;

                lvi.Text = d[0];
          
                lvi.SubItems.Add(d[1]);
                lvi.SubItems.Add("0");
                lvi.SubItems.Add("0");
                lvi.SubItems.Add("0");

                this._lvSimulator.Items.Add(lvi);
            }
        }
    }
}
