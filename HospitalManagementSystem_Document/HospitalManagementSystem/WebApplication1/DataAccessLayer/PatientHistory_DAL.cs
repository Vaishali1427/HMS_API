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
    public class PatientHistory_DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public SqlDataAdapter view1(PatientHistory_BO ObjBO)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("UsingPatientIDs_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@patient_id", ObjBO.patient_id);
                    cmd.Parameters.AddWithValue("@symptom", ObjBO._symptom);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    return da;
                 
            }
            catch
            {
                throw;
            }
        }
        public SqlDataAdapter view2(PatientHistory_BO ObjBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UsingFnameLnames_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fname", ObjBO.Fname);
                cmd.Parameters.AddWithValue("@lname", ObjBO.lname);
                cmd.Parameters.AddWithValue("@symptom", ObjBO.symptom);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                return da;
            }
            catch
            {
                throw;
            }
        }

        public SqlDataAdapter View(PatientHistory_BO ObjBO)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Symptom_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patient_id", ObjBO.patient_id);
                cmd.Parameters.AddWithValue("@fname", ObjBO.Fname);
                cmd.Parameters.AddWithValue("@lname", ObjBO.lname);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);


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
