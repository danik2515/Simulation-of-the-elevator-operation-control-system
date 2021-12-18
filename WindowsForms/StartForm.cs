using Presenters;
using Presenters.IViews;
using System;
using System.Windows.Forms;
namespace WindowsForms {
    public partial class StartForm : Form, IStartView {
        StartPresenter presenter { get; set; }
        public StartForm() {
            InitializeComponent();
            this.MaximizeBox = false;
            presenter = new StartPresenter(this);
        }



        private void StartButton_Click(object sender, EventArgs e) {
            presenter.Start();
        }
        public void Confirm() {
            this.Hide();
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }

    }
}
