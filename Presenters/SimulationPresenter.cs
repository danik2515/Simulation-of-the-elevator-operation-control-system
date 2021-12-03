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
            _simulationView.DrawFloors(ConfigData.countOfFloor);
        }
    }
}
