using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;
//using Data_Access_Layer.Contracts;

namespace Business_Logic_Layer.Services.Patients
{
    public class ServicePatient : IServicePatient
    {
        public readonly IPatientRepository _ipatientRepository;

        public ServicePatient(IPatientRepository patientRepository)
        {
            _ipatientRepository = patientRepository;
        }
        
        public string AddPatient(Patient patient)
        {
            try
            {
                _ipatientRepository.AddPatientDetails(patient);
                return "Added patient";
            }
            catch (Exception)
            { throw; }
        }

        public string GetInsurance(int id)
        {
            try
            {
                return _ipatientRepository.GetInsuranceDetails(id).ToString();

            }
            catch (Exception)
            { throw; }
        }

        public string UpdateInsurance(int id, Patient_Enroll insurance)
        {
            try
            {
                return _ipatientRepository.UpdateInsuranceDetails(id, insurance).ToString();

            }
            catch (Exception)
            { throw; }
        }
    }
}
