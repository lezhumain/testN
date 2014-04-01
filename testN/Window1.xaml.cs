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

namespace testN
{
    ///
    /// \brief Logique d'interaction pour Window1.xaml
    ///
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            showColumnChart();
        }

        private void bouton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// 
        /// \brief  Cree un histogramme a partir d'une
        ///         liste cree en dur
        /// 
        private void showColumnChart()
        {
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();
            MyValue.Add(new KeyValuePair<string, int>("Mahak", 300));
            MyValue.Add(new KeyValuePair<string, int>("Pihu", 250));
            MyValue.Add(new KeyValuePair<string, int>("Rahul", 289));
            MyValue.Add(new KeyValuePair<string, int>("Raj", 256));
            MyValue.Add(new KeyValuePair<string, int>("Vikas", 140));

            this.chartapute.DataContext = MyValue;
        }

        /// 
        /// \brief  Cree un histogramme a partir des parametres (surcharge)
        /// 
        /// \param  keys Liste de String qui identifieront les valeurs (affiches sur l'axe x)
        ///         values Liste de int représentant les valeurs à afficher dans le graph
        /// 
        private void showColumnChart(List<string> keys, List<int> values)
        {
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();
            int cnt = keys.Count();
           
            for(int i = 0; i < cnt; ++i)
                MyValue.Add(new KeyValuePair<string, int>(keys[i], values[i]));
            
            this.chartapute.DataContext = MyValue;
        }

        /// 
        /// \brief  Cree un histogramme a partir des parametres (surcharge)
        ///         Appelle ensuite 'showColumnChart(keys, values)'
        ///         avec    keys : liste des noms de chaque Entite
        ///                 values : liste des nombres de rapports de chaque Entite
        /// \param  
        ///     collabs Liste d'entites COLLABORATEUR
        /// 
        private void showColumnChart(List<COLLABORATEUR> collabs)
        {
            List<string> keys = new List<string>();
            List<int> values = new List<int>();
            
            foreach (COLLABORATEUR cols in collabs)
            {
                keys.Add(cols.nom_col);
                values.Add( cols.RAPPORT_DE_VISITE.Count() );
            }

            showColumnChart(keys, values);
        }
    }
}
