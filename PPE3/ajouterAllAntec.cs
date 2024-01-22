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
    public partial class AjouterAllAntec : Form
    {
        PatDataAcess dataAcessPatAjtAllAntec = new PatDataAcess();

        public AjouterAllAntec()
        {
            InitializeComponent();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            All all = new All(this.textBoxAjtAll.Text);
            int result = dataAcessPatAjtAllAntec.AddAllDb(all);
            if (result > 0)
            {
                MessageBox.Show("L'allergie " + this.textBoxAjtAll.Text + "à été ajouter");

            }
            else
            {
                MessageBox.Show("L'allergie n'a pas pu être ajouter");
            }
        }

        private void btnAddAntec_Click(object sender, EventArgs e)
        {
            Antec antec = new Antec(this.textBoxAjtAntec.Text);
            int result = dataAcessPatAjtAllAntec.AddAntecDb(antec);
            if (result > 0)
            {
                MessageBox.Show("L'antécédent " + this.textBoxAjtAntec.Text + " à été ajouter");
            }
            else
            {
                MessageBox.Show("L'antécédent n'a pas pu être ajouter");
            }
        }

        private void textBoxAjtAll_TextChanged(object sender, EventArgs e)
        {
            textBoxAjtAll.ForeColor = Color.White;
        }

        private void textBoxAjtAntec_TextChanged(object sender, EventArgs e)
        {
            textBoxAjtAntec.ForeColor = Color.White;
        }

        private void textBoxAjtAll_Click(object sender, EventArgs e)
        {
            textBoxAjtAntec.SelectAll();
        }

        private void textBoxAjtAntec_Click(object sender, EventArgs e)
        {
            textBoxAjtAntec.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
