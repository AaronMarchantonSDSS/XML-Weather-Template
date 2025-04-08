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
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        } 
    }
}
