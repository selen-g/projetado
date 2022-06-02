using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestADO
{
    public partial class FrmADO : Form
    {
        //declaration variable globale
        public SqlConnection cnGC;

        //constructeur 


        public FrmADO()
        {
            InitializeComponent();

            //Instanciation de la connexion
            string chaineDeConnexion;
            chaineDeConnexion = "Data Source= SRV-APP-2\\SQLSERVERSIO;" +
            "Initial Catalog=Gulver;" +
            "Integrated Security=SSPI;";
            try
            {
                cnGC = new SqlConnection(chaineDeConnexion);
                cnGC.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion :" + ex.Message);
            }
        }
        private void FrmADO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connecté sur " + cnGC.DataSource + "-->" + cnGC.Database + "Etat = " + cnGC.State);
        }

        private void cmdNbClient_Click(object sender, EventArgs e)
        {
            SqlCommand cmdNbClient;
            int nbClient;
            try
            {
                cmdNbClient = new SqlCommand("SELECT count(*) nbClient FROM client",
               cnGC);
                nbClient = (int)cmdNbClient.ExecuteScalar();
                MessageBox.Show("Il y a " + nbClient.ToString() + " clients");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }
        }

        private void cmdCA_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCA;
            float CA;
            try
            {
                cmdCA = new SqlCommand("SELECT sum(ca) FROM client", cnGC);
                CA = float.Parse(cmdCA.ExecuteScalar().ToString());
                MessageBox.Show("Il y a " + CA.ToString() + " de CA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmdUpdate;
            int resultat;
            try
            {
                cmdUpdate = new SqlCommand("UPDATE article SET prixVente = "
               + txtPrix.Text + " WHERE id = 3", cnGC);
                resultat = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show(resultat.ToString() + " ligne(s) mise(s) à jour");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }

        }

        private void txtCodeArticle_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmdUpdate;
            int resultat;
            try
            {
                cmdUpdate = new SqlCommand("UPDATE article SET prixVente = "
               + txtCodeArticle.Text + " WHERE id = 3", cnGC);
                resultat = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show(resultat.ToString() + " ligne(s) mise(s) à jour");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }

        }

        private void txtNouveauPrix_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmdUpdate;
            int resultat;
            try
            {
                cmdUpdate = new SqlCommand("UPDATE article SET prixVente = "
               + txtNouveauPrix.Text + " WHERE id = 3", cnGC);
                resultat = cmdUpdate.ExecuteNonQuery();
                MessageBox.Show(resultat.ToString() + " ligne(s) mise(s) à jour");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }

        }

        private void txtmagasin_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("select * from magasin where localite like '%" + txtmagasin.Text + "%'", cnGC);
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                string liste;
                liste = "";
                while (dr.Read())
                { //Tq il y a quelque chose à lire dans dr
                    liste = liste + dr["id"].ToString() + " " + dr["localite"].ToString() + " " + dr["gerant"].ToString() + "\n";
                    //ici utilisation des 2 méthodes d'accès au contenu
                }
                MessageBox.Show(liste, "Liste des magasins");
                dr.Close(); //Ferme le DataReader
                dr = null; //Libère le dataReader


            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dataReader :" + ex.Message);
            }

        }

        private void cboArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("select libelle from article", cnGC);
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                string liste;
                liste = "";
                while (dr.Read())
                { //Tq il y a quelque chose à lire dans dr ;
                     liste = liste + dr["libelle"].ToString() + "\n";
                    cboArticle.Items.Add(cmd);
                       
                    //ici utilisation des 2 méthodes d'accès au contenu
                }

                dr.Close(); //Ferme le DataReader
                dr = null; //Libère le dataReader
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dataReader :" + ex.Message);
            }





        }
    }
}


