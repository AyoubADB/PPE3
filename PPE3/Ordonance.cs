using iTextSharp.text;
using iTextSharp.text.pdf;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace PPE3
{
    public partial class Ordonance : Form
    {
        private OrdoDataAcesscs dataAcessPatOrdo = new OrdoDataAcesscs();

        private bool mouseDown;
        private Point LastLocation;

        public Ordonance()
        {
            InitializeComponent();
            afficherNomPatOrdo();
            afficherNomMedcOrdo();
            afficherNomMedocOrdo();
            afficherNomMedocFacultOrdo();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        public void afficherNomPatOrdo()
        {
            List<PatOrdo> patients = dataAcessPatOrdo.GetNomPatOrdoDb();

            comboBoxNomPatOrdo.DataSource = patients;
        }

        public void afficherNomMedocOrdo()
        {
            List<Medoc> medicament = dataAcessPatOrdo.GetNomMedocOrdoDb();

            comboBoxMedocOrdo.DataSource = medicament;
            comboBoxMedocOrdo.DisplayMember = "NonMedoc";
        }

        public void afficherNomMedocFacultOrdo()
        {
            List<Medoc> medicament = dataAcessPatOrdo.GetNomMedocOrdoDb();

            List<Medoc> medicamentsAvecVide = new List<Medoc>();

            medicamentsAvecVide.Add(new Medoc { MedicamentId = -1, NomMedoc = "" });

            medicamentsAvecVide.AddRange(medicament);

            comboBoxMedocFacultative.DataSource = medicamentsAvecVide;
            comboBoxMedocFacultative.DisplayMember = "NonMedoc";
        }

        public void afficherNomMedcOrdo()
        {
            List<Medc> medecins = dataAcessPatOrdo.GetMedcOrdoDb();

            comboBoxMedcOrdo.DataSource = medecins;
        }

        private int GetSelectedPatientId()
        {
            PatOrdo selectedPatient = (PatOrdo)comboBoxNomPatOrdo.SelectedItem;
            return selectedPatient != null ? selectedPatient.PatientId : -1;
        }

        private int GetSelectedMedecinId()
        {
            Medc selectedMedecin = (Medc)comboBoxMedcOrdo.SelectedItem;
            return selectedMedecin != null ? selectedMedecin.MedecinId : -1;
        }

        private int GetSelectedMedocId()
        {
            Medoc selectedMedoc = (Medoc)comboBoxMedocOrdo.SelectedItem;
            return selectedMedoc != null ? selectedMedoc.MedicamentId : -1;
        }

        private int GetSelectedMedocFacultativeId()
        {
            Medoc selectedMedocFacultative = (Medoc)comboBoxMedocFacultative.SelectedItem;
            return selectedMedocFacultative != null ? selectedMedocFacultative.MedicamentId : -1;
        }

        private void comboBoxNomPatOrdo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxMedcOrdo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMedocOrdo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxPosologie_TextChanged(object sender, EventArgs e)
        {
            richTextBoxPosologie.ForeColor = Color.White;
        }

        private void richTextBoxInstruction_TextChanged(object sender, EventArgs e)
        {
            richTextBoxInstruction.ForeColor = Color.White;
        }

        private void dateDebTrait_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateFinTrait_ValueChanged(object sender, EventArgs e)
        {
        }


        private void btnAjtOrdo_Click(object sender, EventArgs e)
        {
            try
            {
                string posologie = richTextBoxPosologie.Text;
                string instruction = richTextBoxInstruction.Text;
                DateTime debutTraitement = dateDebTrait.Value;
                DateTime finTraitement = dateFinTrait.Value;


                int dureeTraitement = (int)(finTraitement - debutTraitement).TotalDays;


                int idPatient = GetSelectedPatientId();
                int idMedecin = GetSelectedMedecinId();
                int idMedoc = GetSelectedMedocId();
                int idMedocFacult = GetSelectedMedocFacultativeId();

                Ordo newOrdo = new Ordo(posologie, dureeTraitement.ToString(), instruction);

                List<All> allergiesPatient = dataAcessPatOrdo.GetAllergiesPatient(idPatient);
                if (dataAcessPatOrdo.IncompatibleWithAllergies(idMedoc, allergiesPatient))
                {
                    MessageBox.Show("Le patient est allergique à ce médicament. Impossible d'ajouter l'ordonnance.");
                    return;
                }

                List<Antec> antecedentsPatient = dataAcessPatOrdo.GetAntecedentsPatient(idPatient);
                if (dataAcessPatOrdo.IncompatibleWithAntecedents(idMedoc, antecedentsPatient))
                {
                    MessageBox.Show("Le patient a des antécédents incompatibles avec ce médicament. Impossible d'ajouter l'ordonnance.");
                    return;
                }



                int result = dataAcessPatOrdo.AddOrdoToDb(newOrdo, idPatient, idMedecin, idMedoc, idMedocFacult);

                if (result > 0)
                {
                    MessageBox.Show("Ordonnance ajoutée avec succès !");

                    int idOrdonnance = dataAcessPatOrdo.GetLastInsertedOrdoId();

                    GenererPDF(newOrdo, idOrdonnance);
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'ordonnance.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void GenererPDF(Ordo ordo, int idOrdonnance)
        {
            string outfile = Environment.CurrentDirectory + "/Ordonance.pdf";
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream(outfile, FileMode.Create));


            doc.Open();

            //Palette de couleur 
            BaseColor bleu = new BaseColor(0, 75, 155);
            BaseColor gris = new BaseColor(240, 240, 240);
            BaseColor blanc = new BaseColor(255, 255, 255);

            // Police d'écriture 
            iTextSharp.text.Font Titre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, bleu);

            //Page PDF 
            Paragraph PNomPat = new Paragraph($"Nom patient : " + comboBoxNomPatOrdo.Text); ;
            Paragraph PNomMedc = new Paragraph($"Nom Medecin : " + comboBoxMedcOrdo.Text);
            Paragraph PNomMedoc = new Paragraph($"Nom Medicament : " + comboBoxMedocOrdo.Text );
            Paragraph PNomMedocFacult = new Paragraph($"Nom du 2ème Médicament : " + comboBoxMedocFacultative.Text + "\n\n\n\n\n");
            Paragraph PDureeTraitement = new Paragraph($"Durée de traitement : {ordo.DureeTraitement} jours" + "\n\n");
            Paragraph PPosologie = new Paragraph($"Posologie : {ordo.PosologieOrdo} jours" + "\n\n");
            Paragraph PInstruction = new Paragraph($"Instruction : {ordo.InstructionOrdo}");

            PNomPat.Alignment = Element.ALIGN_LEFT;
            PNomMedc.Alignment = Element.ALIGN_RIGHT;
            PNomMedoc.Alignment = Element.ALIGN_LEFT;
            PNomMedocFacult.Alignment = Element.ALIGN_RIGHT;
            PDureeTraitement.Alignment = Element.ALIGN_CENTER;
            PPosologie.Alignment = Element.ALIGN_CENTER;
            PInstruction.Alignment = Element.ALIGN_CENTER;

            doc.Add(PNomPat);
            doc.Add(PNomMedc);
            doc.Add(PNomMedoc);
            doc.Add(PNomMedocFacult);
            doc.Add(PDureeTraitement);
            doc.Add(PPosologie);
            doc.Add(PInstruction);

            doc.Close();
            Process.Start(@"cmd.exe", @"/c" + outfile);

            MessageBox.Show($"PDF généré avec succès : {outfile}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBoxPosologie_Click(object sender, EventArgs e)
        {
            richTextBoxPosologie.SelectAll();
        }

        private void richTextBoxInstruction_Click(object sender, EventArgs e)
        {
            richTextBoxInstruction.SelectAll();
        }
    }
}
