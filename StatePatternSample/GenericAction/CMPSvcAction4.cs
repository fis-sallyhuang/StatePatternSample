using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternSample.GenericAction
{
    public class CMPSvcAction4<T> : ISvcAction<T> where T : class, ISvcInfo
    {
        public CMPSvcAction4()
        {
            MessageBox.Show($"called from {this.GetType().Name}");
        }

        public void callSvcActionApi()
        {
            MessageBox.Show($"called callSvcActionApi from {this.GetType().Name}");
        }

        public string commonField { get; set; }
        public T svcInfo { get; set; }

        public void getInfoFromApiResponse()
        {
            MessageBox.Show($"called getInfoFromApiResponse from {this.GetType().Name}");
            this.commonField = this.GetType().Name;
            var fild2 = this.svcInfo.GetType().GetProperty("fild2");
            fild2.SetValue(this.svcInfo, $" {this.GetType().Name} - fild2");
        }
    }
}
