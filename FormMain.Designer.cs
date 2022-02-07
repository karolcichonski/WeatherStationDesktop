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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCurrentWeather = new System.Windows.Forms.GroupBox();
            this.buttonWeatherDetails = new System.Windows.Forms.Button();
            this.pictureBoxCurrentWeather = new System.Windows.Forms.PictureBox();
            this.textBoxWeatherWind = new System.Windows.Forms.TextBox();
            this.textBoxWeatherPress = new System.Windows.Forms.TextBox();
            this.textBoxWeatherHum = new System.Windows.Forms.TextBox();
            this.textBoxWeatherTemp = new System.Windows.Forms.TextBox();
            this.textBoxWeatherDesc = new System.Windows.Forms.TextBox();
            this.textBoxWeatherTime = new System.Windows.Forms.TextBox();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxIndor = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cartesianChartHumidity = new LiveCharts.WinForms.CartesianChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLastMesHum = new System.Windows.Forms.TextBox();
            this.textBox_LastMesTime = new System.Windows.Forms.TextBox();
            this.textBox_LastMesPress = new System.Windows.Forms.TextBox();
            this.textBox_LastMesTemp = new System.Windows.Forms.TextBox();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButton3Days = new System.Windows.Forms.RadioButton();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cartesianChartPressure = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChartTemperature = new LiveCharts.WinForms.CartesianChart();
            this.groupBoxCurrentWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentWeather)).BeginInit();
            this.groupBoxIndor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCurrentWeather
            // 
            this.groupBoxCurrentWeather.Controls.Add(this.buttonWeatherDetails);
            this.groupBoxCurrentWeather.Controls.Add(this.pictureBoxCurrentWeather);
            this.groupBoxCurrentWeather.Controls.Add(this.textBoxWeatherWind);
            this.groupBoxCurrentWeather.Controls.Add(this.textBoxWeatherPress);
            this.groupBoxCurrentWeather.Controls.Add(this.textBoxWeatherHum);
            this.groupBoxCurrentWeather.Controls.Add(this.textBoxWeatherTemp);
            this.groupBoxCurrentWeather.Controls.Add(this.textBoxWeatherDesc);
            this.groupBoxCurrentWeather.Controls.Add(this.textBoxWeatherTime);
            this.groupBoxCurrentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxCurrentWeather.ForeColor = System.Drawing.Color.White;
            this.groupBoxCurrentWeather.Location = new System.Drawing.Point(48, 29);
            this.groupBoxCurrentWeather.Name = "groupBoxCurrentWeather";
            this.groupBoxCurrentWeather.Size = new System.Drawing.Size(1043, 60);
            this.groupBoxCurrentWeather.TabIndex = 15;
            this.groupBoxCurrentWeather.TabStop = false;
            this.groupBoxCurrentWeather.Text = "Current Weather";
            // 
            // buttonWeatherDetails
            // 
            this.buttonWeatherDetails.BackColor = System.Drawing.Color.Gray;
            this.buttonWeatherDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeatherDetails.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWeatherDetails.Location = new System.Drawing.Point(886, 19);
            this.buttonWeatherDetails.Name = "buttonWeatherDetails";
            this.buttonWeatherDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonWeatherDetails.TabIndex = 22;
            this.buttonWeatherDetails.Text = "Details";
            this.buttonWeatherDetails.UseVisualStyleBackColor = false;
            this.buttonWeatherDetails.Click += new System.EventHandler(this.buttonWeatherDetails_Click);
            // 
            // pictureBoxCurrentWeather
            // 
            this.pictureBoxCurrentWeather.Location = new System.Drawing.Point(261, 12);
            this.pictureBoxCurrentWeather.Name = "pictureBoxCurrentWeather";
            this.pictureBoxCurrentWeather.Size = new System.Drawing.Size(45, 39);
            this.pictureBoxCurrentWeather.TabIndex = 21;
            this.pictureBoxCurrentWeather.TabStop = false;
            // 
            // textBoxWeatherWind
            // 
            this.textBoxWeatherWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherWind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherWind.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherWind.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherWind.Location = new System.Drawing.Point(745, 19);
            this.textBoxWeatherWind.Name = "textBoxWeatherWind";
            this.textBoxWeatherWind.ReadOnly = true;
            this.textBoxWeatherWind.Size = new System.Drawing.Size(133, 24);
            this.textBoxWeatherWind.TabIndex = 20;
            // 
            // textBoxWeatherPress
            // 
            this.textBoxWeatherPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherPress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherPress.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherPress.Location = new System.Drawing.Point(598, 19);
            this.textBoxWeatherPress.Name = "textBoxWeatherPress";
            this.textBoxWeatherPress.ReadOnly = true;
            this.textBoxWeatherPress.Size = new System.Drawing.Size(141, 24);
            this.textBoxWeatherPress.TabIndex = 19;
            // 
            // textBoxWeatherHum
            // 
            this.textBoxWeatherHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherHum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherHum.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherHum.Location = new System.Drawing.Point(487, 19);
            this.textBoxWeatherHum.Name = "textBoxWeatherHum";
            this.textBoxWeatherHum.ReadOnly = true;
            this.textBoxWeatherHum.Size = new System.Drawing.Size(105, 24);
            this.textBoxWeatherHum.TabIndex = 18;
            // 
            // textBoxWeatherTemp
            // 
            this.textBoxWeatherTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherTemp.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherTemp.Location = new System.Drawing.Point(408, 19);
            this.textBoxWeatherTemp.Name = "textBoxWeatherTemp";
            this.textBoxWeatherTemp.ReadOnly = true;
            this.textBoxWeatherTemp.Size = new System.Drawing.Size(73, 24);
            this.textBoxWeatherTemp.TabIndex = 17;
            // 
            // textBoxWeatherDesc
            // 
            this.textBoxWeatherDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherDesc.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherDesc.Location = new System.Drawing.Point(312, 19);
            this.textBoxWeatherDesc.Name = "textBoxWeatherDesc";
            this.textBoxWeatherDesc.ReadOnly = true;
            this.textBoxWeatherDesc.Size = new System.Drawing.Size(90, 24);
            this.textBoxWeatherDesc.TabIndex = 16;
            // 
            // textBoxWeatherTime
            // 
            this.textBoxWeatherTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherTime.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherTime.Location = new System.Drawing.Point(24, 19);
            this.textBoxWeatherTime.Name = "textBoxWeatherTime";
            this.textBoxWeatherTime.ReadOnly = true;
            this.textBoxWeatherTime.Size = new System.Drawing.Size(231, 24);
            this.textBoxWeatherTime.TabIndex = 15;
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "01d@2x.png");
            this.imageListIcons.Images.SetKeyName(1, "01n@2x.png");
            this.imageListIcons.Images.SetKeyName(2, "02d@2x.png");
            this.imageListIcons.Images.SetKeyName(3, "02n@2x.png");
            this.imageListIcons.Images.SetKeyName(4, "03d@2x.png");
            this.imageListIcons.Images.SetKeyName(5, "03n@2x.png");
            this.imageListIcons.Images.SetKeyName(6, "04d@2x.png");
            this.imageListIcons.Images.SetKeyName(7, "04n@2x.png");
            this.imageListIcons.Images.SetKeyName(8, "09d@2x.png");
            this.imageListIcons.Images.SetKeyName(9, "09n@2x.png");
            this.imageListIcons.Images.SetKeyName(10, "10d@2x.png");
            this.imageListIcons.Images.SetKeyName(11, "10n@2x.png");
            this.imageListIcons.Images.SetKeyName(12, "11d@2x.png");
            this.imageListIcons.Images.SetKeyName(13, "11n@2x.png");
            this.imageListIcons.Images.SetKeyName(14, "13d@2x.png");
            this.imageListIcons.Images.SetKeyName(15, "13n@2x.png");
            this.imageListIcons.Images.SetKeyName(16, "50d@2x.png");
            this.imageListIcons.Images.SetKeyName(17, "50n@2x.png");
            // 
            // groupBoxIndor
            // 
            this.groupBoxIndor.Controls.Add(this.label6);
            this.groupBoxIndor.Controls.Add(this.cartesianChartHumidity);
            this.groupBoxIndor.Controls.Add(this.groupBox1);
            this.groupBoxIndor.Controls.Add(this.groupBoxRange);
            this.groupBoxIndor.Controls.Add(this.label2);
            this.groupBoxIndor.Controls.Add(this.cartesianChartPressure);
            this.groupBoxIndor.Controls.Add(this.label1);
            this.groupBoxIndor.Controls.Add(this.cartesianChartTemperature);
            this.groupBoxIndor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxIndor.ForeColor = System.Drawing.Color.White;
            this.groupBoxIndor.Location = new System.Drawing.Point(48, 95);
            this.groupBoxIndor.Name = "groupBoxIndor";
            this.groupBoxIndor.Size = new System.Drawing.Size(1043, 691);
            this.groupBoxIndor.TabIndex = 16;
            this.groupBoxIndor.TabStop = false;
            this.groupBoxIndor.Text = "Indor Measurements";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Humidity";
            // 
            // cartesianChartHumidity
            // 
            this.cartesianChartHumidity.Location = new System.Drawing.Point(36, 307);
            this.cartesianChartHumidity.Name = "cartesianChartHumidity";
            this.cartesianChartHumidity.Size = new System.Drawing.Size(980, 170);
            this.cartesianChartHumidity.TabIndex = 19;
            this.cartesianChartHumidity.Text = "cartesianChart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLastMesHum);
            this.groupBox1.Controls.Add(this.textBox_LastMesTime);
            this.groupBox1.Controls.Add(this.textBox_LastMesPress);
            this.groupBox1.Controls.Add(this.textBox_LastMesTemp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(295, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 58);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Measurement";
            // 
            // textBoxLastMesHum
            // 
            this.textBoxLastMesHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLastMesHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastMesHum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLastMesHum.ForeColor = System.Drawing.Color.White;
            this.textBoxLastMesHum.Location = new System.Drawing.Point(297, 23);
            this.textBoxLastMesHum.Name = "textBoxLastMesHum";
            this.textBoxLastMesHum.ReadOnly = true;
            this.textBoxLastMesHum.Size = new System.Drawing.Size(156, 24);
            this.textBoxLastMesHum.TabIndex = 6;
            // 
            // textBox_LastMesTime
            // 
            this.textBox_LastMesTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LastMesTime.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesTime.Location = new System.Drawing.Point(17, 22);
            this.textBox_LastMesTime.Name = "textBox_LastMesTime";
            this.textBox_LastMesTime.ReadOnly = true;
            this.textBox_LastMesTime.Size = new System.Drawing.Size(157, 24);
            this.textBox_LastMesTime.TabIndex = 4;
            // 
            // textBox_LastMesPress
            // 
            this.textBox_LastMesPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesPress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LastMesPress.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesPress.Location = new System.Drawing.Point(459, 22);
            this.textBox_LastMesPress.Name = "textBox_LastMesPress";
            this.textBox_LastMesPress.ReadOnly = true;
            this.textBox_LastMesPress.Size = new System.Drawing.Size(175, 24);
            this.textBox_LastMesPress.TabIndex = 2;
            // 
            // textBox_LastMesTemp
            // 
            this.textBox_LastMesTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LastMesTemp.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesTemp.Location = new System.Drawing.Point(180, 22);
            this.textBox_LastMesTemp.Name = "textBox_LastMesTemp";
            this.textBox_LastMesTemp.ReadOnly = true;
            this.textBox_LastMesTemp.Size = new System.Drawing.Size(110, 24);
            this.textBox_LastMesTemp.TabIndex = 0;
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.radioButtonWeek);
            this.groupBoxRange.Controls.Add(this.radioButton3Days);
            this.groupBoxRange.Controls.Add(this.radioButtonToday);
            this.groupBoxRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRange.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRange.ForeColor = System.Drawing.Color.White;
            this.groupBoxRange.Location = new System.Drawing.Point(60, 26);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(219, 58);
            this.groupBoxRange.TabIndex = 17;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Select Range";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pressure";
            // 
            // cartesianChartPressure
            // 
            this.cartesianChartPressure.Location = new System.Drawing.Point(36, 500);
            this.cartesianChartPressure.Name = "cartesianChartPressure";
            this.cartesianChartPressure.Size = new System.Drawing.Size(980, 169);
            this.cartesianChartPressure.TabIndex = 15;
            this.cartesianChartPressure.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temperature";
            // 
            // cartesianChartTemperature
            // 
            this.cartesianChartTemperature.Location = new System.Drawing.Point(36, 117);
            this.cartesianChartTemperature.Name = "cartesianChartTemperature";
            this.cartesianChartTemperature.Size = new System.Drawing.Size(980, 172);
            this.cartesianChartTemperature.TabIndex = 13;
            this.cartesianChartTemperature.Text = "cartesianChart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1131, 847);
            this.Controls.Add(this.groupBoxIndor);
            this.Controls.Add(this.groupBoxCurrentWeather);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Weather Station";
            this.groupBoxCurrentWeather.ResumeLayout(false);
            this.groupBoxCurrentWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentWeather)).EndInit();
            this.groupBoxIndor.ResumeLayout(false);
            this.groupBoxIndor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCurrentWeather;
        private System.Windows.Forms.TextBox textBoxWeatherTime;
        private System.Windows.Forms.TextBox textBoxWeatherWind;
        private System.Windows.Forms.TextBox textBoxWeatherPress;
        private System.Windows.Forms.TextBox textBoxWeatherHum;
        private System.Windows.Forms.TextBox textBoxWeatherTemp;
        private System.Windows.Forms.TextBox textBoxWeatherDesc;
        private System.Windows.Forms.PictureBox pictureBoxCurrentWeather;
        private System.Windows.Forms.GroupBox groupBoxIndor;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.CartesianChart cartesianChartHumidity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLastMesHum;
        private System.Windows.Forms.TextBox textBox_LastMesTime;
        private System.Windows.Forms.TextBox textBox_LastMesPress;
        private System.Windows.Forms.TextBox textBox_LastMesTemp;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButton3Days;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart cartesianChartPressure;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart cartesianChartTemperature;
        private System.Windows.Forms.Button buttonWeatherDetails;
        public System.Windows.Forms.ImageList imageListIcons;
    }
}

