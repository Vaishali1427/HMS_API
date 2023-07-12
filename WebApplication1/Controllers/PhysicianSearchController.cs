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
        public List<string> GetInsurance()
        {
            return _IservicePhysicianSearch.GetInsurance();
        }

        [HttpGet("/GetDepartmentDetails")]
        public List<Department> GetDepartmentDetails()
        {
            return _IservicePhysicianSearch.GetDepartmentDetails();
        }

        [HttpGet("/SearchPhysician")]
        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments)
        {
            return _IservicePhysicianSearch.GetPhysician(physicianSearchArguments);
        }
    }
}
