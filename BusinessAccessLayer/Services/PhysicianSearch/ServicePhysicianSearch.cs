using Business_Logic_Layer.Services.Physician;
using Business_Logic_Layer.Services.PhysicianSearch;
using Business_Logic_Layer.Services.PhysiciansSearch;
using Data_Access_Layer.Contracts;
using Data_Access_Layer.DataAccess;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services.PhysicianSearch
{
    public class ServicePhysicianSearch : IServicePhysicianSearch
    {
        public readonly IPhysicianSearchRepository _IphysicianSearchRepository;

        public ServicePhysicianSearch(IPhysicianSearchRepository physicianSearchRepository)
        {
            _IphysicianSearchRepository = physicianSearchRepository;
        }

        public List<string> GetInsurance()
        {
            try
            {
                return _IphysicianSearchRepository.GetInsurance().ToList();

            }
            catch (Exception)
            { throw; }
        }

        public List<Department> GetDepartmentDetails()
        {
            try
            {
                return _IphysicianSearchRepository.GetDepartmentDetails().ToList();

            }
            catch (Exception)
            { throw; }
        }

        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments)
        {
            try
            {
                return _IphysicianSearchRepository.GetPhysician(physicianSearchArguments);

            }
            catch (Exception)
            { throw; }
        }

    }
}
