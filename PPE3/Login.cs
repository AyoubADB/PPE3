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
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point LastLocation;

        public Login()
        {
            InitializeComponent();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }



        private string connectionLogin = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connectionLogin);

            try
            {
                string query = "SELECT medecin.nom_user_medc FROM medecin WHERE nom_user_medc='" + textBoxNomU.Text.Trim() + "' AND password_medc='" + textBoxPassword.Text.Trim() + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Home dr = new Home();
                    dr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Veillez vérifier votre Mot de passe ou le Nom D'utilisateur");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(connectionLogin);

                try
                {
                    string query = "SELECT medecin.nom_user_medc FROM medecin WHERE nom_user_medc='" + textBoxNomU.Text.Trim() + "' AND password_medc='" + textBoxPassword.Text.Trim() + "'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        Home dr = new Home();
                        dr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Veillez vérifier votre Mot de passe ou le Nom D'utilisateur");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(connectionLogin);

                try
                {
                    string query = "SELECT medecin.nom_user_medc FROM medecin WHERE nom_user_medc='" + textBoxNomU.Text.Trim() + "' AND password_medc='" + textBoxPassword.Text.Trim() + "'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        Home dr = new Home();
                        dr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Veillez vérifier votre Mot de passe ou le Nom D'utilisateur");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNomU_TextChanged(object sender, EventArgs e)
        {
            textBoxNomU.ForeColor = Color.White;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.PasswordChar = '*';
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(66, 66, 66);
        }

        private void textBoxNomU_Click(object sender, EventArgs e)
        {
            textBoxNomU.SelectAll();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
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
                this.Location = new Point (
                    (this.Location.X - LastLocation.X) + e.X, 
                    (this.Location.Y - LastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
