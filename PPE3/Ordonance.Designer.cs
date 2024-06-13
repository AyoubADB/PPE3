namespace PPE3
{
    partial class Ordonance
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
            comboBoxNomPatOrdo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxMedcOrdo = new ComboBox();
            label8 = new Label();
            comboBoxMedocOrdo = new ComboBox();
            richTextBoxInstruction = new RichTextBox();
            richTextBoxPosologie = new RichTextBox();
            label3 = new Label();
            dateDebTrait = new DateTimePicker();
            btnAjtOrdo = new Button();
            dateFinTrait = new DateTimePicker();
            panel1 = new Panel();
            button1 = new Button();
            comboBoxMedocFacultative = new ComboBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxNomPatOrdo
            // 
            comboBoxNomPatOrdo.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxNomPatOrdo.FlatStyle = FlatStyle.Flat;
            comboBoxNomPatOrdo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNomPatOrdo.ForeColor = SystemColors.HighlightText;
            comboBoxNomPatOrdo.FormattingEnabled = true;
            comboBoxNomPatOrdo.Location = new Point(159, 219);
            comboBoxNomPatOrdo.Name = "comboBoxNomPatOrdo";
            comboBoxNomPatOrdo.Size = new Size(248, 46);
            comboBoxNomPatOrdo.TabIndex = 0;
            comboBoxNomPatOrdo.SelectedIndexChanged += comboBoxNomPatOrdo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(470, 70);
            label1.Name = "label1";
            label1.Size = new Size(487, 65);
            label1.TabIndex = 5;
            label1.Text = "Créer Une Ordonance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(66, 227);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 6;
            label2.Text = "Patient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(183, 601);
            label4.Name = "label4";
            label4.Size = new Size(282, 32);
            label4.TabIndex = 8;
            label4.Text = "Durée du traitement Du :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(714, 601);
            label5.Name = "label5";
            label5.Size = new Size(43, 32);
            label5.TabIndex = 9;
            label5.Text = "Au";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(183, 688);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 10;
            label6.Text = "Instrution";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(486, 226);
            label7.Name = "label7";
            label7.Size = new Size(107, 32);
            label7.TabIndex = 6;
            label7.Text = "Médecin";
            // 
            // comboBoxMedcOrdo
            // 
            comboBoxMedcOrdo.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxMedcOrdo.FlatStyle = FlatStyle.Flat;
            comboBoxMedcOrdo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMedcOrdo.ForeColor = SystemColors.HighlightText;
            comboBoxMedcOrdo.FormattingEnabled = true;
            comboBoxMedcOrdo.Location = new Point(599, 219);
            comboBoxMedcOrdo.Name = "comboBoxMedcOrdo";
            comboBoxMedcOrdo.Size = new Size(248, 46);
            comboBoxMedcOrdo.TabIndex = 11;
            comboBoxMedcOrdo.SelectedIndexChanged += comboBoxMedcOrdo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(894, 226);
            label8.Name = "label8";
            label8.Size = new Size(148, 32);
            label8.TabIndex = 6;
            label8.Text = "Médicament";
            // 
            // comboBoxMedocOrdo
            // 
            comboBoxMedocOrdo.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxMedocOrdo.FlatStyle = FlatStyle.Flat;
            comboBoxMedocOrdo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMedocOrdo.ForeColor = SystemColors.HighlightText;
            comboBoxMedocOrdo.FormattingEnabled = true;
            comboBoxMedocOrdo.Location = new Point(1048, 219);
            comboBoxMedocOrdo.Name = "comboBoxMedocOrdo";
            comboBoxMedocOrdo.Size = new Size(248, 46);
            comboBoxMedocOrdo.TabIndex = 12;
            comboBoxMedocOrdo.SelectedIndexChanged += comboBoxMedocOrdo_SelectedIndexChanged;
            // 
            // richTextBoxInstruction
            // 
            richTextBoxInstruction.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInstruction.BorderStyle = BorderStyle.None;
            richTextBoxInstruction.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInstruction.ForeColor = SystemColors.InactiveCaption;
            richTextBoxInstruction.Location = new Point(322, 688);
            richTextBoxInstruction.Name = "richTextBoxInstruction";
            richTextBoxInstruction.Size = new Size(828, 173);
            richTextBoxInstruction.TabIndex = 13;
            richTextBoxInstruction.Text = "Entrer le Texte ici";
            richTextBoxInstruction.Click += richTextBoxInstruction_Click;
            richTextBoxInstruction.TextChanged += richTextBoxInstruction_TextChanged;
            // 
            // richTextBoxPosologie
            // 
            richTextBoxPosologie.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxPosologie.BorderStyle = BorderStyle.None;
            richTextBoxPosologie.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxPosologie.ForeColor = SystemColors.InactiveCaption;
            richTextBoxPosologie.Location = new Point(322, 439);
            richTextBoxPosologie.Name = "richTextBoxPosologie";
            richTextBoxPosologie.Size = new Size(828, 121);
            richTextBoxPosologie.TabIndex = 14;
            richTextBoxPosologie.Text = " Entre le Texte ici";
            richTextBoxPosologie.Click += richTextBoxPosologie_Click;
            richTextBoxPosologie.TextChanged += richTextBoxPosologie_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(183, 439);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 10;
            label3.Text = "Posologie";
            // 
            // dateDebTrait
            // 
            dateDebTrait.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDebTrait.CalendarForeColor = SystemColors.ActiveCaptionText;
            dateDebTrait.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dateDebTrait.CalendarTitleForeColor = Color.FromArgb(4, 137, 177);
            dateDebTrait.CalendarTrailingForeColor = Color.FromArgb(4, 137, 177);
            dateDebTrait.Format = DateTimePickerFormat.Short;
            dateDebTrait.ImeMode = ImeMode.NoControl;
            dateDebTrait.Location = new Point(503, 602);
            dateDebTrait.Name = "dateDebTrait";
            dateDebTrait.RightToLeft = RightToLeft.No;
            dateDebTrait.Size = new Size(174, 31);
            dateDebTrait.TabIndex = 15;
            dateDebTrait.ValueChanged += dateDebTrait_ValueChanged;
            // 
            // btnAjtOrdo
            // 
            btnAjtOrdo.BackColor = Color.FromArgb(64, 64, 64);
            btnAjtOrdo.FlatAppearance.BorderSize = 0;
            btnAjtOrdo.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAjtOrdo.FlatStyle = FlatStyle.Flat;
            btnAjtOrdo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjtOrdo.ForeColor = Color.White;
            btnAjtOrdo.Location = new Point(877, 912);
            btnAjtOrdo.Name = "btnAjtOrdo";
            btnAjtOrdo.Size = new Size(273, 70);
            btnAjtOrdo.TabIndex = 17;
            btnAjtOrdo.Text = "Génerer PDF";
            btnAjtOrdo.UseVisualStyleBackColor = false;
            btnAjtOrdo.Click += btnAjtOrdo_Click;
            // 
            // dateFinTrait
            // 
            dateFinTrait.Format = DateTimePickerFormat.Short;
            dateFinTrait.Location = new Point(792, 602);
            dateFinTrait.Name = "dateFinTrait";
            dateFinTrait.Size = new Size(174, 31);
            dateFinTrait.TabIndex = 18;
            dateFinTrait.ValueChanged += dateFinTrait_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 38);
            panel1.TabIndex = 19;
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
            button1.Location = new Point(1315, 0);
            button1.Name = "button1";
            button1.Size = new Size(56, 38);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxMedocFacultative
            // 
            comboBoxMedocFacultative.AccessibleName = "comboBoxMedocFacultative";
            comboBoxMedocFacultative.BackColor = Color.FromArgb(64, 64, 64);
            comboBoxMedocFacultative.FlatStyle = FlatStyle.Flat;
            comboBoxMedocFacultative.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMedocFacultative.ForeColor = SystemColors.HighlightText;
            comboBoxMedocFacultative.FormattingEnabled = true;
            comboBoxMedocFacultative.Location = new Point(1048, 305);
            comboBoxMedocFacultative.Name = "comboBoxMedocFacultative";
            comboBoxMedocFacultative.Size = new Size(248, 46);
            comboBoxMedocFacultative.TabIndex = 12;
            comboBoxMedocFacultative.SelectedIndexChanged += comboBoxMedocOrdo_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(827, 313);
            label9.Name = "label9";
            label9.Size = new Size(215, 32);
            label9.TabIndex = 6;
            label9.Text = "2ème Médicament";
            // 
            // Ordonance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 137, 177);
            ClientSize = new Size(1371, 1012);
            Controls.Add(comboBoxMedocFacultative);
            Controls.Add(comboBoxMedocOrdo);
            Controls.Add(comboBoxMedcOrdo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBoxNomPatOrdo);
            Controls.Add(panel1);
            Controls.Add(dateFinTrait);
            Controls.Add(btnAjtOrdo);
            Controls.Add(dateDebTrait);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBoxPosologie);
            Controls.Add(richTextBoxInstruction);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ordonance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordonance";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxNomPatOrdo;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxMedcOrdo;
        private Label label8;
        private ComboBox comboBoxMedocOrdo;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label3;
        private RichTextBox richTextBoxInstruction;
        private RichTextBox richTextBoxPosologie;
        private DateTimePicker dateDebTrait;
        private Button btnAjtOrdo;
        private DateTimePicker dateFinTrait;
        private Panel panel1;
        private Button button1;
        private ComboBox comboBoxMedocFacultative;
        private Label label9;
    }
}