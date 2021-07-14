using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericAction
{
    public interface ISvc<T> where T : class, ISvcInfo
    {
        T info { set; get; }
        List<ISvcAction<T>> svcActions { set; get; }
        void LoadActionList() ;
        void ProcessForEachAction();
        void ShowInfoResult();
    }
}
