using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class CMPService1<T> : ISvc where T : class, ISvcInfo, new()
    {
        public CMPService1() {
            MessageBox.Show($"called from {this.GetType().Name}");
            this.info = new T();
            
        }

        public ISvcInfo info { get; set; }
        public List<ISvcAction> svcActions { get; set; }
        //public List<ISvcAction<ISvcInfo>> svcActionTask { get; set; }
        public void LoadActionList()
        {
            this.svcActions = new List<ISvcAction>();
            this.svcActions.Add(new CMPSvcAction1<T>());
            this.svcActions.Add(new CMPSvcAction3<T>());
            this.svcActions.Add(new CMPSvcAction5<T>());
        }

        public void LoadActionListWithTask()
        {
            //this.svcActionTask = new List<ISvcAction<ISvcInfo>>();
            //this.svcActionTask.Add(new CMPSvcAction1<ISvcInfo>());
            //this.svcActionTask.Add(new CMPSvcAction3<ISvcInfo>());
            //this.svcActionTask.Add(new CMPSvcAction5<ISvcInfo>());
        }

        public void ProcessForEachActionTask() {
            if (this.svcActions != null && this.svcActions.Count > 0)
            {
                foreach (var act in this.svcActions)
                {
                    //Type at = Type.GetType($"StatePatternSample.GenericTask.Actions.{a.Name}");
                    //Type myGeneric = typeof(IEqualityComparer<>);

                    //IBizAction act = (IBizAction)Activator.CreateInstance(a, null);
                    // Type constructedClass = myGeneric.MakeGenericType(a);
                    var t = new SvcActionTaskContext(new SvcActionTaskReady(), act);
                    t.Act.svcInfo = this.info;
                    while (!t.State.TaskCompleteFlag)
                    {
                        t.GoNextProcess();
                    }
                }
            }
        }

        public void ProcessForEachAction() {
            foreach (var act in svcActions) {
                act.svcInfo = this.info;
                act.callSvcActionApi();
                act.getInfoFromApiResponse();
            }
        }

        public void ShowInfoResult()
        {
            foreach (var p in this.info.GetType().GetProperties()) {
                MessageBox.Show(p.GetValue(this.info)?.ToString());
            }
           
        }
    }
}
