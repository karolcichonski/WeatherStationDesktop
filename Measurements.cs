using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation;

namespace WeatherStationDesktop
{
    class Measurements
    {
        public Measurements()
        {
            if (GetMeasurementsFromDB(query))
            {
                LastTemp = AllMeasurements[0].TempDS;
                LastPress = AllMeasurements[0].Press;
                LastTime = AllMeasurements[0].Time.ToString();
                LastHum = AllMeasurements[0].Hum;
                ConnectionStatus = true;
            }
        }
        readonly string query = "SELECT * FROM `ESP` ORDER BY Time Desc LIMIT 1";

        readonly List<SingleMeasure> AllMeasurements = new List<SingleMeasure>();
        public List<Exception> Exceptions { get; private set; } = new List<Exception>();
        
        public double LastTemp { get; private set; }
        public int LastPress { get; private set; }
        public string LastTime { get; private set; }
        public double LastHum { get; private set; }
        public bool ConnectionStatus { get; private set; }


        public ChartsDatas GetChartsDatas(int daysToRead)
        {
            DateTime daysAgo = DateTime.Today.AddDays(-daysToRead+1);
            string query = $"SELECT* FROM ESP WHERE Time > '{daysAgo.ToString("yyyy-MM-dd")}' and Time <= '{DateTime.Today.ToString("yyyy-MM-dd")} 23:59:59' ";
            ConnectionStatus=GetMeasurementsFromDB(query);
            ChartsDatas OutDatas = new ChartsDatas(AllMeasurements);
            return OutDatas;
        } 

        bool GetMeasurementsFromDB(string query)
        {
            try
            {
                using (MySqlConnection DBcon = new MySqlConnection(DBConnection.GetConnectionString()))
                {

                    DBcon.Open();
                    MySqlCommand SQLcommand = new MySqlCommand(query, DBcon);
                    MySqlDataReader output = SQLcommand.ExecuteReader();
                    AllMeasurements.Clear();
                    while (output.Read())
                    {
                        SingleMeasure meas = new SingleMeasure();
                        meas.SetPress(output.GetInt32(0));
                        meas.SetTemp(output.GetDouble(1));
                        meas.SetHum(output.GetDouble(2));
                        meas.SetTime(output.GetDateTime(3));
                        meas.SetTempDH(output.GetDouble(4));
                        meas.SetTempDS(output.GetDouble(5));

                        AllMeasurements.Add(meas);
                    }

                    DBcon.Close();
                    return true;

                }
            }
            catch(Exception Exception)
            {
                Exceptions.Add(Exception);
                return false;
            }
        }


    }



    class SingleMeasure
    {
        public DateTime Time { get; private set; }
        public double TempDH { get; private set; }
        public double TempDS { get; private set; }
        public double Temp { get; private set; }
        public int Press { get; private set; }
        public double Hum { get; private set; }

        public void SetTemp(Double input)
        {
            Temp = input;
        }

        public void SetTempDH(Double input)
        {
            TempDH = input;
        }

        public void SetTempDS(Double input)
        {
            TempDS = input;
        }
        public void SetHum(double input)
        {
            Hum = input;
        }

        public void SetPress(int input)
        {
            Press = input;
        }

        public void SetTime(DateTime input)
        {
            Time = input;
        }

    }
}
