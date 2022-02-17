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

namespace WeatherStationDesctop
{
    public partial class FormHistoricalWeater : Form
    {
        public FormHistoricalWeater()
        {
            InitializeComponent();
            GetWeatherData();
        }

        OpenWeatherMapHistorical openWeatherMapHistorical;

        async Task GetWeatherData()
        {
            openWeatherMapHistorical = new OpenWeatherMapHistorical();
            await openWeatherMapHistorical.GenerateWeatherObject();
            UpdateData(trackBarRange.Value);
        }

        async Task UpdateData(int range)
        {
            DateTime lowerDate = DateTime.Now.AddDays(-range);
            List<OneDayWeather> oneHourWeathers = openWeatherMapHistorical.GetHourlyWeather();
            List<double> Temperature = oneHourWeathers.Where(x=>x.DateTime.Date>=lowerDate.Date).Select(X => X.Temp).ToList();
            List<double> TemperatureFeels = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.Feels_like).ToList();
            List<int> Pressure = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.Pressure).ToList();
            List<double> Humidity = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.Humidity).ToList();
            List<double> Wind = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.WindSpeed).ToList();
            List<double> Snow = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.Snow).ToList();
            List<double> Rain = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.Rain).ToList();

            List<string> TimeLabels;
            if (range > 1)
            {
                TimeLabels = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.DateTime.ToString("d")).ToList();
            }
            else
            {
                TimeLabels = oneHourWeathers.Where(x => x.DateTime.Date >= lowerDate.Date).Select(X => X.DateTime.ToString("t")).ToList();
            }
            

            SeriesCollection TempSeries = new SeriesCollection();
            LineSeries TempSet = new LineSeries() { Title = "Temperature", Values = new ChartValues<double>(Temperature), };
            LineSeries TempFeelsSet = new LineSeries() { Title = "Feels Like", Values = new ChartValues<double>(TemperatureFeels), };
            LineSeries PresSet = new LineSeries() { Title = "Pressure", Values = new ChartValues<int>(Pressure), };
            LineSeries HumSet = new LineSeries() { Title = "Humidity", Values = new ChartValues<double>(Humidity), };
            LineSeries WindSet = new LineSeries() { Title = "Wind speed", Values = new ChartValues<double>(Wind), };
            ColumnSeries RainSet = new ColumnSeries() { Title = "Rain", Values = new ChartValues<double>(Rain), };
            ColumnSeries SnowSet = new ColumnSeries() { Title = "Snow", Values = new ChartValues<double>(Snow), };

            TempSet.Stroke = System.Windows.Media.Brushes.Red;
            TempFeelsSet.Stroke = System.Windows.Media.Brushes.Pink;
            PresSet.Stroke = System.Windows.Media.Brushes.Orange;
            WindSet.Stroke = System.Windows.Media.Brushes.Green;
            //HumSet.Stroke = System.Windows.Media.Brushes.Orange;

            TempSeries.Add(TempSet);
            TempSeries.Add(TempFeelsSet);
            TempSeries.Add(SnowSet);
            TempSeries.Add(RainSet);

            cartesianChartHistTemperature.Series.Clear();
            cartesianChartHistPress.Series.Clear();
            cartesianChartHistWind.Series.Clear();
            cartesianChartHistHumidity.Series.Clear();

            cartesianChartHistTemperature.Series = TempSeries;
            cartesianChartHistPress.Series.Add(PresSet);
            cartesianChartHistWind.Series.Add(WindSet);
            cartesianChartHistHumidity.Series.Add(HumSet);

            Axis axWind = new Axis() {Labels=TimeLabels, Separator = new Separator() { Step = 6*range } };
            Axis axTemp = new Axis() { Labels = TimeLabels, Separator = new Separator() { Step = 6 * range } };
            Axis axPress = new Axis() { Labels = TimeLabels, Separator = new Separator() { Step = 6 * range } };
            Axis axHum = new Axis() { Labels = TimeLabels, Separator = new Separator() { Step = 6 * range } };

            cartesianChartHistWind.AxisX.Clear();
            cartesianChartHistPress.AxisX.Clear();
            cartesianChartHistTemperature.AxisX.Clear();
            cartesianChartHistHumidity.AxisX.Clear();

            cartesianChartHistWind.AxisX.Add(axWind);
            cartesianChartHistPress.AxisX.Add(axPress);
            cartesianChartHistTemperature.AxisX.Add(axTemp);
            cartesianChartHistHumidity.AxisX.Add(axHum);

        }

        private void trackBarRange_ValueChanged(object sender, EventArgs e)
        {
            UpdateData(trackBarRange.Value);
            //MessageBox.Show(trackBarRange.Value.ToString());
        }
    }
}
