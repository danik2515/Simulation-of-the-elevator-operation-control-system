using Model.Repositories;
using Model.Servises;
using System.Collections.Generic;
namespace Model.Entities {
    public static class SimulationSystem {
        public static int fireAlarmsNum = 0;
        public static double startTimeFireAlarm = 0;
        public static double fireAlarmsDuration = 0;
        public static void CountTime() {

            if (!GlobalParametrs.pause) {
                CheckFireAlarmRule(ConfigData.EndFireAlarmTime, false);
                CheckFireAlarmRule(ConfigData.StartFireAlarmTime, true);
                GlobalParametrs.time += GlobalParametrs.accelaration * 0.1;
            }


        }
        public static void StartTime() {
            GlobalParametrs.accelaration = 1.0;
            GlobalParametrs.time = 0.0;
            GlobalParametrs.pause = false;
            Elevator.Create();
            RuleService.GetRule();
        }
        public static void CheckFireAlarmRule(List<double> alarmTime, bool state) {
            if (alarmTime.Count != 0)
                if (GlobalParametrs.time >= alarmTime[0] && GlobalParametrs.accelaration * 0.1 + GlobalParametrs.time >= alarmTime[0]) {
                    GlobalParametrs.fireAlarm = state;
                    alarmTime.RemoveAt(0);
                    if (state && !GlobalParametrs.fireAlarm) {
                        SimulationSystem.fireAlarmsNum++;
                        SimulationSystem.startTimeFireAlarm = GlobalParametrs.time;
                    }
                    if (!state && GlobalParametrs.fireAlarm) {
                        fireAlarmsDuration += GlobalParametrs.time - SimulationSystem.startTimeFireAlarm;
                    }
                }
        }
    }
}
