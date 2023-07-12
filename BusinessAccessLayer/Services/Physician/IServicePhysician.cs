using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
