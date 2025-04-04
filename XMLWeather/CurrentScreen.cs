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
            //Display date and time
            int currentMin = DateTime.Now.Minute;
            int currentHour = DateTime.Now.Hour;
            dateOutput.Text = $"{DateTime.Now.ToString("dddd MMMM, d")}, {currentHour}:{currentMin}";

            //Display location
            cityOutput.Text = Form1.days[0].location;

            //Display temperature
            currentTempOutput.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;

            //Display the conditions
            conditionsTextOutput.Text = Form1.days[0].condition;
            conditionsOutput.Image = 
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
