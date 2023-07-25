using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class PhySearch_BO
    {
        private string _StateName;
        private string _DepartmentName;
        private string _InsurancePlan;
        public string DepartmentName
        {

            get
            {

                return _DepartmentName;

            }



            set
            {

                _DepartmentName = value;

            }

        }
        public string StateName
        {

            get
            {

                return _StateName;

            }

            set
            {

                _StateName = value;

            }

        }


        public string InsurancePlan
        {

            get
            {

                return _InsurancePlan;

            }

            set
            {

                _InsurancePlan = value;

            }

        }
    }
}
