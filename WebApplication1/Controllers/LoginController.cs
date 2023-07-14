using Business_Logic_Layer.Services.Login;
using Data_Access_Layer.Models;
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
        public IActionResult Login(Users user)
        {
            try
            {
                string result = _iServiceLogin.AuthenticateUser(user.Username, user.Password);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while authenticating the user.");
            }
        }

    }
}
