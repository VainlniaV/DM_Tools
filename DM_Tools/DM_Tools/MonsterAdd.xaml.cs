using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour MonsterAdd.xaml
    /// </summary>
    public partial class MonsterAdd : Window
    {
        string filename = "monster.json";
        List<Monster> monstres = new List<Monster>();
        string json = File.ReadAllText("monster.json");

        public MonsterAdd()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            monstres = JsonConvert.DeserializeObject<List<Monster>>(json);

            var monstreAdd = new Monster(
                                         nameMonsterText.Text,
                                         heightMonsterText.Text,
                                         typeMonsterText.Text,
                                         alignmentMonsterText.Text,
                                         int.Parse(acMonsterText.Text),
                                         acTypeMonsterText.Text,
                                         int.Parse(hpMonsterText.Text),
                                         hpFormulaMonsterText.Text,
                                         new List<KeyValuePair<string, int>>() { new KeyValuePair<string, int>("Sol", int.Parse(walkSpeedText.Text)),
                                                                                new KeyValuePair<string, int>("Vol", int.Parse(flySpeedText.Text)),
                                                                                new KeyValuePair<string, int>("Nage", int.Parse(swimSpeedText.Text)),
                                                                                new KeyValuePair<string, int>("Escalade", int.Parse(climbSpeedText.Text))
                                                                                },
                                         new List<int>() { int.Parse(strengthMonsterText.Text),
                                                           int.Parse(dexterityMonsterText.Text),
                                                           int.Parse(constitutionMonsterText.Text),
                                                           int.Parse(intelligenceMonsterText.Text),
                                                           int.Parse(wisdomMonsterText.Text),
                                                           int.Parse(charismaMonsterText.Text)
                                                        },
                                         new List<bool>() { (bool)strengthMonsterBool.IsChecked,
                                                            (bool)dexterityMonsterBool.IsChecked,
                                                            (bool)constitutionMonsterBool.IsChecked,
                                                            (bool)intelligenceMonsterBool.IsChecked,
                                                            (bool)wisdomMonsterBool.IsChecked,
                                                            (bool)charismaMonsterBool.IsChecked
                                                           },
                                         new List<KeyValuePair<string, bool>>() { new KeyValuePair<string, bool>("Acrobatie", (bool)compAcrobatieMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Arcane", (bool)compArcaneMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Athlétisme", (bool)compAthletismeMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Discrétion", (bool)compDiscretionMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Dressage", (bool)compDressageMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Escamotage", (bool)compEscamotageMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Histoire", (bool)compHistoireMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Intimidation", (bool)compIntimidationMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Investigation", (bool)compInvestigationMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Médecine", (bool)compMedecineMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Nature", (bool)compNatureMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Perception", (bool)compPerceptionMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Perspicacité", (bool)compPerspicaciteMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Persuasion", (bool)compPersuasionMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Religion", (bool)compReligionMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Représentation", (bool)compRepresentationMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Survie", (bool)compSurvieMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Tromperie", (bool)compTromperieMonstre.IsChecked)
                                                                                },
                                         new List<KeyValuePair<string, bool>>() { new KeyValuePair<string, bool>("Commun", (bool)langCommunMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Elfe", (bool)langElfeMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Géant", (bool)langGeantMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Gnome", (bool)langGnomeMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Gobelin", (bool)langGobelinMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Halfelin", (bool)langHalfelinMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Nain", (bool)langNainMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Orc", (bool)langOrcMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Abyssal", (bool)langAbyssalMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Céleste", (bool)langCelesteMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Draconique", (bool)langDraconiqueMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Infernal", (bool)langInfernalMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Primordial", (bool)langPrimordialMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Profond", (bool)langProfondMonstre.IsChecked),
                                                                                new KeyValuePair<string, bool>("Sylvain", (bool)langSylvainMonstre.IsChecked)
                                                                                },
                                         vulnMonstre.Text,
                                         resMonstre.Text,
                                         immuDmgMonstre.Text,
                                         immuConMonstre.Text,
                                         sensMonstre.Text
                                        ) ;
            monstres.Add(monstreAdd);
            string jsonAdd = JsonConvert.SerializeObject(monstres);
            File.WriteAllText(filename, jsonAdd);
            Close();
        }

        private void nameMonsterText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameMonsterText.Text == "Nom")
            {
                nameMonsterText.Text = "";
            }

        }
        private void nameMonsterText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nameMonsterText.Text == "")
            {
                nameMonsterText.Text = "Nom";
            }
        }

        private void acMonsterText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (acMonsterText.Text == "CA")
            {
                acMonsterText.Text = "";
            }
        }

        private void acMonsterText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (acMonsterText.Text == "")
            {
                acMonsterText.Text = "CA";
            }
        }

        private void acTypeMonsterText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (acTypeMonsterText.Text == "Type")
            {
                acTypeMonsterText.Text = "";
            }
        }

        private void hpMonsterText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (hpMonsterText.Text == "PDV")
            {
                hpMonsterText.Text = "";
            }
        }

        private void hpMonsterText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (hpMonsterText.Text == "")
            {
                hpMonsterText.Text = "PDV";
            }
        }

        private void hpFormulaMonsterText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (hpFormulaMonsterText.Text == "Formule")
            {
                hpFormulaMonsterText.Text = "";
            }
        }

        private void hpFormulaMonsterText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (hpFormulaMonsterText.Text == "")
            {
                hpFormulaMonsterText.Text = "Formule";
            }
        }

        private void vulnMonstre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (vulnMonstre.Text == "Vulnérabilités aux dégâts")
            {
                vulnMonstre.Text = "";
            }
        }

        private void resMonstre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (resMonstre.Text == "Résistances aux dégâts")
            {
                resMonstre.Text = "";
            }
        }

        private void immuDmgMonstre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (immuDmgMonstre.Text == "Immunités aux dégâts")
            {
                immuDmgMonstre.Text = "";
            }
        }

        private void immuConMonstre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (immuConMonstre.Text == "Immunités aux conditions")
            {
                immuConMonstre.Text = "";
            }
        }

        private void sensMonstre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sensMonstre.Text == "Sens")
            {
                sensMonstre.Text = "";
            }
        }
    }
}
