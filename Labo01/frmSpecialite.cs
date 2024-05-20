﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Labo01
{
    
    public partial class frmSpecialite : Form
    {
        public void Afficher_Liste_Specialite()
        {
            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Specialite.DataSource = dt;

        }
        public frmSpecialite()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
           
                string xCode, xSpecialite;
                xCode = txt_Code.Text;
                xSpecialite = txt_Specialite.Text;
                if (!string.IsNullOrEmpty(xCode)  && xSpecialite != "")
                {
                ClSpecialite Spt = new ClSpecialite(); 
                Spt.Ajouter(xCode,xSpecialite);
                Afficher_Liste_Specialite();
                }
               
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Afficher_Liste_Specialite();

        }

        private void List_Specialite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afficher_Liste_Specialite();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String xCode;
            xCode = txt_Code.Text;

            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Chercher(xCode);
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Specialite.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String xCode;
            xCode = txt_Code.Text;

            ClSpecialite Spt = new ClSpecialite();
            Spt.Suppression(xCode);
            Afficher_Liste_Specialite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xCode, xSpecialite;
            xCode = txt_Code.Text;
            xSpecialite = txt_Specialite.Text;

            ClSpecialite Spt = new ClSpecialite();
            Spt.Modifier(xCode, xSpecialite);
            Afficher_Liste_Specialite();
        }

        private void txt_Specialite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
