using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DM_Tools
{
    /// <summary>
    /// Logique d'interaction pour Monster_Show.xaml
    /// </summary>
    public partial class Monster_Show : Window
    {
        public Monster_Show(Monster monster)
        {
            InitializeComponent();
            
            windowMonsterShow.Title = monster.nomMonstre;
            // Définition des attributs du monstre
            // Nom
            monsterNameText.Content = monster.nomMonstre;
            // Infos
            monsterInfoText.Content = monster.typeMonstre + " de taille " + monster.tailleMonstre + ", " + monster.alignementMonstre;
            // Classe d'armure
            acMonsterText.Content = "Classe d'armure " + monster.classeArmureMonstre;
            if (!string.IsNullOrEmpty(monster.typearmureMonstre))
            {
                acMonsterText.Content += " (" + monster.typearmureMonstre + ")";
            }
            // Points de Vie
            hpMonsterText.Content = "Points de vie " + monster.pdvMonstre + " (" + monster.pdvFormuleMonstre + ")";
            // Vitesse
            setSpeed(monster);
            // Caractéristique
            setCaract(monster);
            // Jets de sauvegarde
            setSaveCaract(monster);
            // Compétences
            setComp(monster);
            // Vulnérabilités
            if(!string.IsNullOrEmpty(monster.vulnMonstre))
            {
                vulnMonsterText.Content += " " + monster.vulnMonstre;
            }
            else
            {
                vulnMonsterText.Visibility = Visibility.Collapsed;
            }
            // Résistances
            if (!string.IsNullOrEmpty(monster.resMonstre))
            {
                resMonsterText.Content += " " + monster.resMonstre;
            }
            else
            {
                resMonsterText.Visibility = Visibility.Collapsed;
            }
            // Immunités dégâts
            if (!string.IsNullOrEmpty(monster.immuDmgMonstre))
            {
                immuDmgMonsterText.Content += " " + monster.immuDmgMonstre;
            }
            else
            {
                immuDmgMonsterText.Visibility = Visibility.Collapsed;
            }
            // Vulnérabilité
            if (!string.IsNullOrEmpty(monster.immuConMonstre))
            {
                immuConMonsterText.Content += " " + monster.immuConMonstre;
            }
            else
            {
                immuConMonsterText.Visibility = Visibility.Collapsed;
            }
            // Sens
            sensMonsterText.Content += " " + monster.sensMonstre;
            // Langage
            setLanguage(monster);
        }

        public void setSpeed(Monster monster)
        {
            bool multiSpeed = false;
            foreach (var vit in monster.vitesseMonstre)
            {
                if (vit.Value != 0)
                {
                    if (multiSpeed)
                    {
                        speedMonsterText.Content += ", ";
                    }
                    else
                    {
                        speedMonsterText.Content += " ";
                    }
                    if (vit.Key == "Sol")
                    {
                        speedMonsterText.Content += vit.Value + " m";
                    }
                    else
                    {
                        speedMonsterText.Content += vit.Key + " " + vit.Value + " m";
                    }
                    multiSpeed = true;
                }
            }
        }

        public void setCaract(Monster monster)
        {
            strMonsterText.Content = monster.caracteristiqueMonstre[0] + " (" + GetBonus(monster.caracteristiqueMonstre[0]) + ")";
            dexMonsterText.Content = monster.caracteristiqueMonstre[1] + " (" + GetBonus(monster.caracteristiqueMonstre[1]) + ")";
            conMonsterText.Content = monster.caracteristiqueMonstre[2] + " (" + GetBonus(monster.caracteristiqueMonstre[2]) + ")";
            intMonsterText.Content = monster.caracteristiqueMonstre[3] + " (" + GetBonus(monster.caracteristiqueMonstre[3]) + ")";
            wisMonsterText.Content = monster.caracteristiqueMonstre[4] + " (" + GetBonus(monster.caracteristiqueMonstre[4]) + ")";
            chaMonsterText.Content = monster.caracteristiqueMonstre[5] + " (" + GetBonus(monster.caracteristiqueMonstre[5]) + ")";
        }

        public void setSaveCaract(Monster monster)
        {
            if (monster.sauvegardeMonstre.Count != 0)
            {
                bool multiCaract = false;
                saveMonsterText.Content = "Jets de sauvegarde";
                for (var i = 0; i <= 5; i++)
                {
                    if (monster.sauvegardeMonstre[i])
                    {
                        if (multiCaract)
                            saveMonsterText.Content += ", ";

                        if (i == 0)
                            saveMonsterText.Content += " For ";
                        else if (i == 1)
                            saveMonsterText.Content += " Dex ";
                        else if (i == 2)
                            saveMonsterText.Content += " Con ";
                        else if (i == 3)
                            saveMonsterText.Content += " Int ";
                        else if (i == 4)
                            saveMonsterText.Content += " Sag ";
                        else if (i == 5)
                            saveMonsterText.Content += " Cha ";
                        saveMonsterText.Content += GetBonus(monster.caracteristiqueMonstre[i]);
                        multiCaract = true;
                    }
                }
            }
            else
            {
                saveMonsterText.Visibility = Visibility.Collapsed;
            }          
        }

        public void setComp(Monster monster)
        {
            if (monster.competenceMonstre.Count != 0)
            {
                foreach (var comp in monster.competenceMonstre)
                {
                    if (comp.Value)
                    {
                        compMonsterText.Content += " " + comp.Key;
                    }
                }
            }
            else
            {
                compMonsterText.Visibility = Visibility.Collapsed;
            }         
        }

        public void setLanguage(Monster monster)
        {
            bool multiSpeek = false;
            foreach (var lang in monster.langageMonstre)
            {
                if (lang.Value)
                {
                    if (multiSpeek)
                    {
                        speekMonsterText.Content += ", ";
                    }
                    else
                    {
                        speekMonsterText.Content += " ";
                        multiSpeek = true;
                    }
                    speekMonsterText.Content += lang.Key;
                }
            }
        }

        public string GetBonus(int caracValue)
        {
            if(caracValue == 1)
                return "-5";
            else if(caracValue <= 3)
                return "-4";
            else if (caracValue <= 5)
                return "-3";
            else if (caracValue <= 7)
                return "-2";
            else if (caracValue <= 9)
                return "-1";
            else if (caracValue <= 11)
                return "+0";
            else if (caracValue <= 13)
                return "+1";
            else if (caracValue <= 15)
                return "+2";
            else if (caracValue <= 17)
                return "+3";
            else if (caracValue <= 19)
                return "+4";
            else if (caracValue <= 21)
                return "+5";
            else if (caracValue <= 23)
                return "+6";
            else if (caracValue <= 25)
                return "+7";
            else if (caracValue <= 27)
                return "+8";
            else if (caracValue <= 29)
                return "+9";
            else
                return "+10";
        }
    }
}
