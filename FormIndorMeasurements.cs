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
using WeatherStationDesktop;

namespace WeatherStation
{
    public partial class FormIndorMeasurements : Form
    {
        Measurements measurements;
        List<RadioButton> LastRange = new List<RadioButton>();

        public FormIndorMeasurements()
        {
            InitializeComponent();
            measurements = new Measurements();
            if (measurements.ConnectionStatus)
            {
                UpdateCharts();
            }
            else
            {
                MessageBox.Show("Database is out of range! Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool UpdateCharts()
        {

            Cursor.Current = Cursors.WaitCursor;
            int rangeCode;
            if (radioButtonToday.Checked == true)
            {
                rangeCode = 1;
            }
            else if (radioButton3Days.Checked == true)
            {
                rangeCode = 3;
            }
            else
            {
                rangeCode = 7;
            }

            ChartsDatas chartsDatas = measurements.GetChartsDatas(rangeCode);
            if (measurements.ConnectionStatus)
            {
                cartesianChartPressure.Series.Clear();
                cartesianChartPressure.AxisX.Clear();
                cartesianChartPressure.AxisY.Clear();
                cartesianChartTemperature.Series.Clear();
                cartesianChartTemperature.AxisX.Clear();
                cartesianChartHumidity.Series.Clear();
                cartesianChartHumidity.AxisX.Clear();

                SeriesCollection PressSeries = new SeriesCollection();
                LineSeries PressSet = new LineSeries() { Title = "Pressure", Values = new ChartValues<double>(chartsDatas.Pressure), };
                PressSet.Stroke = System.Windows.Media.Brushes.Orange;
                PressSeries.Add(PressSet);
                cartesianChartPressure.Series = PressSeries;

                SeriesCollection HumSeries = new SeriesCollection();
                LineSeries HumSet = new LineSeries() { Title = "Humidity", Values = new ChartValues<double>(chartsDatas.Humidity), };
                HumSeries.Add(HumSet);
                cartesianChartHumidity.Series = HumSeries;

                SeriesCollection TempSeries = new SeriesCollection();
                LineSeries TempSet = new LineSeries() { Title = "Temperature", Values = new ChartValues<double>(chartsDatas.Temperature) };
                TempSet.Stroke = System.Windows.Media.Brushes.Red;
                TempSeries.Add(TempSet);
                cartesianChartTemperature.Series = TempSeries;

                Axis axPress = new Axis() { Separator = new Separator() { Step = 24 } };
                axPress.Labels = chartsDatas.TimesLabels;
                Axis axTem = new Axis() { Separator = new Separator() { Step = 12 } };
                axTem.Labels = chartsDatas.TimesLabels;
                Axis axHum = new Axis() { Separator = new Separator() { Step = 24 } };
                axHum.Labels = chartsDatas.TimesLabels;

                cartesianChartPressure.AxisX.Add(axPress);
                //cartesianChartPressure.AxisY.Add(ayPress);
                cartesianChartTemperature.AxisX.Add(axTem);
                cartesianChartHumidity.AxisX.Add(axHum);
                AddLastRange();
                Cursor.Current = Cursors.Default;

                return true;
            }
            else
            {
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                restoreLastRange();
                return false;
            }



        }

        void AddLastRange()
        {
            if (radioButtonToday.Checked)
            {
                LastRange.Add(radioButtonToday);
            }
            else if (radioButton3Days.Checked)
            {
                LastRange.Add(radioButton3Days);
            }
            else
            {
                LastRange.Add(radioButtonWeek);
            }
        }

        void restoreLastRange()
        {
            RadioButton button = LastRange.Last();
            button.Checked = true;
        }


        private void radioButtonToday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonToday.Checked & LastRange.Last() != radioButtonToday) UpdateCharts();
        }

        private void radioButton3Days_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3Days.Checked & LastRange.Last() != radioButton3Days) UpdateCharts();
        }

        private void radioButtonWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeek.Checked & LastRange.Last() != radioButtonWeek) UpdateCharts();
        }
    }
}
