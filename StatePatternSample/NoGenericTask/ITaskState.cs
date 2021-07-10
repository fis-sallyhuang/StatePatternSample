using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.NoGenericTask
{
    public interface ITaskState
    {
        void GoNext(TaskContext context);
    }
    

}
