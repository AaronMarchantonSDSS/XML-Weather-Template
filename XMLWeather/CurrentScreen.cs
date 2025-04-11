using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //Display date 
            dateOutput.Text = DateTime.Now.ToString("dddd MMMM, d");

            //Display location
            cityOutput.Text = Form1.days[0].location;

            //Display temperature
            currentTempOutput.Text = $"{Math.Round(double.Parse(Form1.days[0].currentTemp), 1)}°";
            minOutput.Text = $"{Math.Round(double.Parse(Form1.days[0].tempLow), 1)}°";
            maxOutput.Text = $"{Math.Round(double.Parse(Form1.days[0].tempHigh), 1)}°";

            //Display the conditions
            conditionsTextOutput.Text = Form1.days[0].condition;

            //Display condition icon
            if (Form1.days[0].conditionNumber >= 200 && Form1.days[0].conditionNumber <= 232)
            {
                conditionsOutput.Image = Properties.Resources.Storm250;
            }
            else if (Form1.days[0].conditionNumber >= 300 && Form1.days[0].conditionNumber <= 531)
            {
                conditionsOutput.Image = Properties.Resources.Rain250;
            }
            else if (Form1.days[0].conditionNumber >= 600 && Form1.days[0].conditionNumber <= 622)
            {
                conditionsOutput.Image = Properties.Resources.Snow250;
            }
            else if (Form1.days[0].conditionNumber >= 701 && Form1.days[0].conditionNumber <= 781)
            {
                conditionsOutput.Image = Properties.Resources.Wind250;
            }
            else if (Form1.days[0].conditionNumber == 800)
            {
                conditionsOutput.Image = Properties.Resources.Sun250;
            }
            else if (Form1.days[0].conditionNumber >= 801 && Form1.days[0].conditionNumber <= 804)
            {
                conditionsOutput.Image = Properties.Resources.Cloud250;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //Change screen to forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void citySearchButton_Click(object sender, EventArgs e)
        {
            //Change the city
            try
            {
                string newCity = citySearchBox.Text;
                Form1.currentCity = newCity;

                Form1.days.Clear();
                Form1 f = (Form1)this.FindForm();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                f.Controls.Clear();
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch
            {
                citySearchBox.Text = "ERROR";
            }

            //Change the country
            try
            {
                string newCountry = countrySearchBox.Text;
                Form1.currentCountry = newCountry;

                Form1.days.Clear();
                Form1 f = (Form1)this.FindForm();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                f.Controls.Clear();
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch
            {
                countrySearchBox.Text = "ERROR";
            }
        }

        private void citySearchBox_Click(object sender, EventArgs e)
        {
            //When typing textbox goes back to normal
            citySearchBox.Text = "";
            citySearchBox.ForeColor = Color.Black;
        }

        private void countrySearchBox_Click(object sender, EventArgs e)
        {
            //When typing textbox goes back to normal
            countrySearchBox.Text = "";
            countrySearchBox.ForeColor = Color.Black;
        }
    }
}