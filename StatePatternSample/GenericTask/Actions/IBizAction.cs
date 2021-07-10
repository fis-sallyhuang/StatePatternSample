using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternSample.GenericTask.Actions
{
    public interface IBizAction
    {
        void checkParamBeforeCallApi();
        void callBizActionApi();

        void saveApiResponse2DB();
    }
}
