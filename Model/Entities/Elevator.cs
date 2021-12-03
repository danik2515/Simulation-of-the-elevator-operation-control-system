using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities {
    public class Elevator {
        public static List<Elevator> elevator;
        public int targetFloor { set; get; }
        public double currentSpeed { get; set; }
        public int currentWeight { get; set; }
        public int numberElevator { get; set; }
        public double position { get; set; }
        public Elevator(int num) {
            numberElevator = num;
            position = 1;
        }

        public void Move() {

        }
        public static void Create() {
            elevator = new List<Elevator>();
            for (int num = 0; num <= ConfigData.countOfElevator; num++) {
                elevator.Add(new Elevator(num));
            }
        }
    }
}
