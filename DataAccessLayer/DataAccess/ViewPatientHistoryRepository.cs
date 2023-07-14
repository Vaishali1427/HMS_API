using Data_Access_Layer.Contracts;
using Data_Access_Layer.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Data_Access_Layer.DataAccess
{
    public class ViewPatientHistoryRepository : IViewPatientHistoryRepository
    {
        private readonly string connectionString;

        public ViewPatientHistoryRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<string> GetSymptoms()
        {
            try
            {
                List<string> symptoms = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand command = new SqlCommand("GetSymptoms", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {

                        string symptom = reader["Symptoms"].ToString();
                        symptoms.Add(symptom);
                    }

                    reader.Close();
                }

                if (symptoms == null)

                    return null;

                return (symptoms);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<view_patient_history> GetPatientHistory()
        {
            try
            {
                List<view_patient_history> patient_Histories = new List<view_patient_history>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand command = new SqlCommand("ViewPatientHistory", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();





                    while (reader.Read())
                    {
                        view_patient_history patient_History = new view_patient_history
                        {
                            Patient_Id = Convert.ToInt32(reader["Patient_Id"]),
                            firstname = reader["firstname"].ToString(),
                            lastname = reader["lastname"].ToString(),
                            Phy_Id = reader["Phy_Id"].ToString()
                        };

                        patient_Histories.Add(patient_History);
                    }

                    reader.Close();
                }


                return (patient_Histories);
            }
            catch (Exception)
            {
                throw;
            }
        }
            
        

    }
}
