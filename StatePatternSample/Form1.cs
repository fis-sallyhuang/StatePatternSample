using StatePatternSample.GenericTask;
using StatePatternSample.GenericTask.Actions;
using StatePatternSample.NoGenericTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample
{
    public partial class Form1 : Form
    {
        private TaskContext task = null;
        private ActionTaskContext actTask = null;
        private List<Type> acts = null;
        public Form1()
        {
            InitializeComponent();
            acts = new List<Type>();
            acts.Add(typeof(Action1));
            acts.Add(typeof(Action2));
            acts.Add(typeof(Action3));
            acts.Add(typeof(Action4));
            acts.Add(typeof(Action5));
        }

        private void btnGoNext_Click(object sender, EventArgs e)
        {
            if(task == null) task = new TaskContext(new TaskReady());
            task.GoNextProcess();
        }

        private void btnGoNextAction_Click(object sender, EventArgs e)
        {
            //if (actTask == null) actTask = new ActionTaskContext<Action1>(new ActionTaskReady());
            if (acts != null && acts.Count > 0) {
                foreach (Type a in acts) {
                    //Type at = Type.GetType($"StatePatternSample.GenericTask.Actions.{a.Name}");
                    //Type myGeneric = typeof(IEqualityComparer<>);
                    
                    IBizAction act = (IBizAction)Activator.CreateInstance(a, null);
                   // Type constructedClass = myGeneric.MakeGenericType(a);
                    var t = new ActionTaskContext(new ActionTaskReady(), act);
                    while (!t.State.TaskCompleteFlag) {
                        t.GoNextProcess();
                    }
                }
            }
            
     
        }
    }
}
