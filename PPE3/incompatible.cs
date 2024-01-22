using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class incompatible : Form
    {
        IncDataAcess dataAcessInc = new IncDataAcess();

        private bool mouseDown;
        private Point LastLocation;

        public incompatible()
        {
            InitializeComponent();
            afficherIncAntec();
            afficherIncMedoc();
            afficherIncAll();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        private void comboBoxMedocInc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void afficherIncAll()
        {
            List<All> allergie = dataAcessInc.GetIncAllDb();

            comboBoxAllInc.DataSource = allergie;
        }

        public void afficherIncAntec()
        {
            List<Antec> antecedent = dataAcessInc.GetIncAntecDb();

            comboBoxAntecInc.DataSource = antecedent;
        }

        public void afficherIncMedoc()
        {
            List<Medoc> medicament = dataAcessInc.GetIncMedocDb();

            comboBoxMedocInc.DataSource = medicament;
        }

        private int? ObtenirIdAllInc()
        {
            string nomAllergie = comboBoxAllInc.SelectedItem?.ToString();
            return nomAllergie != null ? dataAcessInc.GetIdAllByNameInc(nomAllergie) : null;
        }

        private int? ObtenirIdAntecInc()
        {
            string nomAntecedent = comboBoxAntecInc.SelectedItem?.ToString();
            return nomAntecedent != null ? dataAcessInc.GetIdAntecByNameInc(nomAntecedent) : null;
        }

        private int? ObtenirIdMedocInc()
        {
            string nomMedicament = comboBoxMedocInc.SelectedItem?.ToString();
            return nomMedicament != null ? dataAcessInc.GetIdMedocByNameInc(nomMedicament) : null;
        }

        private void btnAjtInc_Click(object sender, EventArgs e)
        {

            try
            {
                int idMedoc = (int)ObtenirIdMedocInc();

                if (idMedoc != -1)
                {
                    int idAll = (int)ObtenirIdAllInc();
                    int idAntec = (int)ObtenirIdAntecInc();

                    if (dataAcessInc.IsIncExist(idAll, idAntec, idMedoc))
                    {
                        MessageBox.Show("L'incompatibilité existe déjà dans la base de données.");
                    }
                    else
                    {
                        int result = dataAcessInc.AddIncompatibleToDb(idAll, idAntec, idMedoc);

                        if (result > 0)
                        {
                            MessageBox.Show("Incompatibilité ajoutée avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'ajout de l'incompatibilité.");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Veuillez sélectionner un médicament.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void comboBoxAllInc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void incompatible_Load(object sender, EventArgs e)
        {

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
