using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.PatientDiagnosisDetails
{
    public interface IServicePatientDiagnosisDetails
    {
        public string AddDiagnosisDetails(Patient_Diagnosis physician);
        public List<string> GetPhysicianVisitedDetails();
    }
}
