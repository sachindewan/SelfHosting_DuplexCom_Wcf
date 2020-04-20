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

    //insatance management
    //Per cal/ even if same user has been logged or even for same session
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    //Per session/per logged in user
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    //Single for every  context
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
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
