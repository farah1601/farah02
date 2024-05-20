namespace Labo01
{
    partial class GestionEtudiant
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
            this.Box_Picture = new System.Windows.Forms.PictureBox();
            this.bt_Browser = new System.Windows.Forms.Button();
            this.lbl_NometPrenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Niveau = new System.Windows.Forms.Label();
            this.lbl_Specialite = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NometPrenom = new System.Windows.Forms.TextBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.List_Etudiant = new System.Windows.Forms.DataGridView();
            this.bt_Recherche = new System.Windows.Forms.Button();
            this.textRechercher = new System.Windows.Forms.TextBox();
            this.bt_Afficher = new System.Windows.Forms.Button();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.optHomme = new System.Windows.Forms.RadioButton();
            this.optFemme = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_Etudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_Picture
            // 
            this.Box_Picture.Location = new System.Drawing.Point(12, 19);
            this.Box_Picture.Name = "Box_Picture";
            this.Box_Picture.Size = new System.Drawing.Size(189, 147);
            this.Box_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box_Picture.TabIndex = 0;
            this.Box_Picture.TabStop = false;
            // 
            // bt_Browser
            // 
            this.bt_Browser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Browser.Location = new System.Drawing.Point(35, 175);
            this.bt_Browser.Name = "bt_Browser";
            this.bt_Browser.Size = new System.Drawing.Size(142, 31);
            this.bt_Browser.TabIndex = 1;
            this.bt_Browser.Text = "Browser";
            this.bt_Browser.UseVisualStyleBackColor = true;
            this.bt_Browser.Click += new System.EventHandler(this.bt_Browser_Click);
            // 
            // lbl_NometPrenom
            // 
            this.lbl_NometPrenom.AutoSize = true;
            this.lbl_NometPrenom.Location = new System.Drawing.Point(227, 22);
            this.lbl_NometPrenom.Name = "lbl_NometPrenom";
            this.lbl_NometPrenom.Size = new System.Drawing.Size(80, 13);
            this.lbl_NometPrenom.TabIndex = 2;
            this.lbl_NometPrenom.Text = "Nom et Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Naissance";
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Location = new System.Drawing.Point(227, 158);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(58, 13);
            this.lbl_Telephone.TabIndex = 4;
            this.lbl_Telephone.Text = "Telephone";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(227, 184);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Niveau
            // 
            this.lbl_Niveau.AutoSize = true;
            this.lbl_Niveau.Location = new System.Drawing.Point(227, 210);
            this.lbl_Niveau.Name = "lbl_Niveau";
            this.lbl_Niveau.Size = new System.Drawing.Size(41, 13);
            this.lbl_Niveau.TabIndex = 6;
            this.lbl_Niveau.Text = "Niveau";
            // 
            // lbl_Specialite
            // 
            this.lbl_Specialite.AutoSize = true;
            this.lbl_Specialite.Location = new System.Drawing.Point(227, 237);
            this.lbl_Specialite.Name = "lbl_Specialite";
            this.lbl_Specialite.Size = new System.Drawing.Size(53, 13);
            this.lbl_Specialite.TabIndex = 7;
            this.lbl_Specialite.Text = "Spécialite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sexe";
            // 
            // txt_NometPrenom
            // 
            this.txt_NometPrenom.Location = new System.Drawing.Point(313, 19);
            this.txt_NometPrenom.Name = "txt_NometPrenom";
            this.txt_NometPrenom.Size = new System.Drawing.Size(341, 20);
            this.txt_NometPrenom.TabIndex = 11;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(313, 155);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(289, 20);
            this.txt_Telephone.TabIndex = 13;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(313, 181);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(289, 20);
            this.txt_Email.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BTP",
            "BTS"});
            this.comboBox1.Location = new System.Drawing.Point(313, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(313, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // List_Etudiant
            // 
            this.List_Etudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_Etudiant.Location = new System.Drawing.Point(156, 310);
            this.List_Etudiant.Name = "List_Etudiant";
            this.List_Etudiant.Size = new System.Drawing.Size(1012, 164);
            this.List_Etudiant.TabIndex = 17;
            // 
            // bt_Recherche
            // 
            this.bt_Recherche.Location = new System.Drawing.Point(230, 271);
            this.bt_Recherche.Name = "bt_Recherche";
            this.bt_Recherche.Size = new System.Drawing.Size(75, 23);
            this.bt_Recherche.TabIndex = 18;
            this.bt_Recherche.Text = "Rechercher";
            this.bt_Recherche.UseVisualStyleBackColor = true;
            this.bt_Recherche.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRechercher
            // 
            this.textRechercher.Location = new System.Drawing.Point(313, 271);
            this.textRechercher.Name = "textRechercher";
            this.textRechercher.Size = new System.Drawing.Size(231, 20);
            this.textRechercher.TabIndex = 20;
            // 
            // bt_Afficher
            // 
            this.bt_Afficher.Location = new System.Drawing.Point(12, 310);
            this.bt_Afficher.Name = "bt_Afficher";
            this.bt_Afficher.Size = new System.Drawing.Size(118, 23);
            this.bt_Afficher.TabIndex = 21;
            this.bt_Afficher.Text = "Afficher";
            this.bt_Afficher.UseVisualStyleBackColor = true;
            this.bt_Afficher.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Supprimer
            // 
            this.bt_Supprimer.Location = new System.Drawing.Point(12, 364);
            this.bt_Supprimer.Name = "bt_Supprimer";
            this.bt_Supprimer.Size = new System.Drawing.Size(118, 23);
            this.bt_Supprimer.TabIndex = 22;
            this.bt_Supprimer.Text = "Suppression ";
            this.bt_Supprimer.UseVisualStyleBackColor = true;
            this.bt_Supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(12, 418);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(118, 20);
            this.textId.TabIndex = 23;
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.Location = new System.Drawing.Point(683, 18);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.Size = new System.Drawing.Size(85, 21);
            this.bt_Ajouter.TabIndex = 24;
            this.bt_Ajouter.Text = "Ajouter";
            this.bt_Ajouter.UseVisualStyleBackColor = true;
            this.bt_Ajouter.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(230, 48);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Nom.TabIndex = 25;
            this.lbl_Nom.Text = "Nom ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(313, 71);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(289, 20);
            this.txt_Password.TabIndex = 27;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(313, 45);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(289, 20);
            this.txt_Nom.TabIndex = 28;
            // 
            // optHomme
            // 
            this.optHomme.AutoSize = true;
            this.optHomme.Location = new System.Drawing.Point(332, 131);
            this.optHomme.Name = "optHomme";
            this.optHomme.Size = new System.Drawing.Size(61, 17);
            this.optHomme.TabIndex = 31;
            this.optHomme.TabStop = true;
            this.optHomme.Text = "Homme";
            this.optHomme.UseVisualStyleBackColor = true;
            // 
            // optFemme
            // 
            this.optFemme.AutoSize = true;
            this.optFemme.Location = new System.Drawing.Point(449, 131);
            this.optFemme.Name = "optFemme";
            this.optFemme.Size = new System.Drawing.Size(59, 17);
            this.optFemme.TabIndex = 32;
            this.optFemme.TabStop = true;
            this.optFemme.Text = "Femme";
            this.optFemme.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GestionEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 486);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.optFemme);
            this.Controls.Add(this.optHomme);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.bt_Ajouter);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.bt_Supprimer);
            this.Controls.Add(this.bt_Afficher);
            this.Controls.Add(this.textRechercher);
            this.Controls.Add(this.bt_Recherche);
            this.Controls.Add(this.List_Etudiant);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Telephone);
            this.Controls.Add(this.txt_NometPrenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Specialite);
            this.Controls.Add(this.lbl_Niveau);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NometPrenom);
            this.Controls.Add(this.bt_Browser);
            this.Controls.Add(this.Box_Picture);
            this.Name = "GestionEtudiant";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.GestionEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Box_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_Etudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box_Picture;
        private System.Windows.Forms.Button bt_Browser;
        private System.Windows.Forms.Label lbl_NometPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Niveau;
        private System.Windows.Forms.Label lbl_Specialite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NometPrenom;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView List_Etudiant;
        private System.Windows.Forms.Button bt_Recherche;
        private System.Windows.Forms.TextBox textRechercher;
        private System.Windows.Forms.Button bt_Afficher;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.RadioButton optHomme;
        private System.Windows.Forms.RadioButton optFemme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}