using Data_Access_Layer.Models;
using Data_Access_Layer.Contracts;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;


namespace Data_Access_Layer.DataAccess
{
    public class PatientDiagnosisDetailsRepository : IPatientDiagnosisDetailsRepository
    {
        private readonly string connectionString;

        public PatientDiagnosisDetailsRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public string AddDiagnosisDetails(Patient_Diagnosis physician)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("AddDiagnosisDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Patient_Id", physician.Patient_Id);
                    command.Parameters.AddWithValue("@Diagnosis_Id", physician.Diagnosis_Id);
                    command.Parameters.AddWithValue("@Symptoms", physician.Symptoms);
                    command.Parameters.AddWithValue("@Diagnosis_Provided", physician.Diagnosis_Provided);
                    command.Parameters.AddWithValue("@Physician_Visited", physician.Physician_Visited);
                    command.Parameters.AddWithValue("@Date_of_diag", physician.Date_of_diag);
                    command.Parameters.AddWithValue("@Followup_Req", physician.Followup_Req);
                    command.Parameters.AddWithValue("@Follow_Date", physician.Follow_Date);
                    command.Parameters.AddWithValue("@Bill_Amt", physician.Bill_Amt);
                    command.Parameters.AddWithValue("@Card_No", physician.Card_No);
                    command.Parameters.AddWithValue("@Mode_of_Pay", physician.Mode_of_Pay);
                    command.ExecuteNonQuery();
                }

                return "Details added successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> GetPhysicianVisitedDetails()
        {
            try
            {
                List<string> physicians_visited = new();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetPhysicianVisitedDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {

                        string physician_visited = reader["Physician_Visited"].ToString();
                        physicians_visited.Add(physician_visited);
                    }

                    reader.Close();
                }

                if (physicians_visited == null)

                    return null;

                return (physicians_visited);
            }
            catch (Exception)
            {
                throw;
            }
        }

    
    }
}
