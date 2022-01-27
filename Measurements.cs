using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationDesktop
{
    class Measurements
    {
        public Measurements()
        {
            List<SingleMeasure> LastMes = GetMeasurementsFromDB(1);
            LastTemp = LastMes[0].Temp;
            LastPress = LastMes[0].Press;
            LastTime = LastMes[0].Time.ToString();
        }

        DBConnection connection = new DBConnection();
        public double LastTemp { get; private set; }
        public int LastPress { get; private set; }
        public string LastTime { get; private set; }


        public List<SingleMeasure> GetMeasurementsFromDB(int limit)
        {
            List<SingleMeasure> AllMeasurements = new List<SingleMeasure>();
            MySqlConnection DBcon = new MySqlConnection(connection.GetConnectionString());
            DBcon.Open();
            MySqlCommand SQLcommand = new MySqlCommand($"SELECT * FROM `ESP` ORDER BY Time Desc LIMIT {limit}", DBcon);
            MySqlDataReader output = SQLcommand.ExecuteReader();
            
            while (output.Read())
            {
                SingleMeasure meas = new SingleMeasure();
                meas.SetPress(output.GetString(0));
                meas.SetTemp(output.GetString(1));
                meas.SetTime(output.GetString(3));
                AllMeasurements.Add(meas);
            }

            return AllMeasurements;
        }
    }



    class SingleMeasure
    {
        public string Time { get; private set; }
        public double Temp { get; private set; }
        public int Press { get; private set; }

        public void SetTemp(string input)
        {
            double tmp;
            double.TryParse(input, out tmp);
            Temp = tmp;
        }


        public void SetPress(string input)
        {
            int tmp;
            Int32.TryParse(input, out tmp);
            Press = tmp;
        }

        public void SetTime(string input)
        {
            Time = input;
        }
    }

    public class ChartData <T>
    {
        List<T> InputData = new List<T>();
        int NumOfOutputRecords { get; set; }
    }
}
