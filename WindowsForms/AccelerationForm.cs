using Presenters;
using Presenters.IViews;
using System;
using System.Windows.Forms;

namespace WindowsForms {
    public partial class AccelerationForm : Form, IAccelerationView {
        AccelerationPresenter presenter;
        public AccelerationForm() {
            InitializeComponent();
            presenter = new AccelerationPresenter(this);
            this.MinimizeBox = false;
        }

        public void Confirm() {
            this.Hide();
        }

        public void ShowErrorMessage(string message) {
            MessageBox.Show(message);
        }

        private void SetButton_Click(object sender, EventArgs e) {
            presenter.CheckCorrect(AccelerationTextBox.Text);
            this.Hide();
        }
    }
}
