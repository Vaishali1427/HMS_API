using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.ViewPatientHistory
{
    public class ServiceViewPatientHistory : IServiceViewPatientHistory
    {
        public readonly IViewPatientHistoryRepository _IviewPatientHistoryRepository;

        public ServiceViewPatientHistory(IViewPatientHistoryRepository iviewPatientHistoryRepository)
        {
            _IviewPatientHistoryRepository = iviewPatientHistoryRepository;
        }

        public List<string> GetSymptoms()
        {
            try
            {
                return _IviewPatientHistoryRepository.GetSymptoms().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<view_patient_history> GetPatientHistory()
        {
            try
            {
                return _IviewPatientHistoryRepository.GetPatientHistory().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

