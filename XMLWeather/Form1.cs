//Aaron Marchanton
//11 April, 2025
//Weather App

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //Create list to hold day objects
        public static List<Day> days = new List<Day>();

        //Create strings to hold location information
        public static string currentLocation;

        public static string currentCity = "Stratford";
        public static string currentCountry = "CA";

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            //Open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //Create a day object
                Day d = new Day();

                //Find time element and get day attribute
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                //find symbol element and get the condition attribute
                reader.ReadToFollowing("symbol");
                d.conditionNumber = Convert.ToInt16(reader.GetAttribute("number"));
                d.condition = reader.GetAttribute("name");

                //find temperature element and get the min and max attribute
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                //Add day to list of days
                days.Add(d);
            }
        }

        public static void ExtractCurrent()
        {
            //Current info is not included in forecast file so we need to use this file to get it
            currentLocation = $"{currentCity}, {currentCountry}";
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={currentLocation}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //Find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionNumber = Convert.ToInt16(reader.GetAttribute("number"));
            days[0].condition = reader.GetAttribute("value");
        }
    }
}
