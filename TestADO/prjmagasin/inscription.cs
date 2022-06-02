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
    public partial class inscription : Form
    {
        string login;
        string selAStocker;
        string empreinte;
        public inscription()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            login = txtBoxLoginInscription.Text;
            string pwd = txtBoxMDPInscription.Text;

            //Générer un grain de sel
            byte[] grainDeSel = new byte[8];
            RNGCryptoServiceProvider p = new RNGCryptoServiceProvider();

            p.GetNonZeroBytes(grainDeSel);

            //Convertir en string
            selAStocker = Convert.ToBase64String(grainDeSel);

            //Hacher
            Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(pwd, grainDeSel, 8);
            empreinte = Convert.ToBase64String(hash.GetBytes(100));

            int res;
            string req = "INSERT INTO Utilisateur VALUES('" + txtBoxLoginInscription.Text + "','" + selAStocker + "','" + empreinte + "','" + txtBoxNom.Text + "','" + txtBoxPrenom.Text + "')";
            SqlCommand com = new SqlCommand(req, Connexion.getInstance());
            try
            {
                //On exécute la commande
                res = com.ExecuteNonQuery();

                //Libération de la commande
                com = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MessageBox.Show("Inscription effectuée");
            FormAuthentification fa = new FormAuthentification();
            fa.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAuthentification fa = new FormAuthentification();
            fa.Show();
            this.Hide();
        }
    }
}
