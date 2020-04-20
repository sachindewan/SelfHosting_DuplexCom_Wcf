using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ServiceModel;
namespace SampleWcfService
{
    [ServiceBehavior(ConcurrencyMode =ConcurrencyMode.Reentrant)]
    public class Process : IProcess
    {
        public void TaskProcess()
        {
            for(int i= 0;i<= 100; i++){
                Thread.Sleep(50);
                OperationContext.Current.GetCallbackChannel<IProcessCallback>().TaskProgress(i);
            }
        }
    }
}
