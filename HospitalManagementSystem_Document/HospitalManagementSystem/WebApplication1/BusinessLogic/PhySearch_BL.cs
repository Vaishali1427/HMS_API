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
    public class PhySearch_BL
    {
        PhySearch_DAL PhySearch_dal = new PhySearch_DAL();
        public SqlDataAdapter PhySearch_dropdept()
        {
            
            return PhySearch_dal.dept();
        }
        public SqlDataAdapter PhySearch_dropstate()
        {
            
            return PhySearch_dal.state();
        }
        public SqlDataAdapter PhySearch_dropInsurance()
        {
           
            return PhySearch_dal.insurance();
        }

        public SqlDataAdapter PhySearch_View1(PhySearch_BO objUserBO) // passing Bussiness object Here 
        {

            try
            {
            return PhySearch_dal.View(objUserBO);

            }

            catch
            {

                throw;

            }

        }
    }
}
