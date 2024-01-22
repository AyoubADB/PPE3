using Org.BouncyCastle.Math.EC;
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
    public partial class Patient : Form
    {
        private PatDataAcess dataAcessPat = new PatDataAcess();
        private bool mouseDown;
        private Point LastLocation;

        public Patient()
        {
            InitializeComponent();
            affichageDataGrid();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        private void dataGridViewPat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        public void affichageDataGrid()
        {
            this.dataGridViewPat.DataSource = null;
            this.dataGridViewPat.DataSource = dataAcessPat.getPatFromDB();
        }

        private void btnAjouterPat_Click(object sender, EventArgs e)
        {
            ajouterPat showAjouterPat = new ajouterPat();
            showAjouterPat.ShowDialog();
        }

        private void btnRefreshPat_Click(object sender, EventArgs e)
        {
            RefreshDataGridPat();
        }

        public void RefreshDataGridPat()
        {


            List<Pat> patList = dataAcessPat.getPatFromDB();

            if (patList != null && patList.Count > 0)
            {
                dataGridViewPat.DataSource = null;
                dataGridViewPat.DataSource = patList;
            }
            else
            {
                MessageBox.Show("Aucun patient trouvé dans la base de données.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
