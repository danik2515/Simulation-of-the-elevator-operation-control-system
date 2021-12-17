using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.IViews {
    public interface IInformationView {

        void ShowStatus(int totalTrips, int transprotedPeopleNum, double averageWaitingTime,
            double longestWaitingTime, double cumulativeWaitingTime, int fireAlarmsNum, double fireAlarmsDuration);

    }
}
