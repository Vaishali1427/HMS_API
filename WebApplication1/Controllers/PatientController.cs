using Business_Logic_Layer.Services.Patients;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                    return BadRequest("Data already exists. Try with different patient Id.");
                return BadRequest(ex.Message);
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
                return BadRequest("No data found for this Id.");
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
            catch(SqlException ex)
            {
                if (ex.Message.Contains("Patient Id does not exist."))
                {
                    return BadRequest("Patient Id does not exist.");
                }
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating patient insurance details.");
            }
        }
    }
}
