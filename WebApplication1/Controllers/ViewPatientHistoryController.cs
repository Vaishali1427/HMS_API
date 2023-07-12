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

        public List<string> GetSymptoms()
        {
            return _IserviceViewHistory.GetSymptoms();
        }

        [HttpGet("/GetPatientHistory")]
        public List<view_patient_history> GetPatientHistory()
        {
            return _IserviceViewHistory.GetPatientHistory();
        }
    }
}
