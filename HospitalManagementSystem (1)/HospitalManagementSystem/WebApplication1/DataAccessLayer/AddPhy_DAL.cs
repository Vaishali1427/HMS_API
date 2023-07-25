using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class AddPhy_DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

       
       
        public SqlDataAdapter view1(AddPhy_BO AddPhy_objBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayPhysicianID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fname", AddPhy_objBO.FirstName);
                cmd.Parameters.AddWithValue("@lname", AddPhy_objBO.LastName);
                cmd.Parameters.AddWithValue("@department", AddPhy_objBO.DepartmentName);
                con.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                con.Close();
                return da;
            }
            catch
            {
                throw;
            }

        }

        public SqlDataAdapter dept()
        {
            SqlCommand com = new SqlCommand("DepartmentDrop_SP", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Close();
            return da;
        }
        public SqlDataAdapter state()
        {
            SqlCommand com = new SqlCommand("StateNameDrop_SP", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Close();
            return da;
        }
        public SqlDataAdapter insurance()
        {
            SqlCommand com = new SqlCommand("InsuranceDrop_SP", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Close();
            return da;
        }
        public int AddUserDetails(AddPhy_BO AddPhy_ObjBO) // passing Bussiness object Here 
        {

            try
            {



                SqlCommand cmd = new SqlCommand("AddPhysician_SP", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", AddPhy_ObjBO.FirstName);

                cmd.Parameters.AddWithValue("@LastName", AddPhy_ObjBO.LastName);

                cmd.Parameters.AddWithValue("@department_name", AddPhy_ObjBO.DepartmentName);

                cmd.Parameters.AddWithValue("@educational_qualifications", AddPhy_ObjBO.EducationQualification);
                cmd.Parameters.AddWithValue("@years_of_experience", AddPhy_ObjBO.YearsOfExperience);
                cmd.Parameters.AddWithValue("@state_name", AddPhy_ObjBO.StateName);
                cmd.Parameters.AddWithValue("@insurance_name", AddPhy_ObjBO.InsurancePlan);

                con.Open();

                int Result = cmd.ExecuteNonQuery();


                cmd.Dispose();

                return Result;

            }

            catch
            {

                throw;

            }
            finally
            {
                con.Close();
            }

        }

    }
}
