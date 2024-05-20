using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;


namespace Labo01
{
    internal class ClLogin
    {

        MySqlConnection cns = new MySqlConnection("server=localhost;uid=root;database=clogindb1");
        public void Ajouter(string NometPrenom, string Nom, string Password, string DateNaissance, string Sexe, string Telephone, string Email, string Niveau, string Specialite)
        {

            try
            {
                string Query = "INSERT INTO etudiant (nometprenom,nom,password,datenaissance,sexe,telephone,email,niveau,specialite) VALUES ('" + NometPrenom + "','" + Nom + "','" + Password + "','" + DateNaissance+ "','" + Sexe + "','" + Telephone + "','" + Email + "','" + Niveau + "','" + Specialite + "')";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modifier(string Login, string Password)
        {
            try
            {
                string Query = "UPDATE etudiant SET nom='" + Login + "' where password='" + Password + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Suppression(string Id)
        {
            try
            {
                string Query = "DELETE FROM etudiant where id='" + Id + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public MySqlDataReader Consulter()
        {
            try
            {
                string Query = "SELECT * FROM etudiant ORDER BY nom";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Consulter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public MySqlDataReader Lister()
        {
            try
            {
                string Query = "SELECT * FROM etudiant";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Lister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public MySqlDataReader Chercher(string nom)
        {
            try
            {
                string Query = "SELECT * FROM etudiant where nom like '%" + nom + "%'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Chercher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public bool Authentification(string Login, string Password)
        {
            try
            {
                bool Result = false;
                string Query = "SELECT * FROM etudiant WHERE nom='" + Login + "' AND password='" + Password + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                if (Rs.HasRows) Result = true;
                cns.Close();
                return Result;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;   
            }
        }
    }
}
