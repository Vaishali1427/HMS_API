using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
