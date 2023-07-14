using Data_Access_Layer.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Data_Access_Layer.DataAccess
{
    public class LoginRepository : ILoginRepository
    {
        private readonly string connectionString;

        private IConfiguration? _config;
        public LoginRepository(IConfiguration? config)
        {
            _config = config;
            connectionString = config.GetConnectionString("DefaultConnection");
        }


        public string AuthenticateUser(string userId, string password)
        {
            try
            {
                // Verify the user from the users table
                bool isUserValid = VerifyUser(userId, password);



                if (!isUserValid)
                {
                    // Return null or throw an exception indicating authentication failure
                    return "User Does not exists";
                }
                string token = GenerateJwtToken(userId);



                return String.Format("Token: {0}", token);
            }
            catch (Exception)
            {
                throw;
            }

        }    
   
        public bool VerifyUser(string userId, string password)
        {
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    // Check if the user exists in the database
                    string query = "SELECT COUNT(*) FROM users WHERE Username = @UserId AND User_Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Password", password);



                        int count = (int)command.ExecuteScalar();



                        return count > 0;
                    }

                }
            
        }



        public string GenerateJwtToken(string userId)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], null,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);





        }



    }
}
    

