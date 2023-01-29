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

namespace CeUAA14Partie2_POO_Michaux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public Button[,] btnJeux = new Button[10, 10];
        TourJoueur tourJoueur = new TourJoueur();
        public MainWindow()
        {
            InitializeComponent();
            Interface setupInterface = new Interface();
            setupInterface.setupInterface();
        }

        private void ClickJouer(object sender, RoutedEventArgs e)
        {
            tourJoueur.TourPlateau(1);
        }

    }
}
