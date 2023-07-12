using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services.PhysiciansSearch
{
    public interface IServicePhysicianSearch
    {

        public List<string> GetInsurance();
        public List<Department> GetDepartmentDetails();
        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments);
    }
}
