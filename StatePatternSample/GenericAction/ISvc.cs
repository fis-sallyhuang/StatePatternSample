using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericAction
{
    public interface ISvc//<T> where T : class, ISvcInfo
    {
        ISvcInfo info { set; get; }
        List<ISvcAction> svcActions { set; get; }
        void LoadActionList() ;
        void ProcessForEachAction();
        void ProcessForEachActionTask();
        void ShowInfoResult();
    }
}
