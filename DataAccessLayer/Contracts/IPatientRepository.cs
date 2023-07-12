using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Contracts
{
    public interface IPatientRepository
    {

        public string AddPatientDetails(Patient patient);
        public string GetInsuranceDetails(int id);
        public string UpdateInsuranceDetails(int id, Patient_Enroll insurance);


    }
}
