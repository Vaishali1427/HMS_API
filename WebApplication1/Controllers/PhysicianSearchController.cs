using Business_Logic_Layer.Services.PhysiciansSearch;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PhysicianSearchController : ControllerBase
    {

        public IServicePhysicianSearch _IservicePhysicianSearch;

        public PhysicianSearchController(IServicePhysicianSearch servicePhysicianSearch)
        {
            _IservicePhysicianSearch = servicePhysicianSearch;
        }

        [HttpGet("/GetInsuranceDetails")]
        public IActionResult GetInsurance()
        {
            try
            {
                List<string> result = _IservicePhysicianSearch.GetInsurance();
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("/GetDepartmentDetails")]
        public IActionResult GetDepartmentDetails()
        {
            try
            {
                List<Department> result = _IservicePhysicianSearch.GetDepartmentDetails();
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("/SearchPhysician")]
        public IActionResult GetPhysician(PhysicianSearchArguments physicianSearchArguments)
        {
            try
            {
                Physician_Search result = _IservicePhysicianSearch.GetPhysician(physicianSearchArguments);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
