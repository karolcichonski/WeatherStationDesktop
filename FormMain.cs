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
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        List<RadioButton> LastRange = new List<RadioButton>();
        int? iconNumber;
        public FormMain()
        {
            InitializeComponent();

            measurements = new Measurements();
            if (measurements.ConnectionStatus)
            {
                textBox_LastMesPress.Text = $"Pressure: {(measurements.LastPress/100).ToString()} hPa";
                textBox_LastMesTemp.Text = measurements.LastTemp.ToString()+"\u00b0 C";
                textBox_LastMesTime.Text = measurements.LastTime.ToString();
                textBoxLastMesHum.Text = $"Humidity: {measurements.LastHum.ToString()}%";
                UpdateCharts();
            }
            else
            {
                MessageBox.Show("Database is out of range! Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // System.Environment.Exit(0);
            }

            UpdateWather();
            UpdateWeatherForecast();


        }

        async Task UpdateWather()
        {
            OpenWeatherMap OpenWeatherMap = new OpenWeatherMap();
            await OpenWeatherMap.GenerateWeatherObject();
            currentWeather = OpenWeatherMap.GetCurrentWeather();
            textBoxWeatherTime.Text = currentWeather.DateTime.ToString("dddd, MMMM dd yyyy", culture);
            textBoxWeatherDesc.Text = currentWeather.Description;
            textBoxWeatherTemp.Text = $"Temperature: {currentWeather.Temp}\u00b0 C";
            textBoxWeatherHum.Text = $"Humidity: {currentWeather.Humidity}%";
            textBoxWeatherPress.Text = $"Pressure: {currentWeather.Pressure} hPa";
            textBoxWeatherWind.Text = $"Wind: {currentWeather.WindSpeed} km/h";
            iconNumber = GetImageCode(currentWeather.Icon);
            if(iconNumber != null) pictureBoxCurrentWeather.Image = imageListIcons.Images[(int)iconNumber];
        }

        async Task UpdateWeatherForecast()
        {
            OpenWeatherMapForecast openWeatherMapForecast = new OpenWeatherMapForecast();
            await openWeatherMapForecast.GenerateWeatherObject();
            List<OneDayWeather> ForecastWeaders = openWeatherMapForecast.GetDailyWeather();
            pictureBoxForecast1.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[1].Icon)];
            textBoxForecast1main.Text = ForecastWeaders[1].DateTime.ToString("dddd",culture);
            textBoxForecast1main.Text += $": {ForecastWeaders[1].Main}";
            textBoxForecast1details.AppendText( $"T: {ForecastWeaders[1].Temp.ToString()}\u00b0 C");
            textBoxForecast1details.AppendText(Environment.NewLine);
            textBoxForecast1details.AppendText($"H: {ForecastWeaders[1].Humidity.ToString()} %");
            textBoxForecast1details.AppendText(Environment.NewLine);
            textBoxForecast1details.AppendText($"W: {Math.Round(ForecastWeaders[1].WindSpeed).ToString()} km/h");
            textBoxForecast1details.AppendText(Environment.NewLine);
            textBoxForecast1details.AppendText($"R: {ForecastWeaders[1].Rain} mm");
            pictureBoxForecast2.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[2].Icon)];
            textBoxForecast2main.Text = ForecastWeaders[2].DateTime.ToString("dddd",culture);
            textBoxForecast2main.Text += $": {ForecastWeaders[2].Main}";
            textBoxForecast2details.AppendText($"T: {ForecastWeaders[2].Temp.ToString()}\u00b0 C");
            textBoxForecast2details.AppendText(Environment.NewLine);
            textBoxForecast2details.AppendText($"H: {ForecastWeaders[2].Humidity.ToString()} %");
            textBoxForecast2details.AppendText(Environment.NewLine);
            textBoxForecast2details.AppendText($"W: {Math.Round(ForecastWeaders[2].WindSpeed).ToString()} km/h");
            textBoxForecast2details.AppendText(Environment.NewLine);
            textBoxForecast2details.AppendText($"R: {ForecastWeaders[2].Rain} mm");
            pictureBoxForecast3.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[3].Icon)];
            textBoxForecast3main.Text = ForecastWeaders[3].DateTime.ToString("dddd", culture);
            textBoxForecast3main.Text += $": {ForecastWeaders[3].Main}";
            textBoxForecast3details.AppendText($"T: {ForecastWeaders[3].Temp.ToString()}\u00b0 C");
            textBoxForecast3details.AppendText(Environment.NewLine);
            textBoxForecast3details.AppendText($"H: {ForecastWeaders[3].Humidity.ToString()} %");
            textBoxForecast3details.AppendText(Environment.NewLine);
            textBoxForecast3details.AppendText($"W: {Math.Round(ForecastWeaders[3].WindSpeed).ToString()} km/h");
            textBoxForecast3details.AppendText(Environment.NewLine);
            textBoxForecast3details.AppendText($"R: {ForecastWeaders[3].Rain} mm");
            pictureBoxForecast4.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[4].Icon)];
            textBoxForecast4main.Text = ForecastWeaders[4].DateTime.ToString("dddd", culture);
            textBoxForecast4main.Text += $": {ForecastWeaders[4].Main}";
            textBoxForecast4details.AppendText($"T: {ForecastWeaders[4].Temp.ToString()}\u00b0 C");
            textBoxForecast4details.AppendText(Environment.NewLine);
            textBoxForecast4details.AppendText($"H: {ForecastWeaders[4].Humidity.ToString()} %");
            textBoxForecast4details.AppendText(Environment.NewLine);
            textBoxForecast4details.AppendText($"W: {Math.Round(ForecastWeaders[4].WindSpeed).ToString()} km/h");
            textBoxForecast4details.AppendText(Environment.NewLine);
            textBoxForecast4details.AppendText($"R: {ForecastWeaders[4].Rain} mm");
            pictureBoxForecast5.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[5].Icon)];
            textBoxForecast5main.Text = ForecastWeaders[5].DateTime.ToString("dddd", culture);
            textBoxForecast5main.Text += $": {ForecastWeaders[5].Main}";
            textBoxForecast5details.AppendText($"T: {ForecastWeaders[5].Temp.ToString()}\u00b0 C");
            textBoxForecast5details.AppendText(Environment.NewLine);
            textBoxForecast5details.AppendText($"H: {ForecastWeaders[5].Humidity.ToString()} %");
            textBoxForecast5details.AppendText(Environment.NewLine);
            textBoxForecast5details.AppendText($"W: {Math.Round(ForecastWeaders[5].WindSpeed).ToString()} km/h");
            textBoxForecast5details.AppendText(Environment.NewLine);
            textBoxForecast5details.AppendText($"R: {ForecastWeaders[5].Rain} mm");
            pictureBoxForecast6.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[6].Icon)];
            textBoxForecast6main.Text = ForecastWeaders[6].DateTime.ToString("dddd", culture);
            textBoxForecast6main.Text += $": {ForecastWeaders[6].Main}";
            textBoxForecast6details.AppendText($"T: {ForecastWeaders[6].Temp.ToString()}\u00b0 C");
            textBoxForecast6details.AppendText(Environment.NewLine);
            textBoxForecast6details.AppendText($"H: {ForecastWeaders[6].Humidity.ToString()} %");
            textBoxForecast6details.AppendText(Environment.NewLine);
            textBoxForecast6details.AppendText($"W: {Math.Round(ForecastWeaders[6].WindSpeed).ToString()} km/h");
            textBoxForecast6details.AppendText(Environment.NewLine);
            textBoxForecast6details.AppendText($"R: {ForecastWeaders[6].Rain} mm");
            pictureBoxForecast7.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeaders[7].Icon)];
            textBoxForecast7main.Text = ForecastWeaders[7].DateTime.ToString("dddd", culture);
            textBoxForecast7main.Text += $": {ForecastWeaders[7].Main}";
            textBoxForecast7details.AppendText($"T: {ForecastWeaders[7].Temp.ToString()}\u00b0 C");
            textBoxForecast7details.AppendText(Environment.NewLine);
            textBoxForecast7details.AppendText($"H: {ForecastWeaders[7].Humidity.ToString()} %");
            textBoxForecast7details.AppendText(Environment.NewLine);
            textBoxForecast7details.AppendText($"W: {Math.Round(ForecastWeaders[7].WindSpeed).ToString()} km/h");
            textBoxForecast7details.AppendText(Environment.NewLine);
            textBoxForecast7details.AppendText($"R: {ForecastWeaders[7].Rain} mm");


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
