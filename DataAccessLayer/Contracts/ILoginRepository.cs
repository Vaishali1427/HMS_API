namespace Data_Access_Layer.Contracts
{
    public interface ILoginRepository
    {
        public string AuthenticateUser(string userId, string password);

        public bool VerifyUser(string userId, string password);

        public string GenerateJwtToken(string userId);
    }
}
