using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class ajouterMedoc : Form
    {
        private MedocDataAcess dataAccessMedocAjt = new MedocDataAcess();
        private bool mouseDown;
        private Point LastLocation;

        public ajouterMedoc()
        {
            InitializeComponent();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Medoc medoc = new Medoc(this.textBox1.Text);
            //dataAccess.addDrug(drug);
            int result = dataAccessMedocAjt.addMedocToDB(medoc);
            if (result == 0)
            {
                MessageBox.Show("Impossible d'ajouter le médicament");
            }
            else if (result > 0)
            {
                MessageBox.Show("Le Medicament : " + this.textBox1.Text + " à bien été ajouté");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
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

        private void annuleAjoutMedoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
