using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.NoGenericTask
{
    public class TaskProcessEnd : ITaskState
    {
        public void GoNext(TaskContext context)
        {
            MessageBox.Show("GoNext called from TaskProcessEnd");
            Console.WriteLine("GoNext called from TaskProcessEnd");
        }
    }
}
