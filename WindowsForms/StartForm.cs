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
using Presenters;
namespace WindowsForms {
    public partial class StartForm :Form, IStartView {
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
