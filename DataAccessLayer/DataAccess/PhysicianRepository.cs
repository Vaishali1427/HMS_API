using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data_Access_Layer.Models;
using System.Xml.Linq;
using Data_Access_Layer.Contracts;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Data_Access_Layer.DataAccess
{
    public class PhysicianRepository : IPhysicianRepository
    {
        private readonly string connectionString;

        public PhysicianRepository(IConfiguration configuration) 
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        public List<Department> GetDepartmentDetails()
        {
            List<Department> departments = new List<Department>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                SqlCommand command = new SqlCommand("GetDepartment", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Department department = new Department
                    {

                        Dept_Id = reader["Dept_Id"].ToString(),
                        Dept_Name = reader["Dept_Name"].ToString()
                    };

                departments.Add(department);
                }

            reader.Close();
            }

           return (departments);
        }



        public string AddPhysician(Physician_Enroll physician)

        {

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                connection.Open();

                SqlCommand command = new SqlCommand("AddPhysicianDetails", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Phy_Id", physician.Phy_Id);

                command.Parameters.AddWithValue("@Phy_Fname", physician.Phy_Fname);

                command.Parameters.AddWithValue("@Phy_Lname", physician.Phy_Lname);

                command.Parameters.AddWithValue("@Dept_Id", physician.Dept_Id);

                command.Parameters.AddWithValue("@Phy_Exp", physician.Phy_Exp);

                command.Parameters.AddWithValue("@Phy_State", physician.Phy_State);

                command.Parameters.AddWithValue("@InsurancePlan", physician.InsurancePlan);

                command.ExecuteNonQuery();



            }

                return "Physician data added successfully";


        }


        public string UpdateDepartmentdetails(string DeptName, Department department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();





               
                SqlCommand command = new SqlCommand("UpdateDepartmentDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Dept_Id", department.Dept_Id);
                command.Parameters.AddWithValue("@Search", DeptName);
                command.Parameters.AddWithValue("@Dept_Name", department.Dept_Name);
                command.ExecuteNonQuery();
            }





            return "Department details has been updated successfully";
        }

        public string GetInsurance(string id)
        {
            string insurance = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                ;
                SqlCommand command = new SqlCommand("GetPhysicianInsurance", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Phy_Id", id);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    insurance = reader["InsurancePlan"].ToString();
                }

                reader.Close();
            }

            if (insurance == null)
                return "Not Found";



            return (insurance);
        }


    }
}
