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
using System.Threading;
namespace WindowsForms {
    public partial class SimulationForm : Form,ISimulationView {
        SimulationPresenter presenter { get; set; }
        double time;
        static Image part = new Bitmap(1405, 1020);
        static Graphics g = Graphics.FromImage(part);
        public SimulationForm() {
            InitializeComponent();
            presenter = new SimulationPresenter(this);
            presenter.AddFloors();
            presenter.AddElevator();
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

        public void DrawFloors(int countOfFloor,int countOfElevator) {
            int sizeX = 200;
            int sizeY = 50; 
            Bitmap wall = new Bitmap("C:\\Users\\1111\\Desktop\\Project\\WindowsForms\\WindowsForms\\Picture\\wall.png");
            for (int i = 0; i < countOfFloor; i++) {
                for (int j = 0; j < countOfElevator; j++) {
                    g.DrawImage(wall, 0+j*sizeX, 965 - i * (sizeY), new Rectangle(new Point(0, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
                    pictureBoxFloor.Image = part;
                }
            }
        }
        public void DrawElevator(int numberElevator,double position) {
            int sizeX = 36;
            int sizeY = 50;
            Bitmap elevator = new Bitmap("C:\\Users\\1111\\Desktop\\Project\\WindowsForms\\WindowsForms\\Picture\\closeElevator.png");
            g.DrawImage(elevator, 200-sizeX+numberElevator*(200),1015-sizeY*(float)position, new Rectangle(new Point(0, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            pictureBoxFloor.Image = part;
              


        }
        public void TimeUpdate(double currentTime) {
            time = currentTime;
            Console.WriteLine(time.ToString());
            
        }

        private void timer_Tick(object sender, EventArgs e) {
            presenter.TimeSet();
            presenter.AddElevator();
        }
    }
}
