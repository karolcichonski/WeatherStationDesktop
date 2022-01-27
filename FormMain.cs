using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStationDesktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Measurements measurements = new Measurements();
            InitializeComponent();
            textBox_LastMesPress.Text = measurements.LastPress.ToString();
            textBox_LastMesTemp.Text = measurements.LastTemp.ToString();
            textBox_LastMesTime.Text = measurements.LastTime.ToString();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
