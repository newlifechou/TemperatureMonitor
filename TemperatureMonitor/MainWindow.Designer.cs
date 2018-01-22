namespace TemperatureMonitor
{
    partial class MainWindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史曲线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.temperatureGraph1 = new XSWindowFormControl.TemperatureGraph();
            this.temperatureGraph4 = new XSWindowFormControl.TemperatureGraph();
            this.temperatureGraph2 = new XSWindowFormControl.TemperatureGraph();
            this.temperatureGraph3 = new XSWindowFormControl.TemperatureGraph();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 755);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1442, 29);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(64, 24);
            this.txtStatus.Text = "状态栏";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1442, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.关闭ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.历史曲线ToolStripMenuItem});
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.数据ToolStripMenuItem.Text = "数据";
            // 
            // 历史曲线ToolStripMenuItem
            // 
            this.历史曲线ToolStripMenuItem.Name = "历史曲线ToolStripMenuItem";
            this.历史曲线ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.历史曲线ToolStripMenuItem.Text = "历史曲线";
            this.历史曲线ToolStripMenuItem.Click += new System.EventHandler(this.历史曲线ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperatureGraph1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1442, 723);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // temperatureGraph1
            // 
            this.temperatureGraph1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph1.Location = new System.Drawing.Point(3, 5);
            this.temperatureGraph1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.temperatureGraph1.Name = "temperatureGraph1";
            this.temperatureGraph1.Size = new System.Drawing.Size(715, 351);
            this.temperatureGraph1.TabIndex = 3;
            // 
            // temperatureGraph4
            // 
            this.temperatureGraph4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph4.Location = new System.Drawing.Point(724, 5);
            this.temperatureGraph4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.temperatureGraph4.Name = "temperatureGraph4";
            this.temperatureGraph4.Size = new System.Drawing.Size(715, 351);
            this.temperatureGraph4.TabIndex = 7;
            // 
            // temperatureGraph2
            // 
            this.temperatureGraph2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph2.Location = new System.Drawing.Point(724, 366);
            this.temperatureGraph2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.temperatureGraph2.Name = "temperatureGraph2";
            this.temperatureGraph2.Size = new System.Drawing.Size(715, 352);
            this.temperatureGraph2.TabIndex = 8;
            // 
            // temperatureGraph3
            // 
            this.temperatureGraph3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.temperatureGraph3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureGraph3.Location = new System.Drawing.Point(3, 366);
            this.temperatureGraph3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.temperatureGraph3.Name = "temperatureGraph3";
            this.temperatureGraph3.Size = new System.Drawing.Size(715, 352);
            this.temperatureGraph3.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "模具温度传感器检测程序-先锋材料-designed by xs.zhou";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史曲线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private XSWindowFormControl.TemperatureGraph temperatureGraph1;
        private XSWindowFormControl.TemperatureGraph temperatureGraph3;
        private XSWindowFormControl.TemperatureGraph temperatureGraph2;
        private XSWindowFormControl.TemperatureGraph temperatureGraph4;
    }
}

