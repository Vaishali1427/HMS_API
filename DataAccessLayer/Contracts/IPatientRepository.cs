using Data_Access_Layer.Models;

namespace Data_Access_Layer.Contracts
{
    public interface IPatientRepository
    {

        public string AddPatientDetails(Patient patient);
        public string GetInsuranceDetails(int id);
        public string UpdateInsuranceDetails(int id, Patient_Enroll insurance);


    }
}
