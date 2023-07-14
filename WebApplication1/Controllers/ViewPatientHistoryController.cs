using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer.Models;
using Business_Logic_Layer.Services.ViewPatientHistory;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ViewPatientHistoryController : ControllerBase
    {

        public IServiceViewPatientHistory _IserviceViewHistory;

        public ViewPatientHistoryController(IServiceViewPatientHistory iserviceViewHistory)
        {
            _IserviceViewHistory = iserviceViewHistory;
        }

        [HttpGet("/GetSymptoms")]

        public IActionResult GetSymptoms()
        {
            try
            {
                List<string> result = _IserviceViewHistory.GetSymptoms();
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("/GetPatientHistory")]
        public IActionResult GetPatientHistory()
        {
            try
            {
                List<view_patient_history> result = _IserviceViewHistory.GetPatientHistory();
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
