using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationDesctop;

namespace WeatherStationDesktop
{
    public partial class FormMain : Form
    {
        Measurements measurements = new Measurements();
        public FormMain()
        {
            InitializeComponent();
            textBox_LastMesPress.Text = measurements.LastPress.ToString();
            textBox_LastMesTemp.Text = measurements.LastTemp.ToString();
            textBox_LastMesTime.Text = measurements.LastTime.ToString();
            textBoxLastMesHum.Text = measurements.LastHum.ToString();
            UpdateCharts();
        }

        void UpdateCharts()
        {
            Cursor.Current = Cursors.WaitCursor;
            int rangeCode;
            if (radioButtonToday.Checked == true)
            {
                rangeCode = 1;
            }else if (radioButton3Days.Checked == true)
            {
                rangeCode = 3;
            }
            else
            {
                rangeCode = 7;
            }
            ChartsDatas chartsDatas = measurements.GetChartsDatas(rangeCode);

            cartesianChartPressure.Series.Clear();
            cartesianChartPressure.AxisX.Clear();
            cartesianChartTemperature.Series.Clear();
            cartesianChartTemperature.AxisX.Clear();
            cartesianChartHumidity.Series.Clear();
            cartesianChartHumidity.AxisX.Clear();

            SeriesCollection SeriesPress = new SeriesCollection();
            LineSeries pressSeries = new LineSeries() { Title = "Pressure", Values = new ChartValues<double>(chartsDatas.Pressure), };
            pressSeries.Stroke = System.Windows.Media.Brushes.Orange;
            SeriesPress.Add(pressSeries);
            cartesianChartPressure.Series = SeriesPress;

            SeriesCollection seriesHum = new SeriesCollection();
            LineSeries humSeries = new LineSeries() { Title = "Humidity", Values = new ChartValues<double>(chartsDatas.Humidity), };
            seriesHum.Add(humSeries);
            cartesianChartHumidity.Series = seriesHum;

            SeriesCollection SeriesTemp = new SeriesCollection();
            LineSeries temSeries = new LineSeries() { Title = "Temperature", Values = new ChartValues<double>(chartsDatas.Temperature) };
            temSeries.Stroke = System.Windows.Media.Brushes.Red;
            SeriesTemp.Add(temSeries);
            cartesianChartTemperature.Series = SeriesTemp;
            Axis axPress = new Axis() { Separator = new Separator() { Step = 12 } };
            axPress.Labels = chartsDatas.TimesLabels;
            Axis axTem= new Axis() { Separator = new Separator() { Step = 12 } };
            axTem.Labels = chartsDatas.TimesLabels;
            Axis axHum = new Axis() { Separator = new Separator() { Step = 12 } };
            axHum.Labels = chartsDatas.TimesLabels;

            cartesianChartPressure.AxisX.Add(axPress);
            cartesianChartTemperature.AxisX.Add(axTem);
            cartesianChartHumidity.AxisX.Add(axHum);

            Cursor.Current = Cursors.Default;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonToday_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCharts();
        }

        private void radioButton3Days_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCharts();
        }

        private void radioButtonWeek_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCharts();
        }
    }
}
