using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.NoGenericTask
{
    public class TaskContext
    {
        private ITaskState state;

        public TaskContext(ITaskState newstate)
        {
            state = newstate;
        }

        public void GoNextProcess()
        {
            state.GoNext(this);
        }

        public ITaskState State
        {
            get { return state; }
            set { state = value; }
        }
    }

}
