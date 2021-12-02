using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms {
    public partial class SimulationForm : Form {
        public SimulationForm() {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void accelerateToolStripMenuItem_Click(object sender, EventArgs e) {
            AccelerationForm accelerationForm = new AccelerationForm();
            accelerationForm.Show();
        }

        private void showInformationToolStripMenuItem_Click(object sender, EventArgs e) {
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }

        private void addHumansToolStripMenuItem_Click(object sender, EventArgs e) {
            AddHumanForm addHumanForm = new AddHumanForm();
            addHumanForm.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e) {
            HumanStatusForm humanStatusForm = new HumanStatusForm();
            humanStatusForm.Show();
        }

        private void ShutdownButton_Click(object sender, EventArgs e) {
            this.Hide();
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }
    }
}
