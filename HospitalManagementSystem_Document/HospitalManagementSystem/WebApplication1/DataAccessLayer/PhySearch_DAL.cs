using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace DataAccessLayer
{
    public class PhySearch_DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
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

        public SqlDataAdapter View(PhySearch_BO PhySearch_dalObjBO)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("PhysicianSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@department_name", PhySearch_dalObjBO.DepartmentName);
                cmd.Parameters.AddWithValue("@state_name", PhySearch_dalObjBO.StateName);
                cmd.Parameters.AddWithValue("@insurance_name", PhySearch_dalObjBO.InsurancePlan);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                if (da == null)
                {
                    return null;
                }
                else
                    return da;
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
