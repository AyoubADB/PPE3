using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPE3
{
    public partial class ajouterPat : Form
    {
        private string connectionAjtPat = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        PatDataAcess dataAcessPatAjt = new PatDataAcess();

        private bool mouseDown;
        private Point LastLocation;

        public ajouterPat()
        {
            InitializeComponent();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        private void ajouterPat_Load(object sender, EventArgs e)
        {
            RemplirComboBoxAge();
            RemplirComboBoxSexePat();
            afficherAllAjtPat();
            afficherAntecAjtPat();
        }

        private void RemplirComboBoxAge()
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBoxAgePat.Items.Add(i);
            }
        }

        private void RemplirComboBoxSexePat()
        {
            comboBoxSexePat.Items.Clear();

            comboBoxSexePat.Items.Add("M");
            comboBoxSexePat.Items.Add("F");
        }



        private void btnAjouterPat_Click(object sender, EventArgs e)
        {
            Pat pat = new Pat(this.textBox1.Text, this.textBox2.Text, Int32.Parse(this.comboBoxAgePat.Text), this.comboBoxSexePat.Text);
            int result = dataAcessPatAjt.addPatToDB(pat);
            if (result > 0)
            {
                int idPatient = ObtenirIdPat(pat.NomPat, pat.PrenomPat);

                int idAllergie = ObtenirIdAll();

                int idAntecedent = ObtenirIdAntec();

                if (idAllergie > 0)
                {
                    int resultEtre = dataAcessPatAjt.AddAllPatToDb(idPatient, idAllergie);
                    if (resultEtre <= 0)
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'allergie.");
                    }
                }

                if (idAntecedent > 0)
                {
                    int resultAvoir = dataAcessPatAjt.AddAntecPatToDb(idPatient, idAntecedent);
                    if (resultAvoir <= 0)
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'antécédent.");
                    }
                }

                MessageBox.Show("Patient ajouté avec succès");
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter le patient");
            }
        }

        private int ObtenirIdPat(string nom, string prenom)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionAjtPat))
            {
                conn.Open();
                string query = "SELECT LAST_INSERT_ID()";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private int ObtenirIdAll()
        {
            string nomAllergie = comboBoxAllAjtPat.SelectedItem?.ToString();
            return nomAllergie != null ? dataAcessPatAjt.GetIdAllByName(nomAllergie) : -1;
        }

        private int ObtenirIdAntec()
        {
            string nomAntecedent = comboBoxAntecAjtPat.SelectedItem?.ToString();
            return nomAntecedent != null ? dataAcessPatAjt.GetIdAntecByName(nomAntecedent) : -1;
        }

        public void afficherAllAjtPat()
        {
            List<All> allergie = dataAcessPatAjt.GetAllAjtPatDb();


            comboBoxAllAjtPat.DataSource = allergie;
        }

        public void afficherAntecAjtPat()
        {
            List<Antec> antecedent = dataAcessPatAjt.GetAntecAjtPatDb();

            comboBoxAntecAjtPat.DataSource = antecedent;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAgePat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSexePat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAllAjtPat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxAntecAjtPat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAjouterAllAntec_Click(object sender, EventArgs e)
        {
            AjouterAllAntec ShowAjouterAllAntec = new AjouterAllAntec();
            ShowAjouterAllAntec.ShowDialog();
        }
        private void btnAnnulerPat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            LastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X,
                    (this.Location.Y - LastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
