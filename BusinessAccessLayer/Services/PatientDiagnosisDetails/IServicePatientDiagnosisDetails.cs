using Data_Access_Layer.Models;
using Data_Access_Layer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services.PatientDiagnosisDetails
{
    public interface IServicePatientDiagnosisDetails
    {
        public string AddDiagnosisDetails(Patient_Diagnosis physician);
        public List<string> GetPhysicianVisitedDetails();
    }
}
