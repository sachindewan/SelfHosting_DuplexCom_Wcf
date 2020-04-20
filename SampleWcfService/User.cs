using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SampleWcfService
{
    public class User : IUser
    {
        public string AuthenticateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public string WelcomeUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
