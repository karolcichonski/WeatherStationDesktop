﻿namespace WeatherStationDesktop
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
            this.cartesianChartTemperature = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChartPressure = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.radioButton_24H = new System.Windows.Forms.RadioButton();
            this.radioButton_Week = new System.Windows.Forms.RadioButton();
            this.radioButton_Max = new System.Windows.Forms.RadioButton();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_LastMesTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LastMesPress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_LastMesTime = new System.Windows.Forms.TextBox();
            this.groupBoxRange.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChartTemperature
            // 
            this.cartesianChartTemperature.Location = new System.Drawing.Point(34, 76);
            this.cartesianChartTemperature.Name = "cartesianChartTemperature";
            this.cartesianChartTemperature.Size = new System.Drawing.Size(525, 234);
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
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indor temperature";
            // 
            // cartesianChartPressure
            // 
            this.cartesianChartPressure.Location = new System.Drawing.Point(587, 76);
            this.cartesianChartPressure.Name = "cartesianChartPressure";
            this.cartesianChartPressure.Size = new System.Drawing.Size(512, 234);
            this.cartesianChartPressure.TabIndex = 3;
            this.cartesianChartPressure.Text = "cartesianChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(606, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indor pressure";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(47, 600);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(169, 34);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // radioButton_24H
            // 
            this.radioButton_24H.AutoSize = true;
            this.radioButton_24H.Checked = true;
            this.radioButton_24H.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_24H.ForeColor = System.Drawing.Color.White;
            this.radioButton_24H.Location = new System.Drawing.Point(24, 20);
            this.radioButton_24H.Name = "radioButton_24H";
            this.radioButton_24H.Size = new System.Drawing.Size(48, 18);
            this.radioButton_24H.TabIndex = 6;
            this.radioButton_24H.TabStop = true;
            this.radioButton_24H.Text = "24H";
            this.radioButton_24H.UseVisualStyleBackColor = true;
            // 
            // radioButton_Week
            // 
            this.radioButton_Week.AutoSize = true;
            this.radioButton_Week.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Week.ForeColor = System.Drawing.Color.White;
            this.radioButton_Week.Location = new System.Drawing.Point(78, 20);
            this.radioButton_Week.Name = "radioButton_Week";
            this.radioButton_Week.Size = new System.Drawing.Size(56, 18);
            this.radioButton_Week.TabIndex = 7;
            this.radioButton_Week.Text = "Week";
            this.radioButton_Week.UseVisualStyleBackColor = true;
            // 
            // radioButton_Max
            // 
            this.radioButton_Max.AutoSize = true;
            this.radioButton_Max.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Max.ForeColor = System.Drawing.Color.White;
            this.radioButton_Max.Location = new System.Drawing.Point(140, 20);
            this.radioButton_Max.Name = "radioButton_Max";
            this.radioButton_Max.Size = new System.Drawing.Size(48, 18);
            this.radioButton_Max.TabIndex = 8;
            this.radioButton_Max.Text = "Max";
            this.radioButton_Max.UseVisualStyleBackColor = true;
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.radioButton_Week);
            this.groupBoxRange.Controls.Add(this.radioButton_Max);
            this.groupBoxRange.Controls.Add(this.radioButton_24H);
            this.groupBoxRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRange.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRange.ForeColor = System.Drawing.Color.White;
            this.groupBoxRange.Location = new System.Drawing.Point(47, 316);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(209, 50);
            this.groupBoxRange.TabIndex = 9;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Select Range";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_LastMesTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_LastMesPress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_LastMesTemp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(290, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 50);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Measurement";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 22);
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
            this.textBox_LastMesPress.Location = new System.Drawing.Point(464, 17);
            this.textBox_LastMesPress.Name = "textBox_LastMesPress";
            this.textBox_LastMesPress.Size = new System.Drawing.Size(73, 21);
            this.textBox_LastMesPress.TabIndex = 2;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1131, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRange);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartesianChartPressure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChartTemperature);
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RadioButton radioButton_24H;
        private System.Windows.Forms.RadioButton radioButton_Week;
        private System.Windows.Forms.RadioButton radioButton_Max;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LastMesTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LastMesPress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_LastMesTemp;
    }
}
