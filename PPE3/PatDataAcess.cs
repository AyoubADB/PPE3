using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PPE3
{
    internal class PatDataAcess
    {
        private string connectionPat = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Pat> pats = new List<Pat>();


        public List<Pat> getPatFromDB()
        {
            this.pats.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionPat))
            {
                conn.Open();
                string query = "SELECT patient.nom_pat, prenom_pat, age_pat, sexe_pat, nom_all, nom_antec " +
                               "FROM patient " +
                               "LEFT JOIN etre ON patient.id_pat = etre.id_pat " +
                               "LEFT JOIN allergie ON etre.id_all = allergie.id_all " +
                               "LEFT JOIN avoir ON patient.id_pat = avoir.id_pat " +
                               "LEFT JOIN antecedent ON avoir.id_antec = antecedent.id_antec";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string NomPat = reader["nom_pat"].ToString();
                            string PrenomPat = reader["prenom_pat"].ToString();
                            int agePat = reader.GetInt32("age_pat");
                            string sexePat = reader["sexe_pat"].ToString();
                            string nom_all = reader["nom_all"].ToString();
                            string nom_antec = reader["nom_antec"].ToString();
                            Pat patient = new Pat(NomPat, PrenomPat, agePat, sexePat);

                            if (reader["nom_all"] != DBNull.Value)
                            {
                                string nomAllergie = reader["nom_all"].ToString();
                                All allergie = new All(nomAllergie);
                                patient.Allergie = patient.Allergie + "-  " + nomAllergie;
                            }

                            if (reader["nom_antec"] != DBNull.Value)
                            {
                                string nomAntecedent = reader["nom_antec"].ToString();
                                Antec antecedent = new Antec(nomAntecedent);
                                patient.Antecedent = patient.Antecedent + "-  " + nomAntecedent;
                            }

                            this.pats.Add(patient);
                        }
                    }
                }
                conn.Close();
            }
            return pats; 
        }


        public List<All> GetAllAjtPatDb()
        {
            List<All> allergies = new List<All>();

            using (MySqlConnection conn = new MySqlConnection(connectionPat))
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

        public List<Antec> GetAntecAjtPatDb()
        {
            List<Antec> antecedents = new List<Antec>();

            using (MySqlConnection conn = new MySqlConnection(connectionPat))
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

        public int addPatToDB(Pat pat)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionPat)) 
            { 
                conn.Open();
                string query = "INSERT INTO patient (nom_pat, prenom_pat, age_pat, sexe_pat) VALUES (@nomPat, @PrenomPat, @AgePat, @SexePat)";
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nomPat", pat.NomPat);
                    command.Parameters.AddWithValue("@PrenomPat", pat.PrenomPat);
                    command.Parameters.AddWithValue("@AgePat", pat.AgePat);
                    command.Parameters.AddWithValue("@SexePat", pat.SexePat);
                        
                    try
                    {
                        int result = command.ExecuteNonQuery();
                        conn.Close();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur SQL : " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        public int AddAllPatToDb(int IdPati, int IdAllerg)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionPat))
            {
                conn.Open();
                string query = "INSERT INTO etre (id_pat, id_all) VALUES (@IdPat, @IdAll)";
                using( MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdPat", IdPati);
                    command.Parameters.AddWithValue("@IdAll", IdAllerg);
                    int result = command.ExecuteNonQuery();
                    conn.Close() ;
                    return result;
                }
            }
        }

        public int AddAntecPatToDb(int IdPatient,int IdAntec)
        {
            using(MySqlConnection conn = new MySqlConnection( connectionPat))
            {
                conn.Open();
                string query = "INSERT INTO avoir (id_pat, id_antec) VALUES (@IdPat, @IdAntec)";
                using(MySqlCommand command = new MySqlCommand( query, conn))
                {
                    command.Parameters.AddWithValue("@IdPat", IdPatient);
                    command.Parameters.AddWithValue("@IdAntec", IdAntec);
                    int result = command.ExecuteNonQuery();
                    conn.Close() ;
                    return result;
                }
            }
        }

        public int AddAllDb(All all)
        {
            if (string.IsNullOrEmpty(all.NomAll))
            {
                // La valeur est nulle ou vide, vous pouvez gérer cela en conséquence.
                MessageBox.Show("Le champ 'nom_all' ne peut pas être vide.");
                return -1; // Ou tout autre code d'erreur que vous préférez
            }

            using ( MySqlConnection conn = new MySqlConnection(connectionPat))
            {
                conn.Open();
                string query = "INSERT INTO allergie (nom_all) VALUES (@NomAll)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NomAll", all.NomAll);
                    int result = command.ExecuteNonQuery();
                    conn.Close() ;
                    return result;
                }
            }
        }

        public int AddAntecDb(Antec antec)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionPat))
            {
                conn.Open();
                string query = "INSERT INTO antecedent (nom_antec) VALUES (@NomAntec)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NomAntec", antec.NomAntec);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int GetIdAllByName(string nomAllergie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionPat))
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

        public int GetIdAntecByName(string nomAntecedent)
        {
            using( MySqlConnection conn = new MySqlConnection(connectionPat)) 
            { 
                conn.Open();
                string query = "SELECT id_antec FROM antecedent WHERE nom_antec = @NomAntec";
                using ( MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NomAntec", nomAntecedent);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}
