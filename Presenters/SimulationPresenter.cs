using Model.Entities;
using Model.Repositories;
using Presenters.IViews;
using System.Linq;
namespace Presenters {
    public class SimulationPresenter {
        ISimulationView _simulationView;

        public SimulationPresenter(ISimulationView simulationView) {
            _simulationView = simulationView;
        }
        public void AddFloors() {
            _simulationView.DrawFloors(ConfigData.countOfFloor, ConfigData.countOfElevator);
        }
        public void TimeSet() {
            SimulationSystem.CountTime();
        }
        public void AddElevator() {
            if (Elevator.elevator != null)
                for (int num = 0; num < ConfigData.countOfElevator; num++) {
                    _simulationView.DrawElevator(num, Elevator.elevator[num].position);
                }
        }
        public void AddHuman() {
            if (Human.humans != null)
                for (int num = 0; num < Human.humans.Count(); num++) {
                    _simulationView.DrawHuman(Human.humans[num].startFloor, Human.humans[num].position, Human.humans[num].state, Human.humans[num].currFrame, Human.humans[num].targetFloor);
                }
        }

        public void AddFire() {
            _simulationView.DrawFire(GlobalParametrs.fireAlarm, GlobalParametrs.pause, ConfigData.countOfFloor, ConfigData.countOfElevator);
        }
        public void Pause() {
            if (GlobalParametrs.pause) {
                GlobalParametrs.pause = false;
            }
            else {
                GlobalParametrs.pause = true;
            }
        }
        public void FireAlarm() {
            if (GlobalParametrs.fireAlarm) {
                GlobalParametrs.fireAlarm = false;
                SimulationSystem.fireAlarmsDuration += GlobalParametrs.time - SimulationSystem.startTimeFireAlarm;
            }
            else {
                SimulationSystem.fireAlarmsNum++;
                GlobalParametrs.fireAlarm = true;
                SimulationSystem.startTimeFireAlarm = GlobalParametrs.time;
            }
        }
        public double GetTime() {
            return GlobalParametrs.time;
        }
        public void ShutdownCheck() {
            for (int i = 0; i < ConfigData.countOfElevator; i++) {
                if (Elevator.elevator[i].human.Count != 0 || Elevator.elevator[i].isMove) {
                    _simulationView.ShowErrorMessage("Elevator is move!!!");
                    return;
                }
            }
            _simulationView.Shutdown();
        }
    }
}