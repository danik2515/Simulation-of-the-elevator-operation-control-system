using Model.Entities;


namespace Presenters.IViews {
    public class InformationPresenter {
        IInformationView _informationView;
        public InformationPresenter(IInformationView informationView) {
            _informationView = informationView;
        }


        public void GetStatus() {
            _informationView.ShowStatus(Elevator.totalTrips, Human.transprotedPeopleNum, Human.SumWaitingTime() / (Human.humans.Count + 0.001), Human.LongestWaitingTime(), Human.SumWaitingTime(), SimulationSystem.fireAlarmsNum, SimulationSystem.fireAlarmsDuration);
        }

    }
}
