namespace XSWindowFormControl
{
    partial class TemperatureGraph
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtCurrentTemperature = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.BorderlineColor = System.Drawing.Color.Black;
            this.chartMain.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Area3DStyle.Inclination = 5;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea2.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea2);
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.chartMain.Series.Add(series2);
            this.chartMain.Size = new System.Drawing.Size(938, 678);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachine.Font = new System.Drawing.Font("宋体", 20F);
            this.txtMachine.ForeColor = System.Drawing.Color.White;
            this.txtMachine.Location = new System.Drawing.Point(14, 15);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(162, 46);
            this.txtMachine.TabIndex = 1;
            this.txtMachine.Text = "设备";
            this.txtMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("宋体", 20F);
            this.txtPosition.ForeColor = System.Drawing.Color.White;
            this.txtPosition.Location = new System.Drawing.Point(182, 15);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(162, 46);
            this.txtPosition.TabIndex = 1;
            this.txtPosition.Text = "底座";
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentTemperature
            // 
            this.txtCurrentTemperature.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCurrentTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentTemperature.Font = new System.Drawing.Font("宋体", 20F);
            this.txtCurrentTemperature.ForeColor = System.Drawing.Color.White;
            this.txtCurrentTemperature.Location = new System.Drawing.Point(350, 15);
            this.txtCurrentTemperature.Name = "txtCurrentTemperature";
            this.txtCurrentTemperature.ReadOnly = true;
            this.txtCurrentTemperature.Size = new System.Drawing.Size(162, 46);
            this.txtCurrentTemperature.TabIndex = 1;
            this.txtCurrentTemperature.Text = "温度";
            this.txtCurrentTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.Font = new System.Drawing.Font("宋体", 20F);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(518, 15);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(175, 46);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "时间";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TemperatureGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCurrentTemperature);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.chartMain);
            this.Name = "TemperatureGraph";
            this.Size = new System.Drawing.Size(938, 678);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtCurrentTemperature;
        private System.Windows.Forms.TextBox txtTime;
    }
}
