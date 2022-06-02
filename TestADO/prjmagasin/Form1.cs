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


namespace prjmagasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> liste = CommandeDAO.GetListe();
            foreach (string s in liste)
            {
                cboCommande.Items.Add(s);
            }
        }

        //rechercher des magasins selon l'id
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string valTxtNumero = txtboxNum.Text;

            if (valTxtNumero == "")
            {
                MessageBox.Show("Veuillez entrer un numéro");
            }
            else
            {
                int id;
                id = int.Parse(txtboxNum.Text);
                Magasin m = MagasinDAO.FindById(id);
                if (m == null)
                {
                    MessageBox.Show("Ce magasin n'est pas répertorié");
                }
                else
                {
                    txtBoxLocalite.Text = m.Localite;
                    txtBoxGerant.Text = m.Gerant;
                }
                txtBoxNom.Text = "";
                txtBoxPrenom.Text = "";
                txtBoxMail.Text = "";
                richTBLigne.Text = "";
                txtBoxNumCli.Text = "";

            }

        }
        //lister les magasins
        private void btnListeMagasin_Click(object sender, EventArgs e)
        {
            string liste = "liste des magasins \n ";
            liste = liste + "-------------------------\n";
    
            foreach (Magasin m in MagasinDAO.ReadAll())
            {
                liste = liste + m.Id + "\t" + m.Localite + "\n";
            }
             MessageBox.Show(liste);
        }

        //crer/ ajouter un magasin
        private void btnCreer_Click(object sender, EventArgs e)
        {
            string valTxtNumero = txtboxNum.Text;
            string loc = txtBoxLocalite.Text;
            string ger = txtBoxGerant.Text;

            if (valTxtNumero == "" || loc == "" || ger == "")
            {
                MessageBox.Show("Veuillez compléter les informations manquantes");
            }
            else
            {
                int id = int.Parse(txtboxNum.Text);

                Magasin m = new Magasin(id, loc, ger);
                MagasinDAO.Create(m);
            }
        }

        //mettre a jour la table
        private void btnMAJ_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtboxNum.Text);
            string loc = txtBoxLocalite.Text;
            string ger = txtBoxGerant.Text;
            Magasin m = new Magasin(id, loc, ger);
            bool ok = MagasinDAO.Update(m);
            if (ok)
            {
                MessageBox.Show("Mise à jour réalisée");
            }
            else
            {
                MessageBox.Show("Mise à jour échouée");
            }
        }

        //supprimer un magasin
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Boolean res;
            Magasin m = new Magasin(int.Parse(txtboxNum.Text), txtBoxLocalite.Text, txtBoxGerant.Text);

            res = MagasinDAO.Delete(m);
            if (!res)
            {
                MessageBox.Show("Erreur de suppression");
            }
            else
            {
                MessageBox.Show("Suppression effectuée");
                txtboxNum.Clear();
                txtBoxLocalite.Clear();
                txtBoxGerant.Clear();
            }
        }
    
        //afficher les infos sur le magasin + client selon la commande
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = cboCommande.SelectedItem.ToString().Split('-');
            int id = int.Parse(temp[0]);
            Commande c = CommandeDAO.getById(id);
            //MessageBox.Show(c.ToString(), "Détail de la commande n°" + id);
            richTBLigne.Text = c.ToString();

            Magasin m = MagasinDAO.FindById(id);
            if (m == null)
            {
                MessageBox.Show("Ce magasin n'est pas répertorié");
            }
            else
            {
                txtBoxLocalite.Text = m.Localite;
                txtBoxGerant.Text = m.Gerant;
            }

            Client cl = ClientDAO.FindById(id);
                txtBoxNom.Text = cl.Nom;
                txtBoxPrenom.Text = cl.Prenom;
                txtBoxMail.Text = cl.Mail;
            
        }

        //rechercher un client
        private void btnRechercherCli_Click(object sender, EventArgs e)
        {
            string valTxtNumeroCli = txtBoxNumCli.Text;

            if (valTxtNumeroCli == "")
            {
                MessageBox.Show("Veuillez entrer un numéro");
            }
            else
            {
                int id;
                id = int.Parse(txtBoxNumCli.Text);
                Client cl = ClientDAO.FindById(id);
                if (cl == null)
                {
                    MessageBox.Show("Ce client n'est pas répertorié");
                }
                else
                {
                    txtBoxNom.Text = cl.Nom;
                    txtBoxPrenom.Text = cl.Prenom;
                    txtBoxMail.Text = cl.Mail;
                }
                txtBoxGerant.Text = "";
                txtBoxLocalite.Text = "";
                richTBLigne.Text = "";
                txtboxNum.Text = "";
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
