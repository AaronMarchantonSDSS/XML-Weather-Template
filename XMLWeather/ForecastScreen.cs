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

            //Display condition icon
            if (Form1.days[0].conditionNumber >= 200 && Form1.days[0].conditionNumber <= 232)
            {
                conditions1Output.Image = Properties.Resources.Storm130;
            }
            else if (Form1.days[0].conditionNumber >= 300 && Form1.days[0].conditionNumber <= 531)
            {
                conditions1Output.Image = Properties.Resources.Rain130;
            }
            else if (Form1.days[0].conditionNumber >= 600 && Form1.days[0].conditionNumber <= 622)
            {
                conditions1Output.Image = Properties.Resources.Snow130;
            }
            else if (Form1.days[0].conditionNumber >= 701 && Form1.days[0].conditionNumber <= 781)
            {
                conditions1Output.Image = Properties.Resources.Wind130;
            }
            else if (Form1.days[0].conditionNumber == 800)
            {
                conditions1Output.Image = Properties.Resources.Sun130;
            }
            else if (Form1.days[0].conditionNumber >= 801 && Form1.days[0].conditionNumber <= 804)
            {
                conditions1Output.Image = Properties.Resources.Cloud130;
            }

            //Day 2
            date2Output.Text = Form1.days[1].date;
            min2Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[1].tempLow), 1)}°";
            max2Output.Text = $"High: {Math.Round(double.Parse(Form1.days[1].tempHigh), 1)}°";
            conditionsText2Output.Text = Form1.days[1].condition;

            //Display condition icon
            if (Form1.days[1].conditionNumber >= 200 && Form1.days[0].conditionNumber <= 232)
            {
                conditions2Output.Image = Properties.Resources.Storm130;
            }
            else if (Form1.days[1].conditionNumber >= 300 && Form1.days[0].conditionNumber <= 531)
            {
                conditions2Output.Image = Properties.Resources.Rain130;
            }
            else if (Form1.days[1].conditionNumber >= 600 && Form1.days[0].conditionNumber <= 622)
            {
                conditions2Output.Image = Properties.Resources.Snow130;
            }
            else if (Form1.days[1].conditionNumber >= 701 && Form1.days[0].conditionNumber <= 781)
            {
                conditions2Output.Image = Properties.Resources.Wind130;
            }
            else if (Form1.days[1].conditionNumber == 800)
            {
                conditions2Output.Image = Properties.Resources.Sun130;
            }
            else if (Form1.days[1].conditionNumber >= 801 && Form1.days[0].conditionNumber <= 804)
            {
                conditions2Output.Image = Properties.Resources.Cloud130;
            }

            //Day 3
            date3Output.Text = Form1.days[2].date;
            min3Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[2].tempLow), 1)}°";
            max3Output.Text = $"High: {Math.Round(double.Parse(Form1.days[2].tempHigh), 1)}°";
            conditionsText3Output.Text = Form1.days[2].condition;

            //Display condition icon
            if (Form1.days[2].conditionNumber >= 200 && Form1.days[2].conditionNumber <= 232)
            {
                conditions3Output.Image = Properties.Resources.Storm130;
            }
            else if (Form1.days[2].conditionNumber >= 300 && Form1.days[2].conditionNumber <= 531)
            {
                conditions3Output.Image = Properties.Resources.Rain130;
            }
            else if (Form1.days[2].conditionNumber >= 600 && Form1.days[2].conditionNumber <= 622)
            {
                conditions3Output.Image = Properties.Resources.Snow130;
            }
            else if (Form1.days[2].conditionNumber >= 701 && Form1.days[2].conditionNumber <= 781)
            {
                conditions3Output.Image = Properties.Resources.Wind130;
            }
            else if (Form1.days[2].conditionNumber == 800)
            {
                conditions3Output.Image = Properties.Resources.Sun130;
            }
            else if (Form1.days[2].conditionNumber >= 801 && Form1.days[2].conditionNumber <= 804)
            {
                conditions3Output.Image = Properties.Resources.Cloud130;
            }

            //Day 4
            date4Output.Text = Form1.days[3].date;
            min4Output.Text = $"Low: {Math.Round(double.Parse(Form1.days[3].tempLow), 1)}°";
            max4Output.Text = $"High: {Math.Round(double.Parse(Form1.days[3].tempHigh), 1)}°";
            conditionsText4Output.Text = Form1.days[3].condition;

            //Display condition icon
            if (Form1.days[3].conditionNumber >= 200 && Form1.days[3].conditionNumber <= 232)
            {
                conditions4Output.Image = Properties.Resources.Storm130;
            }
            else if (Form1.days[3].conditionNumber >= 300 && Form1.days[3].conditionNumber <= 531)
            {
                conditions4Output.Image = Properties.Resources.Rain130;
            }
            else if (Form1.days[3].conditionNumber >= 600 && Form1.days[3].conditionNumber <= 622)
            {
                conditions4Output.Image = Properties.Resources.Snow130;
            }
            else if (Form1.days[3].conditionNumber >= 701 && Form1.days[3].conditionNumber <= 781)
            {
                conditions4Output.Image = Properties.Resources.Wind130;
            }
            else if (Form1.days[3].conditionNumber == 800)
            {
                conditions4Output.Image = Properties.Resources.Sun130;
            }
            else if (Form1.days[3].conditionNumber >= 801 && Form1.days[3].conditionNumber <= 804)
            {
                conditions4Output.Image = Properties.Resources.Cloud130;
            }
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            //Switches Screen to current Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
