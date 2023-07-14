using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer.Models;
using Business_Logic_Layer.Services.PatientDiagnosisDetails;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PatientDiagnosisDetailsController : ControllerBase
    {

        public IServicePatientDiagnosisDetails _IservicePatientDiagnosisDetails;

        public PatientDiagnosisDetailsController(IServicePatientDiagnosisDetails iservicePatientDiagnosisDetails)
        {
            _IservicePatientDiagnosisDetails = iservicePatientDiagnosisDetails;
        }

        [HttpPost("/AddDiagnosisDetails")]
        public IActionResult AddDiagnosisDetails(Patient_Diagnosis physician)
        {
            try
            {
                string result = _IservicePatientDiagnosisDetails.AddDiagnosisDetails(physician);
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the diagnosis details.");
            }
        }

        [HttpGet("/GetPhysicianVisitedDetails")]
        public IActionResult GetPhysicianVisitedDetails()
        {
            try
            {
                List<string> result = _IservicePatientDiagnosisDetails.GetPhysicianVisitedDetails();
                return Ok(result.ToList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving physician visited details.");
            }
        }



    }
}
