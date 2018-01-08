namespace TemperatureMonitor
{
    partial class Form1
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
            this.temperatureGraph1 = new XSWindowFormControl.TemperatureGraph();
            this.SuspendLayout();
            // 
            // temperatureGraph1
            // 
            this.temperatureGraph1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph1.Location = new System.Drawing.Point(0, 0);
            this.temperatureGraph1.Name = "temperatureGraph1";
            this.temperatureGraph1.Size = new System.Drawing.Size(1282, 753);
            this.temperatureGraph1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.temperatureGraph1);
            this.Name = "Form1";
            this.Text = "模具温度传感器检测程序-先锋材料-designed by xs.zhou";
            this.ResumeLayout(false);

        }

        #endregion

        private XSWindowFormControl.TemperatureGraph temperatureGraph1;
    }
}

