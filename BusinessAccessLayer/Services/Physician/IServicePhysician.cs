using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Services.Physician
{
    public interface IServicePhysician
    {
        List<Department> GetDepartmentDetails();
        string AddPhysician(Physician_Enroll physician);
        string UpdateDepartmentdetails(string DeptName, Department department);
        string GetInsurance(string id);
    }
}
