using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BusinessObject;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class LogIn_DAL
    {
        int result = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public int LogIn(LogIn_BEL belUlogin)
        {
            SqlCommand cmd = new SqlCommand("userlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Userid", belUlogin.Userid);
            cmd.Parameters.AddWithValue("@Password", belUlogin.Password);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            result = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            return result;
        }
    }
}


