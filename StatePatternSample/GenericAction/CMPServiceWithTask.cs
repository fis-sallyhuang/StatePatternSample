using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericAction
{
    public class CMPServiceWithTask<S,T> where S : class, ISvc,new()
                                         where T : class, ISvcInfo, new()
    {
        private S svc;
        public CMPServiceWithTask() {
            svc = new S();
            svc.info = new T();
        }

        public void ProcessCMPActions() {
            svc.LoadActionList();
            svc.ProcessForEachAction();
            svc.ShowInfoResult();
        }
    }
}
