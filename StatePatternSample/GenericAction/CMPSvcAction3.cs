using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class CMPSvcAction3<T> : ISvcAction where T : class, ISvcInfo
    {
        public CMPSvcAction3()
        {
            MessageBox.Show($"called from {this.GetType().Name}");
        }

        public string commonField { get; set; }
        public ISvcInfo svcInfo { get; set; }

        public void callSvcActionApi()
        {
            MessageBox.Show($"called callSvcActionApi from {this.GetType().Name}, commonField:{commonField}");
        }

        public void getInfoFromApiResponse()
        {
            MessageBox.Show($"called getInfoFromApiResponse from {this.GetType().Name}");
            this.commonField = this.GetType().Name;
            var fild2 = ((T)this.svcInfo).GetType().GetProperty("fild2");
            fild2.SetValue(((T)this.svcInfo), $" {this.GetType().Name} - fild2");
        }
    }
}
