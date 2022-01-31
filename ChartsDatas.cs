using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationDesktop;

namespace WeatherStationDesctop
{
    class ChartsDatas
    {
        public ChartsDatas(List<SingleMeasure> AllData)
        {
            InputData = AllData;
            //InputData.Reverse();
            Times = new List<DateTime>();
            TimesLabels = new List<string>();
            Pressure = new List<double>();
            Temperature = new List<double>();
            Humidity = new List<double>();
            GetSimpleListByTime(CalculateDelay());
        }

        public List<DateTime> Times { get; set; }
        public List<String> TimesLabels { get; set; }
        public List<double> Pressure { get; set; } 
        public List<double> Temperature { get; set; }
        public List<double> Humidity { get; set; }

        List<SingleMeasure> InputData;

        int NumOfOutputRecords { get; set; }

        void GetSimpleList()
        {

            int startNum = 0;

            int numOfItems = InputData.Count / 144;

            for (int i = 1; i <= 144; i++)
            {
                List<SingleMeasure> TMP = InputData.GetRange(startNum, numOfItems);
                double avgPress = TMP.Average(X=> X.Press);
                double avgTemp = TMP.Average(X=> X.Temp);
                double avgHum = TMP.Average(X=>X.Hum);
                Pressure.Add(avgPress);
                Temperature.Add(avgTemp);
                Humidity.Add(avgHum);
                Times.Add(TMP[0].Time);
                startNum += numOfItems;
            }
        }

        void GetSimpleListByTime(int intervalInMin)
        {
            DateTime StartTime = InputData[0].Time.Date;
            DateTime IntervalTime= InputData[0].Time.Date.AddMinutes(intervalInMin);
            DateTime EndTime = InputData[InputData.Count-1].Time;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            while (IntervalTime < EndTime)
            {
                IEnumerable<SingleMeasure> TMP = InputData.Where(X=>X.Time>StartTime & X.Time<IntervalTime);
                string label = StartTime.ToString("t");
                if (StartTime.ToString("t") == "00:00") label += $" {StartTime.ToString("ddd", culture)}";
                Times.Add(StartTime);
                TimesLabels.Add(label);

                if (TMP.Count() > 0)
                {
                    Pressure.Add(TMP.Average(X=>X.Press));
                    Temperature.Add(TMP.Average(X => X.Temp));
                    Humidity.Add(TMP.Average(X => X.Hum));
                }
                else
                {
                    Pressure.Add(0);
                    Temperature.Add(0);
                    Humidity.Add(0);
                }

                StartTime=StartTime.AddMinutes(intervalInMin);
                IntervalTime=IntervalTime.AddMinutes(intervalInMin);
            }
        }

        int CalculateDelay()
        {
            double totalDays = (InputData[InputData.Count - 1].Time - InputData[0].Time).TotalDays;
            if (totalDays <= 1)
            {
                return 10;
            }else if(totalDays>1 & totalDays<=3)
            {
                return 30;
            }
            else
            {
                return 60;
            }

        }
    }
}
