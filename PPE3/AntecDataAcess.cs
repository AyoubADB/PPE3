using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class AntecDataAcess
    {
        private string connectionAntec = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Antec> antecs = new List<Antec>();

        public List<Antec> getAntecedentByPatientId(int IdPat)
        {
            List<Antec> antecedents = new List<Antec>();

            using (MySqlConnection conn = new MySqlConnection(connectionAntec))
            {
                conn.Open();

                string query = "SELECT antecedent.nom_antec FROM avoir " +
                               "INNER JOIN antecedent ON avoir.id_antec = antecedent.id_antec " +
                               "WHERE avoir.id_pat = @IdPat";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdPat", IdPat);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.antecs.Add(new Antec(reader["nom_antec"].ToString()));
                        }
                    }
                }

                conn.Close();
            }

            return antecs;
        }
    }
}

