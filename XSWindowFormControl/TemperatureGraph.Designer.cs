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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chartMain.BorderlineWidth = 0;
            chartArea1.Area3DStyle.Inclination = 5;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkOrange;
            chartArea1.BackColor = System.Drawing.Color.Wheat;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartMain.Name = "chartMain";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(1055, 814);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachine.Font = new System.Drawing.Font("宋体", 20F);
            this.txtMachine.ForeColor = System.Drawing.Color.White;
            this.txtMachine.Location = new System.Drawing.Point(16, 18);
            this.txtMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(182, 53);
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
            this.txtPosition.Location = new System.Drawing.Point(205, 18);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(182, 53);
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
            this.txtCurrentTemperature.Location = new System.Drawing.Point(642, 18);
            this.txtCurrentTemperature.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentTemperature.Name = "txtCurrentTemperature";
            this.txtCurrentTemperature.ReadOnly = true;
            this.txtCurrentTemperature.Size = new System.Drawing.Size(182, 53);
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
            this.txtTime.Location = new System.Drawing.Point(393, 18);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(243, 53);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "采样时间";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TemperatureGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCurrentTemperature);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.chartMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TemperatureGraph";
            this.Size = new System.Drawing.Size(1055, 814);
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
