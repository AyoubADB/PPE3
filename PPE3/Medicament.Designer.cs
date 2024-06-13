namespace PPE3
{
    partial class Medicament
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicament));
            affichageMedoc = new DataGridView();
            ajouter = new Button();
            refreshGridView = new Button();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)affichageMedoc).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // affichageMedoc
            // 
            affichageMedoc.AllowUserToAddRows = false;
            affichageMedoc.AllowUserToDeleteRows = false;
            affichageMedoc.AllowUserToResizeColumns = false;
            affichageMedoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 137, 177);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            affichageMedoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            affichageMedoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            affichageMedoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            affichageMedoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            affichageMedoc.BackgroundColor = Color.FromArgb(64, 64, 64);
            affichageMedoc.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(4, 137, 177);
            affichageMedoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            affichageMedoc.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(4, 137, 177);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            affichageMedoc.DefaultCellStyle = dataGridViewCellStyle3;
            affichageMedoc.EnableHeadersVisualStyles = false;
            affichageMedoc.GridColor = Color.FromArgb(64, 64, 64);
            affichageMedoc.ImeMode = ImeMode.NoControl;
            affichageMedoc.Location = new Point(669, 34);
            affichageMedoc.Name = "affichageMedoc";
            affichageMedoc.ReadOnly = true;
            affichageMedoc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(4, 137, 177);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            affichageMedoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            affichageMedoc.RowHeadersVisible = false;
            affichageMedoc.RowHeadersWidth = 300;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(4, 137, 177);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(64, 64, 64);
            affichageMedoc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            affichageMedoc.RowTemplate.Height = 33;
            affichageMedoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            affichageMedoc.Size = new Size(658, 732);
            affichageMedoc.TabIndex = 1;
            affichageMedoc.UseWaitCursor = true;
            affichageMedoc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ajouter
            // 
            ajouter.BackColor = Color.FromArgb(64, 64, 64);
            ajouter.BackgroundImage = (Image)resources.GetObject("ajouter.BackgroundImage");
            ajouter.BackgroundImageLayout = ImageLayout.Zoom;
            ajouter.FlatAppearance.BorderSize = 0;
            ajouter.FlatAppearance.MouseOverBackColor = Color.Gray;
            ajouter.FlatStyle = FlatStyle.Flat;
            ajouter.Location = new Point(183, 365);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(209, 190);
            ajouter.TabIndex = 0;
            ajouter.UseVisualStyleBackColor = false;
            ajouter.UseWaitCursor = true;
            ajouter.Click += ajouter_Click;
            // 
            // refreshGridView
            // 
            refreshGridView.BackColor = Color.FromArgb(64, 64, 64);
            refreshGridView.BackgroundImage = Properties.Resources.De;
            refreshGridView.BackgroundImageLayout = ImageLayout.Zoom;
            refreshGridView.FlatAppearance.BorderSize = 0;
            refreshGridView.FlatAppearance.MouseOverBackColor = Color.Gray;
            refreshGridView.FlatStyle = FlatStyle.Flat;
            refreshGridView.Location = new Point(183, 113);
            refreshGridView.Name = "refreshGridView";
            refreshGridView.Size = new Size(209, 190);
            refreshGridView.TabIndex = 2;
            refreshGridView.UseVisualStyleBackColor = false;
            refreshGridView.UseWaitCursor = true;
            refreshGridView.Click += refreshGridView_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1327, 38);
            panel1.TabIndex = 6;
            panel1.UseWaitCursor = true;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.x;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1271, 0);
            button1.Name = "button1";
            button1.Size = new Size(56, 38);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // Medicament
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(4, 137, 177);
            ClientSize = new Size(1327, 766);
            Controls.Add(panel1);
            Controls.Add(refreshGridView);
            Controls.Add(ajouter);
            Controls.Add(affichageMedoc);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Medicament";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "medicament";
            UseWaitCursor = true;
            Load += refreshGridView_Click;
            ((System.ComponentModel.ISupportInitialize)affichageMedoc).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ajouter;
        private DataGridView affichageMedoc;
        private DataGridViewTextBoxColumn Non;
        private DataGridViewTextBoxColumn Contre_indication;
        private Button refreshGridView;
        private Panel panel1;
        private Button button1;
    }
}