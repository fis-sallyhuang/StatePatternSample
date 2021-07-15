using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class CMPSvcAction2<T> : ISvcAction where T : class, ISvcInfo
    {
        public CMPSvcAction2()
        {
            MessageBox.Show($"called from {this.GetType().Name}");
        }

        public string commonField { get; set; }
        public ISvcInfo svcInfo { get; set; }
        public void callSvcActionApi()
        {
            MessageBox.Show($"called callSvcActionApi from {this.GetType().Name}");
        }

        public void getInfoFromApiResponse()
        {
            MessageBox.Show($"called getInfoFromApiResponse from {this.GetType().Name}");
            this.commonField = this.GetType().Name;
            var fild1 = ((T)this.svcInfo).GetType().GetProperty("fild1");
            fild1.SetValue(((T)this.svcInfo), $" {this.GetType().Name} - fild1");
        }


    }
}
