using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.IViews;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms {
    public partial class InformationForm : Form, IInformationView{
        InformationPresenter presenter;
        public InformationForm() {
            InitializeComponent();
            presenter = new InformationPresenter(this);
            this.MaximizeBox = false;
            presenter.GetStatus();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text Files | *.txt";
                saveFileDialog1.Title = "Save data in file";
                saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                StreamWriter w = new StreamWriter(fs);
                w.WriteLine(TripsNumLable.Text);
                w.WriteLine(NumOfTransportedPeopleLable.Text);
                w.WriteLine(AverageWaitingTImeLable.Text);
                w.WriteLine(LongestWaitingTimeLable.Text);
                w.WriteLine(CumulativeWaitingTimeLable.Text);
                w.WriteLine(FireAlarmsNumLable.Text);
                w.WriteLine(DurationFireAlarmLable.Text);

                w.Flush();
                w.Close();
            }
        }

        public void ShowStatus(int totalTrips, int transprotedPeopleNum, double averageWaitingTime,
            double longestWaitingTime, double cumulativeWaitingTime, int fireAlarmsNum, double fireAlarmsDuration) {
            TripsNumLable.Text = totalTrips.ToString();
            NumOfTransportedPeopleLable.Text = transprotedPeopleNum.ToString();
            AverageWaitingTImeLable.Text = Math.Round(averageWaitingTime, 2).ToString();
            LongestWaitingTimeLable.Text = Math.Round(longestWaitingTime, 2).ToString(); 
            CumulativeWaitingTimeLable.Text = Math.Round(cumulativeWaitingTime, 2).ToString();
            FireAlarmsNumLable.Text = fireAlarmsNum.ToString();
            DurationFireAlarmLable.Text = Math.Round(fireAlarmsDuration, 2).ToString();
        }
    }
}
