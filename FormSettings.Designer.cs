namespace WeatherStation
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBoxCoordinates = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProvices = new System.Windows.Forms.ComboBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCoordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSettings.Location = new System.Drawing.Point(167, 222);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 29);
            this.buttonSaveSettings.TabIndex = 0;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // groupBoxCoordinates
            // 
            this.groupBoxCoordinates.Controls.Add(this.label4);
            this.groupBoxCoordinates.Controls.Add(this.label3);
            this.groupBoxCoordinates.Controls.Add(this.comboBoxProvices);
            this.groupBoxCoordinates.Controls.Add(this.comboBoxCities);
            this.groupBoxCoordinates.Controls.Add(this.label2);
            this.groupBoxCoordinates.Controls.Add(this.label1);
            this.groupBoxCoordinates.Controls.Add(this.textBoxLongitude);
            this.groupBoxCoordinates.Controls.Add(this.textBoxLatitude);
            this.groupBoxCoordinates.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxCoordinates.ForeColor = System.Drawing.Color.White;
            this.groupBoxCoordinates.Location = new System.Drawing.Point(26, 25);
            this.groupBoxCoordinates.Name = "groupBoxCoordinates";
            this.groupBoxCoordinates.Size = new System.Drawing.Size(445, 166);
            this.groupBoxCoordinates.TabIndex = 1;
            this.groupBoxCoordinates.TabStop = false;
            this.groupBoxCoordinates.Text = "Geo coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Provintion";
            // 
            // comboBoxProvices
            // 
            this.comboBoxProvices.FormattingEnabled = true;
            this.comboBoxProvices.Location = new System.Drawing.Point(36, 108);
            this.comboBoxProvices.Name = "comboBoxProvices";
            this.comboBoxProvices.Size = new System.Drawing.Size(180, 25);
            this.comboBoxProvices.TabIndex = 5;
            this.comboBoxProvices.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProvices_SelectedIndexChanged);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(222, 108);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(180, 25);
            this.comboBoxCities.TabIndex = 4;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude";
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.BackColor = System.Drawing.Color.Gray;
            this.textBoxLongitude.ForeColor = System.Drawing.Color.White;
            this.textBoxLongitude.Location = new System.Drawing.Point(144, 52);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(102, 24);
            this.textBoxLongitude.TabIndex = 1;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.BackColor = System.Drawing.Color.Gray;
            this.textBoxLatitude.ForeColor = System.Drawing.Color.White;
            this.textBoxLatitude.Location = new System.Drawing.Point(36, 52);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(102, 24);
            this.textBoxLatitude.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(248, 222);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 29);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(501, 287);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxCoordinates);
            this.Controls.Add(this.buttonSaveSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.groupBoxCoordinates.ResumeLayout(false);
            this.groupBoxCoordinates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.GroupBox groupBoxCoordinates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProvices;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label label4;
    }
}