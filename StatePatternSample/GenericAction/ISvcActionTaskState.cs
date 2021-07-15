using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericAction
{
    public interface ISvcActionTaskState
    {
        bool TaskCompleteFlag { get; }
        void GoNext(SvcActionTaskContext context);
    }
}
