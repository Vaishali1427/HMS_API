using Data_Access_Layer.Models;

namespace Data_Access_Layer.Contracts
{
    public interface IPatientDiagnosisDetailsRepository
    {
        public string AddDiagnosisDetails(Patient_Diagnosis physician);
        public List<string> GetPhysicianVisitedDetails();
    }
}
