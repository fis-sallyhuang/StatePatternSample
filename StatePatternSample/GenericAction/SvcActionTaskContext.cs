using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericAction
{
    public class SvcActionTaskContext
    {
        private ISvcActionTaskState state;
        private ISvcAction act;

        public SvcActionTaskContext(ISvcActionTaskState newstate, ISvcAction myAct)
        {
            state = newstate;
            act = myAct;
        }

        public void GoNextProcess()
        {
            state.GoNext(this);
        }

        public ISvcAction Act
        {
            get { return act; }
            set { act = value; }
        }
        public ISvcActionTaskState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
