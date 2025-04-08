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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //Display city
            cityOutput.Text = Form1.days[0].location;

            //Forecast for days
            //Day 1
            date1Output.Text = Form1.days[0].date;
            min1Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[0].tempLow), 1)}°";
            max1Output.Text = $"High: {Math.Round(double.Parse(Form1.days[0].tempHigh), 1)}°";
            conditionsText1Output.Text = Form1.days[0].condition;

            //Day 2
            date2Output.Text = Form1.days[1].date;
            min2Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[1].tempLow), 1)}°";
            max2Output.Text = $"High: {Math.Round(double.Parse(Form1.days[1].tempHigh), 1)}°";
            conditionsText2Output.Text = Form1.days[1].condition;

            //Day 3
            date3Output.Text = Form1.days[2].date;
            min3Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[2].tempLow), 1)}°";
            max3Output.Text = $"High: {Math.Round(double.Parse(Form1.days[2].tempHigh), 1)}°";
            conditionsText3Output.Text = Form1.days[2].condition;

            //Day 4
            date4Output.Text = Form1.days[3].date;
            min4Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[3].tempLow), 1)}°";
            max4Output.Text = $"High: {Math.Round(double.Parse(Form1.days[3].tempHigh), 1)}°";
            conditionsText4Output.Text = Form1.days[3].condition;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
