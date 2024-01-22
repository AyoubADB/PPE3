namespace PPE3
{
    partial class ajouterMedoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouterMedoc));
            button1 = new Button();
            annuleAjoutMedoc = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 137, 177);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 137, 177);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(588, 350);
            button1.Name = "button1";
            button1.Size = new Size(97, 94);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // annuleAjoutMedoc
            // 
            annuleAjoutMedoc.BackColor = Color.FromArgb(4, 137, 177);
            annuleAjoutMedoc.BackgroundImage = (Image)resources.GetObject("annuleAjoutMedoc.BackgroundImage");
            annuleAjoutMedoc.BackgroundImageLayout = ImageLayout.Zoom;
            annuleAjoutMedoc.FlatAppearance.BorderSize = 0;
            annuleAjoutMedoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 137, 177);
            annuleAjoutMedoc.FlatStyle = FlatStyle.Flat;
            annuleAjoutMedoc.Location = new Point(702, 348);
            annuleAjoutMedoc.Name = "annuleAjoutMedoc";
            annuleAjoutMedoc.Size = new Size(97, 99);
            annuleAjoutMedoc.TabIndex = 1;
            annuleAjoutMedoc.UseVisualStyleBackColor = false;
            annuleAjoutMedoc.Click += annuleAjoutMedoc_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(4, 137, 177);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(3, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 30);
            textBox1.TabIndex = 2;
            textBox1.Text = "Entrer un médicament";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(182, 234);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 3;
            label1.Text = "Nom Médicament ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(294, 71);
            label3.Name = "label3";
            label3.Size = new Size(335, 45);
            label3.TabIndex = 4;
            label3.Text = "Ajout de Médicament";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 38);
            panel1.TabIndex = 7;
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
            button2.Location = new Point(826, 0);
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
            panel3.Location = new Point(387, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 63);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(66, 66, 66);
            panel4.Location = new Point(3, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 2);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Design_sans_zaerezatitre;
            pictureBox1.Location = new Point(114, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // ajouterMedoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 137, 177);
            ClientSize = new Size(882, 528);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(annuleAjoutMedoc);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ajouterMedoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ajouterMedoc";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button annuleAjoutMedoc;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}