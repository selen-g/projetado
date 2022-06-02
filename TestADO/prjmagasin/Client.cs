using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjmagasin
{
    class Client
    {
        //Attributs privés
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string pays;
        private string localite;
        private float ca;

        //Constructeur
        public Client(int id, string nom, string prenom, string mail, string pays, string localite, float ca)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.pays = pays;
            this.localite = localite;
            this.ca = ca;
        }

        //Accesseurs
        public int Id { get => id; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Mail { get => mail; }
        public string Pays { get => pays; }
        public string Localite { get => localite; }
        public float Ca { get => ca; }

        // Méthode qui renvoie une description d'un client sous la forme
        // d'une ligne au format   Client n° id + nom + localite + (libelle type client)
        public string ToLine()
        {

            string res = "Client n° " + this.id + "\t\t" + this.localite /*+ "(" + this.codeTypeClient + ")"*/;
            return res;
        }
    }
}
