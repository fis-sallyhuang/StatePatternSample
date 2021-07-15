using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class SvcActionTaskReady: ISvcActionTaskState
    {
        public bool TaskCompleteFlag { get => false; }

        public void GoNext(SvcActionTaskContext context)
        {
            MessageBox.Show($"GoNext called from {this.GetType().Name}");
            context.State = new SvcActionTaskStart();
        }
    }
}
