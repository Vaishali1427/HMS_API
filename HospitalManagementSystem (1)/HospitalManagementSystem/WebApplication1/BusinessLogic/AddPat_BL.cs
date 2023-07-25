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
    public class AddPat_BL
    {
        AddPat_DAL AddPat_objUserda = new AddPat_DAL();
        public SqlDataAdapter DispPatID(AddPat_BO AddPat_ObjBO)
        {
            return AddPat_objUserda.DispPatID(AddPat_ObjBO);
        }

        public int SaveUserregisrationBL(AddPat_BO objUserBO) // passing Bussiness object Here 
        {

            try
            {

                 // Creating object of Dataccess

                return AddPat_objUserda.AddUserDetails(objUserBO);

                 // calling Method of DataAccess 



            }

            catch
            {

                throw;

            }

        }
    }
}
