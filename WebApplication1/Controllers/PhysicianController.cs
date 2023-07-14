using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;
using Business_Logic_Layer.Services.Physician;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PhysicianController : ControllerBase
    {

        public IServicePhysician _IservicePhysician;

        public PhysicianController(IServicePhysician iservicePhysician)
        {
            _IservicePhysician = iservicePhysician;
        }

        [HttpGet("/GetPhysicianDepartmentDetails")]
         public IActionResult GetDepartmentDetails()
        {
            try
            {
                List<Department> result = _IservicePhysician.GetDepartmentDetails();
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost("/AddPhysician")]
        public IActionResult AddPhysician(Physician_Enroll physician)
        {
            try
            {
                string result = _IservicePhysician.AddPhysician(physician);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("/UpdateDepartmentDetails")]
        public IActionResult UpdateDepartmentdetails(string DeptName, Department department)
        {
            try
            {
                string result = _IservicePhysician.UpdateDepartmentdetails(DeptName, department);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("/GetPhysicianInsuranceDetails")]
        public IActionResult GetInsurance(string id)
        {
            try
            {
                string result = _IservicePhysician.GetInsurance(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}
