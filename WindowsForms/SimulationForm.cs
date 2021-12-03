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
    public partial class SimulationForm : Form,ISimulationView {
        SimulationPresenter presenter;
        public SimulationForm() {
            InitializeComponent();
            presenter = new SimulationPresenter(this);
            presenter.AddFloors();
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

        private void SimulationForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        public void DrawFloors(int countOfFloor) {
            int sizeX = 200;
            int sizeY = 50; 
            Bitmap wall = new Bitmap("C:\\Users\\1111\\Desktop\\Project\\WindowsForms\\WindowsForms\\Picture\\wall.png");
            Image part = new Bitmap(828,1020);
            Graphics g = Graphics.FromImage(part);
            for(int i = 0; i < countOfFloor; i++) {
                g.DrawImage(wall, 0, 965-i*(sizeY), new Rectangle(new Point(0, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
                pictureBoxFloor.Image = part;
            }
        }

    }
}
