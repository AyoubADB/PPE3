using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PPE3
{
    internal class OrdoDataAcesscs
    {
        private string connectionOrdo = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;


        public List<PatOrdo> GetNomPatOrdoDb()
        {
            List<PatOrdo> patients = new List<PatOrdo>();

            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open ();
                string query = "SELECT patient.id_pat, nom_pat, prenom_pat FROM patient";
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatOrdo patient = new()
                            {
                                PatientId = Convert.ToInt32(reader["id_pat"]),
                                NomPatOrdo = reader["nom_pat"].ToString(),
                                PrenomPatOrdo = reader["prenom_pat"].ToString()
                            };
                            
                            patients.Add(patient);
                        }
                    }
                    conn.Close ();
                }
            }

            return patients;
        }


        public List<Medoc> GetNomMedocOrdoDb()
        {
            List<Medoc> medicaments = new List<Medoc>();

            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();
                string query = "SELECT medicament.id_medoc, nom_medoc FROM medicament";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
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


        public List<Medc> GetMedcOrdoDb ()
        {
            List<Medc> medecins = new List<Medc>();

            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();
                string query = "SELECT medecin.id_medc, nom_medc, prenom_medc FROM medecin";
                using (MySqlCommand command = new MySqlCommand( query, conn))
                {
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medc medecin = new()
                            {
                                MedecinId = Convert.ToInt32(reader["id_medc"]),
                                NomMedc = reader["nom_medc"].ToString(),
                                PrenomMedc = reader["prenom_medc"].ToString()
                            };

                            medecins.Add(medecin);
                        }
                    }
                    conn.Close();
                }
            }
            return medecins;
        }

        public int AddOrdoToDb(Ordo ordo, int idPatient, int idMedecin, int idMedoc)
        {
            List<All> allergiesPatient = GetAllergiesPatient(idPatient);
            if (IncompatibleWithAllergies(idMedoc, allergiesPatient))
            {
                MessageBox.Show("Le patient est allergique à ce médicament. Impossible d'ajouter l'ordonnance.");
                return -1;
            }

            List<Antec> antecedentsPatient = GetAntecedentsPatient(idPatient);
            if (IncompatibleWithAntecedents(idMedoc, antecedentsPatient))
            {
                MessageBox.Show("Le patient a des antécédents incompatibles avec ce médicament. Impossible d'ajouter l'ordonnance.");
                return -1;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionOrdo)) 
            {
                conn.Open();

                string query = "INSERT INTO ordonnance (posologie_ordo, duree_traitement_ordo, instruction_ordo, id_pat, id_medc, id_medoc) " +
                               "VALUE (@Posologie, @DureeTraitement, @Instruction, @IdPatient, @IdMedecin, @IdMedoc)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Posologie", ordo.PosologieOrdo);
                    command.Parameters.AddWithValue("@DureeTraitement", ordo.DureeTraitement);
                    command.Parameters.AddWithValue("@Instruction", ordo.InstructionOrdo);
                    command.Parameters.AddWithValue("@IdPatient", idPatient);
                    command.Parameters.AddWithValue("@IdMedecin", idMedecin);
                    command.Parameters.AddWithValue("@IdMedoc", idMedoc);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }

            }
        }

        public int GetLastInsertedOrdoId()
        {
            int lastInsertedId = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();

                string query = "SELECT LAST_INSERT_ID() as id_ordo";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("id_ordo")))
                            {
                                lastInsertedId = reader.GetInt32("id_ordo");
                            }
                        }
                    }
                }

                conn.Close();
            }

            return lastInsertedId;
        }

        public List<All> GetAllergiesPatient(int idPatient)
        {
            List<All> allergies = new List<All>();
            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();
                string query = "SELECT id_all FROM etre WHERE id_pat = @IdPatient";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdPatient", idPatient);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idAll = Convert.ToInt32(reader["id_all"]);

                            All all = new All { IdAll = idAll };

                            allergies.Add(all);
                        }
                    }
                }
            }
            return allergies;
        }

        public List<Antec> GetAntecedentsPatient(int idPatient)
        {
            List<Antec> antecedents = new List<Antec>();
            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();
                string query = "SELECT id_antec FROM avoir WHERE id_pat = @IdPatient";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdPatient", idPatient);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idAntec = Convert.ToInt32(reader["id_antec"]);

                            Antec antec = new Antec { IdAntec = idAntec };

                            antecedents.Add(antec);
                        }
                    }
                }
            }
            return antecedents;
        }

        public bool IncompatibleWithAllergies(int idMedicament, List<All> allergies)
        {
            // Vérifier l'incompatibilité avec les allergies
            foreach (All allergy in allergies)
            {
                int idAllergie = allergy.IdAll;
                if (IsMedicamentIncompatibleWithAllergie(idMedicament, idAllergie))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsMedicamentIncompatibleWithAllergie(int idMedicament, int idAllergie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM incompatible WHERE id_medoc = @IdMedicament AND id_all = @IdAllergie";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdMedicament", idMedicament);
                    command.Parameters.AddWithValue("@IdAllergie", idAllergie);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool IncompatibleWithAntecedents(int idMedicament, List<Antec> antecedents)
        {
            foreach (Antec antec in antecedents)
            {
                int idAntecedent = antec.IdAntec;
                if (IsMedicamentIncompatibleWithAntecedent(idMedicament, idAntecedent))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsMedicamentIncompatibleWithAntecedent(int idMedicament, int idAntecedent)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionOrdo))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM incompatible WHERE id_medoc = @IdMedicament AND id_antec = @IdAntecedent";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdMedicament", idMedicament);
                    command.Parameters.AddWithValue("@IdAntecedent", idAntecedent);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
