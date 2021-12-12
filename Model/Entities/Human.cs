using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities {
    public class Human {
        
        public int targetFloor { get; set;}
        public int startFloor { get; set; }
        public static List<Human> humans;
        public static void Wait() {

        }
        public Human(int _targetFloor,int _startFloor) {
            
            targetFloor = _targetFloor;
            startFloor = _startFloor;
            
        }
    }
}
