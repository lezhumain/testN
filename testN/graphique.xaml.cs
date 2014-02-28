using System;
using System.Collections;
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

namespace testN
{
    /// <summary>
    /// Logique d'interaction pour graphique.xaml
    /// </summary>
    public partial class graphique : Window
    {
        public graphique()
        {
            InitializeComponent();

            List<int> liste = new List<int>();
            liste.Add(5);
            liste.Add(24);
            liste.Add(17);
            liste.Add(12);

            drawDatGraph(liste);
        }

        /// <summary>
        /// Dessine les histogrammes avec les valeurs
        /// contenues dans la liste en parametre
        /// </summary>
        /// <param name="valeurs"></param>
        private void drawDatGraph(List<int> valeurs)
        {
            int nb = valeurs.Count();
            double itWidth = this.ActualWidth / (2.0 * nb);
            double margin = itWidth / 2.0;
            List<Rectangle> rectangles = new List<Rectangle>();

            foreach(int val in valeurs)
            {
                Rectangle rec = new Rectangle();
                rec.Margin = new Thickness(0,margin,0,margin);
                rectangles.Add(rec);
            }

            foreach (Rectangle rec in rectangles)
                this.stp.Children.Add(rec);
        }
    }
}
