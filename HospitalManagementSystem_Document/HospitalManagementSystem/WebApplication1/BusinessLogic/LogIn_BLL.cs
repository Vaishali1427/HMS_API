using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using DataAccessLayer;
namespace BusinessLogic
{
    public class LogIn_BLL
    {


        public int LogIn(LogIn_BEL belUlogin)
        {
            LogIn_DAL daldlogin = new LogIn_DAL();
            try
            {
                return daldlogin.LogIn(belUlogin);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                daldlogin = null;
            }
        }
    }
}
