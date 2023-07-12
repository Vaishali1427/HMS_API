using Business_Logic_Layer.Services.Patients;
using Data_Access_Layer.Contracts;
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
    public class PatientController : ControllerBase
    {

        public IServicePatient _IservicePatient;

        public PatientController(IServicePatient servicePatient)
        {
            _IservicePatient = servicePatient;
        }

        [HttpPost("/AddPatient")]
        public string AddPatient(Patient patient)
        {
            return _IservicePatient.AddPatient(patient);
        }

        [HttpGet("/GetPatientInsuranceDetails")]
        
        public string GetInsurance(int id)
        {
            return _IservicePatient.GetInsurance(id);
        }

        [HttpPut("/UpdatePatientInsuranceDetails")]
        public string UpdateInsurance(int id, Patient_Enroll insurance)
        {
            return _IservicePatient.UpdateInsurance(id, insurance).ToString();
        }
    }
}
