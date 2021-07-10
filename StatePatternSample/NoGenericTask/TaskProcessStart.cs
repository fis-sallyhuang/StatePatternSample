using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.NoGenericTask
{
    public class TaskProcessStart : ITaskState
    {
        public void GoNext(TaskContext context)
        {
            MessageBox.Show("GoNext called from TaskProcessStart");
            Console.WriteLine("GoNext called from TaskProcessStart");
            context.State = new TaskProcessing();

        }
    }
}
