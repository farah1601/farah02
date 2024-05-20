using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Labo01
{
    public partial class GestionEtudiant : Form
    {

        int xSexeChecked = 2;

        public void Afficher_Liste_Etudiant()
        {
            ClLogin Etudiant = new ClLogin();
            MySqlDataReader Rs;
            Rs = Etudiant.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Etudiant.DataSource = dt;

        }

        public GestionEtudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String xUsername;
            xUsername = textRechercher.Text;

            ClLogin Etudiant = new ClLogin();
            MySqlDataReader Rs;
            Rs = Etudiant.Chercher(xUsername);
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Etudiant.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClLogin gesetud = new ClLogin();
            MySqlDataReader Rs;
            Rs = gesetud.Consulter();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Etudiant.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String xId;
            xId = textId.Text;

            ClLogin gesetud = new ClLogin();
            gesetud.Suppression(xId);
            MessageBox.Show("Suppression effectuer");
            Afficher_Liste_Etudiant();        
        }

        public void Load_tbl_Specialite_in_combobox()
        {
            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Lister_code_specialite();
            DataTable dt = new DataTable();
            dt.Columns.Add("code", typeof(string));
            dt.Load(Rs);
            comboBox2.ValueMember = "code";
            comboBox2.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xNomComplet,xUsername,xPassword, xSexe, xMobile,xEmail,xNiveau,xSpecialite;
            DateTime xDateNaissance;

            xNomComplet = txt_NometPrenom.Text;
            xUsername = txt_Nom.Text;
            xPassword = txt_Password.Text;
            xMobile = txt_Telephone.Text;
            xEmail = txt_Email.Text;
            xNiveau = comboBox1.Text;
            xSpecialite = comboBox2.Text;
            xDateNaissance = dateTimePicker1.Value;

            if (optHomme.Checked) xSexe = "Homme";
            else xSexe = "Femme";


            if (!string.IsNullOrEmpty(xNomComplet) && xUsername != "" && xPassword != "" && xMobile != ""  && xEmail != "" && xNiveau != "" && xSpecialite != "")
            {
                ClLogin gesetud = new ClLogin();
                gesetud.Ajouter(xNomComplet, xUsername, xPassword, xDateNaissance.ToShortDateString(), xSexe, xMobile, xEmail, xNiveau, xSpecialite);
                MessageBox.Show("Bien Ajouter");
                Afficher_Liste_Etudiant();            }
        }

        private void GestionEtudiant_Load(object sender, EventArgs e)
        {
            Afficher_Liste_Etudiant();
            Load_tbl_Specialite_in_combobox();

            optHomme.Checked = true;
                if (xSexeChecked == 2) optFemme.Checked = true;
               
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = $"C:";
            dialog.RestoreDirectory = true;
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Box_Picture.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
