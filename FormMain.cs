using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationDesctop;

namespace WeatherStationDesktop
{
    public partial class FormMain : Form
    {
        Measurements measurements;
        OneDayWeather currentWeather;

        List<RadioButton> LastRange = new List<RadioButton>();
        int? iconNumber;
        public FormMain()
        {
            InitializeComponent();

            measurements = new Measurements();
            if (measurements.ConnectionStatus)
            {
                textBox_LastMesPress.Text = $"Pressure {(measurements.LastPress/100).ToString()} hPa";
                textBox_LastMesTemp.Text = measurements.LastTemp.ToString()+"\u00b0 C";
                textBox_LastMesTime.Text = measurements.LastTime.ToString();
                textBoxLastMesHum.Text = $"Humidity {measurements.LastHum.ToString()}%";
                UpdateCharts();
            }
            else
            {
                MessageBox.Show("Database is out of range! Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // System.Environment.Exit(0);
            }

            UpdateWather();



        }

        async Task UpdateWather()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            OpenWeatherMap OpenWeatherMap = new OpenWeatherMap();
            await OpenWeatherMap.GenerateWeatherObject();
            currentWeather = OpenWeatherMap.GetCurrentWeather();
            textBoxWeatherTime.Text = currentWeather.DateTime.ToString("dddd, MMMM dd yyyy", culture);
            textBoxWeatherDesc.Text = currentWeather.Description;
            textBoxWeatherTemp.Text = $"{currentWeather.Temp}\u00b0 C";
            textBoxWeatherHum.Text = $"Humidity {currentWeather.Humidity}%";
            textBoxWeatherPress.Text = $"Pressure {currentWeather.Pressure} hPa";
            textBoxWeatherWind.Text = $"Wind {currentWeather.WindSpeed} km/h";
            iconNumber = GetImageCode(currentWeather.Icon);
            if(iconNumber != null) pictureBoxCurrentWeather.Image = imageListIcons.Images[(int)iconNumber];
        }

        bool UpdateCharts()
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
                Axis axPress = new Axis() { Separator = new Separator() { Step = 12 } };
               // Axis ayPress = new Axis() { MinValue = 95000, MaxValue = 101000 };
                axPress.Labels = chartsDatas.TimesLabels;
                Axis axTem = new Axis() { Separator = new Separator() { Step = 12 } };
                axTem.Labels = chartsDatas.TimesLabels;
                Axis axHum = new Axis() { Separator = new Separator() { Step = 12 } };
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
                MessageBox.Show("Update failed!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        
        private int? GetImageCode(string iconeCode)
        {
            Dictionary<string, int> Icons = new Dictionary<string, int>();
            for (int i=0; i<imageListIcons.Images.Count; i++ )
            {
                Icons.Add(imageListIcons.Images.Keys[i].ToString().Substring(0,3), i);
            }

            int icoNum;
            if (Icons.TryGetValue(iconeCode, out icoNum))
            {
                return icoNum;
            }
            else
            {
                return null;
            }

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
        private void buttonWeatherDetails_Click(object sender, EventArgs e)
        {
            FormCurrentWeather currentWeatherForm = new FormCurrentWeather(currentWeather, (int)iconNumber);
            currentWeatherForm.Show();
        }
    }
}
