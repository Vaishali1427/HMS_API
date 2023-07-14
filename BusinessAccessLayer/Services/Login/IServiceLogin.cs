namespace Business_Logic_Layer.Services.Login
{
    public interface IServiceLogin
    {

        public string AuthenticateUser(string userId, string password);

    }
}
