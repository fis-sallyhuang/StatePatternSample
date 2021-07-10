using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.NoGenericTask
{
    public class TaskProcessing : ITaskState
    {
        public void GoNext(TaskContext context)
        {
            MessageBox.Show("GoNext called from TaskProcessing");
            Console.WriteLine("GoNext called from TaskProcessing");
            context.State = new TaskProcessEnd();

        }
    }
}
