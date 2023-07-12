using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Contracts
{
    public interface IPatientDiagnosisDetailsRepository
    {
        public string AddDiagnosisDetails(Patient_Diagnosis physician);
        public List<string> GetPhysicianVisitedDetails();
    }
}
