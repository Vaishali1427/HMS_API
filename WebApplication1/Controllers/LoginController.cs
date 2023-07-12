using Business_Logic_Layer.Services.Login;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IServiceLogin _iServiceLogin;
        public LoginController(IServiceLogin iServiceLogin)
        {
            _iServiceLogin = iServiceLogin;
        }
        [HttpPost("/Login")]
        public string Login(Users user)
        {
            return _iServiceLogin.AuthenticateUser(user.Username, user.Password);
        }
    }
}
