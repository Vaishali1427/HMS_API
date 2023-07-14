using Data_Access_Layer.Models;

namespace Data_Access_Layer.Contracts
{
    public interface IPhysicianRepository
    {
        List<Department> GetDepartmentDetails();
        string AddPhysician(Physician_Enroll physician);
        string UpdateDepartmentdetails(string DeptName, Department department);
        string GetInsurance(string id);
    }
}
