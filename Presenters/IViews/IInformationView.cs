namespace Presenters.IViews {
    public interface IInformationView {

        void ShowStatus(int totalTrips, int transprotedPeopleNum, double averageWaitingTime,
            double longestWaitingTime, double cumulativeWaitingTime, int fireAlarmsNum, double fireAlarmsDuration);

    }
}
