using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjmagasin
{
    class Magasin
    {
        private int id;
        private string localite;
        private string gerant;

        public int Id { get => id;}
        public string Localite { get => localite; }
        public string Gerant { get => gerant; }

        public Magasin(int id, string loc, string ger)
        {
            this.id = id;
            this.localite = loc;
            this.gerant = ger;
        }
        // Méthode qui renvoie une description d'un client sous la forme
        // d'une ligne au format Magasin n° id + localite + Gérant : gerant
        public string ToLine()
        {
            string res = "Magasin n° " + this.id + "\t" + this.localite + "\tGérant : " + this.gerant;
            return res;
        }
    }
}
