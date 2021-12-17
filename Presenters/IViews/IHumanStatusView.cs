using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.IViews {
    public interface IHumanStatusView {
        void ShowStatus(int num,int state,int startFloor,int endFloor,double timeWait);
    }
}
