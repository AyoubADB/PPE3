using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class IncDataAcess
    {
        private string connectionInc = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public List<All> GetIncAllDb()
        {
            List<All> allergies = new List<All>();

            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT allergie.nom_all FROM allergie";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        allergies.Add(new All { NomAll = "" });
                        while (reader.Read())
                        {
                            All allergie = new()
                            {
                                NomAll = reader["nom_all"].ToString(),
                            };

                            allergies.Add(allergie);
                        }
                    }
                    conn.Close();
                }
            }
            return allergies;
        }

        public List<Antec> GetIncAntecDb()
        {
            List<Antec> antecedents = new List<Antec>();

            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT antecedent.nom_antec FROM antecedent";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        antecedents.Add(new Antec { NomAntec = "" });
                        while (reader.Read())
                        {
                            Antec antecedent = new()
                            {
                                NomAntec = reader["nom_antec"].ToString(),
                            };

                            antecedents.Add(antecedent);
                        }
                    }
                    conn.Close();
                }
            }
            return antecedents;
        }

        public List<Medoc> GetIncMedocDb()
        {
            List<Medoc> medicaments = new List<Medoc>();

            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT medicament.id_medoc, nom_medoc FROM medicament";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        medicaments.Add(new Medoc { NomMedoc = "" });
                        while (reader.Read())
                        {
                            Medoc medicament = new()
                            {
                                MedicamentId = Convert.ToInt32(reader["id_medoc"]),
                                NomMedoc = reader["nom_medoc"].ToString()
                            };

                            medicaments.Add(medicament);
                        }
                    }
                    conn.Close();
                }
            }

            return medicaments;
        }

        public int GetIdAllByNameInc(string nomAllergie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT id_all FROM allergie WHERE nom_all = @NomAll";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NomAll", nomAllergie);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public int GetIdAntecByNameInc(string nomAntecedent)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT id_antec FROM antecedent WHERE nom_antec = @NomAntec";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NomAntec", nomAntecedent);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public int GetIdMedocByNameInc(string nomMedicament)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT id_medoc FROM medicament WHERE nom_medoc = @NomMedoc";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NomMedoc", nomMedicament);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public int AddIncompatibleToDb(int IdAll, int IdAntec, int IdMedoc)
        {
            if (IsIncExist(IdAll, IdAntec, IdMedoc))
            {
                MessageBox.Show("L'incompatibilité existe déjà dans la base de données.");
                return -1;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "INSERT INTO incompatible (id_all, id_antec, id_medoc) VALUE (@IdAll, @IdAntec, @IdMedoc)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdAll", IdAll);
                    command.Parameters.AddWithValue("@IdAntec", IdAntec);
                    command.Parameters.AddWithValue("@IdMedoc", IdMedoc);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public bool IsIncExist(int IdAll, int IdAntec, int IdMedoc)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionInc))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM incompatible WHERE id_all = @IdAll AND id_antec = @IdAntec AND id_medoc = @IdMedoc";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdAll", IdAll);
                    command.Parameters.AddWithValue("@IdAntec", IdAntec);
                    command.Parameters.AddWithValue("@IdMedoc", IdMedoc);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
