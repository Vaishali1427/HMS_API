using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObject;


namespace DataAccessLayer
{
    public class AddPat_DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public SqlDataAdapter DispPatID(AddPat_BO AddPat_ObjBO)
        {
            SqlCommand cmd = new SqlCommand("DisplayPatientID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", AddPat_ObjBO.FirstName);

            cmd.Parameters.AddWithValue("@lname", AddPat_ObjBO.LastName);

            cmd.Parameters.AddWithValue("@DOB", AddPat_ObjBO.DOB);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
        public int AddUserDetails(AddPat_BO AddPat_ObjBO) // passing Bussiness object Here 
        {

            try
            {



                SqlCommand cmd = new SqlCommand("EnrollPatient_SP", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@first_name", AddPat_ObjBO.FirstName);

                cmd.Parameters.AddWithValue("@last_name", AddPat_ObjBO.LastName);

                cmd.Parameters.AddWithValue("@date_of_birth", AddPat_ObjBO.DOB);

                cmd.Parameters.AddWithValue("@emailaddress", AddPat_ObjBO.Email);
                cmd.Parameters.AddWithValue("@contact_number", AddPat_ObjBO.ContactNO);
                cmd.Parameters.AddWithValue("@state_name", AddPat_ObjBO.state_name);
                cmd.Parameters.AddWithValue("@insurance_name", AddPat_ObjBO.insurance_name);

                con.Open();

                int Result = cmd.ExecuteNonQuery();


                cmd.Dispose();

                return Result;

            }

            catch
            {

                throw;

            }

        }
    }
}
