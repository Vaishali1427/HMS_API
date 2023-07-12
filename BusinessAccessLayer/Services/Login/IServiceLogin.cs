using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services.Login
{
    public interface IServiceLogin
    {

        public string AuthenticateUser(string userId, string password);

    }
}
