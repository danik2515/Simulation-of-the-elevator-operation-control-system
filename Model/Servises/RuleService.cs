using Model.Entities;
using Model.Repositories;
using System;
using System.Collections.Generic;

namespace Model.Servises {
    public static class RuleService {
        public static void GetRule() {
            ConfigData.EndFireAlarmTime = new List<double> { };
            ConfigData.StartFireAlarmTime = new List<double> { };
            string[] rule = ConfigData.rule;
            if (rule.Length > 0) {
                for (int i = 0; i < rule.Length; i++) {
                    if (rule[i].Equals("/human")) {
                        try {
                            int _cntOfPeople = Int32.Parse(rule[i + 1]);
                            int _startFloor = Int32.Parse(rule[i + 2]);
                            int _endFloor = Int32.Parse(rule[i + 3]);
                            if (_cntOfPeople != 0 && _startFloor >= 1 && _startFloor <= ConfigData.countOfFloor && _endFloor >= 1 && _endFloor <= ConfigData.countOfFloor && _endFloor != _startFloor) {
                                for (int j = 0; j < _cntOfPeople; j++) {
                                    Human human = new Human(_endFloor, _startFloor);
                                }
                            }
                        }
                        catch {

                        }

                    }
                    if (rule[i].Equals("/fireAlarm")) {
                        try {
                            double _startTime = Double.Parse(rule[i + 1]);
                            double _endTime = Double.Parse(rule[i + 2]);
                            if (_startTime >= 0 && _endTime > _startTime) {
                                ConfigData.StartFireAlarmTime.Add(_startTime);
                                ConfigData.EndFireAlarmTime.Add(_endTime);
                            }
                        }
                        catch {

                        }

                    }
                }
            }
            ConfigData.EndFireAlarmTime.Sort();
            ConfigData.StartFireAlarmTime.Sort();
        }

    }
}
