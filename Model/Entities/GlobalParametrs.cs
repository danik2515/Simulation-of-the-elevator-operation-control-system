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
        static void CountTime(object state) {
            time += accelaration*0.1;
            Console.WriteLine(time.ToString());
        }
        public static void StartTime() {
            accelaration = 1.0;
            time = 0.0;
            TimerCallback timeCB = new TimerCallback(CountTime);
            Timer timer = new Timer(timeCB, null, 0, 100);

        }
    }
}
