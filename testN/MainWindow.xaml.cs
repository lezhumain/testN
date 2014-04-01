using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace testN
{
    /// 
    /// \brief Logique d'interaction pour MainWindow.xaml
    /// 
    public partial class MainWindow : Window
    {
        //private DBSet<MOTIF> customersViewSource;
        private BDD_SIO7_CONNSETT BDDentites;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Desactive un bouton d'apres son nom
        /// (noms entres en dur)
        /// </summary>
        /// \param 
        ///     name Le nom du bouton a desactiver
        /// 
        private void desBtn(string name)
        {
            switch (name)
            {
                case "btprat":
                    btprat.IsEnabled = false;
                    btcolla.IsEnabled = true;
                    btrapp.IsEnabled = true;
                    break;
                case "btcolla":
                    btprat.IsEnabled = true;
                    btcolla.IsEnabled = false;
                    btrapp.IsEnabled = true;
                    break;
                case "btrapp":
                    btprat.IsEnabled = true;
                    btcolla.IsEnabled = true;
                    btrapp.IsEnabled = false;
                    break;
            }
        }

        /// <summary>
        /// Handler pour l'evnmt window_loaded
        /// </summary>
        /// <param name="sender">objet emetteur</param>
        /// <param name="e">evenement concerne</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BDDentites = new BDD_SIO7_CONNSETT();
            
            /* Remplissage de la grille */
            fillGrid('c');

            /* Remplissage de la comboBox des filtres */
            fillCombo();

            // on desactive le bouton deja aff
            desBtn("btcolla");
        }

        /// <summary>
        /// Ferme l'application
        /// </summary>
        private void btquit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Rempli la comboBox qui permet de filtrer l'affichage
        /// avec les noms entres en dur
        /// </summary>
        private void fillCombo()
        {
            List<string> l = new List<string>();

            l.Add("Général");
            l.Add("Matricule");
            l.Add("Prenom");
            l.Add("Nom");
            
            filtreType.ItemsSource = l;
        }

        /// <summary>
        /// Rempli la comboBox qui permet de filtrer l'affichage
        /// avec la liste passee en parametre
        /// </summary>
        /// <param name="l">liste de string dont les valeurs seront affichees ds la cb</param>
        private void fillCombo(List<string> l)
        {
            filtreType.ItemsSource = l;
        }

        /// <summary>
        /// Rempli la grille qui affiche les informations
        /// </summary>
        /// <param name="type">char qui permet d'identifier un type de vue:
        ///     c->collaborateur;</param>
        private void fillGrid(char type)
        {           
            switch (type)
            {
                case 'c':
                    var qmots = from colla in BDDentites.COLLABORATEUR
                            select new { colla.matricule_col, colla.nom_col, colla.prenom_col, colla.ville_col };

                    if (qmots.Count() == 0)
                        MaGrid.ItemsSource = null;
                    else
                        MaGrid.ItemsSource = qmots.ToList();
                    break;

                case 'r':
                    var qmot = from colla in BDDentites.RAPPORT_DE_VISITE
                            select colla ;

                    if (qmot.Count() == 0)
                        MaGrid.ItemsSource = null;
                    else
                        MaGrid.ItemsSource = qmot.ToList();
                    break;
                case 'p':
                    var mot = from colla in BDDentites.PRATICIEN
                              select new
                              {
                                  colla.matricule_praticien,
                                  colla.prenom_praticien,
                                  colla.nom_praticien,
                                  colla.numTel,
                                  colla.adresse_praticien,
                                  colla.ville_praticien
                              };

                    if (mot.Count() == 0)
                        MaGrid.ItemsSource = null;
                    else
                        MaGrid.ItemsSource = mot.ToList();
                    break;

            }
        }

        // clic sur le bouton Excel"
        private void toCSV_Click(object sender, RoutedEventArgs e)
        {
            MaGrid.SelectAllCells();
            MaGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;

            ApplicationCommands.Copy.Execute(null, MaGrid);
            MaGrid.UnselectAllCells();
            
            String result = (string) Clipboard.GetData(DataFormats.CommaSeparatedValue);
            
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\dju\\Desktop\\export.csv");
                sw.WriteLine(result);
                sw.Close();
                Process.Start("C:\\Users\\dju\\Desktop\\export.csv");
                MessageBox.Show("Données exportées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* mise en place du filtre d'affichage */
        private void filtreBtn_Click(object sender, RoutedEventArgs e)
        {
            //var source = MaGrid.ItemsSource;
            DbSet<COLLABORATEUR> collabs = BDDentites.COLLABORATEUR;

            string expr = filtreVal.Text;
            string colonne = filtreType.Text;

            int iexpr = 0;
            bool rep = Int32.TryParse(expr, out iexpr);

            var qmots = from filColla in collabs
                        select new { filColla.matricule_col, filColla.nom_col, filColla.prenom_col, filColla.ville_col };

            expr = expr.Trim();

            switch (colonne)
            {
                case "Nom":
                    qmots = qmots.Where( filcol => filcol.nom_col.Contains(expr) );    
                    break;
                case "Prenom":
                    qmots = qmots.Where( filcol => filcol.prenom_col.Contains(expr) );
                    break;
                case "Général":
                    qmots = qmots.Where(filcol => ( filcol. prenom_col.Contains(expr) ||
                                                    filcol.nom_col.Contains(expr)) ||
                                                    filcol.ville_col.Contains(expr) ||
                                                    filcol.matricule_col == iexpr ); 
                    break;
                case "Matricule":
                    try
                    {
                        int exr = int.Parse(expr);
                        qmots = qmots.Where( filcol => filcol.matricule_col == exr );
                    }
                    catch
                    {
                        MessageBox.Show("Erreur de parsing");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Erreur");
                    return;
            }

            MaGrid.ItemsSource = qmots.ToList();
        }

        private void btrefresh_Click(object sender, RoutedEventArgs e)
        {
            if (!btcolla.IsEnabled)
                fillGrid('c');
            else
                if (!btprat.IsEnabled)
                    fillGrid('p');
                else
                    fillGrid('r');       
        }

        /* click sur nouveau
         * pour test
         */
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }


        // clic sur voir praticien
        private void btprat_Click(object sender, RoutedEventArgs e)
        {
            fillGrid('p');

            // on desactive
            desBtn("btprat");
        }

        private void btcolla_Click(object sender, RoutedEventArgs e)
        {
            fillGrid('c');

            // on desactive
            desBtn("btcolla");
        }

        private void btrapp_Click(object sender, RoutedEventArgs e)
        {
            fillGrid('r');

            // on desactive
            desBtn("btrapp");
        }

        /* btn statistiques */
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}