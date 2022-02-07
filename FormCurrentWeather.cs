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
using WeatherStationDesktop;

namespace WeatherStationDesctop
{
    public partial class FormCurrentWeather : Form
    {
        public FormCurrentWeather(OneDayWeather weather, int icon)
        {
            InitializeComponent();

            pictureBoxCurrentWeather.Image = imageListIcons.Images[icon];
            textBoxLocation.Text = weather.Name;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            textBoxTime.Text = weather.DateTime.ToString("dddd, MMMM dd yyyy", culture);
            textBoxWeatherDesc.Text = weather.Main + ": " + weather.Description;
            textBoxSunrise.Text = $"Sunrise: {weather.Sunrise.ToString("t")}";
            textBoxSunset.Text = $"Sunset: {weather.Sunset.ToString("t")}";
            textBoxTemp.Text = weather.Temp.ToString() + "\u00b0 C";
            textBoxTempFeels.Text = weather.Feels_like.ToString() + "\u00b0 C";
            textBoxTempMin.Text = weather.Temp_min.ToString() + "\u00b0 C";
            textBoxTempMax.Text = weather.Temp_max.ToString() + "\u00b0 C";
            textBoxWindSpeed.Text = (weather.WindSpeed).ToString() + "km/h";
            textBoxWindGust.Text = (weather.WindGust).ToString() + "km/h";
            textBoxWindDeg.Text = weather.WindDeg.ToString() + "\u00b0 C";
            textBoxPress.Text = weather.Pressure.ToString()+"hPa";
            textBoxHum.Text = weather.Humidity.ToString()+"%";
            textBoxVis.Text = weather.Visibility.ToString() + "m";
            textBoxClouds.Text = weather.CloudAll.ToString()+"%";



            //pictureBoxCurrentWeather.Image.
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
