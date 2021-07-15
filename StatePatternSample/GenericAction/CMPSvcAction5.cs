using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class CMPSvcAction5<T> : ISvcAction  where T : class, ISvcInfo
    {
        public CMPSvcAction5()
        {
            MessageBox.Show($"called from {this.GetType().Name}");
        }

        public void callSvcActionApi()
        {
            MessageBox.Show($"called callSvcActionApi from {this.GetType().Name}");
        }
        public string commonField { get; set; }
        public ISvcInfo svcInfo { get; set; }

        public void getInfoFromApiResponse()
        {
            MessageBox.Show($"called getInfoFromApiResponse from {this.GetType().Name}");
            this.commonField = this.GetType().Name;
            var fild3 = ((T)this.svcInfo).GetType().GetProperty("fild3");
            if(fild3 != null)
                fild3.SetValue(((T)this.svcInfo), $" {this.GetType().Name} - fild3");
        }
    }
}
