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
         public List<Department> GetDepartmentDetails()
        {
            return _IservicePhysician.GetDepartmentDetails();
        }

        [HttpPost("/AddPhysician")]
        public string AddPhysician(Physician_Enroll physician)
        {
            return _IservicePhysician.AddPhysician(physician);
        }

        [HttpPut("/UpdateDepartmentDetails")]
        public string UpdateDepartmentdetails(string DeptName, Department department)
        {
            return _IservicePhysician.UpdateDepartmentdetails(DeptName, department);
        }

        [HttpGet("/GetPhysicianInsuranceDetails")]
        public string GetInsurance(string id)
        {
            return _IservicePhysician.GetInsurance(id);
        }

    }
}
