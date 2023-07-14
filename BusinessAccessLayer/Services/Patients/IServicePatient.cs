using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.Patients
{
    public interface IServicePatient
    {
        public string AddPatient(Patient patient);

        public string GetInsurance(int id);

        public string UpdateInsurance(int id, Patient_Enroll insurance);
    }
}
