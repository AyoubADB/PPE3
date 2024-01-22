using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class AllDataAcess
    {
        private string connectionAll = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<All> alls = new List<All>();

        public List<All> getAlergiesByPatientId(int IdPat)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionAll))
            {
                conn.Open();

                string query = "SELECT allergie.nom_all FROM etre " +
                               "INNER JOIN allergie ON etre.id_all = allergie.id_all " +
                               "WHERE etre.id_pat = @IdPat";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdPat", IdPat);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.alls.Add(new All(reader["nom_all"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return alls;
        }
    }
}
