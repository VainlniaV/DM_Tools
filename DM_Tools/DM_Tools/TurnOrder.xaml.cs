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
    /// Logique d'interaction pour TurnOrder.xaml
    /// </summary>
    public partial class TurnOrder : Window
    {
        List<Turn> turnOrder = new List<Turn>();

        public TurnOrder()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            turnOrder.Add(new Turn(who.Text, int.Parse(how.Text)));
            SetDataGrid(turnOrder);
        }

        private void tri_Click(object sender, RoutedEventArgs e)
        {
            turnOrder = turnOrder.OrderByDescending(turnOrder => turnOrder.Valeur).ToList();
            SetDataGrid(turnOrder);
        }

        private void SetDataGrid(List<Turn> turnOrder)
        {
            turnOrderGrid.ItemsSource = turnOrder;
            turnOrderGrid.Items.Refresh();
            turnOrderGrid.SelectedIndex = 0;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            turnOrder = NextChar(turnOrder);
            SetDataGrid(turnOrder);
        }

        private void less_Click(object sender, RoutedEventArgs e)
        {
            how.Text = (int.Parse(how.Text) - 1).ToString();
        }

        private void more_Click(object sender, RoutedEventArgs e)
        {
            how.Text = (int.Parse(how.Text) + 1).ToString();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            turnOrder.RemoveAt(turnOrderGrid.SelectedIndex);
            SetDataGrid(turnOrder);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            turnOrder.Clear();
            SetDataGrid(turnOrder);
        }

        private List<Turn> NextChar(List<Turn> init)
        {
            List<Turn> end = new List<Turn>();
            for (var i = 0; i < init.Count; i++)
            {
                if (i + 1 == init.Count)
                {
                    end.Add(init[0]);
                }
                else
                {
                    end.Add(init[i + 1]);
                }
            }
            return end;
        }

    }
}
