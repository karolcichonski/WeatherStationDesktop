namespace WeatherStation
{
    partial class FormIndorMeasurements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndorMeasurements));
            this.label6 = new System.Windows.Forms.Label();
            this.cartesianChartHumidity = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.cartesianChartPressure = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChartTemperature = new LiveCharts.WinForms.CartesianChart();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButton3Days = new System.Windows.Forms.RadioButton();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.groupBoxRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Humidity %";
            // 
            // cartesianChartHumidity
            // 
            this.cartesianChartHumidity.Location = new System.Drawing.Point(74, 355);
            this.cartesianChartHumidity.Name = "cartesianChartHumidity";
            this.cartesianChartHumidity.Size = new System.Drawing.Size(479, 170);
            this.cartesianChartHumidity.TabIndex = 25;
            this.cartesianChartHumidity.Text = "cartesianChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(582, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pressure hPa";
            // 
            // cartesianChartPressure
            // 
            this.cartesianChartPressure.Location = new System.Drawing.Point(559, 355);
            this.cartesianChartPressure.Name = "cartesianChartPressure";
            this.cartesianChartPressure.Size = new System.Drawing.Size(500, 169);
            this.cartesianChartPressure.TabIndex = 23;
            this.cartesianChartPressure.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Temperature °C";
            // 
            // cartesianChartTemperature
            // 
            this.cartesianChartTemperature.Location = new System.Drawing.Point(74, 165);
            this.cartesianChartTemperature.Name = "cartesianChartTemperature";
            this.cartesianChartTemperature.Size = new System.Drawing.Size(980, 172);
            this.cartesianChartTemperature.TabIndex = 21;
            this.cartesianChartTemperature.Text = "cartesianChart1";
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.radioButtonWeek);
            this.groupBoxRange.Controls.Add(this.radioButton3Days);
            this.groupBoxRange.Controls.Add(this.radioButtonToday);
            this.groupBoxRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRange.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRange.ForeColor = System.Drawing.Color.White;
            this.groupBoxRange.Location = new System.Drawing.Point(98, 28);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(219, 58);
            this.groupBoxRange.TabIndex = 27;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Select Range";
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonWeek.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonWeek.ForeColor = System.Drawing.Color.White;
            this.radioButtonWeek.Location = new System.Drawing.Point(147, 21);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(56, 18);
            this.radioButtonWeek.TabIndex = 7;
            this.radioButtonWeek.Text = "Week";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            this.radioButtonWeek.CheckedChanged += new System.EventHandler(this.radioButtonWeek_CheckedChanged);
            // 
            // radioButton3Days
            // 
            this.radioButton3Days.AutoSize = true;
            this.radioButton3Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3Days.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3Days.ForeColor = System.Drawing.Color.White;
            this.radioButton3Days.Location = new System.Drawing.Point(85, 21);
            this.radioButton3Days.Name = "radioButton3Days";
            this.radioButton3Days.Size = new System.Drawing.Size(56, 18);
            this.radioButton3Days.TabIndex = 8;
            this.radioButton3Days.Text = "3days";
            this.radioButton3Days.UseVisualStyleBackColor = true;
            this.radioButton3Days.CheckedChanged += new System.EventHandler(this.radioButton3Days_CheckedChanged);
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Checked = true;
            this.radioButtonToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonToday.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonToday.ForeColor = System.Drawing.Color.White;
            this.radioButtonToday.Location = new System.Drawing.Point(24, 20);
            this.radioButtonToday.Name = "radioButtonToday";
            this.radioButtonToday.Size = new System.Drawing.Size(58, 18);
            this.radioButtonToday.TabIndex = 6;
            this.radioButtonToday.TabStop = true;
            this.radioButtonToday.Text = "Today";
            this.radioButtonToday.UseVisualStyleBackColor = true;
            this.radioButtonToday.CheckedChanged += new System.EventHandler(this.radioButtonToday_CheckedChanged);
            // 
            // FormIndorMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1132, 670);
            this.Controls.Add(this.groupBoxRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cartesianChartHumidity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartesianChartPressure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChartTemperature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormIndorMeasurements";
            this.Text = "FormIndorMeasurements";
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.CartesianChart cartesianChartHumidity;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart cartesianChartPressure;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart cartesianChartTemperature;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButton3Days;
        private System.Windows.Forms.RadioButton radioButtonToday;
    }
}