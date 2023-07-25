using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class AddPat_BO
    {
        private string _FirstName;



        private string _LastName;
        private DateTime _DOB;
        private string _Email;
        private string _ContactNo;
        private string _state_name;
        private string _insurance_name;

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
        public DateTime DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                _DOB = value;
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public string ContactNO
        {
            get
            {
                return _ContactNo;
            }
            set
            {
                _ContactNo = value;
            }
        }
        public string state_name
        {
            get
            {
                return _state_name;
            }
            set
            {
                _state_name = value;
            }
        }
        public string insurance_name
        {
            get
            {
                return _insurance_name;
            }
            set
            {
                _insurance_name = value;
            }
        }


    }
}
