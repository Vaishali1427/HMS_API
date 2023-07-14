using Data_Access_Layer.Models;

namespace Data_Access_Layer.Contracts
{
    public interface IPhysicianSearchRepository
    {
        public List<string> GetInsurance();
        public List<Department> GetDepartmentDetails();
        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments);
    }
}
