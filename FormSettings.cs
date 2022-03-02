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
using WeatherStationDesktop;

namespace WeatherStation
{
    public partial class FormSettings : Form
    {
        readonly FormMain mainForm;
        readonly List<City> cities;
        public FormSettings(FormMain formMain)
        {
            InitializeComponent();
            textBoxLatitude.Text = Properties.Settings.Default.latitude.ToString();
            textBoxLongitude.Text = Properties.Settings.Default.longitude.ToString();
            mainForm = formMain;
            cities = new List<City>();
            cities= CitiesInPoland.GetCitiesList();
            UpdateProvinceComboBox();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBoxLatitude.Text,out double latitude) & double.TryParse(textBoxLongitude.Text, out double longitude))
            {
                Properties.Settings.Default.latitude = latitude;
                Properties.Settings.Default.longitude = longitude;
                Properties.Settings.Default.Save();
                mainForm.UpdateWeatherForecast();
                this.Close();

            }
            else
            {
                MessageBox.Show("Value is not a proper number! ");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProvices_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> citiesStr = cities.Where(x => x.Province == comboBoxProvices.Text).Select(y => y.Name).ToList();
            comboBoxCities.Items.Clear();
            foreach (string cit in citiesStr)
            {
                comboBoxCities.Items.Add(cit);
            }
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            City SelectedCity = cities.Find(x => x.Name == comboBoxCities.Text);
            textBoxLatitude.Text = SelectedCity.Latitude.ToString();
            textBoxLongitude.Text = SelectedCity.Longitude.ToString();
        }

        private void UpdateProvinceComboBox()
        {
            List <string> provinces= cities.Select(e => e.Province).Distinct().ToList();
            comboBoxProvices.Items.Clear();
            foreach(string prov in provinces)
            {
                comboBoxProvices.Items.Add(prov);
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                List<City> searchedCities = cities.Where(x => x.Name.Trim().ToLower().StartsWith(textBoxSearch.Text.ToLower())).ToList();
                treeViewResults.Nodes.Clear();
                foreach (City city in searchedCities)
                {
                    treeViewResults.Nodes.Add(city.Name);
                    treeViewResults.Nodes[treeViewResults.Nodes.Count - 1].Tag = city;
                }
            }
            else
            {
                treeViewResults.Nodes.Clear();
            }
        }

        private void treeViewResults_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            City city = (City)treeViewResults.SelectedNode.Tag;
            textBoxLatitude.Text = city.Latitude.ToString();
            textBoxLongitude.Text = city.Longitude.ToString();
        }
    }
}
