using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjmagasin
{
    public partial class FormAuthentification : Form
    {
        string login;
        string selAStocker;
        string empreinte;
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void FormAuthentification_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            string loginConnexion = txtBoxLogin.Text;
            string pwd = txtBoxMDP.Text;

            //rechercher sel et mdp en fonction du login saisi
            string req = "SELECT sel, mdp FROM Utilisateur where login='" + loginConnexion + "'";
            
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            SqlDataReader dr;
            dr = com.ExecuteReader();

            if (dr.Read())
            {



                string sel = dr[0].ToString();
                byte[] grainDeSel = Convert.FromBase64String(sel);


                //Hacher
                Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(pwd, grainDeSel, 8);
                string empreinteGeneree = Convert.ToBase64String(hash.GetBytes(100));


                string pwddb = dr[1].ToString();



                if (empreinteGeneree == pwddb)
                {
                    //MessageBox.Show("Connexion réussie");
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Connexion échouée");
                }

            }
            else
            {
                MessageBox.Show("Utilisateur on reconnu");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inscription fi = new inscription();
            fi.Show();
            this.Hide();
        }


    }
}
