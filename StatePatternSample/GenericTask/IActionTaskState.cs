using StatePatternSample.GenericTask.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericTask
{
    public interface IActionTaskState
    {
        bool TaskCompleteFlag { get; }
        void GoNext(ActionTaskContext context);
    }
}
