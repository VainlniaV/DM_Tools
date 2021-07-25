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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DM_Tools
{
    /// <summary>
    /// Logique d'interaction pour Bestiary_View.xaml
    /// </summary>
    public partial class Bestiary_View : Page
    {
        string filename = "monster.json";
        List<Monster> monstres = new List<Monster>();
        string json = File.ReadAllText("monster.json");

        public Bestiary_View()
        {
            InitializeComponent();
            monstres = JsonConvert.DeserializeObject<List<Monster>>(json);
            Refresh();
        }

        private void Test_Button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MonsterAdd ma = new MonsterAdd();
            ma.Show();
            Refresh();
        }

        private void Refresh()
        {
            ListViewTest.ItemsSource = null;
            string json = File.ReadAllText("monster.json");
            monstres = JsonConvert.DeserializeObject<List<Monster>>(json);
            ListViewTest.ItemsSource = monstres;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Monster item = ListViewTest.SelectedItem as Monster;
            monstres.Remove(item);
            string jsonAdd = JsonConvert.SerializeObject(monstres);
            File.WriteAllText(filename, jsonAdd);
            Refresh();
        }

        private void Button_Show_Click(object sender, RoutedEventArgs e)
        {
            Monster item = ListViewTest.SelectedItem as Monster;
            if (item != null)
            {
                Monster_Show ms = new Monster_Show(item);
                ms.Show();
            }       
        }
    }
}
