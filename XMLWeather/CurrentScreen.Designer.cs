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
            this.conditionsTextOutput = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.citySearchBox = new System.Windows.Forms.TextBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionsOutput = new System.Windows.Forms.PictureBox();
            this.citySearchButton = new System.Windows.Forms.Button();
            this.countrySearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.Location = new System.Drawing.Point(817, 222);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(250, 123);
            this.minOutput.TabIndex = 32;
            this.minOutput.Text = "3";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.Location = new System.Drawing.Point(325, 222);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(250, 123);
            this.currentTempOutput.TabIndex = 30;
            this.currentTempOutput.Text = "1";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.Black;
            this.todayLabel.Location = new System.Drawing.Point(833, 0);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(111, 34);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DimGray;
            this.forecastLabel.Location = new System.Drawing.Point(952, 0);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(111, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "4 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(559, 222);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(250, 123);
            this.maxOutput.TabIndex = 44;
            this.maxOutput.Text = "2";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.Location = new System.Drawing.Point(19, 100);
            this.dateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(309, 27);
            this.dateOutput.TabIndex = 47;
            this.dateOutput.Text = "Date";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionsTextOutput
            // 
            this.conditionsTextOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionsTextOutput.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsTextOutput.ForeColor = System.Drawing.Color.Black;
            this.conditionsTextOutput.Location = new System.Drawing.Point(63, 382);
            this.conditionsTextOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionsTextOutput.Name = "conditionsTextOutput";
            this.conditionsTextOutput.Size = new System.Drawing.Size(220, 41);
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
            this.cityOutput.Location = new System.Drawing.Point(4, 38);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(343, 62);
            this.cityOutput.TabIndex = 51;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // citySearchBox
            // 
            this.citySearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citySearchBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citySearchBox.ForeColor = System.Drawing.Color.Gray;
            this.citySearchBox.Location = new System.Drawing.Point(591, 434);
            this.citySearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.citySearchBox.Name = "citySearchBox";
            this.citySearchBox.Size = new System.Drawing.Size(207, 25);
            this.citySearchBox.TabIndex = 52;
            this.citySearchBox.Text = "Stratford";
            this.citySearchBox.Click += new System.EventHandler(this.citySearchBox_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.Black;
            this.currentLabel.Location = new System.Drawing.Point(380, 186);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(136, 36);
            this.currentLabel.TabIndex = 53;
            this.currentLabel.Text = "Current";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Black;
            this.maxLabel.Location = new System.Drawing.Point(603, 186);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(159, 36);
            this.maxLabel.TabIndex = 54;
            this.maxLabel.Text = "Daily High";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Black;
            this.minLabel.Location = new System.Drawing.Point(867, 186);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(157, 36);
            this.minLabel.TabIndex = 56;
            this.minLabel.Text = "Daily Low";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(552, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 47);
            this.label1.TabIndex = 57;
            this.label1.Text = "Temperatures";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionsOutput
            // 
            this.conditionsOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionsOutput.Location = new System.Drawing.Point(46, 130);
            this.conditionsOutput.Name = "conditionsOutput";
            this.conditionsOutput.Size = new System.Drawing.Size(250, 250);
            this.conditionsOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conditionsOutput.TabIndex = 58;
            this.conditionsOutput.TabStop = false;
            // 
            // citySearchButton
            // 
            this.citySearchButton.BackColor = System.Drawing.Color.Transparent;
            this.citySearchButton.FlatAppearance.BorderSize = 4;
            this.citySearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citySearchButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citySearchButton.ForeColor = System.Drawing.Color.Black;
            this.citySearchButton.Location = new System.Drawing.Point(895, 427);
            this.citySearchButton.Name = "citySearchButton";
            this.citySearchButton.Size = new System.Drawing.Size(129, 39);
            this.citySearchButton.TabIndex = 59;
            this.citySearchButton.Text = "Search";
            this.citySearchButton.UseVisualStyleBackColor = false;
            this.citySearchButton.Click += new System.EventHandler(this.citySearchButton_Click);
            // 
            // countrySearchBox
            // 
            this.countrySearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countrySearchBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countrySearchBox.ForeColor = System.Drawing.Color.Gray;
            this.countrySearchBox.Location = new System.Drawing.Point(806, 434);
            this.countrySearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.countrySearchBox.Name = "countrySearchBox";
            this.countrySearchBox.Size = new System.Drawing.Size(82, 25);
            this.countrySearchBox.TabIndex = 60;
            this.countrySearchBox.Text = "CA";
            this.countrySearchBox.Click += new System.EventHandler(this.countrySearchBox_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Backdrop;
            this.Controls.Add(this.countrySearchBox);
            this.Controls.Add(this.citySearchButton);
            this.Controls.Add(this.conditionsOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.citySearchBox);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.conditionsTextOutput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentTempOutput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(1067, 492);
            ((System.ComponentModel.ISupportInitialize)(this.conditionsOutput)).EndInit();
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
        private System.Windows.Forms.Label conditionsTextOutput;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.TextBox citySearchBox;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox conditionsOutput;
        private System.Windows.Forms.Button citySearchButton;
        private System.Windows.Forms.TextBox countrySearchBox;
    }
}
