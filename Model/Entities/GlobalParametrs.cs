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
               
                
            }
            time += accelaration*0.1;
            
            
            
        }
        public static void StartTime() {
            accelaration = 1.0;
            time = 0.0;
   
        }
    }
}
