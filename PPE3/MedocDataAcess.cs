using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class MedocDataAcess
    {
        private string connectionMedoc = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<MedocIncompatible> medocs = new List<MedocIncompatible>();

        public List<MedocIncompatible> getMedocListFromDB()
        {
            this.medocs.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionMedoc))
            {
                conn.Open();
                string query = "SELECT nom_medoc From medicament";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.medocs.Add(new MedocIncompatible(reader["nom_medoc"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return this.medocs;
        }

        public int addMedocToDB(Medoc medoc) {
            using (MySqlConnection conn = new MySqlConnection(connectionMedoc))
            {
                conn.Open();
                string query = "INSERT INTO medicament (nom_medoc) VALUES (@nomMedoc)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nomMedoc", medoc.NomMedoc);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
    }
}