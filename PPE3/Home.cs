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
    public partial class Home : Form
    {
        private bool mouseDown;
        private Point LastLocation;

        public Home()
        {
            InitializeComponent();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }


        private void btnMedicament_Click(object sender, EventArgs e)
        {
            Medicament ShowMedicament = new Medicament();
            ShowMedicament.Show();
        }
        private void btnPat_Click(object sender, EventArgs e)
        {
            Patient ShowPatient = new Patient();
            ShowPatient.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdonance_Click(object sender, EventArgs e)
        {
            Ordonance ShowOrdonance = new Ordonance();
            ShowOrdonance.Show();
        }

        private void btnIncompatible_Click(object sender, EventArgs e)
        {
            incompatible ShowIncompatible = new incompatible();
            ShowIncompatible.Show();
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
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
