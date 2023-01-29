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


namespace CeUAA14Partie2_POO_Michaux
{
    internal class Interface
    {
        MainWindow Jeu = (CeUAA14Partie2_POO_Michaux.MainWindow)App.Current.MainWindow;
        public void setupInterface()
        {
            Jeu.Width = 800;
            Jeu.Height = 720;
            Jeu.FontSize = 30;

            Grid gridPlateau = new Grid();
            RowDefinition[] rowdef = new RowDefinition[10];
            ColumnDefinition[] colDef = new ColumnDefinition[10];

            for (int i = 0; i < 10; i++)
            {
                rowdef[i] = new RowDefinition();
                gridPlateau.RowDefinitions.Add(rowdef[i]);
            }

            for (int y = 0; y < 10; y++)
            {
                colDef[y] = new ColumnDefinition();
                gridPlateau.ColumnDefinitions.Add(colDef[y]);
            }

            Grid.SetColumn(gridPlateau, 0);
            Grid.SetRow(gridPlateau, 1);
            Jeu.grdMain.Children.Add(gridPlateau);

            for (int x = 0; x < 10; x++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Jeu.btnJeux[x, j] = new Button();
                    if (x % 2 == 0)
                    {
                        int numberCase = (10 * x) + j + 1;
                        Jeu.btnJeux[x, j].Content = Convert.ToString(numberCase);

                    }
                    else
                    {
                        int numberCase = (10 * x) + 10 - j;
                        Jeu.btnJeux[x, j].Content = Convert.ToString(numberCase);
                    }

                    if (int.Parse((string)Jeu.btnJeux[x, j].Content) % 2 == 0)
                    {
                        Jeu.btnJeux[x, j].Background = Brushes.Blue;
                    }
                    else
                    {
                        Jeu.btnJeux[x, j].Background = Brushes.Red;
                    }

                    Jeu.btnJeux[x, j].HorizontalAlignment = HorizontalAlignment.Center;
                    Jeu.btnJeux[x, j].VerticalAlignment = VerticalAlignment.Center;
                    Jeu.btnJeux[x, j].Width = 60;
                    Jeu.btnJeux[x, j].Height = 60;
                    Grid.SetRow(Jeu.btnJeux[x, j], x);
                    Grid.SetColumn(Jeu.btnJeux[x, j], j);

                    gridPlateau.Children.Add(Jeu.btnJeux[x, j]);

                }
            }


        }
    }
}
