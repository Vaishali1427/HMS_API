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
        public string AddDiagnosisDetails(Patient_Diagnosis physician)
        {
            return _IservicePatientDiagnosisDetails.AddDiagnosisDetails(physician);
        }

        [HttpGet("/GetPhysicianVisitedDetails")]
        public List<string> GetPhysicianVisitedDetails()
        {
            return _IservicePatientDiagnosisDetails.GetPhysicianVisitedDetails();
        }



    }
}
