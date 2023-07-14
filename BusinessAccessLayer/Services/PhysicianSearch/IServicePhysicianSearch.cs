using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.PhysiciansSearch
{
    public interface IServicePhysicianSearch
    {

        public List<string> GetInsurance();
        public List<Department> GetDepartmentDetails();
        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments);
    }
}
