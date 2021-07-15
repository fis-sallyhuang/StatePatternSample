using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericAction
{
    public interface ISvcAction//<T> where T : class, ISvcInfo
    {
        ISvcInfo svcInfo { set; get; }
        string commonField { set; get; }
        void callSvcActionApi();
        void getInfoFromApiResponse();
    }
}
