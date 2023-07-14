using Business_Logic_Layer.Services.Patients;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult AddPatient(Patient patient)
        {
            try
            {
                string result = _IservicePatient.AddPatient(patient);
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the patient.");
            }
        }

        [HttpGet("/GetPatientInsuranceDetails")]
        
        public IActionResult GetInsurance(int id)
        {
            try
            {
                string result = _IservicePatient.GetInsurance(id);
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the patient insurance details.");
            }
        }

        [HttpPut("/UpdatePatientInsuranceDetails")]
        public IActionResult UpdateInsurance(int id, Patient_Enroll insurance)
        {
            try
            {
                string result = _IservicePatient.UpdateInsurance(id, insurance).ToString();
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating patient insurance details.");
            }
        }
    }
}
