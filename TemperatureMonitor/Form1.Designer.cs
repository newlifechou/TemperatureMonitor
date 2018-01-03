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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.temperatureGraph1 = new XSWindowFormControl.TemperatureGraph();
            this.temperatureGraph2 = new XSWindowFormControl.TemperatureGraph();
            this.temperatureGraph3 = new XSWindowFormControl.TemperatureGraph();
            this.temperatureGraph4 = new XSWindowFormControl.TemperatureGraph();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // temperatureGraph1
            // 
            this.temperatureGraph1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph1.Location = new System.Drawing.Point(3, 3);
            this.temperatureGraph1.Name = "temperatureGraph1";
            this.temperatureGraph1.Size = new System.Drawing.Size(635, 370);
            this.temperatureGraph1.TabIndex = 0;
            // 
            // temperatureGraph2
            // 
            this.temperatureGraph2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph2.Location = new System.Drawing.Point(644, 3);
            this.temperatureGraph2.Name = "temperatureGraph2";
            this.temperatureGraph2.Size = new System.Drawing.Size(635, 370);
            this.temperatureGraph2.TabIndex = 0;
            // 
            // temperatureGraph3
            // 
            this.temperatureGraph3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph3.Location = new System.Drawing.Point(3, 379);
            this.temperatureGraph3.Name = "temperatureGraph3";
            this.temperatureGraph3.Size = new System.Drawing.Size(635, 371);
            this.temperatureGraph3.TabIndex = 0;
            // 
            // temperatureGraph4
            // 
            this.temperatureGraph4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph4.Location = new System.Drawing.Point(644, 379);
            this.temperatureGraph4.Name = "temperatureGraph4";
            this.temperatureGraph4.Size = new System.Drawing.Size(635, 371);
            this.temperatureGraph4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "模具温度传感器检测程序-先锋材料-designed by xs.zhou";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private XSWindowFormControl.TemperatureGraph temperatureGraph1;
        private XSWindowFormControl.TemperatureGraph temperatureGraph2;
        private XSWindowFormControl.TemperatureGraph temperatureGraph3;
        private XSWindowFormControl.TemperatureGraph temperatureGraph4;
    }
}

