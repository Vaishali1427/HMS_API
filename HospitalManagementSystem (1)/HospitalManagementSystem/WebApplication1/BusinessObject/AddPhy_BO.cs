using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class AddPhy_BO
    {
        private string _FirstName;



        private string _LastName;



        private string _DepartmentName;



        private string _EducationQualification;

        private string _YearsOfExperience;

        private string _StateName;

        private string _InsurancePlan;



        // Get and set values



        public string FirstName
        {

            get
            {

                return _FirstName;

            }

            set
            {

                _FirstName = value;

            }

        }

        public string LastName
        {

            get
            {

                return _LastName;

            }



            set
            {

                _LastName = value;

            }

        }



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



        public string EducationQualification
        {

            get
            {

                return _EducationQualification;

            }

            set
            {

                _EducationQualification = value;

            }

        }


        public string YearsOfExperience
        {

            get
            {

                return _YearsOfExperience;

            }

            set
            {

                _YearsOfExperience = value;

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
