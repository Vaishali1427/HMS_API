
using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;
using Microsoft.Extensions.Configuration;
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
            try
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
            catch (Exception)
            {
                throw;
            }
        }

        public string GetInsuranceDetails(int id)
        {
            try {
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
            catch (Exception)
            {
                throw;
            }
        }
        

        public string UpdateInsuranceDetails(int id, Patient_Enroll insurance)
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    /*SqlCommand checkCommand = new SqlCommand("Select count(*) from patient_enroll where patient_id = @Patient_id",connection);
                    checkCommand.Parameters.AddWithValue("Patient_id", id);
                    int patientCount = (int)checkCommand.ExecuteScalar();
                    if (patientCount == 0)
                        return "Patient id does not exsists";*/
                    SqlCommand command = new SqlCommand("UpdateeInsurance", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Patient_Id", id);
                    command.Parameters.AddWithValue("@Insurance", insurance.Insurance);
                    command.ExecuteNonQuery();
                    return "Insurance Updated Successfully";
/*                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        PatientId = Convert.ToInt32(reader["Patient_Id"]);
                        reader.Close();
                        if (PatientId == 0)
                        {
                            return "Not Found";
                        }
                        return "Insurance Plan has been updated";
                    }*/
                   



                }

            }
            catch (Exception)
            {
                throw;
            }

            

        }
            

    }
}
