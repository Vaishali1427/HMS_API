using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using BL;
using BO;
using DA;
using System.Data.SqlClient;



 // for acessing bussiness object class



namespace BL
{

    public class PDD_BL
    {

        public int SaveUserregisrationBL(PDD_BO objUserBL) // passing Bussiness object Here 
        {

            try
            {

                PDD_DA objUserda = new PDD_DA(); // Creating object of Dataccess



                return objUserda.AddUserDetails(objUserBL); // calling Method of DataAccess 



            }

            catch
            {

                throw;

            }

        }
        public int check_bll(PDD_BO dhbel)
        {
            PDD_DA objUserdal = new PDD_DA();
            return objUserdal.check_dal(dhbel);
        }
        //public DataTable SavePhysicianBL(UserBO objUserBL) // passing Bussiness object Here 
        //{

        //    try
        //    {

        //        UserDA objUserd = new UserDA(); // Creating object of Dataccess



        //        return objUserd.AddPhyDetails(objUserBL); // calling Method of DataAccess 



        //    }

        //    catch
        //    {

        //        throw;

        //    }

        //}
        public SqlDataAdapter View1(PDD_BO objUserBO) // passing Bussiness object Here 
        {

            try
            {

                PDD_DA objUserda = new PDD_DA(); // Creating object of Dataccess


                return objUserda.View(objUserBO);




            }

            catch
            {

                throw;

            }

        }

    }

}
