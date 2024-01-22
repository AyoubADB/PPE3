namespace PPE3
{
    partial class AjouterAllAntec
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
            textBoxAjtAll = new TextBox();
            textBoxAjtAntec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddAll = new Button();
            btnAddAntec = new Button();
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
            // textBoxAjtAll
            // 
            textBoxAjtAll.BackColor = Color.FromArgb(4, 137, 177);
            textBoxAjtAll.BorderStyle = BorderStyle.None;
            textBoxAjtAll.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAjtAll.ForeColor = SystemColors.InactiveCaption;
            textBoxAjtAll.Location = new Point(3, 17);
            textBoxAjtAll.Name = "textBoxAjtAll";
            textBoxAjtAll.Size = new Size(359, 27);
            textBoxAjtAll.TabIndex = 0;
            textBoxAjtAll.Text = "Entrer allergie";
            textBoxAjtAll.Click += textBoxAjtAll_Click;
            textBoxAjtAll.TextChanged += textBoxAjtAll_TextChanged;
            // 
            // textBoxAjtAntec
            // 
            textBoxAjtAntec.BackColor = Color.FromArgb(4, 137, 177);
            textBoxAjtAntec.BorderStyle = BorderStyle.None;
            textBoxAjtAntec.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAjtAntec.ForeColor = SystemColors.InactiveCaption;
            textBoxAjtAntec.Location = new Point(3, 16);
            textBoxAjtAntec.Name = "textBoxAjtAntec";
            textBoxAjtAntec.Size = new Size(359, 27);
            textBoxAjtAntec.TabIndex = 1;
            textBoxAjtAntec.Text = "Entrer antécédent";
            textBoxAjtAntec.Click += textBoxAjtAntec_Click;
            textBoxAjtAntec.TextChanged += textBoxAjtAntec_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 242);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 2;
            label1.Text = "Allergie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 327);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "Antécédent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(294, 92);
            label3.Name = "label3";
            label3.Size = new Size(329, 45);
            label3.TabIndex = 2;
            label3.Text = "Allergie / Antécédent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(378, 50);
            label4.Name = "label4";
            label4.Size = new Size(157, 54);
            label4.TabIndex = 2;
            label4.Text = "Ajouter";
            // 
            // btnAddAll
            // 
            btnAddAll.BackColor = Color.FromArgb(64, 64, 64);
            btnAddAll.FlatAppearance.BorderSize = 0;
            btnAddAll.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddAll.FlatStyle = FlatStyle.Flat;
            btnAddAll.ForeColor = SystemColors.ButtonHighlight;
            btnAddAll.Location = new Point(662, 240);
            btnAddAll.Name = "btnAddAll";
            btnAddAll.Size = new Size(112, 34);
            btnAddAll.TabIndex = 3;
            btnAddAll.Text = "Ajouter";
            btnAddAll.UseVisualStyleBackColor = false;
            btnAddAll.Click += btnAddAll_Click;
            // 
            // btnAddAntec
            // 
            btnAddAntec.BackColor = Color.FromArgb(64, 64, 64);
            btnAddAntec.FlatAppearance.BorderSize = 0;
            btnAddAntec.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddAntec.FlatStyle = FlatStyle.Flat;
            btnAddAntec.ForeColor = SystemColors.ButtonHighlight;
            btnAddAntec.Location = new Point(662, 322);
            btnAddAntec.Name = "btnAddAntec";
            btnAddAntec.Size = new Size(112, 34);
            btnAddAntec.TabIndex = 4;
            btnAddAntec.Text = "Ajouter";
            btnAddAntec.UseVisualStyleBackColor = false;
            btnAddAntec.Click += btnAddAntec_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 38);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.x;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(823, 0);
            button2.Name = "button2";
            button2.Size = new Size(56, 38);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBoxAjtAll);
            panel3.Location = new Point(243, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 55);
            panel3.TabIndex = 20;
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
            panel2.Controls.Add(textBoxAjtAntec);
            panel2.Location = new Point(243, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 55);
            panel2.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(66, 66, 66);
            panel5.Location = new Point(3, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(403, 2);
            panel5.TabIndex = 9;
            // 
            // AjouterAllAntec
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 137, 177);
            ClientSize = new Size(879, 484);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnAddAntec);
            Controls.Add(btnAddAll);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjouterAllAntec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AjouterAllAntec";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAjtAll;
        private TextBox textBoxAjtAntec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddAll;
        private Button btnAddAntec;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
    }
}