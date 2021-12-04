using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Model.Entities {
    public static class GlobalParametrs {
        public static double time {set;get;}
        public static double accelaration { set; get; }
        public static double floorHeight = 3.0;
        public static void CountTime() {
            if (Elevator.elevator == null) {
                Elevator.Create();
                Elevator.elevator[0].targetFloor = 20;
                
            }
            time += accelaration*0.1;
            
            for (int num = 0; num < ConfigData.countOfElevator; num++) {
                Elevator.elevator[num].Move();
            }
        }
        public static void StartTime() {
            accelaration = 1.0;
            time = 0.0;
   
        }
    }
}
