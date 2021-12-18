using Presenters;
using Presenters.IViews;
using System;
using System.Windows.Forms;

namespace WindowsForms {
    public partial class AddHumanForm : Form, IAddHumanView {
        AddHumanPresenter presenter;
        public AddHumanForm() {
            InitializeComponent();
            presenter = new AddHumanPresenter(this);
            this.MinimizeBox = false;
        }
        public void ShowErrorMessage(string message) {
            MessageBox.Show(message);
        }

        private void addButton_Click(object sender, EventArgs e) {
            presenter.CheckCorrect(countOfPeopleTextBox.Text, startFloorTextBox.Text, endFloorTextBox.Text);
        }
    }
}
