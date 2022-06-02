using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjmagasin
{
    class Commande
    {
        //Attributs privés
        private int id;
        private string dateC;
        private int idClient;
        private int idMagasin;

        // Constructeur
        public Commande(int id, string dateC, int idClient, int idMagasin)
        {
            this.id = id;
            this.dateC = dateC;
            this.idClient = idClient;
            this.idMagasin = idMagasin;
        }

        //Accesseurs
        public int Id { get => id; }
        public string DateC { get => dateC; }
        public int IdClient { get => idClient; }
        public int IdMagasin { get => idMagasin; }
    
        // Méthode qui renvoie une description d'une commande sous la forme
        // d'une ligne au format Commande n° id + du date
        public string ToLine()
        {
            string res = "Commande n° " + this.id + "\t\t" + "du " + this.dateC;
            return res;
        }


        //Méthode qui renvoie une chaine qui décrit une commande
        // au format attendu dans le sujet...

        public override string ToString()
        {
            Article a = ArticleDAO.getById(id);
            Commande c = CommandeDAO.getById(id);
            //Client cl = ClientDAO.getById(id);
            //Magasin m = MagasinDAO.getById(id);
            List<LigneCmd> listc = LigneCmdDAO.ReadAllByCommande(id);




            float tot = 0;
            string res = c.ToLine() + "\n" + /*cl.ToLine() + "\n" + m.ToLine() + "\n" +*/
                "----------------------------------------------------------------------------------------------------------------------------------------------\n" +
                "N° \t Libellé \t  \t Quantité \t \t Prix unitaire \t Total" + "\t " + "\n" +
                "----------------------------------------------------------------------------------------------------------------------------------------------\n";
            foreach (LigneCmd lc in listc)
            {
                res += lc.ToLine() + "\n";
            }
            res += "--------------------------------------------------------------------------------------------------------------------------------------------\n";
            foreach (LigneCmd lc in listc)
            {
                tot += lc.GetTotal();
            }
            res += "Total  \t\t\t\t\t\t\t" + tot + "\n" +
            "----------------------------------------------------------------------------------------------------------------------------------------------\n";
            
            return res;
        }
    }
}