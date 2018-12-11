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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Résultat.xaml
    /// </summary>
    public partial class Results : Window
    {
        public static Results results = null;
        public Results()
        {
            InitializeComponent();
        }

        public Results GetResults()
        {
            if (results == null)
            {
                results = new Results();
            }
            results.Show();
            return results;
        }
    }
}
