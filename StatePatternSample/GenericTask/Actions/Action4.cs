using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericTask.Actions
{
    public class Action4 : IBizAction
    {
        public void callBizActionApi()
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            MessageBox.Show($"{m.Name} called from {this.GetType().Name}");
        }

        public void checkParamBeforeCallApi()
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            MessageBox.Show($"{m.Name} called from {this.GetType().Name}");
        }

        public void saveApiResponse2DB()
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            MessageBox.Show($"{m.Name} called from {this.GetType().Name}");
        }
    }
}
