namespace jBatchPhone
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpBasic = new System.Windows.Forms.TabPage();
            this.gbSimulator = new System.Windows.Forms.GroupBox();
            this.btnBasicSimulatorChoise = new System.Windows.Forms.Button();
            this.tbBasicSimulatorExeDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSimulator = new System.Windows.Forms.TabPage();
            this.tpTask = new System.Windows.Forms.TabPage();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tpBasic.SuspendLayout();
            this.gbSimulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpBasic);
            this.tcMain.Controls.Add(this.tpSimulator);
            this.tcMain.Controls.Add(this.tpTask);
            this.tcMain.Controls.Add(this.tpLog);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(664, 641);
            this.tcMain.TabIndex = 0;
            // 
            // tpBasic
            // 
            this.tpBasic.Controls.Add(this.gbSimulator);
            this.tpBasic.Location = new System.Drawing.Point(4, 22);
            this.tpBasic.Name = "tpBasic";
            this.tpBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasic.Size = new System.Drawing.Size(656, 615);
            this.tpBasic.TabIndex = 0;
            this.tpBasic.Text = "基本配置";
            this.tpBasic.UseVisualStyleBackColor = true;
            // 
            // gbSimulator
            // 
            this.gbSimulator.Controls.Add(this.btnBasicSimulatorChoise);
            this.gbSimulator.Controls.Add(this.tbBasicSimulatorExeDir);
            this.gbSimulator.Controls.Add(this.label1);
            this.gbSimulator.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSimulator.Location = new System.Drawing.Point(3, 3);
            this.gbSimulator.Name = "gbSimulator";
            this.gbSimulator.Size = new System.Drawing.Size(650, 61);
            this.gbSimulator.TabIndex = 0;
            this.gbSimulator.TabStop = false;
            this.gbSimulator.Text = "模拟器设置";
            // 
            // btnBasicSimulatorChoise
            // 
            this.btnBasicSimulatorChoise.Location = new System.Drawing.Point(560, 20);
            this.btnBasicSimulatorChoise.Name = "btnBasicSimulatorChoise";
            this.btnBasicSimulatorChoise.Size = new System.Drawing.Size(75, 23);
            this.btnBasicSimulatorChoise.TabIndex = 2;
            this.btnBasicSimulatorChoise.Text = "选择";
            this.btnBasicSimulatorChoise.UseVisualStyleBackColor = true;
            this.btnBasicSimulatorChoise.Click += new System.EventHandler(this.btnBasicSimulatorChoise_Click);
            // 
            // tbBasicSimulatorExeDir
            // 
            this.tbBasicSimulatorExeDir.Location = new System.Drawing.Point(117, 21);
            this.tbBasicSimulatorExeDir.Name = "tbBasicSimulatorExeDir";
            this.tbBasicSimulatorExeDir.ReadOnly = true;
            this.tbBasicSimulatorExeDir.Size = new System.Drawing.Size(431, 21);
            this.tbBasicSimulatorExeDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模拟器安装目录:";
            // 
            // tpSimulator
            // 
            this.tpSimulator.Location = new System.Drawing.Point(4, 22);
            this.tpSimulator.Name = "tpSimulator";
            this.tpSimulator.Size = new System.Drawing.Size(656, 615);
            this.tpSimulator.TabIndex = 2;
            this.tpSimulator.Text = "模拟器列表";
            this.tpSimulator.UseVisualStyleBackColor = true;
            // 
            // tpTask
            // 
            this.tpTask.Location = new System.Drawing.Point(4, 22);
            this.tpTask.Name = "tpTask";
            this.tpTask.Size = new System.Drawing.Size(656, 615);
            this.tpTask.TabIndex = 3;
            this.tpTask.Text = "任务列表";
            this.tpTask.UseVisualStyleBackColor = true;
            // 
            // tpLog
            // 
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(656, 615);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "日志列表";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 641);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jBatchPhone By Jhonse @2017-01-02 Version 1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tcMain.ResumeLayout(false);
            this.tpBasic.ResumeLayout(false);
            this.gbSimulator.ResumeLayout(false);
            this.gbSimulator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpBasic;
        private System.Windows.Forms.TabPage tpLog;
        private System.Windows.Forms.TabPage tpSimulator;
        private System.Windows.Forms.TabPage tpTask;
        private System.Windows.Forms.GroupBox gbSimulator;
        private System.Windows.Forms.Button btnBasicSimulatorChoise;
        private System.Windows.Forms.TextBox tbBasicSimulatorExeDir;
        private System.Windows.Forms.Label label1;
    }
}

