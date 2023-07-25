using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Data; // Required for using Dataset , Datatable and Sql

using System.Data.SqlClient; // Required for Using Sql 

using System.Configuration; // for Using Connection From Web.config 

using BO;  // for acessing bussiness object class

using System.Web;

namespace DA
{

    public class PDD_DA
    {

        //SqlConnection con = new

        //SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        //SqlConnection con = new SqlConnection("Data Source=PC180135\\SQLEXPRESS;initial catalog=hms_db;user id=sa;password=password-1");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public int AddUserDetails(PDD_BO ObjBO) // passing Bussiness object Here 
        {

            try
            {

                /* Because We will put all out values from our (UserRegistration.aspx) 

                 To in Bussiness object and then Pass it to Bussiness logic and then to 

                 DataAcess
 
                 this way the flow carry on*/

                SqlCommand cmd = new SqlCommand("Add_PatientDiagnosis_SP", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@patient_id", ObjBO.physician_id);
                cmd.Parameters.AddWithValue("@diagnosis_id", ObjBO.diagnosisid);
                cmd.Parameters.AddWithValue("@symptoms", ObjBO.symptoms);
                cmd.Parameters.AddWithValue("@diagnosis_provided", ObjBO.diagnosisprovided);
                cmd.Parameters.AddWithValue("@administerd_by", ObjBO.physician);


                cmd.Parameters.AddWithValue("@date_of_diagnosis", ObjBO.dt.Date);
                cmd.Parameters.AddWithValue("@follow_up", ObjBO.followup);



                cmd.Parameters.AddWithValue("@date_of_follow_up", ObjBO.followupdate.Date);
                cmd.Parameters.AddWithValue("@card_number", ObjBO.card);
                cmd.Parameters.AddWithValue("@mode_of_payment", ObjBO.mode);

                cmd.Parameters.AddWithValue("@bil_amount", ObjBO.bill);

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
        public int check_dal(PDD_BO dhbel)
        {
            SqlCommand cmd = new SqlCommand("CheckPatient_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@patientid", dhbel.physician_id);
            con.Open();
            int r = (int)cmd.ExecuteScalar();
            con.Close();
            return r;
        }
        public SqlDataAdapter View(PDD_BO ObjBO)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("PhysicianName_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
              
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);


                return da;
            }
            catch
            {
                throw;
            }

        }
        //public DataTable AddPhyDetails(UserBO ObjBO) // passing Bussiness object Here 
        //{
            
        //    try
        //    {
        //        SqlCommand cm = new SqlCommand("retphy", con);

        //        cm.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(cm);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
       
    }

    }




