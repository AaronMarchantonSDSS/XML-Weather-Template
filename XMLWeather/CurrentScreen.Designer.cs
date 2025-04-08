namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minOutput = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.conditionsOutput = new System.Windows.Forms.Label();
            this.conditionsTextOutput = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.Location = new System.Drawing.Point(634, 180);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(150, 100);
            this.minOutput.TabIndex = 32;
            this.minOutput.Text = "3";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.Location = new System.Drawing.Point(260, 180);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(150, 100);
            this.currentTempOutput.TabIndex = 30;
            this.currentTempOutput.Text = "1";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.Black;
            this.todayLabel.Location = new System.Drawing.Point(625, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(83, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DimGray;
            this.forecastLabel.Location = new System.Drawing.Point(714, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "4 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(447, 180);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(150, 100);
            this.maxOutput.TabIndex = 44;
            this.maxOutput.Text = "2";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.Location = new System.Drawing.Point(47, 81);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(165, 22);
            this.dateOutput.TabIndex = 47;
            this.dateOutput.Text = "Date";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionsOutput
            // 
            this.conditionsOutput.BackColor = System.Drawing.Color.White;
            this.conditionsOutput.Location = new System.Drawing.Point(30, 110);
            this.conditionsOutput.Name = "conditionsOutput";
            this.conditionsOutput.Size = new System.Drawing.Size(200, 200);
            this.conditionsOutput.TabIndex = 49;
            this.conditionsOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionsTextOutput
            // 
            this.conditionsTextOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionsTextOutput.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsTextOutput.ForeColor = System.Drawing.Color.Black;
            this.conditionsTextOutput.Location = new System.Drawing.Point(47, 310);
            this.conditionsTextOutput.Name = "conditionsTextOutput";
            this.conditionsTextOutput.Size = new System.Drawing.Size(165, 33);
            this.conditionsTextOutput.TabIndex = 48;
            this.conditionsTextOutput.Text = "Conditions";
            this.conditionsTextOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cityOutput.Location = new System.Drawing.Point(3, 31);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(257, 50);
            this.cityOutput.TabIndex = 51;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 52;
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.Black;
            this.currentLabel.Location = new System.Drawing.Point(285, 151);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(102, 29);
            this.currentLabel.TabIndex = 53;
            this.currentLabel.Text = "Current";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Black;
            this.maxLabel.Location = new System.Drawing.Point(452, 151);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(119, 29);
            this.maxLabel.TabIndex = 54;
            this.maxLabel.Text = "Daily High";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Black;
            this.minLabel.Location = new System.Drawing.Point(650, 151);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(118, 29);
            this.minLabel.TabIndex = 56;
            this.minLabel.Text = "Daily Low";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(414, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 57;
            this.label1.Text = "Temperatures";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Backdrop;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.conditionsOutput);
            this.Controls.Add(this.conditionsTextOutput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentTempOutput);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(800, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label conditionsOutput;
        private System.Windows.Forms.Label conditionsTextOutput;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label1;
    }
}
