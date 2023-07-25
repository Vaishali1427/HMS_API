using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
namespace BusinessLogic
{
    public class AddPhy_BL
    {
        AddPhy_DAL AddPhy_dal = new AddPhy_DAL();
        public SqlDataAdapter dropdept()
        {

            return AddPhy_dal.dept();
        }
        public SqlDataAdapter dropstate()
        {
            
            return AddPhy_dal.state();
        }
        public SqlDataAdapter dropInsurance()
        {
            
            return AddPhy_dal.insurance();
        }
        public SqlDataAdapter view1(AddPhy_BO objUserBO)
        {
            try
            {

                return AddPhy_dal.view1(objUserBO);
            }
            catch
            {
                throw;
            }
        }
        
      
        
        public int SaveUserregisrationBL(AddPhy_BO objUserBO) // passing Bussiness object Here 
        {

            try
            {

              



                return AddPhy_dal.AddUserDetails(objUserBO); // calling Method of DataAccess 



            }

            catch
            {

                throw;

            }

        }
        
        
    }
}
