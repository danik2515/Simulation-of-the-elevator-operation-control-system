using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities {
    public class Elevator {
        public static List<Elevator> elevator;
        public static double eps = 10e-6;
        public static double acc = (double)ConfigData.accelerationOfElevator / 100;
        public int targetFloor { set; get; }
        public double currentSpeed { get; set; }
        public int currentWeight { get; set; }
        public int numberElevator { get; set; }
        public double position { get; set; }
        public bool isMove { get; set; }
        private double time0;
        private double lenght;
        private double tExpect;
        private double position0;
        private double tUniform;
        private double tExpectUn;
        public Elevator(int num) {
            numberElevator = num;
            position = 1;
            targetFloor = 1;
            isMove = false;
        }

        public void Move() {
            if ((int)position != targetFloor && !isMove) {
                isMove = true;
                time0 = GlobalParametrs.time;
                lenght = (targetFloor - position) * GlobalParametrs.floorHeight;
               
                tExpect = 2 * Math.Sqrt(Math.Abs(lenght) / acc);
                position0 = position;
                
                tExpectUn = 2 * ConfigData.speedOfElevator/acc;
                tUniform = (Math.Abs(lenght) - ConfigData.speedOfElevator * tExpectUn / 2) / ConfigData.speedOfElevator;
            }
            else if(isMove && (ConfigData.speedOfElevator > Math.Sqrt(acc * Math.Abs(lenght)))) {
                double delteTime = GlobalParametrs.time - time0;
                if(delteTime < tExpect) {
                    delteTime = GlobalParametrs.time - time0;
                    if (delteTime < tExpect / 2) {
                        position =position0+ (lenght / Math.Abs(lenght)) * (acc * Math.Pow((delteTime), 2) / 2)/GlobalParametrs.floorHeight;
                    } else {
                        position =position0+(lenght/Math.Abs(lenght))*((lenght / Math.Abs(lenght)) * lenght /2+ tExpect * acc * (delteTime-tExpect/2) / 2 - acc * Math.Pow((delteTime-tExpect/2), 2) / 2)/GlobalParametrs.floorHeight;
                    }

                } else {
                    position = targetFloor;
                    isMove = false;
                }
            }else if(isMove && (ConfigData.speedOfElevator <= Math.Sqrt(acc * Math.Abs(lenght)))) {
                double delteTime = GlobalParametrs.time - time0;
                if (delteTime < tExpectUn + tUniform) {
                    if (delteTime < tExpectUn / 2) {
                        position = position0 + (lenght / Math.Abs(lenght)) * (acc * Math.Pow((delteTime), 2) / 2) / GlobalParametrs.floorHeight;
                    }else if (delteTime < (tExpectUn / 2 + tUniform)) {
                        position = position0 + (lenght / Math.Abs(lenght))*(acc*Math.Pow(tExpectUn / 2,2)/2 +ConfigData.speedOfElevator*(delteTime- tExpectUn / 2))/ GlobalParametrs.floorHeight;
                    } else {
                        position = position0 + (lenght / Math.Abs(lenght)) * (acc * Math.Pow(tExpectUn / 2, 2) / 2+ ConfigData.speedOfElevator*tUniform+ConfigData.speedOfElevator* (delteTime - tUniform - tExpectUn / 2) - acc * Math.Pow((delteTime-tUniform - tExpectUn / 2), 2)/2) / GlobalParametrs.floorHeight;
                    }
                }else {
                    position = targetFloor;
                    isMove = false;
                }
            }
       
            
        }
        public static void Create() {
            elevator = new List<Elevator>();
            for (int num = 0; num <= ConfigData.countOfElevator; num++) {
                elevator.Add(new Elevator(num));
            }
        }
    }
}
