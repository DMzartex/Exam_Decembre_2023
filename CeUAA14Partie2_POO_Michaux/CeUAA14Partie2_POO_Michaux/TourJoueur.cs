using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CeUAA14Partie2_POO_Michaux
{
    internal class TourJoueur
    {
        private int _totalJoueur;

		public int TotalJoueur
		{
			get { return _totalJoueur; }
			set { _totalJoueur = value; }
		}

		private int[] _positionPionJoueur;

		public int[] PositionPionJoueur
		{
			get { return _positionPionJoueur; }
			set { _positionPionJoueur = value; }
		}

		private string _iconJoueur;

		public string IconJoueur
		{
			get { return _iconJoueur; }
			set { _iconJoueur = value; }
		}

		private string _ancienneValeur;

		public string AncienneValeur
		{
			get { return _ancienneValeur; }
			set { _ancienneValeur = value; }
		}
		
		public TourJoueur()
		{
            AncienneValeur = "1";
			PositionPionJoueur = new int[] { 0, 0 };
            IconJoueur = "X";
            TotalJoueur = 1;
		}

        public void TourPlateau(int numeroJoueur)
        {
            MainWindow Jeu = (CeUAA14Partie2_POO_Michaux.MainWindow)App.Current.MainWindow;
            Random alea = new Random();
            int de = alea.Next(1, 7);
            Jeu.nameJoueur.Text = "Joueur" + numeroJoueur;
            Jeu.infoDe.Text = "Dé : " + de;
            int reste;
            Jeu.btnJeux[PositionPionJoueur[0], PositionPionJoueur[1]].Content = AncienneValeur;
            Jeu.btnJeux[PositionPionJoueur[0], PositionPionJoueur[1]].Foreground = Brushes.Black;
            TotalJoueur += de;
            reste = TotalJoueur - 10 * (PositionPionJoueur[0] + 1);
            if (reste < 0)
            {
                reste += 10;
            }
            else
            {
                PositionPionJoueur[0] += 1;
            }
            if (PositionPionJoueur[0] % 2 != 0)
            {
                PositionPionJoueur[1] = 9 - reste;
            }
            else
            {
                PositionPionJoueur[1] = reste;
            }
            if (PositionPionJoueur[0] <= 9)
            {
                AncienneValeur = Jeu.btnJeux[PositionPionJoueur[0], PositionPionJoueur[1]].Content.ToString();
                Jeu.btnJeux[PositionPionJoueur[0], PositionPionJoueur[1]].Content = IconJoueur;
                Jeu.btnJeux[PositionPionJoueur[0], PositionPionJoueur[1]].Foreground = Brushes.Gold;
            }
            else
            {
                Jeu.nameJoueur.Text = "Fin !";
                Jeu.btnJeux[9, 0].Content = IconJoueur;
                Jeu.btnJeux[9, 0].Foreground = Brushes.Gold;
                Jeu.btnPlay.IsEnabled = false;
            }
        }
    }
}
