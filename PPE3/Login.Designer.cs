namespace PPE3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBoxNomU = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panelLogin = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNomU
            // 
            textBoxNomU.BackColor = Color.FromArgb(4, 137, 177);
            textBoxNomU.BorderStyle = BorderStyle.None;
            textBoxNomU.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomU.ForeColor = SystemColors.InactiveCaption;
            textBoxNomU.Location = new Point(3, 13);
            textBoxNomU.Name = "textBoxNomU";
            textBoxNomU.Size = new Size(403, 30);
            textBoxNomU.TabIndex = 0;
            textBoxNomU.Text = "Entrer Nom d'utilisateur";
            textBoxNomU.Click += textBoxNomU_Click;
            textBoxNomU.TextChanged += textBoxNomU_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(4, 137, 177);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.InactiveCaption;
            textBoxPassword.Location = new Point(3, 12);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(403, 30);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "Entrer Mot de passe";
            textBoxPassword.Click += textBoxPassword_Click;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(526, 212);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 2;
            label1.Text = "Nom D'utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(526, 323);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 2;
            label2.Text = "Mot De Passe";
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 66, 66);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(66, 66, 66);
            btnLogin.Location = new Point(640, 457);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(278, 47);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyPress += btnLogin_KeyPress;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 38);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
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
            button1.Location = new Point(1135, 0);
            button1.Name = "button1";
            button1.Size = new Size(56, 38);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 576);
            panel2.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.La_meilleur_App_de_Labo;
            pictureBox4.Location = new Point(69, 139);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(271, 277);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(4, 137, 177);
            panelLogin.Controls.Add(pictureBox3);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(panel5);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(panel3);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label3);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1191, 614);
            panelLogin.TabIndex = 6;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 75);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(457, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(textBoxPassword);
            panel5.Location = new Point(748, 310);
            panel5.Name = "panel5";
            panel5.Size = new Size(412, 63);
            panel5.TabIndex = 9;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(66, 66, 66);
            panel6.Location = new Point(3, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(403, 2);
            panel6.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBoxNomU);
            panel3.Location = new Point(748, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 63);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(66, 66, 66);
            panel4.Location = new Point(3, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 2);
            panel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(712, 63);
            label3.Name = "label3";
            label3.Size = new Size(103, 46);
            label3.TabIndex = 7;
            label3.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 614);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxNomU;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Panel panel1;
        private Panel panel2;
        private Panel panelLogin;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
    }
}