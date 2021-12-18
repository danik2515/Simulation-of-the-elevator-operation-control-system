using Presenters;
using Presenters.IViews;
using System;
using System.Windows.Forms;
namespace WindowsForms {
    public partial class HumanStatusForm : Form, IHumanStatusView {
        HumanStatusPresenter presenter;
        public HumanStatusForm() {
            InitializeComponent();
            presenter = new HumanStatusPresenter(this);
            this.MaximizeBox = false;
            for (int i = 0; i < presenter.CountOfHuman(); i++) {
                HumanListBox.Items.Add(i + 1);
            }
        }
        public void ShowStatus(int num, int state, int startFloor, int endFloor, double timeWait) {
            HumanNumLable.Text = (num + 1).ToString();
            StartLable.Text = startFloor.ToString();
            TargetLable.Text = endFloor.ToString();
            string txt = "";
            switch (state) {
                case 0:
                    txt = "Wait elevator";
                    break;
                case 1:
                    txt = "Go toward press button";
                    break;
                case 2:
                    txt = "Start running";
                    break;
                case 3:
                    txt = "Run";
                    break;
                case 4:
                    txt = "Stand in elevator";
                    break;
                case 5:
                    txt = "Start moving";
                    break;
                case 6:
                    txt = "Go to the exit";
                    break;
                case 7:
                    txt = "Out of the building";
                    break;
            }

            StatusLable.Text = txt;
            waitingTimeLable.Text = Math.Round(timeWait, 2).ToString();
        }





        private void timerStatus_Tick(object sender, EventArgs e) {
            if (HumanListBox.SelectedIndex != -1)
                presenter.GetStatus(HumanListBox.SelectedIndex);
        }

        private void HumanListBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}