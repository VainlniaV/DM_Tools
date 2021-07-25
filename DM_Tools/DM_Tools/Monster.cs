using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Tools
{
    public class Monster
    {
        public string nomMonstre { get; private set; }
        public string typeMonstre { get; private set; }
        public string tailleMonstre { get; private set; }
        public string alignementMonstre { get; private set; }
        public int classeArmureMonstre { get; private set; }
        public string typearmureMonstre { get; private set; }
        public int pdvMonstre { get; private set; }
        public string pdvFormuleMonstre { get; private set; }
        public List<KeyValuePair<string, int>> vitesseMonstre { get; private set; }
        public List<int> caracteristiqueMonstre { get; private set; }
        public List<bool> sauvegardeMonstre { get; private set; }
        public List<KeyValuePair<string, bool>> competenceMonstre { get; private set; }
        public List<KeyValuePair<string, bool>> langageMonstre { get; private set; }
        public string vulnMonstre { get; private set; }
        public string resMonstre { get; private set; }
        public string immuDmgMonstre { get; private set; }
        public string immuConMonstre { get; private set; }
        public string sensMonstre { get; private set; }

        public Monster(string nomMonstre,
                       string tailleMonstre,
                       string typeMonstre,
                       string alignementMonstre,
                       int classeArmureMonstre,
                       string typearmureMonstre,
                       int pdvMonstre,
                       string pdvFormuleMonstre,
                       List<KeyValuePair<string, int>> vitesseMonstre,
                       List<int> caracteristiqueMonstre,
                       List<bool> sauvegardeMonstre,
                       List<KeyValuePair<string, bool>> competenceMonstre,
                       List<KeyValuePair<string, bool>> langageMonstre,
                       string vulnMonstre,
                       string resMonstre,
                       string immuDmgMonstre,
                       string immuConMonstre,
                       string sensMonstre
        )
        {
            this.nomMonstre = nomMonstre;
            this.tailleMonstre = tailleMonstre;
            this.typeMonstre = typeMonstre;
            this.alignementMonstre = alignementMonstre;
            this.classeArmureMonstre = classeArmureMonstre;
            this.typearmureMonstre = typearmureMonstre;
            this.pdvMonstre = pdvMonstre;
            this.pdvFormuleMonstre = pdvFormuleMonstre;
            this.vitesseMonstre = vitesseMonstre;
            this.caracteristiqueMonstre = caracteristiqueMonstre;
            this.sauvegardeMonstre = sauvegardeMonstre;
            this.competenceMonstre = competenceMonstre;
            this.langageMonstre = langageMonstre;
            this.vulnMonstre = vulnMonstre;
            this.resMonstre = resMonstre;
            this.immuDmgMonstre = immuDmgMonstre;
            this.immuConMonstre = immuConMonstre;
            this.sensMonstre = sensMonstre;
        }
    }
}
