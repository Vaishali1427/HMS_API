using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services.Patients
{
    public interface IServicePatient
    {
        public string AddPatient(Patient patient);

        public string GetInsurance(int id);

        public string UpdateInsurance(int id, Patient_Enroll insurance);
    }
}
