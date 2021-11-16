using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Tools
{
    public class Turn
    {
        public string Nom { get; private set; }
        public int Valeur { get; private set; }

        public Turn(string nom, int valeur)
        {
            this.Nom = nom;
            this.Valeur = valeur;
        }
    }
}
