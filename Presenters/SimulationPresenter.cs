using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Model.Entities;


namespace Presenters {
    public class SimulationPresenter {
        ISimulationView _simulationView;
        
        public SimulationPresenter(ISimulationView simulationView) {
            _simulationView = simulationView;
        }
        public void AddFloors() {
            _simulationView.DrawFloors(ConfigData.countOfFloor,ConfigData.countOfElevator);
        }
        public void TimeSet() {
            GlobalParametrs.CountTime();
        }
        public void AddElevator() {
            if (Elevator.elevator != null) {
                for (int num = 0; num < ConfigData.countOfElevator; num++) {
                    _simulationView.DrawElevator(num, Elevator.elevator[num].position);
                }
            }
        }
        
        
    }
}
