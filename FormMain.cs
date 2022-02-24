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

        OneDayWeather currentWeather;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
        List<OneDayWeather> ForecastWeadersDaily = new List<OneDayWeather>();
        List<OneDayWeather> ForecastWeadersHurly = new List<OneDayWeather>();
        int? iconNumber;
        int openWeatherMapConnecionStatus;


        public FormMain()
        {
            InitializeComponent();

           Measurements measurements = new Measurements();
            if (measurements.ConnectionStatus)
            {
                textBox_LastMesPress.Text = $"Pressure: {(measurements.LastPress/100).ToString()} hPa";
                textBox_LastMesTemp.Text = measurements.LastTemp.ToString()+"\u00b0 C";
                textBox_LastMesTime.Text = measurements.LastTime.ToString();
                textBoxLastMesHum.Text = $"Humidity: {measurements.LastHum.ToString()}%";
            }
            else
            {
                MessageBox.Show("Database is out of range! Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateWeatherForecast();


        }


        async Task UpdateWeatherForecast()
        {
            OpenWeatherMapForecast openWeatherMapForecast = new OpenWeatherMapForecast();
            await openWeatherMapForecast.GenerateWeatherObject();
            ForecastWeadersDaily = openWeatherMapForecast.GetDailyWeather();
            ForecastWeadersHurly = openWeatherMapForecast.GetHourlyWeather();
            openWeatherMapConnecionStatus = openWeatherMapForecast.httpStatusCode;
            if (openWeatherMapForecast.httpStatusCode != 200)
            {
                MessageBox.Show($"Failed connection to Open Weather Map API! code {openWeatherMapForecast.httpStatusCode}", $"Error {openWeatherMapForecast.httpStatusCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            currentWeather = ForecastWeadersDaily[0];
            textBoxWeatherTime.Text = currentWeather.DateTime.ToString("dddd, MMMM dd yyyy", culture);
            textBoxWeatherDesc.Text = currentWeather.Description;
            textBoxWeatherTemp.Text = $"Temperature: {currentWeather.Temp}\u00b0 C";
            textBoxWeatherHum.Text = $"Humidity: {currentWeather.Humidity}%";
            textBoxWeatherPress.Text = $"Pressure: {currentWeather.Pressure} hPa";
            textBoxWeatherWind.Text = $"Wind: {currentWeather.WindSpeed} km/h";
            iconNumber = GetImageCode(currentWeather.Icon);
            if (iconNumber != null) pictureBoxCurrentWeather.Image = imageListIcons.Images[(int)iconNumber];
            buttonWeatherDetails.Enabled = true;

            for (int i=1;i<=7; i++)
            {
                Control[] controls=this.Controls.Find($"pictureBoxForecast{i}",true);
                PictureBox pictureBox = (PictureBox)controls[0] ;
                controls = this.Controls.Find($"textBoxForecast{i}main", true);
                TextBox textBoxMain = (TextBox)controls[0];
                controls = this.Controls.Find($"textBoxForecast{i}details", true);
                TextBox textBoxDetails = (TextBox)controls[0];
                pictureBox.Image = imageListIcons.Images[(int)GetImageCode(ForecastWeadersDaily[i].Icon)];
                textBoxMain.Text = ForecastWeadersDaily[i].DateTime.ToString("dddd", culture);
                textBoxMain.Text += $": {ForecastWeadersDaily[i].Main}";
                textBoxDetails.AppendText($"T: {ForecastWeadersDaily[i].Temp.ToString()}\u00b0 C");
                textBoxDetails.AppendText(Environment.NewLine);
                textBoxDetails.AppendText($"W: {Math.Round(ForecastWeadersDaily[i].WindSpeed).ToString()} km/h");
                textBoxDetails.AppendText(Environment.NewLine);
                textBoxDetails.AppendText($"R: {ForecastWeadersDaily[i].Rain} mm");
                textBoxDetails.AppendText(Environment.NewLine);
                textBoxDetails.AppendText($"S: {ForecastWeadersDaily[i].Snow} mm");
            }

            List<double> Temperature = ForecastWeadersHurly.Select(E=>E.Temp).ToList();
            List<double> TemperatureFeels = ForecastWeadersHurly.Select(E => E.Feels_like).ToList();
            List<int> Pressure = ForecastWeadersHurly.Select(E => E.Pressure).ToList();
            List<double> Rain = ForecastWeadersHurly.Select(X => X.Rain).ToList();
            List<double> Snow = ForecastWeadersHurly.Select(X => X.Snow).ToList();
            List<string> Labels = ForecastWeadersHurly.Select(E => E.DateTime.ToString("t")).ToList();

            SeriesCollection TempSeries = new SeriesCollection();
            SeriesCollection PrecipationSeries = new SeriesCollection();

            LineSeries TempSet = new LineSeries() { Title = "Temperature", Values = new ChartValues<double>(Temperature) };
            LineSeries TempFeelsSet = new LineSeries() { Title = "Temperature Feels", Values = new ChartValues<double>(TemperatureFeels) };
            LineSeries PressSet = new LineSeries() { Title = "Humidity", Values = new ChartValues<int>(Pressure) };
            ColumnSeries RainSet = new ColumnSeries() { Title = "Rain", Values = new ChartValues<double>(Rain), };
            ColumnSeries SnowSet = new ColumnSeries() { Title = "Snow", Values = new ChartValues<double>(Snow), };

            TempSet.Stroke = System.Windows.Media.Brushes.Red;
            TempFeelsSet.Stroke = System.Windows.Media.Brushes.Pink;
            PressSet.Stroke = System.Windows.Media.Brushes.Orange;
            RainSet.Stroke = System.Windows.Media.Brushes.Blue;
            SnowSet.Stroke = System.Windows.Media.Brushes.White;

            TempSeries.Add(TempSet);
            TempSeries.Add(TempFeelsSet);
            PrecipationSeries.Add(RainSet);
            PrecipationSeries.Add(SnowSet);

            Axis ayPress = new Axis() { Separator = new Separator() { Step = 20 }};
            Axis axTem = new Axis() { Separator = new Separator() { Step = 4 }, Position = AxisPosition.RightTop, Labels = Labels };
            Axis axPress = new Axis() { Separator = new Separator() { Step = 4 }, Labels = Labels };
            Axis axPrec= new Axis() { Separator = new Separator() { Step = 4 }, Labels = Labels };

            
            cartesianChartTemperature.Series = TempSeries;
            cartesianChartPressure.Series.Add(PressSet);
            cartesianChartRain.Series=PrecipationSeries;

            cartesianChartTemperature.AxisX.Clear();
            cartesianChartPressure.AxisX.Clear();
            cartesianChartRain.AxisX.Clear();
            cartesianChartPressure.AxisY.Clear();

            cartesianChartPressure.AxisY.Add(ayPress);
            cartesianChartPressure.AxisX.Add(axPress);
            cartesianChartTemperature.AxisX.Add(axTem);
            cartesianChartRain.AxisX.Add(axPrec);

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

        private void buttonWeatherDetails_Click(object sender, EventArgs e)
        {
            FormCurrentWeather currentWeatherForm = new FormCurrentWeather(currentWeather, (int)iconNumber);
            currentWeatherForm.Show();
        }

        private void pictureBoxForecast1_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[1], (int)GetImageCode(ForecastWeadersDaily[1].Icon));
                currentWeatherForm.Show();
            }

        }

        private void pictureBoxForecast2_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[2], (int)GetImageCode(ForecastWeadersDaily[2].Icon));
                currentWeatherForm.Show();
            }
        }

        private void pictureBoxForecast3_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[3], (int)GetImageCode(ForecastWeadersDaily[3].Icon));
                currentWeatherForm.Show();
            }
        }

        private void pictureBoxForecast4_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[4], (int)GetImageCode(ForecastWeadersDaily[4].Icon));
                currentWeatherForm.Show();
            }
        }

        private void pictureBoxForecast5_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[5], (int)GetImageCode(ForecastWeadersDaily[5].Icon));
                currentWeatherForm.Show();
            }
        }

        private void pictureBoxForecast6_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[6], (int)GetImageCode(ForecastWeadersDaily[6].Icon));
                currentWeatherForm.Show();
            }
        }

        private void pictureBoxForecast7_Click(object sender, EventArgs e)
        {
            if (openWeatherMapConnecionStatus == 200)
            {
                FormCurrentWeather currentWeatherForm = new FormCurrentWeather(ForecastWeadersDaily[7], (int)GetImageCode(ForecastWeadersDaily[7].Icon));
                currentWeatherForm.Show();
            }
        }

        private void buttonHist_Click(object sender, EventArgs e)
        {
            FormHistoricalWeater formHistoricalWeater = new FormHistoricalWeater();
            formHistoricalWeater.Show();
        }

        private void button_IndorMeasDetails_Click(object sender, EventArgs e)
        {
            FormIndorMeasurements formIndorMeasurements = new FormIndorMeasurements();
            formIndorMeasurements.Show();
        }

    }
}
