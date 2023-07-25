using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
   public class LogIn_BEL
    {
        private string userid;
        private string password;

        public string Userid
        {

            set
            {
                userid = value;
            }
            get
            {
                return userid;
            }
        }
        public string Password
        {

            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
    }
}


