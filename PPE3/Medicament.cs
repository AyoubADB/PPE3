using System.Text;
using System.Windows.Forms;

namespace PPE3
{
    public partial class Medicament : Form
    {
        private MedocDataAcess dataAccessMedoc = new MedocDataAcess();
        private bool mouseDown;
        private Point LastLocation;

        public Medicament()
        {
            InitializeComponent();
            updateDataGridView();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void updateDataGridView()
        {
            this.affichageMedoc.DataSource = dataAccessMedoc.getMedocListFromDB();
        }


        private void ajouter_Click(object sender, EventArgs e)
        {
            ajouterMedoc ajoutMedoc = new ajouterMedoc();
            ajoutMedoc.Show();
        }

        private void refreshGridView_Click(object sender, EventArgs e)
        {
            dataGridViewRefresh();
        }

        public void dataGridViewRefresh()
        {
            List<MedocIncompatible> medocList = dataAccessMedoc.getMedocListFromDB();

            if (medocList != null && medocList.Count > 0)
            {
                affichageMedoc.DataSource = null;
                affichageMedoc.DataSource = medocList;
            }
            else
            {
                MessageBox.Show("Aucun médicament trouvé dans la base de données.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}