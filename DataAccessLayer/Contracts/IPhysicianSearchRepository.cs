using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Contracts
{
    public interface IPhysicianSearchRepository
    {
        public List<string> GetInsurance();
        public List<Department> GetDepartmentDetails();
        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments);
    }
}
