using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.ViewPatientHistory
{
    public interface IServiceViewPatientHistory
    {
        public List<string> GetSymptoms();
        public List<view_patient_history> GetPatientHistory();
    }
}
