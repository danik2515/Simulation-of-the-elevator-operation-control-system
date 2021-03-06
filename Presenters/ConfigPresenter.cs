using Model.Entities;
using Model.Repositories;
using Presenters.IViews;
using System;
namespace Presenters {
    public class ConfigPresenter {
        IConfigView _configView;

        public ConfigPresenter(IConfigView configView) {
            _configView = configView;
        }

        public void CheckCorrect(string cntOfElevator, string cntOfFloors, bool stategy
            , string maxWeight, string speed, string acceleration, string rule) {

            if (!cntOfElevator.Equals("") && !cntOfFloors.Equals("") && !maxWeight.Equals("") && !speed.Equals("") && !acceleration.Equals("")) {
                try {
                    ConfigData.countOfElevator = Int32.Parse(cntOfElevator.Replace(" ", ""));
                    ConfigData.countOfFloor = Int32.Parse(cntOfFloors.Replace(" ", ""));
                    ConfigData.strategy = stategy;
                    ConfigData.maxWeightOfElevator = Int32.Parse(maxWeight.Replace(" ", ""));
                    ConfigData.speedOfElevator = Int32.Parse(speed.Replace(" ", ""));
                    ConfigData.accelerationOfElevator = Int32.Parse(acceleration.Replace(" ", ""));
                }
                catch {

                }
                if (!rule.Equals("")) {
                    ConfigData.rule = rule.Split(' ');
                }
                else {
                    ConfigData.rule = new string[] { };
                }
                if (ConfigData.countOfElevator >= 1 && ConfigData.countOfElevator <= 5 &&
                    ConfigData.countOfFloor >= 2 && ConfigData.countOfFloor <= 20 &&
                    ConfigData.maxWeightOfElevator >= 1 &&
                    ConfigData.speedOfElevator >= 1 &&
                    ConfigData.accelerationOfElevator >= 1) {
                    _configView.Confirm();
                    SimulationSystem.StartTime();
                }
                else {
                    _configView.ShowErrorMessage("Uncorrect data");
                }
            }
            else {
                _configView.ShowErrorMessage("Some fields are empty. Please, input data");
            }
        }
    }
}
