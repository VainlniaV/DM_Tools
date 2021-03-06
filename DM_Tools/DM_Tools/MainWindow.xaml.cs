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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DM_Tools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Bestiary_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Bestiary_View();
        }

        private void Button_TurnOrder_Click(object sender, RoutedEventArgs e)
        {
            TurnOrder to = new TurnOrder();
            to.Show();
        }
    }
}
