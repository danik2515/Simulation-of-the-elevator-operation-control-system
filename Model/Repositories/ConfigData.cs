using System.Collections.Generic;

namespace Model.Repositories {
    public static class ConfigData {
        public static int countOfElevator { get; set; }
        public static int countOfFloor { get; set; }
        public static bool strategy { get; set; }
        public static int maxWeightOfElevator { get; set; }
        public static int speedOfElevator { get; set; }
        public static int accelerationOfElevator { get; set; }
        public static string[] rule { get; set; }
        public static List<double> StartFireAlarmTime { get; set; }
        public static List<double> EndFireAlarmTime { get; set; }
    }
}
