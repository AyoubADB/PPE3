namespace PPE3
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewPat = new DataGridView();
            btnAjouterPat = new Button();
            btnRefreshPat = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPat).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPat
            // 
            dataGridViewPat.AllowUserToAddRows = false;
            dataGridViewPat.AllowUserToDeleteRows = false;
            dataGridViewPat.AllowUserToResizeColumns = false;
            dataGridViewPat.AllowUserToResizeRows = false;
            dataGridViewPat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPat.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewPat.BorderStyle = BorderStyle.None;
            dataGridViewPat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 137, 177);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPat.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(4, 137, 177);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPat.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPat.EnableHeadersVisualStyles = false;
            dataGridViewPat.Location = new Point(40, 126);
            dataGridViewPat.Name = "dataGridViewPat";
            dataGridViewPat.ReadOnly = true;
            dataGridViewPat.RowHeadersVisible = false;
            dataGridViewPat.RowHeadersWidth = 150;
            dataGridViewPat.RowTemplate.Height = 33;
            dataGridViewPat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPat.Size = new Size(1221, 556);
            dataGridViewPat.TabIndex = 0;
            dataGridViewPat.CellContentClick += dataGridViewPat_CellContentClick;
            // 
            // btnAjouterPat
            // 
            btnAjouterPat.BackColor = Color.FromArgb(64, 64, 64);
            btnAjouterPat.BackgroundImage = Properties.Resources.zaerzad;
            btnAjouterPat.BackgroundImageLayout = ImageLayout.Zoom;
            btnAjouterPat.FlatAppearance.BorderSize = 0;
            btnAjouterPat.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 64, 64);
            btnAjouterPat.FlatStyle = FlatStyle.Flat;
            btnAjouterPat.Location = new Point(657, 9);
            btnAjouterPat.Name = "btnAjouterPat";
            btnAjouterPat.Size = new Size(133, 127);
            btnAjouterPat.TabIndex = 1;
            btnAjouterPat.UseVisualStyleBackColor = false;
            btnAjouterPat.Click += btnAjouterPat_Click;
            // 
            // btnRefreshPat
            // 
            btnRefreshPat.BackColor = Color.FromArgb(64, 64, 64);
            btnRefreshPat.BackgroundImage = Properties.Resources.De;
            btnRefreshPat.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshPat.FlatAppearance.BorderSize = 0;
            btnRefreshPat.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 64, 64);
            btnRefreshPat.FlatStyle = FlatStyle.Flat;
            btnRefreshPat.Location = new Point(433, 10);
            btnRefreshPat.Name = "btnRefreshPat";
            btnRefreshPat.Size = new Size(133, 125);
            btnRefreshPat.TabIndex = 1;
            btnRefreshPat.UseVisualStyleBackColor = false;
            btnRefreshPat.Click += btnRefreshPat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 38);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.x;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1245, 0);
            button2.Name = "button2";
            button2.Size = new Size(56, 38);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnAjouterPat);
            panel2.Controls.Add(btnRefreshPat);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 681);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 147);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(4, 137, 177);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(1301, 90);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(295, 48);
            label1.TabIndex = 0;
            label1.Text = "Liste Des Patients";
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1301, 828);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPat).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPat;
        private Button btnAjouterPat;
        private Button btnRefreshPat;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}