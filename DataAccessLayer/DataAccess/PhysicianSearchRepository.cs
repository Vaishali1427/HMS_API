using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Data_Access_Layer.DataAccess
{
    public class PhysicianSearchRepository : IPhysicianSearchRepository
    {

        private readonly string connectionString;

        public PhysicianSearchRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        public List<string> GetInsurance()
        {
            try
            {
                List<string> plan_names = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand command = new SqlCommand("GetAllPhysicianInsurance", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {

                        string name = reader["InsurancePlan"].ToString();
                        plan_names.Add(name);
                    }
                }

                return (plan_names);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Department> GetDepartmentDetails()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
        }


        public Physician_Search GetPhysician(PhysicianSearchArguments physicianSearchArguments)
        {
            try
            {
                Physician_Search physician = null;





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();





                    SqlCommand command = new SqlCommand("GetPhysician", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InsurancePlan", physicianSearchArguments.InsurancePlan);
                    command.Parameters.AddWithValue("@Phy_State", physicianSearchArguments.State);
                    command.Parameters.AddWithValue("@Dept_Id", physicianSearchArguments.Dept_Id);
                    SqlDataReader reader = command.ExecuteReader();





                    if (reader.Read())
                    {
                        physician = new Physician_Search
                        {

                            Phy_Id = reader["Phy_Id"].ToString(),
                            Phy_Name = reader["Phy_Name"].ToString()


                        };
                    }





                    reader.Close();
                }

                    if (physician == null)
                    return null;

                return (physician);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
