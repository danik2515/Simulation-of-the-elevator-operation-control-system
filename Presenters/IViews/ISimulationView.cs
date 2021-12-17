﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.IViews {
    public interface ISimulationView {
        void DrawFloors(int countOfFloor,int countOfElevator);
        
        void DrawElevator(int number, double position);

        void DrawHuman(int floor, double humanPosition, int humanState,int currFrame,int targetFloor);
        void DrawFire(bool state,bool pause,int floor,int elevator);
    }
}
