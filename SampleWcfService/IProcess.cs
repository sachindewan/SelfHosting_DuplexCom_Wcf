using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace SampleWcfService
{
    [ServiceContract(CallbackContract =typeof(IProcessCallback))]
    public interface IProcess
    {
        [OperationContract]
        void TaskProcess();
    }
}
