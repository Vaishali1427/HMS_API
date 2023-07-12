using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Contracts
{
    public interface IViewPatientHistoryRepository
    {
        public List<string> GetSymptoms();
        public List<view_patient_history> GetPatientHistory();
    }
}
