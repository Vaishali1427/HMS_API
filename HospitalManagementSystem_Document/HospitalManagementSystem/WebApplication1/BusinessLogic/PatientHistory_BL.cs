using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class PatientHistory_BL
    {
        PatientHistory_DAL PatHistory_objUserDa = new PatientHistory_DAL();
        public SqlDataAdapter view(PatientHistory_BO objUserBO)
        {
            try
            {

                return PatHistory_objUserDa.view1(objUserBO);
            }
            catch
            {
                throw;
            }
        }
        public SqlDataAdapter viewp(PatientHistory_BO objUserBO)
        {
            try
            {
               
                return PatHistory_objUserDa.view2(objUserBO);
            }
            catch
            {
                throw;
            }
        }

        public SqlDataAdapter View1(PatientHistory_BO objUserBO) // passing Bussiness object Here 
        {

            try
            {




                return PatHistory_objUserDa.View(objUserBO);




            }

            catch
            {

                throw;

            }

        }
    }
}
