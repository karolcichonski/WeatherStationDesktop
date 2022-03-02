namespace WeatherStation
{
    partial class FormHistoricalWeater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricalWeater));
            this.cartesianChartHistTemperature = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartHistPress = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartHistWind = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartHistHumidity = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarRange = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRange)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChartHistTemperature
            // 
            this.cartesianChartHistTemperature.Location = new System.Drawing.Point(49, 129);
            this.cartesianChartHistTemperature.Name = "cartesianChartHistTemperature";
            this.cartesianChartHistTemperature.Size = new System.Drawing.Size(500, 200);
            this.cartesianChartHistTemperature.TabIndex = 14;
            this.cartesianChartHistTemperature.Text = "cartesianChart1";
            // 
            // cartesianChartHistPress
            // 
            this.cartesianChartHistPress.Location = new System.Drawing.Point(579, 129);
            this.cartesianChartHistPress.Name = "cartesianChartHistPress";
            this.cartesianChartHistPress.Size = new System.Drawing.Size(500, 200);
            this.cartesianChartHistPress.TabIndex = 15;
            this.cartesianChartHistPress.Text = "cartesianChart1";
            // 
            // cartesianChartHistWind
            // 
            this.cartesianChartHistWind.Location = new System.Drawing.Point(579, 359);
            this.cartesianChartHistWind.Name = "cartesianChartHistWind";
            this.cartesianChartHistWind.Size = new System.Drawing.Size(500, 200);
            this.cartesianChartHistWind.TabIndex = 17;
            this.cartesianChartHistWind.Text = "cartesianChart1";
            // 
            // cartesianChartHistHumidity
            // 
            this.cartesianChartHistHumidity.Location = new System.Drawing.Point(49, 359);
            this.cartesianChartHistHumidity.Name = "cartesianChartHistHumidity";
            this.cartesianChartHistHumidity.Size = new System.Drawing.Size(500, 200);
            this.cartesianChartHistHumidity.TabIndex = 18;
            this.cartesianChartHistHumidity.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Temperature °C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(599, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pressure hPa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Humidity %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(599, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Wind Speed km/h";
            // 
            // trackBarRange
            // 
            this.trackBarRange.Location = new System.Drawing.Point(71, 595);
            this.trackBarRange.Maximum = 5;
            this.trackBarRange.Minimum = 1;
            this.trackBarRange.Name = "trackBarRange";
            this.trackBarRange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarRange.Size = new System.Drawing.Size(200, 45);
            this.trackBarRange.TabIndex = 23;
            this.trackBarRange.TabStop = false;
            this.trackBarRange.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRange.Value = 5;
            this.trackBarRange.ValueChanged += new System.EventHandler(this.trackBarRange_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Range [days]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(255, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(468, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Historical Weather";
            // 
            // FormHistoricalWeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1148, 692);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChartHistHumidity);
            this.Controls.Add(this.cartesianChartHistWind);
            this.Controls.Add(this.cartesianChartHistPress);
            this.Controls.Add(this.cartesianChartHistTemperature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHistoricalWeater";
            this.Text = "HistoricalWeater";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChartHistTemperature;
        private LiveCharts.WinForms.CartesianChart cartesianChartHistPress;
        private LiveCharts.WinForms.CartesianChart cartesianChartHistWind;
        private LiveCharts.WinForms.CartesianChart cartesianChartHistHumidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}