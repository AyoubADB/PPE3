namespace PPE3
{
    partial class ajouterPat
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAjouterPat = new Button();
            btnAnnulerPat = new Button();
            comboBoxAgePat = new ComboBox();
            comboBoxSexePat = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxAllAjtPat = new ComboBox();
            comboBoxAntecAjtPat = new ComboBox();
            btnAjouterAllAntec = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(4, 137, 177);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(3, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "Entrer nom du patient";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(4, 137, 177);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(3, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 24);
            textBox2.TabIndex = 1;
            textBox2.Text = "Entre prénom du patient";
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(74, 147);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 4;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(63, 233);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 5;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(74, 300);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 6;
            label3.Text = "Age";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(74, 362);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 7;
            label4.Text = "Sexe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(314, 52);
            label5.Name = "label5";
            label5.Size = new Size(478, 48);
            label5.TabIndex = 8;
            label5.Text = "Ajout D'un Nouveau Patient";
            // 
            // btnAjouterPat
            // 
            btnAjouterPat.BackColor = Color.FromArgb(4, 137, 177);
            btnAjouterPat.BackgroundImage = Properties.Resources.zadefdz;
            btnAjouterPat.BackgroundImageLayout = ImageLayout.Zoom;
            btnAjouterPat.FlatAppearance.BorderSize = 0;
            btnAjouterPat.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 137, 177);
            btnAjouterPat.FlatStyle = FlatStyle.Flat;
            btnAjouterPat.Location = new Point(881, 490);
            btnAjouterPat.Name = "btnAjouterPat";
            btnAjouterPat.Size = new Size(102, 78);
            btnAjouterPat.TabIndex = 9;
            btnAjouterPat.UseVisualStyleBackColor = false;
            btnAjouterPat.Click += btnAjouterPat_Click;
            // 
            // btnAnnulerPat
            // 
            btnAnnulerPat.BackColor = Color.FromArgb(4, 137, 177);
            btnAnnulerPat.BackgroundImage = Properties.Resources.Design_sans_azdefdeds;
            btnAnnulerPat.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnnulerPat.FlatAppearance.BorderSize = 0;
            btnAnnulerPat.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 137, 177);
            btnAnnulerPat.FlatStyle = FlatStyle.Flat;
            btnAnnulerPat.Location = new Point(993, 490);
            btnAnnulerPat.Name = "btnAnnulerPat";
            btnAnnulerPat.Size = new Size(84, 78);
            btnAnnulerPat.TabIndex = 10;
            btnAnnulerPat.UseVisualStyleBackColor = false;
            btnAnnulerPat.Click += btnAnnulerPat_Click;
            // 
            // comboBoxAgePat
            // 
            comboBoxAgePat.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxAgePat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAgePat.FlatStyle = FlatStyle.Flat;
            comboBoxAgePat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAgePat.ForeColor = Color.FromArgb(4, 137, 177);
            comboBoxAgePat.FormattingEnabled = true;
            comboBoxAgePat.Location = new Point(182, 297);
            comboBoxAgePat.Name = "comboBoxAgePat";
            comboBoxAgePat.Size = new Size(112, 33);
            comboBoxAgePat.TabIndex = 11;
            comboBoxAgePat.SelectedIndexChanged += comboBoxAgePat_SelectedIndexChanged;
            // 
            // comboBoxSexePat
            // 
            comboBoxSexePat.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxSexePat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSexePat.FlatStyle = FlatStyle.Flat;
            comboBoxSexePat.ForeColor = Color.FromArgb(4, 137, 177);
            comboBoxSexePat.FormattingEnabled = true;
            comboBoxSexePat.Location = new Point(182, 359);
            comboBoxSexePat.Name = "comboBoxSexePat";
            comboBoxSexePat.Size = new Size(66, 33);
            comboBoxSexePat.TabIndex = 12;
            comboBoxSexePat.SelectedIndexChanged += comboBoxSexePat_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(542, 147);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 13;
            label6.Text = "Allergie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(542, 237);
            label7.Name = "label7";
            label7.Size = new Size(112, 28);
            label7.TabIndex = 14;
            label7.Text = "Antécédent";
            // 
            // comboBoxAllAjtPat
            // 
            comboBoxAllAjtPat.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxAllAjtPat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAllAjtPat.FlatStyle = FlatStyle.Flat;
            comboBoxAllAjtPat.ForeColor = Color.FromArgb(4, 137, 177);
            comboBoxAllAjtPat.FormattingEnabled = true;
            comboBoxAllAjtPat.Location = new Point(678, 142);
            comboBoxAllAjtPat.Name = "comboBoxAllAjtPat";
            comboBoxAllAjtPat.Size = new Size(305, 33);
            comboBoxAllAjtPat.TabIndex = 15;
            comboBoxAllAjtPat.SelectedIndexChanged += comboBoxAllAjtPat_SelectedIndexChanged;
            // 
            // comboBoxAntecAjtPat
            // 
            comboBoxAntecAjtPat.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxAntecAjtPat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAntecAjtPat.FlatStyle = FlatStyle.Flat;
            comboBoxAntecAjtPat.ForeColor = Color.FromArgb(4, 137, 177);
            comboBoxAntecAjtPat.FormattingEnabled = true;
            comboBoxAntecAjtPat.Location = new Point(678, 232);
            comboBoxAntecAjtPat.Name = "comboBoxAntecAjtPat";
            comboBoxAntecAjtPat.Size = new Size(305, 33);
            comboBoxAntecAjtPat.TabIndex = 16;
            comboBoxAntecAjtPat.SelectedIndexChanged += comboBoxAntecAjtPat_SelectedIndexChanged;
            // 
            // btnAjouterAllAntec
            // 
            btnAjouterAllAntec.BackColor = Color.FromArgb(64, 64, 64);
            btnAjouterAllAntec.FlatAppearance.BorderSize = 0;
            btnAjouterAllAntec.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAjouterAllAntec.FlatStyle = FlatStyle.Flat;
            btnAjouterAllAntec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouterAllAntec.ForeColor = Color.FromArgb(4, 137, 177);
            btnAjouterAllAntec.Location = new Point(678, 297);
            btnAjouterAllAntec.Name = "btnAjouterAllAntec";
            btnAjouterAllAntec.Size = new Size(305, 81);
            btnAjouterAllAntec.TabIndex = 17;
            btnAjouterAllAntec.Text = "Ajouter Allergie / Antécédent";
            btnAjouterAllAntec.UseVisualStyleBackColor = false;
            btnAjouterAllAntec.Click += btnAjouterAllAntec_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 38);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
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
            button2.Location = new Point(1059, 0);
            button2.Name = "button2";
            button2.Size = new Size(56, 38);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(176, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 60);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(66, 66, 66);
            panel4.Location = new Point(3, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 2);
            panel4.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(179, 215);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 59);
            panel2.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(66, 66, 66);
            panel5.Location = new Point(3, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(403, 2);
            panel5.TabIndex = 9;
            // 
            // ajouterPat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 137, 177);
            ClientSize = new Size(1115, 580);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnAjouterAllAntec);
            Controls.Add(comboBoxAntecAjtPat);
            Controls.Add(comboBoxAllAjtPat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxSexePat);
            Controls.Add(comboBoxAgePat);
            Controls.Add(btnAnnulerPat);
            Controls.Add(btnAjouterPat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ajouterPat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ajouterPat";
            Load += ajouterPat_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAjouterPat;
        private Button btnAnnulerPat;
        private ComboBox comboBoxAgePat;
        private ComboBox comboBoxSexePat;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxAllAjtPat;
        private ComboBox comboBoxAntecAjtPat;
        private Button btnAjouterAllAntec;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
    }
}