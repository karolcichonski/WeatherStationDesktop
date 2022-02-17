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
            this.buttonHist = new System.Windows.Forms.Button();
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
            this.groupBoxForecast = new System.Windows.Forms.GroupBox();
            this.textBoxForecast7details = new System.Windows.Forms.TextBox();
            this.textBoxForecast6details = new System.Windows.Forms.TextBox();
            this.textBoxForecast5details = new System.Windows.Forms.TextBox();
            this.textBoxForecast4details = new System.Windows.Forms.TextBox();
            this.textBoxForecast3details = new System.Windows.Forms.TextBox();
            this.textBoxForecast2details = new System.Windows.Forms.TextBox();
            this.textBoxForecast1details = new System.Windows.Forms.TextBox();
            this.textBoxForecast7main = new System.Windows.Forms.TextBox();
            this.textBoxForecast6main = new System.Windows.Forms.TextBox();
            this.textBoxForecast5main = new System.Windows.Forms.TextBox();
            this.textBoxForecast4main = new System.Windows.Forms.TextBox();
            this.textBoxForecast3main = new System.Windows.Forms.TextBox();
            this.textBoxForecast2main = new System.Windows.Forms.TextBox();
            this.textBoxForecast1main = new System.Windows.Forms.TextBox();
            this.pictureBoxForecast7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxForecast6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxForecast5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxForecast4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxForecast3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxForecast2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxForecast1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCurrentWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentWeather)).BeginInit();
            this.groupBoxIndor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRange.SuspendLayout();
            this.groupBoxForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCurrentWeather
            // 
            this.groupBoxCurrentWeather.Controls.Add(this.buttonHist);
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
            this.groupBoxCurrentWeather.Size = new System.Drawing.Size(1043, 94);
            this.groupBoxCurrentWeather.TabIndex = 15;
            this.groupBoxCurrentWeather.TabStop = false;
            this.groupBoxCurrentWeather.Text = "Current Weather";
            // 
            // buttonWeatherDetails
            // 
            this.buttonWeatherDetails.BackColor = System.Drawing.Color.Gray;
            this.buttonWeatherDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWeatherDetails.Enabled = false;
            this.buttonWeatherDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeatherDetails.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWeatherDetails.Location = new System.Drawing.Point(902, 22);
            this.buttonWeatherDetails.Name = "buttonWeatherDetails";
            this.buttonWeatherDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonWeatherDetails.TabIndex = 22;
            this.buttonWeatherDetails.Text = "Details";
            this.buttonWeatherDetails.UseVisualStyleBackColor = false;
            this.buttonWeatherDetails.Click += new System.EventHandler(this.buttonWeatherDetails_Click);
            // 
            // pictureBoxCurrentWeather
            // 
            this.pictureBoxCurrentWeather.Location = new System.Drawing.Point(24, 19);
            this.pictureBoxCurrentWeather.Name = "pictureBoxCurrentWeather";
            this.pictureBoxCurrentWeather.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxCurrentWeather.TabIndex = 21;
            this.pictureBoxCurrentWeather.TabStop = false;
            // 
            // textBoxWeatherWind
            // 
            this.textBoxWeatherWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherWind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherWind.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWeatherWind.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherWind.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherWind.Location = new System.Drawing.Point(592, 56);
            this.textBoxWeatherWind.Name = "textBoxWeatherWind";
            this.textBoxWeatherWind.ReadOnly = true;
            this.textBoxWeatherWind.Size = new System.Drawing.Size(289, 24);
            this.textBoxWeatherWind.TabIndex = 20;
            this.textBoxWeatherWind.TabStop = false;
            // 
            // textBoxWeatherPress
            // 
            this.textBoxWeatherPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherPress.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWeatherPress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherPress.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherPress.Location = new System.Drawing.Point(592, 21);
            this.textBoxWeatherPress.Name = "textBoxWeatherPress";
            this.textBoxWeatherPress.ReadOnly = true;
            this.textBoxWeatherPress.Size = new System.Drawing.Size(289, 24);
            this.textBoxWeatherPress.TabIndex = 19;
            this.textBoxWeatherPress.TabStop = false;
            // 
            // textBoxWeatherHum
            // 
            this.textBoxWeatherHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherHum.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWeatherHum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherHum.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherHum.Location = new System.Drawing.Point(318, 56);
            this.textBoxWeatherHum.Name = "textBoxWeatherHum";
            this.textBoxWeatherHum.ReadOnly = true;
            this.textBoxWeatherHum.Size = new System.Drawing.Size(268, 24);
            this.textBoxWeatherHum.TabIndex = 18;
            this.textBoxWeatherHum.TabStop = false;
            // 
            // textBoxWeatherTemp
            // 
            this.textBoxWeatherTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWeatherTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherTemp.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherTemp.Location = new System.Drawing.Point(318, 21);
            this.textBoxWeatherTemp.Name = "textBoxWeatherTemp";
            this.textBoxWeatherTemp.ReadOnly = true;
            this.textBoxWeatherTemp.Size = new System.Drawing.Size(268, 24);
            this.textBoxWeatherTemp.TabIndex = 17;
            this.textBoxWeatherTemp.TabStop = false;
            // 
            // textBoxWeatherDesc
            // 
            this.textBoxWeatherDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWeatherDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherDesc.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherDesc.Location = new System.Drawing.Point(80, 55);
            this.textBoxWeatherDesc.Name = "textBoxWeatherDesc";
            this.textBoxWeatherDesc.ReadOnly = true;
            this.textBoxWeatherDesc.Size = new System.Drawing.Size(231, 24);
            this.textBoxWeatherDesc.TabIndex = 16;
            this.textBoxWeatherDesc.TabStop = false;
            // 
            // textBoxWeatherTime
            // 
            this.textBoxWeatherTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWeatherTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeatherTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWeatherTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeatherTime.ForeColor = System.Drawing.Color.White;
            this.textBoxWeatherTime.Location = new System.Drawing.Point(80, 19);
            this.textBoxWeatherTime.Name = "textBoxWeatherTime";
            this.textBoxWeatherTime.ReadOnly = true;
            this.textBoxWeatherTime.Size = new System.Drawing.Size(231, 24);
            this.textBoxWeatherTime.TabIndex = 15;
            this.textBoxWeatherTime.TabStop = false;
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
            this.groupBoxIndor.Location = new System.Drawing.Point(48, 271);
            this.groupBoxIndor.Name = "groupBoxIndor";
            this.groupBoxIndor.Size = new System.Drawing.Size(1043, 501);
            this.groupBoxIndor.TabIndex = 16;
            this.groupBoxIndor.TabStop = false;
            this.groupBoxIndor.Text = "Indor Measurements";
            // 
            // buttonHist
            // 
            this.buttonHist.BackColor = System.Drawing.Color.Gray;
            this.buttonHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHist.Location = new System.Drawing.Point(902, 54);
            this.buttonHist.Name = "buttonHist";
            this.buttonHist.Size = new System.Drawing.Size(103, 23);
            this.buttonHist.TabIndex = 21;
            this.buttonHist.Text = "Historical";
            this.buttonHist.UseVisualStyleBackColor = false;
            this.buttonHist.Click += new System.EventHandler(this.buttonHist_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Humidity %";
            // 
            // cartesianChartHumidity
            // 
            this.cartesianChartHumidity.Location = new System.Drawing.Point(36, 307);
            this.cartesianChartHumidity.Name = "cartesianChartHumidity";
            this.cartesianChartHumidity.Size = new System.Drawing.Size(479, 170);
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
            this.textBoxLastMesHum.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxLastMesHum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLastMesHum.ForeColor = System.Drawing.Color.White;
            this.textBoxLastMesHum.Location = new System.Drawing.Point(297, 23);
            this.textBoxLastMesHum.Name = "textBoxLastMesHum";
            this.textBoxLastMesHum.ReadOnly = true;
            this.textBoxLastMesHum.Size = new System.Drawing.Size(156, 24);
            this.textBoxLastMesHum.TabIndex = 6;
            this.textBoxLastMesHum.TabStop = false;
            // 
            // textBox_LastMesTime
            // 
            this.textBox_LastMesTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_LastMesTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LastMesTime.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesTime.Location = new System.Drawing.Point(17, 22);
            this.textBox_LastMesTime.Name = "textBox_LastMesTime";
            this.textBox_LastMesTime.ReadOnly = true;
            this.textBox_LastMesTime.Size = new System.Drawing.Size(157, 24);
            this.textBox_LastMesTime.TabIndex = 4;
            this.textBox_LastMesTime.TabStop = false;
            // 
            // textBox_LastMesPress
            // 
            this.textBox_LastMesPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesPress.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_LastMesPress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LastMesPress.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesPress.Location = new System.Drawing.Point(459, 22);
            this.textBox_LastMesPress.Name = "textBox_LastMesPress";
            this.textBox_LastMesPress.ReadOnly = true;
            this.textBox_LastMesPress.Size = new System.Drawing.Size(175, 24);
            this.textBox_LastMesPress.TabIndex = 2;
            this.textBox_LastMesPress.TabStop = false;
            // 
            // textBox_LastMesTemp
            // 
            this.textBox_LastMesTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_LastMesTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LastMesTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_LastMesTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LastMesTemp.ForeColor = System.Drawing.Color.White;
            this.textBox_LastMesTemp.Location = new System.Drawing.Point(180, 22);
            this.textBox_LastMesTemp.Name = "textBox_LastMesTemp";
            this.textBox_LastMesTemp.ReadOnly = true;
            this.textBox_LastMesTemp.Size = new System.Drawing.Size(110, 24);
            this.textBox_LastMesTemp.TabIndex = 0;
            this.textBox_LastMesTemp.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pressure hPa";
            // 
            // cartesianChartPressure
            // 
            this.cartesianChartPressure.Location = new System.Drawing.Point(521, 307);
            this.cartesianChartPressure.Name = "cartesianChartPressure";
            this.cartesianChartPressure.Size = new System.Drawing.Size(500, 169);
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
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temperature °C";
            // 
            // cartesianChartTemperature
            // 
            this.cartesianChartTemperature.Location = new System.Drawing.Point(36, 117);
            this.cartesianChartTemperature.Name = "cartesianChartTemperature";
            this.cartesianChartTemperature.Size = new System.Drawing.Size(980, 172);
            this.cartesianChartTemperature.TabIndex = 13;
            this.cartesianChartTemperature.Text = "cartesianChart1";
            // 
            // groupBoxForecast
            // 
            this.groupBoxForecast.Controls.Add(this.textBoxForecast7details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast6details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast5details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast4details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast3details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast2details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast1details);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast7main);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast6main);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast5main);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast4main);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast3main);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast2main);
            this.groupBoxForecast.Controls.Add(this.textBoxForecast1main);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast7);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast6);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast5);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast4);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast3);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast2);
            this.groupBoxForecast.Controls.Add(this.pictureBoxForecast1);
            this.groupBoxForecast.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxForecast.ForeColor = System.Drawing.Color.White;
            this.groupBoxForecast.Location = new System.Drawing.Point(48, 129);
            this.groupBoxForecast.Name = "groupBoxForecast";
            this.groupBoxForecast.Size = new System.Drawing.Size(1043, 136);
            this.groupBoxForecast.TabIndex = 17;
            this.groupBoxForecast.TabStop = false;
            this.groupBoxForecast.Text = "Forecast Weather";
            // 
            // textBoxForecast7details
            // 
            this.textBoxForecast7details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast7details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast7details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast7details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast7details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast7details.Location = new System.Drawing.Point(926, 53);
            this.textBoxForecast7details.Multiline = true;
            this.textBoxForecast7details.Name = "textBoxForecast7details";
            this.textBoxForecast7details.ReadOnly = true;
            this.textBoxForecast7details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast7details.TabIndex = 42;
            this.textBoxForecast7details.TabStop = false;
            // 
            // textBoxForecast6details
            // 
            this.textBoxForecast6details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast6details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast6details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast6details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast6details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast6details.Location = new System.Drawing.Point(785, 53);
            this.textBoxForecast6details.Multiline = true;
            this.textBoxForecast6details.Name = "textBoxForecast6details";
            this.textBoxForecast6details.ReadOnly = true;
            this.textBoxForecast6details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast6details.TabIndex = 41;
            // 
            // textBoxForecast5details
            // 
            this.textBoxForecast5details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast5details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast5details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast5details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast5details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast5details.Location = new System.Drawing.Point(644, 53);
            this.textBoxForecast5details.Multiline = true;
            this.textBoxForecast5details.Name = "textBoxForecast5details";
            this.textBoxForecast5details.ReadOnly = true;
            this.textBoxForecast5details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast5details.TabIndex = 40;
            this.textBoxForecast5details.TabStop = false;
            // 
            // textBoxForecast4details
            // 
            this.textBoxForecast4details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast4details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast4details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast4details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast4details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast4details.Location = new System.Drawing.Point(503, 53);
            this.textBoxForecast4details.Multiline = true;
            this.textBoxForecast4details.Name = "textBoxForecast4details";
            this.textBoxForecast4details.ReadOnly = true;
            this.textBoxForecast4details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast4details.TabIndex = 39;
            this.textBoxForecast4details.TabStop = false;
            // 
            // textBoxForecast3details
            // 
            this.textBoxForecast3details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast3details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast3details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast3details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast3details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast3details.Location = new System.Drawing.Point(362, 53);
            this.textBoxForecast3details.Multiline = true;
            this.textBoxForecast3details.Name = "textBoxForecast3details";
            this.textBoxForecast3details.ReadOnly = true;
            this.textBoxForecast3details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast3details.TabIndex = 38;
            this.textBoxForecast3details.TabStop = false;
            // 
            // textBoxForecast2details
            // 
            this.textBoxForecast2details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast2details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast2details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast2details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast2details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast2details.Location = new System.Drawing.Point(221, 53);
            this.textBoxForecast2details.Multiline = true;
            this.textBoxForecast2details.Name = "textBoxForecast2details";
            this.textBoxForecast2details.ReadOnly = true;
            this.textBoxForecast2details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast2details.TabIndex = 37;
            this.textBoxForecast2details.TabStop = false;
            // 
            // textBoxForecast1details
            // 
            this.textBoxForecast1details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast1details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast1details.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast1details.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast1details.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast1details.Location = new System.Drawing.Point(80, 53);
            this.textBoxForecast1details.Multiline = true;
            this.textBoxForecast1details.Name = "textBoxForecast1details";
            this.textBoxForecast1details.ReadOnly = true;
            this.textBoxForecast1details.Size = new System.Drawing.Size(79, 60);
            this.textBoxForecast1details.TabIndex = 36;
            this.textBoxForecast1details.TabStop = false;
            // 
            // textBoxForecast7main
            // 
            this.textBoxForecast7main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast7main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast7main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast7main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast7main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast7main.Location = new System.Drawing.Point(870, 23);
            this.textBoxForecast7main.Name = "textBoxForecast7main";
            this.textBoxForecast7main.ReadOnly = true;
            this.textBoxForecast7main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast7main.TabIndex = 35;
            this.textBoxForecast7main.TabStop = false;
            // 
            // textBoxForecast6main
            // 
            this.textBoxForecast6main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast6main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast6main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast6main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast6main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast6main.Location = new System.Drawing.Point(729, 23);
            this.textBoxForecast6main.Name = "textBoxForecast6main";
            this.textBoxForecast6main.ReadOnly = true;
            this.textBoxForecast6main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast6main.TabIndex = 34;
            this.textBoxForecast6main.TabStop = false;
            // 
            // textBoxForecast5main
            // 
            this.textBoxForecast5main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast5main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast5main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast5main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast5main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast5main.Location = new System.Drawing.Point(588, 23);
            this.textBoxForecast5main.Name = "textBoxForecast5main";
            this.textBoxForecast5main.ReadOnly = true;
            this.textBoxForecast5main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast5main.TabIndex = 33;
            this.textBoxForecast5main.TabStop = false;
            // 
            // textBoxForecast4main
            // 
            this.textBoxForecast4main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast4main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast4main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast4main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast4main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast4main.Location = new System.Drawing.Point(447, 23);
            this.textBoxForecast4main.Name = "textBoxForecast4main";
            this.textBoxForecast4main.ReadOnly = true;
            this.textBoxForecast4main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast4main.TabIndex = 32;
            this.textBoxForecast4main.TabStop = false;
            // 
            // textBoxForecast3main
            // 
            this.textBoxForecast3main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast3main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast3main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast3main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast3main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast3main.Location = new System.Drawing.Point(306, 23);
            this.textBoxForecast3main.Name = "textBoxForecast3main";
            this.textBoxForecast3main.ReadOnly = true;
            this.textBoxForecast3main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast3main.TabIndex = 31;
            this.textBoxForecast3main.TabStop = false;
            // 
            // textBoxForecast2main
            // 
            this.textBoxForecast2main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast2main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast2main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast2main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast2main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast2main.Location = new System.Drawing.Point(165, 23);
            this.textBoxForecast2main.Name = "textBoxForecast2main";
            this.textBoxForecast2main.ReadOnly = true;
            this.textBoxForecast2main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast2main.TabIndex = 30;
            this.textBoxForecast2main.TabStop = false;
            // 
            // textBoxForecast1main
            // 
            this.textBoxForecast1main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxForecast1main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxForecast1main.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxForecast1main.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxForecast1main.ForeColor = System.Drawing.Color.White;
            this.textBoxForecast1main.Location = new System.Drawing.Point(24, 23);
            this.textBoxForecast1main.Name = "textBoxForecast1main";
            this.textBoxForecast1main.ReadOnly = true;
            this.textBoxForecast1main.Size = new System.Drawing.Size(135, 24);
            this.textBoxForecast1main.TabIndex = 29;
            this.textBoxForecast1main.TabStop = false;
            // 
            // pictureBoxForecast7
            // 
            this.pictureBoxForecast7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast7.Location = new System.Drawing.Point(869, 53);
            this.pictureBoxForecast7.Name = "pictureBoxForecast7";
            this.pictureBoxForecast7.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast7.TabIndex = 28;
            this.pictureBoxForecast7.TabStop = false;
            this.pictureBoxForecast7.Click += new System.EventHandler(this.pictureBoxForecast7_Click);
            // 
            // pictureBoxForecast6
            // 
            this.pictureBoxForecast6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast6.Location = new System.Drawing.Point(729, 53);
            this.pictureBoxForecast6.Name = "pictureBoxForecast6";
            this.pictureBoxForecast6.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast6.TabIndex = 27;
            this.pictureBoxForecast6.TabStop = false;
            this.pictureBoxForecast6.Click += new System.EventHandler(this.pictureBoxForecast6_Click);
            // 
            // pictureBoxForecast5
            // 
            this.pictureBoxForecast5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast5.Location = new System.Drawing.Point(588, 53);
            this.pictureBoxForecast5.Name = "pictureBoxForecast5";
            this.pictureBoxForecast5.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast5.TabIndex = 26;
            this.pictureBoxForecast5.TabStop = false;
            this.pictureBoxForecast5.Click += new System.EventHandler(this.pictureBoxForecast5_Click);
            // 
            // pictureBoxForecast4
            // 
            this.pictureBoxForecast4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast4.Location = new System.Drawing.Point(447, 53);
            this.pictureBoxForecast4.Name = "pictureBoxForecast4";
            this.pictureBoxForecast4.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast4.TabIndex = 25;
            this.pictureBoxForecast4.TabStop = false;
            this.pictureBoxForecast4.Click += new System.EventHandler(this.pictureBoxForecast4_Click);
            // 
            // pictureBoxForecast3
            // 
            this.pictureBoxForecast3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast3.Location = new System.Drawing.Point(306, 53);
            this.pictureBoxForecast3.Name = "pictureBoxForecast3";
            this.pictureBoxForecast3.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast3.TabIndex = 24;
            this.pictureBoxForecast3.TabStop = false;
            this.pictureBoxForecast3.Click += new System.EventHandler(this.pictureBoxForecast3_Click);
            // 
            // pictureBoxForecast2
            // 
            this.pictureBoxForecast2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast2.Location = new System.Drawing.Point(165, 53);
            this.pictureBoxForecast2.Name = "pictureBoxForecast2";
            this.pictureBoxForecast2.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast2.TabIndex = 23;
            this.pictureBoxForecast2.TabStop = false;
            this.pictureBoxForecast2.Click += new System.EventHandler(this.pictureBoxForecast2_Click);
            // 
            // pictureBoxForecast1
            // 
            this.pictureBoxForecast1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForecast1.Location = new System.Drawing.Point(24, 53);
            this.pictureBoxForecast1.Name = "pictureBoxForecast1";
            this.pictureBoxForecast1.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxForecast1.TabIndex = 22;
            this.pictureBoxForecast1.TabStop = false;
            this.pictureBoxForecast1.Click += new System.EventHandler(this.pictureBoxForecast1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1131, 794);
            this.Controls.Add(this.groupBoxForecast);
            this.Controls.Add(this.groupBoxIndor);
            this.Controls.Add(this.groupBoxCurrentWeather);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
            this.groupBoxForecast.ResumeLayout(false);
            this.groupBoxForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForecast1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxForecast;
        private System.Windows.Forms.PictureBox pictureBoxForecast7;
        private System.Windows.Forms.PictureBox pictureBoxForecast6;
        private System.Windows.Forms.PictureBox pictureBoxForecast5;
        private System.Windows.Forms.PictureBox pictureBoxForecast4;
        private System.Windows.Forms.PictureBox pictureBoxForecast3;
        private System.Windows.Forms.PictureBox pictureBoxForecast2;
        private System.Windows.Forms.PictureBox pictureBoxForecast1;
        private System.Windows.Forms.TextBox textBoxForecast7main;
        private System.Windows.Forms.TextBox textBoxForecast6main;
        private System.Windows.Forms.TextBox textBoxForecast5main;
        private System.Windows.Forms.TextBox textBoxForecast4main;
        private System.Windows.Forms.TextBox textBoxForecast3main;
        private System.Windows.Forms.TextBox textBoxForecast2main;
        private System.Windows.Forms.TextBox textBoxForecast1main;
        private System.Windows.Forms.TextBox textBoxForecast1details;
        private System.Windows.Forms.TextBox textBoxForecast7details;
        private System.Windows.Forms.TextBox textBoxForecast6details;
        private System.Windows.Forms.TextBox textBoxForecast5details;
        private System.Windows.Forms.TextBox textBoxForecast4details;
        private System.Windows.Forms.TextBox textBoxForecast3details;
        private System.Windows.Forms.TextBox textBoxForecast2details;
        private System.Windows.Forms.Button buttonHist;
    }
}

