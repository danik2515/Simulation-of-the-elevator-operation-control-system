namespace WindowsForms {
    partial class InformationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TripsNumLable = new System.Windows.Forms.Label();
            this.IdleTripsLable = new System.Windows.Forms.Label();
            this.NumOfTransportedPeopleLable = new System.Windows.Forms.Label();
            this.AverageWaitingTImeLable = new System.Windows.Forms.Label();
            this.LongestWaitingTimeLable = new System.Windows.Forms.Label();
            this.CumulativeWaitingTimeLable = new System.Windows.Forms.Label();
            this.FireAlarmsNumLable = new System.Windows.Forms.Label();
            this.DurationFireAlarmLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total number of trips:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percentage of “idle” trips:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of people transported:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Average waiting time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Longest waiting time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cumulative waiting time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Number of fire alarms:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total duration of fire alarms:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(278, 221);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TripsNumLable
            // 
            this.TripsNumLable.AutoSize = true;
            this.TripsNumLable.Location = new System.Drawing.Point(158, 24);
            this.TripsNumLable.Name = "TripsNumLable";
            this.TripsNumLable.Size = new System.Drawing.Size(10, 13);
            this.TripsNumLable.TabIndex = 12;
            this.TripsNumLable.Text = " ";
            // 
            // IdleTripsLable
            // 
            this.IdleTripsLable.AutoSize = true;
            this.IdleTripsLable.Location = new System.Drawing.Point(178, 48);
            this.IdleTripsLable.Name = "IdleTripsLable";
            this.IdleTripsLable.Size = new System.Drawing.Size(13, 13);
            this.IdleTripsLable.TabIndex = 13;
            this.IdleTripsLable.Text = "0";
            // 
            // NumOfTransportedPeopleLable
            // 
            this.NumOfTransportedPeopleLable.AutoSize = true;
            this.NumOfTransportedPeopleLable.Location = new System.Drawing.Point(202, 71);
            this.NumOfTransportedPeopleLable.Name = "NumOfTransportedPeopleLable";
            this.NumOfTransportedPeopleLable.Size = new System.Drawing.Size(10, 13);
            this.NumOfTransportedPeopleLable.TabIndex = 14;
            this.NumOfTransportedPeopleLable.Text = " ";
            // 
            // AverageWaitingTImeLable
            // 
            this.AverageWaitingTImeLable.AutoSize = true;
            this.AverageWaitingTImeLable.Location = new System.Drawing.Point(160, 93);
            this.AverageWaitingTImeLable.Name = "AverageWaitingTImeLable";
            this.AverageWaitingTImeLable.Size = new System.Drawing.Size(10, 13);
            this.AverageWaitingTImeLable.TabIndex = 15;
            this.AverageWaitingTImeLable.Text = " ";
            // 
            // LongestWaitingTimeLable
            // 
            this.LongestWaitingTimeLable.AutoSize = true;
            this.LongestWaitingTimeLable.Location = new System.Drawing.Point(158, 116);
            this.LongestWaitingTimeLable.Name = "LongestWaitingTimeLable";
            this.LongestWaitingTimeLable.Size = new System.Drawing.Size(10, 13);
            this.LongestWaitingTimeLable.TabIndex = 16;
            this.LongestWaitingTimeLable.Text = " ";
            // 
            // CumulativeWaitingTimeLable
            // 
            this.CumulativeWaitingTimeLable.AutoSize = true;
            this.CumulativeWaitingTimeLable.Location = new System.Drawing.Point(172, 140);
            this.CumulativeWaitingTimeLable.Name = "CumulativeWaitingTimeLable";
            this.CumulativeWaitingTimeLable.Size = new System.Drawing.Size(10, 13);
            this.CumulativeWaitingTimeLable.TabIndex = 17;
            this.CumulativeWaitingTimeLable.Text = " ";
            // 
            // FireAlarmsNumLable
            // 
            this.FireAlarmsNumLable.AutoSize = true;
            this.FireAlarmsNumLable.Location = new System.Drawing.Point(161, 163);
            this.FireAlarmsNumLable.Name = "FireAlarmsNumLable";
            this.FireAlarmsNumLable.Size = new System.Drawing.Size(10, 13);
            this.FireAlarmsNumLable.TabIndex = 18;
            this.FireAlarmsNumLable.Text = " ";
            // 
            // DurationFireAlarmLable
            // 
            this.DurationFireAlarmLable.AutoSize = true;
            this.DurationFireAlarmLable.Location = new System.Drawing.Point(189, 187);
            this.DurationFireAlarmLable.Name = "DurationFireAlarmLable";
            this.DurationFireAlarmLable.Size = new System.Drawing.Size(10, 13);
            this.DurationFireAlarmLable.TabIndex = 19;
            this.DurationFireAlarmLable.Text = " ";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(365, 256);
            this.Controls.Add(this.DurationFireAlarmLable);
            this.Controls.Add(this.FireAlarmsNumLable);
            this.Controls.Add(this.CumulativeWaitingTimeLable);
            this.Controls.Add(this.LongestWaitingTimeLable);
            this.Controls.Add(this.AverageWaitingTImeLable);
            this.Controls.Add(this.NumOfTransportedPeopleLable);
            this.Controls.Add(this.IdleTripsLable);
            this.Controls.Add(this.TripsNumLable);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label TripsNumLable;
        private System.Windows.Forms.Label IdleTripsLable;
        private System.Windows.Forms.Label NumOfTransportedPeopleLable;
        private System.Windows.Forms.Label AverageWaitingTImeLable;
        private System.Windows.Forms.Label LongestWaitingTimeLable;
        private System.Windows.Forms.Label CumulativeWaitingTimeLable;
        private System.Windows.Forms.Label FireAlarmsNumLable;
        private System.Windows.Forms.Label DurationFireAlarmLable;
    }
}