namespace GameLibrary
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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
            BtnSauvegarder = new Button();
            BtnQuitter = new Button();
            listView1 = new ListView();
            colTitre = new ColumnHeader();
            colPlateforme = new ColumnHeader();
            colGenre = new ColumnHeader();
            colAnnee = new ColumnHeader();
            colMultijoueur = new ColumnHeader();
            colFormat = new ColumnHeader();
            BtnSupprimer = new Button();
            BtnModifier = new Button();
            BtnAjouter = new Button();
            LblTotal = new Label();
            TxtTitre = new TextBox();
            TxtAnnee = new TextBox();
            CmbPlateforme = new ComboBox();
            CmbGenre = new ComboBox();
            ChkMultijoueur = new CheckBox();
            RdbPhysique = new RadioButton();
            RdbNumerique = new RadioButton();
            GrpFormat = new GroupBox();
            LblTitre = new Label();
            LblPlateforme = new Label();
            LblGenre = new Label();
            LblAnnee = new Label();
            LblTri = new Label();
            CmbTri = new ComboBox();
            GrpFormat.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSauvegarder
            // 
            BtnSauvegarder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSauvegarder.Location = new Point(680, 510);
            BtnSauvegarder.Name = "BtnSauvegarder";
            BtnSauvegarder.Size = new Size(130, 34);
            BtnSauvegarder.TabIndex = 15;
            BtnSauvegarder.Text = "Sauvegarder";
            BtnSauvegarder.UseVisualStyleBackColor = true;
            BtnSauvegarder.Click += BtnSauvegarder_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnQuitter.Location = new Point(820, 510);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(130, 34);
            BtnQuitter.TabIndex = 17;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colTitre, colPlateforme, colGenre, colAnnee, colMultijoueur, colFormat });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(30, 210);
            listView1.Name = "listView1";
            listView1.Size = new Size(920, 290);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colTitre
            // 
            colTitre.Text = "Titre";
            colTitre.Width = 220;
            // 
            // colPlateforme
            // 
            colPlateforme.Text = "Plateforme";
            colPlateforme.Width = 130;
            // 
            // colGenre
            // 
            colGenre.Text = "Genre";
            colGenre.Width = 130;
            // 
            // colAnnee
            // 
            colAnnee.Text = "Année";
            colAnnee.Width = 130;
            // 
            // colMultijoueur
            // 
            colMultijoueur.Text = "Multijoueur";
            colMultijoueur.Width = 130;
            // 
            // colFormat
            // 
            colFormat.Text = "Format";
            colFormat.Width = 130;
            // 
            // BtnSupprimer
            // 
            BtnSupprimer.Location = new Point(390, 160);
            BtnSupprimer.Name = "BtnSupprimer";
            BtnSupprimer.Size = new Size(112, 34);
            BtnSupprimer.TabIndex = 12;
            BtnSupprimer.Text = "Supprimer";
            BtnSupprimer.UseVisualStyleBackColor = true;
            BtnSupprimer.Click += BtnSupprimer_Click;
            // 
            // BtnModifier
            // 
            BtnModifier.Location = new Point(260, 160);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(112, 34);
            BtnModifier.TabIndex = 11;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = true;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // BtnAjouter
            // 
            BtnAjouter.Location = new Point(130, 160);
            BtnAjouter.Name = "BtnAjouter";
            BtnAjouter.Size = new Size(112, 34);
            BtnAjouter.TabIndex = 10;
            BtnAjouter.Text = "Ajouter";
            BtnAjouter.UseVisualStyleBackColor = true;
            BtnAjouter.Click += BtnAjouter_Click;
            // 
            // LblTotal
            // 
            LblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblTotal.Location = new Point(30, 515);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(148, 28);
            LblTotal.TabIndex = 14;
            LblTotal.Text = "Total : 0 jeu(x)";
            // 
            // TxtTitre
            // 
            TxtTitre.Location = new Point(130, 47);
            TxtTitre.Name = "TxtTitre";
            TxtTitre.Size = new Size(250, 31);
            TxtTitre.TabIndex = 1;
            // 
            // TxtAnnee
            // 
            TxtAnnee.Location = new Point(470, 97);
            TxtAnnee.Name = "TxtAnnee";
            TxtAnnee.Size = new Size(100, 31);
            TxtAnnee.TabIndex = 7;
            TxtAnnee.Text = "2026";
            // 
            // CmbPlateforme
            // 
            CmbPlateforme.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPlateforme.FormattingEnabled = true;
            CmbPlateforme.Items.AddRange(new object[] { "PC", "PlayStation 5", "PlayStation 4", "Xbox Series X", "Xbox One", "Nintendo Switch", "Nintendo 3DS", "Mobile", "Autre" });
            CmbPlateforme.Location = new Point(130, 97);
            CmbPlateforme.Name = "CmbPlateforme";
            CmbPlateforme.Size = new Size(220, 33);
            CmbPlateforme.TabIndex = 3;
            // 
            // CmbGenre
            // 
            CmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGenre.FormattingEnabled = true;
            CmbGenre.Items.AddRange(new object[] { "Action", "Aventure", "RPG", "FPS", "Sport", "Course", "Puzzle", "Stratégie", "Simulation", "Horreur", "Combat", "Plateforme", "Sandbox", "Autre" });
            CmbGenre.Location = new Point(470, 47);
            CmbGenre.Name = "CmbGenre";
            CmbGenre.Size = new Size(150, 33);
            CmbGenre.TabIndex = 5;
            // 
            // ChkMultijoueur
            // 
            ChkMultijoueur.AutoSize = true;
            ChkMultijoueur.Location = new Point(650, 50);
            ChkMultijoueur.Name = "ChkMultijoueur";
            ChkMultijoueur.Size = new Size(128, 29);
            ChkMultijoueur.TabIndex = 8;
            ChkMultijoueur.Text = "Multijoueur";
            ChkMultijoueur.UseVisualStyleBackColor = true;
            // 
            // RdbPhysique
            // 
            RdbPhysique.AutoSize = true;
            RdbPhysique.Location = new Point(10, 22);
            RdbPhysique.Name = "RdbPhysique";
            RdbPhysique.Size = new Size(108, 29);
            RdbPhysique.TabIndex = 0;
            RdbPhysique.Text = "Physique";
            RdbPhysique.UseVisualStyleBackColor = true;
            // 
            // RdbNumerique
            // 
            RdbNumerique.AutoSize = true;
            RdbNumerique.Checked = true;
            RdbNumerique.Location = new Point(142, 22);
            RdbNumerique.Name = "RdbNumerique";
            RdbNumerique.Size = new Size(125, 29);
            RdbNumerique.TabIndex = 1;
            RdbNumerique.TabStop = true;
            RdbNumerique.Text = "Numérique";
            RdbNumerique.UseVisualStyleBackColor = true;
            // 
            // GrpFormat
            // 
            GrpFormat.Controls.Add(RdbPhysique);
            GrpFormat.Controls.Add(RdbNumerique);
            GrpFormat.Location = new Point(650, 85);
            GrpFormat.Name = "GrpFormat";
            GrpFormat.Size = new Size(300, 55);
            GrpFormat.TabIndex = 9;
            GrpFormat.TabStop = false;
            GrpFormat.Text = "Format";
            // 
            // LblTitre
            // 
            LblTitre.AutoSize = true;
            LblTitre.Location = new Point(30, 50);
            LblTitre.Name = "LblTitre";
            LblTitre.Size = new Size(55, 25);
            LblTitre.TabIndex = 0;
            LblTitre.Text = "Titre :";
            // 
            // LblPlateforme
            // 
            LblPlateforme.AutoSize = true;
            LblPlateforme.Location = new Point(30, 100);
            LblPlateforme.Name = "LblPlateforme";
            LblPlateforme.Size = new Size(107, 25);
            LblPlateforme.TabIndex = 2;
            LblPlateforme.Text = "Plateforme :";
            // 
            // LblGenre
            // 
            LblGenre.AutoSize = true;
            LblGenre.Location = new Point(400, 50);
            LblGenre.Name = "LblGenre";
            LblGenre.Size = new Size(67, 25);
            LblGenre.TabIndex = 4;
            LblGenre.Text = "Genre :";
            // 
            // LblAnnee
            // 
            LblAnnee.AutoSize = true;
            LblAnnee.Location = new Point(400, 100);
            LblAnnee.Name = "LblAnnee";
            LblAnnee.Size = new Size(71, 25);
            LblAnnee.TabIndex = 6;
            LblAnnee.Text = "Année :";
            // 
            // LblTri
            // 
            LblTri.AutoSize = true;
            LblTri.Location = new Point(550, 163);
            LblTri.Name = "LblTri";
            LblTri.Size = new Size(84, 25);
            LblTri.TabIndex = 20;
            LblTri.Text = "Trier par :";
            // 
            // CmbTri
            // 
            CmbTri.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTri.FormattingEnabled = true;
            CmbTri.Items.AddRange(new object[] { "Titre", "Année", "Plateforme", "Genre" });
            CmbTri.Location = new Point(630, 160);
            CmbTri.Name = "CmbTri";
            CmbTri.Size = new Size(130, 33);
            CmbTri.TabIndex = 21;
            CmbTri.SelectedIndexChanged += CmbTri_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(CmbTri);
            Controls.Add(LblTri);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnSauvegarder);
            Controls.Add(LblTotal);
            Controls.Add(listView1);
            Controls.Add(BtnSupprimer);
            Controls.Add(BtnModifier);
            Controls.Add(BtnAjouter);
            Controls.Add(GrpFormat);
            Controls.Add(ChkMultijoueur);
            Controls.Add(TxtAnnee);
            Controls.Add(LblAnnee);
            Controls.Add(CmbGenre);
            Controls.Add(LblGenre);
            Controls.Add(CmbPlateforme);
            Controls.Add(LblPlateforme);
            Controls.Add(TxtTitre);
            Controls.Add(LblTitre);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            Text = "Bibliothèque de Jeux Vidéo";
            GrpFormat.ResumeLayout(false);
            GrpFormat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSauvegarder;
        private Button BtnQuitter;
        private ListView listView1;
        private ColumnHeader colTitre;
        private ColumnHeader colPlateforme;
        private ColumnHeader colGenre;
        private ColumnHeader colAnnee;
        private ColumnHeader colMultijoueur;
        private ColumnHeader colFormat;
        private Button BtnSupprimer;
        private Button BtnModifier;
        private Button BtnAjouter;
        private Label LblTotal;
        private TextBox TxtTitre;
        private TextBox TxtAnnee;
        private ComboBox CmbPlateforme;
        private ComboBox CmbGenre;
        private CheckBox ChkMultijoueur;
        private RadioButton RdbPhysique;
        private RadioButton RdbNumerique;
        private GroupBox GrpFormat;
        private Label LblTitre;
        private Label LblPlateforme;
        private Label LblGenre;
        private Label LblAnnee;
        private Label LblTri;
        private ComboBox CmbTri;
    }
}
