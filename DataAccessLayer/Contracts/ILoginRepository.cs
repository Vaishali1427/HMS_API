using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Contracts
{
    public interface ILoginRepository
    {
        public string AuthenticateUser(string userId, string password);

        public bool VerifyUser(string userId, string password);

        public string GenerateJwtToken(string userId);
    }
}
