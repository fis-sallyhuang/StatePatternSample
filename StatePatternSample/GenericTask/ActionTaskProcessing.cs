using StatePatternSample.GenericTask;
using StatePatternSample.GenericTask.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericTask
{
    public class ActionTaskProcessing : IActionTaskState
    {
        public bool TaskCompleteFlag { get => false; }
        public void GoNext(ActionTaskContext context)
        {
            MessageBox.Show($"GoNext called from {this.GetType().Name}");
            context.Act.callBizActionApi();
            context.State = new ActionTaskEnd();
        }
    }
}
