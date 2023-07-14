using Data_Access_Layer.Models;
using Data_Access_Layer.Contracts;

namespace Business_Logic_Layer.Services.PatientDiagnosisDetails
{
    public class ServicePatientDiagnosisDetails : IServicePatientDiagnosisDetails
    {
        public readonly IPatientDiagnosisDetailsRepository _IpatientDiagnosisDetails;

        public ServicePatientDiagnosisDetails(IPatientDiagnosisDetailsRepository patientDiagnosisDetailsRepository)
        {
            _IpatientDiagnosisDetails = patientDiagnosisDetailsRepository;
        }

        public string AddDiagnosisDetails(Patient_Diagnosis physician)
        {
            try
            {
                _IpatientDiagnosisDetails.AddDiagnosisDetails(physician);
                return "Details added successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> GetPhysicianVisitedDetails()
        {
            try
            {
                return _IpatientDiagnosisDetails.GetPhysicianVisitedDetails().ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
