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
            this.minLabel = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.conditionsOutput = new System.Windows.Forms.Label();
            this.conditionsTextOutput = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(117, 335);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(113, 13);
            this.minOutput.TabIndex = 32;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(21, 335);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 31;
            this.minLabel.Text = "min";
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(117, 312);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(113, 13);
            this.currentTempOutput.TabIndex = 30;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(21, 312);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(40, 13);
            this.currentLabel.TabIndex = 29;
            this.currentLabel.Text = "current";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(21, 14);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(83, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(141, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(117, 358);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(113, 13);
            this.maxOutput.TabIndex = 44;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(21, 358);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 43;
            this.maxLabel.Text = "max";
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(117, 90);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(113, 13);
            this.dateOutput.TabIndex = 47;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(21, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 45;
            this.dateLabel.Text = "Date";
            // 
            // conditionsOutput
            // 
            this.conditionsOutput.BackColor = System.Drawing.Color.White;
            this.conditionsOutput.Location = new System.Drawing.Point(69, 162);
            this.conditionsOutput.Name = "conditionsOutput";
            this.conditionsOutput.Size = new System.Drawing.Size(113, 96);
            this.conditionsOutput.TabIndex = 49;
            this.conditionsOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionsTextOutput
            // 
            this.conditionsTextOutput.ForeColor = System.Drawing.Color.White;
            this.conditionsTextOutput.Location = new System.Drawing.Point(62, 267);
            this.conditionsTextOutput.Name = "conditionsTextOutput";
            this.conditionsTextOutput.Size = new System.Drawing.Size(126, 16);
            this.conditionsTextOutput.TabIndex = 48;
            this.conditionsTextOutput.Text = "Conditions";
            this.conditionsTextOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(60, 122);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(130, 28);
            this.cityOutput.TabIndex = 51;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.conditionsOutput);
            this.Controls.Add(this.conditionsTextOutput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label conditionsOutput;
        private System.Windows.Forms.Label conditionsTextOutput;
        private System.Windows.Forms.Label cityOutput;
    }
}
