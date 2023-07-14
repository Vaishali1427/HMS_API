using Data_Access_Layer.Contracts;

namespace Business_Logic_Layer.Services.Login
{
    public class ServiceLogin : IServiceLogin
    {

        private readonly ILoginRepository _iLoginRepository;
        public ServiceLogin(ILoginRepository iLoginRepository)
        {
            _iLoginRepository = iLoginRepository;

        }



        public string AuthenticateUser(string userId, string password)
        {
            try
            {

                return _iLoginRepository.AuthenticateUser(userId, password);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
