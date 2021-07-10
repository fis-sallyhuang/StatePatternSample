using StatePatternSample.GenericTask;
using StatePatternSample.GenericTask.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericTask
{
    public class ActionTaskContext
    {
        private IActionTaskState state;
        private IBizAction act;

        public ActionTaskContext(IActionTaskState newstate, IBizAction myAct)
        {
            state = newstate;
            act = myAct;
        }

        public void GoNextProcess()
        {
            state.GoNext(this);
        }

        public IBizAction Act
        {
            get { return act; }
            set { act = value; }
        }
        public IActionTaskState State
        {
            get { return state; }
            set { state = value; }
        }
    }

}
