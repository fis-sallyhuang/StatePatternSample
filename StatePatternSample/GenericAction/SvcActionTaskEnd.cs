using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class SvcActionTaskEnd : ISvcActionTaskState
    {
        public bool TaskCompleteFlag { get => true; }

        public void GoNext(SvcActionTaskContext context)
        {
            MessageBox.Show($"SvcActionTaskEnd ");
        }
    }
}
