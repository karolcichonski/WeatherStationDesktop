namespace WeatherStationDesktop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cartesianChartTemperature = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChartPressure = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButton3Days = new System.Windows.Forms.RadioButton();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLastMesHum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_LastMesTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LastMesPress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_LastMesTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cartesianChartHumidity = new LiveCharts.WinForms.CartesianChart();
            this.groupBoxRange.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChartTemperature
            // 
            this.cartesianChartTemperature.Location = new System.Drawing.Point(34, 76);
            this.cartesianChartTemperature.Name = "cartesianChartTemperature";
            this.cartesianChartTemperature.Size = new System.Drawing.Size(1056, 190);
            this.cartesianChartTemperature.TabIndex = 0;
            this.cartesianChartTemperature.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature";
            // 
            // cartesianChartPressure
            // 
            this.cartesianChartPressure.Location = new System.Drawing.Point(34, 506);
            this.cartesianChartPressure.Name = "cartesianChartPressure";
            this.cartesianChartPressure.Size = new System.Drawing.Size(1056, 190);
            this.cartesianChartPressure.TabIndex = 3;
            this.cartesianChartPressure.Text = "cartesianChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pressure";
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Checked = true;
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
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
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
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.radioButtonWeek);
            this.groupBoxRange.Controls.Add(this.radioButton3Days);
            this.groupBoxRange.Controls.Add(this.radioButtonToday);
            this.groupBoxRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRange.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRange.ForeColor = System.Drawing.Color.White;
            this.groupBoxRange.Location = new System.Drawing.Point(47, 741);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(219, 50);
            this.groupBoxRange.TabIndex = 9;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Select Range";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxLastMesHum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_LastMesTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_LastMesPress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_LastMesTemp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(275, 741);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 50);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Measurement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Humidity";
            // 
            // textBoxLastMesHum
            // 
            this.textBoxLastMesHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLastMesHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastMesHum.ForeColor = System.Drawing.Color.White;
            this.textBoxLastMesHum.Location = new System.Drawing.Point(460, 17);
            this.textBoxLastMesHum.Name = "textBoxLastMesHum";
            this.textBoxLastMesHum.Size = new System.Drawing.Size(73, 21);
            this.textBoxLastMesHum.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time";
            // 
            // textBox_LastMesTime
            // 
            this.textBox_LastMesTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesTime.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesTime.Location = new System.Drawing.Point(67, 19);
            this.textBox_LastMesTime.Name = "textBox_LastMesTime";
            this.textBox_LastMesTime.Size = new System.Drawing.Size(157, 21);
            this.textBox_LastMesTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pressure";
            // 
            // textBox_LastMesPress
            // 
            this.textBox_LastMesPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesPress.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesPress.Location = new System.Drawing.Point(621, 17);
            this.textBox_LastMesPress.Name = "textBox_LastMesPress";
            this.textBox_LastMesPress.Size = new System.Drawing.Size(73, 21);
            this.textBox_LastMesPress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Temperature";
            // 
            // textBox_LastMesTemp
            // 
            this.textBox_LastMesTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesTemp.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesTemp.Location = new System.Drawing.Point(314, 17);
            this.textBox_LastMesTemp.Name = "textBox_LastMesTemp";
            this.textBox_LastMesTemp.Size = new System.Drawing.Size(73, 21);
            this.textBox_LastMesTemp.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Humidity";
            // 
            // cartesianChartHumidity
            // 
            this.cartesianChartHumidity.Location = new System.Drawing.Point(34, 289);
            this.cartesianChartHumidity.Name = "cartesianChartHumidity";
            this.cartesianChartHumidity.Size = new System.Drawing.Size(1056, 190);
            this.cartesianChartHumidity.TabIndex = 11;
            this.cartesianChartHumidity.Text = "cartesianChart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1131, 842);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cartesianChartHumidity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartesianChartPressure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChartTemperature);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Weather Station";
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChartTemperature;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart cartesianChartPressure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButton3Days;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LastMesTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LastMesPress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_LastMesTemp;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.CartesianChart cartesianChartHumidity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLastMesHum;
    }
}

