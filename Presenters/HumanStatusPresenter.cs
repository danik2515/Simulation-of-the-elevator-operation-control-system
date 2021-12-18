using Model.Entities;
using Presenters.IViews;
namespace Presenters {
    public class HumanStatusPresenter {
        IHumanStatusView _humanStatus;

        public HumanStatusPresenter(IHumanStatusView humanStatus) {
            _humanStatus = humanStatus;
        }


        public int CountOfHuman() {
            return Human.humans.Count;
        }
        public void GetStatus(int num) {
            _humanStatus.ShowStatus(num, Human.humans[num].state, Human.humans[num].startFloor, Human.humans[num].targetFloor, Human.humans[num].timeWait);
        }
    }
}
