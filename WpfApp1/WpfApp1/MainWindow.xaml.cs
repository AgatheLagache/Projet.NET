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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random nb_random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Simulation_Click(object sender, RoutedEventArgs e)
        {
            Results results = new Results();
            results.Show();
        }

        private void Nb_Clients_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Fast_Clients_Choice.Text = nb_random.Next(1, 12).ToString();
            Nb_Ordinary_Clients_Choice.Text = nb_random.Next(1, 12).ToString();
            Nb_Slow_Clients_Choice.Text = nb_random.Next(1, 12).ToString();
        }

        private void Nb_Waiters_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Waiters_Choice.Text = nb_random.Next(1, 12).ToString();
        }

        private void Nb_Cooks_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Cooks_Choice.Text = nb_random.Next(1, 12).ToString();
        }
    }
}
