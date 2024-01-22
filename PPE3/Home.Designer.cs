namespace PPE3
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnMedicament = new Button();
            btnPat = new Button();
            btnOrdonance = new Button();
            btnIncompatible = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMedicament
            // 
            btnMedicament.BackColor = Color.FromArgb(4, 137, 177);
            btnMedicament.BackgroundImage = (Image)resources.GetObject("btnMedicament.BackgroundImage");
            btnMedicament.FlatAppearance.BorderSize = 0;
            btnMedicament.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 166, 215);
            btnMedicament.FlatStyle = FlatStyle.Flat;
            btnMedicament.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMedicament.Location = new Point(0, 38);
            btnMedicament.Name = "btnMedicament";
            btnMedicament.Size = new Size(305, 623);
            btnMedicament.TabIndex = 0;
            btnMedicament.TextAlign = ContentAlignment.BottomCenter;
            btnMedicament.UseVisualStyleBackColor = false;
            btnMedicament.Click += btnMedicament_Click;
            // 
            // btnPat
            // 
            btnPat.BackColor = Color.FromArgb(66, 66, 66);
            btnPat.BackgroundImage = Properties.Resources.pat;
            btnPat.FlatAppearance.BorderSize = 0;
            btnPat.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 104, 104);
            btnPat.FlatStyle = FlatStyle.Flat;
            btnPat.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPat.Location = new Point(298, 38);
            btnPat.Name = "btnPat";
            btnPat.Size = new Size(305, 623);
            btnPat.TabIndex = 1;
            btnPat.UseVisualStyleBackColor = false;
            btnPat.Click += btnPat_Click;
            // 
            // btnOrdonance
            // 
            btnOrdonance.BackColor = Color.FromArgb(66, 66, 66);
            btnOrdonance.BackgroundImage = (Image)resources.GetObject("btnOrdonance.BackgroundImage");
            btnOrdonance.FlatAppearance.BorderSize = 0;
            btnOrdonance.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 104, 104);
            btnOrdonance.FlatStyle = FlatStyle.Flat;
            btnOrdonance.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdonance.Location = new Point(899, 38);
            btnOrdonance.Name = "btnOrdonance";
            btnOrdonance.Size = new Size(307, 624);
            btnOrdonance.TabIndex = 2;
            btnOrdonance.UseVisualStyleBackColor = false;
            btnOrdonance.Click += btnOrdonance_Click;
            // 
            // btnIncompatible
            // 
            btnIncompatible.BackColor = Color.FromArgb(4, 137, 177);
            btnIncompatible.BackgroundImage = (Image)resources.GetObject("btnIncompatible.BackgroundImage");
            btnIncompatible.FlatAppearance.BorderSize = 0;
            btnIncompatible.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 166, 215);
            btnIncompatible.FlatStyle = FlatStyle.Flat;
            btnIncompatible.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncompatible.Location = new Point(598, 38);
            btnIncompatible.Name = "btnIncompatible";
            btnIncompatible.Size = new Size(305, 624);
            btnIncompatible.TabIndex = 3;
            btnIncompatible.UseVisualStyleBackColor = false;
            btnIncompatible.Click += btnIncompatible_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.x;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1150, 0);
            button1.Name = "button1";
            button1.Size = new Size(56, 38);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 38);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1206, 660);
            Controls.Add(btnIncompatible);
            Controls.Add(btnMedicament);
            Controls.Add(btnPat);
            Controls.Add(btnOrdonance);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMedicament;
        private Button btnPat;
        private Button btnOrdonance;
        private Button btnIncompatible;
        private Button button1;
        private Panel panel1;
    }
}