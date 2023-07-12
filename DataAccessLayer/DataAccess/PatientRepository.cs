
using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.DataAccess
{
    public class PatientRepository : IPatientRepository
    {
        private readonly string connectionString;

        public PatientRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        public string AddPatientDetails(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();



                // Create and execute the SQL command to insert the patient details
                SqlCommand command = new SqlCommand("AddPatient", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Patient_Id", patient.Patient_Id);
                command.Parameters.AddWithValue("@Patient_Fname", patient.FirstName);
                command.Parameters.AddWithValue("@Patient_Lname", patient.LastName);
                command.Parameters.AddWithValue("@Patient_Dob", patient.DateOfBirth);
                command.Parameters.AddWithValue("@Patient_Email", patient.Email);
                command.Parameters.AddWithValue("@Patient_Contact", patient.PhoneNo);
                command.Parameters.AddWithValue("@Patient_State", patient.State);
                command.Parameters.AddWithValue("@Insurance", patient.Insurance);



                command.ExecuteNonQuery();



                // Return a success response
                return "Patient details added successfully.";
            }
        }

        public string GetInsuranceDetails(int id)
        {
            string insurance = null;



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetInsurance", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Patient_Id", id);
                SqlDataReader reader = command.ExecuteReader();



                if (reader.Read())
                {
                    insurance = reader["Insurance"].ToString();

                }

                    reader.Close();
            }



            if (insurance == null)
                return "Not Found";



            return (insurance);
        }

        public string UpdateInsuranceDetails(int id, Patient_Enroll insurance)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {



                connection.Open();


                SqlCommand command = new SqlCommand("UpdateInsurance", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Patient_Id", id);
                command.Parameters.AddWithValue("@Insurance", insurance.Insurance);
                command.ExecuteNonQuery();
            }



            return "Insurance Plan has been updated";
        }

    }
}
