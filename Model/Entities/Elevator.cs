using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities {
    public class Elevator {
        int targetFloor { set; get; }
        double currentSpeed { get; set; }

        public Elevator() {

        }
    }
}
