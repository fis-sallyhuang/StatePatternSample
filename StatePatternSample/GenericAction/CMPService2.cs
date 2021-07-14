using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class CMPService2<T> : ISvc<T> where T : class, ISvcInfo, new()
    {
        public CMPService2() {
            MessageBox.Show($"called from {this.GetType().Name}");
            this.info = new T();
        }
        public T info { get; set; }

        public List<ISvcAction<T>> svcActions { get; set; }

        public void LoadActionList()
        {
            this.svcActions = new List<ISvcAction<T>>();
            this.svcActions.Add(new CMPSvcAction2<T>());
            this.svcActions.Add(new CMPSvcAction4<T>());
            this.svcActions.Add(new CMPSvcAction5<T>());
        }

        public void ProcessForEachAction()
        {
            foreach (var act in svcActions)
            {
                act.svcInfo = this.info;
                act.callSvcActionApi();
                act.getInfoFromApiResponse();
            }
        }

        public void ShowInfoResult()
        {
            foreach (var p in this.info.GetType().GetProperties())
            {
                MessageBox.Show(p.GetValue(this.info).ToString());
            }
        }
    }
}
