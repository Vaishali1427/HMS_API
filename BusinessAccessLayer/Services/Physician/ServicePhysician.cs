using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.Physician
{
    public class ServicePhysician : IServicePhysician
    {
        public readonly IPhysicianRepository _IphysicianRepository;

        public ServicePhysician(IPhysicianRepository iphysicianRepository)
        {
            _IphysicianRepository = iphysicianRepository;
        }

        public List<Department> GetDepartmentDetails()
        {
            try
            {
                return _IphysicianRepository.GetDepartmentDetails().ToList();

            }
            catch (Exception)
            { throw; }
        }

        public string AddPhysician(Physician_Enroll physician)
        {
            try
            {
                _IphysicianRepository.AddPhysician(physician);
                return "Physician added successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string UpdateDepartmentdetails(string DeptName, Department department)
        {
            try
            {
                _IphysicianRepository.UpdateDepartmentdetails(DeptName, department);
                return "Updated department details!";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetInsurance(string id)
        {
            try
            {
                return _IphysicianRepository.GetInsurance(id).ToString();

            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
