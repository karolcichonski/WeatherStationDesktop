using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationDesctop;

namespace WeatherStationDesktop
{
    class Measurements
    {
        public Measurements()
        {
            GetMeasurementsFromDB(queries[0]);
            LastTemp = AllMeasurements[0].Temp;
            LastPress = AllMeasurements[0].Press;
            LastTime = AllMeasurements[0].Time.ToString();
            LastHum = AllMeasurements[0].Hum;
        }
        string[] queries = { $"SELECT * FROM `ESP` ORDER BY Time Desc LIMIT 1" };

        List<SingleMeasure> AllMeasurements = new List<SingleMeasure>();

        DBConnection connection = new DBConnection();
        
        public double LastTemp { get; private set; }
        public int LastPress { get; private set; }
        public string LastTime { get; private set; }
        public double LastHum { get; private set; }



        public ChartsDatas GetChartsDatas(int daysToRead)
        {
            DateTime daysAgo = DateTime.Today.AddDays(-daysToRead+1);
            //DateTime today = DateTime.Today;
            //string query =$"SELECT * FROM `ESP` ORDER BY Time Desc Limit 360";
            //string query = $"SELECT* FROM ESP WHERE Time > CURDATE() ORDER BY Time Desc";
            //string query = $"SELECT* FROM ESP WHERE Time > '2022-01-28' and Time <= '2022-01-29' ";
            string query = $"SELECT* FROM ESP WHERE Time > '{daysAgo.ToString("yyyy-MM-dd")}' and Time <= '{DateTime.Today.ToString("yyyy-MM-dd")} 23:59:59' ";
            GetMeasurementsFromDB(query);
            ChartsDatas OutDatas = new ChartsDatas(AllMeasurements);
            return OutDatas;
        } 

        void GetMeasurementsFromDB(string query)
        {
            
            MySqlConnection DBcon = new MySqlConnection(connection.GetConnectionString());
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

    /*public class ChartData1<T>
    { 
        List<T> InputData = new List<T>();
        List<T> NormalizeData = new List<T>();
        int NumOfOutputRecords { get; set; }

        List<T> GetSimpleList(List<T> InputList)
        {
            List<T> OutList = new List<T>();

            int startNum = 0;

            int numOfItems = InputList.Count / 100;

            for (int i = 1; i <= 100; i++)
            {
                List<T> TMP = InputList.GetRange(startNum, numOfItems);
                double avg = TMP.Sum();
                //OutList.Add(avg);
                startNum += numOfItems;
            }

            OutList.Reverse();
            return OutList;
        }
    }*/
}
