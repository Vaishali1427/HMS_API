using Data_Access_Layer.Models;

namespace Data_Access_Layer.Contracts
{
    public interface IViewPatientHistoryRepository
    {
        public List<string> GetSymptoms();
        public List<view_patient_history> GetPatientHistory();
    }
}
