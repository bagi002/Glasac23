using Glasac23.Objekti;
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

namespace Glasac23.pages
{
    /// <summary>
    /// Interaction logic for Kreiranje.xaml
    /// </summary>
    public partial class Kreiranje : Page
    {

        izbori aktivni;

        public Kreiranje(ref izbori aktivni)
        {
            InitializeComponent();
            this.aktivni = aktivni;
            this.aktivni = new izbori();
        }

        private void predsedickiButton_Checked(object sender, RoutedEventArgs e)
        {
            PredsednickiDialog.Visibility = Visibility.Visible;
            aktivni.izbornaDodjelka(2, 0);
        }

        private void predsedickiButton_Unchecked(object sender, RoutedEventArgs e)
        {
            PredsednickiDialog.Visibility = Visibility.Hidden;
            aktivni.izbornaDodjelka(1, 0);
        }

        private void parlamentarniButton_Checked(object sender, RoutedEventArgs e)
        {
            parlamentarniDialogg.Visibility = Visibility.Visible;
            aktivni.izbornaDodjelka(0, 2);
        }

        private void parlamentarniButton_Unchecked(object sender, RoutedEventArgs e)
        {
            parlamentarniDialogg.Visibility = Visibility.Hidden;
            aktivni.izbornaDodjelka(0, 1);
        }

        private void dodajKandidata_Click(object sender, RoutedEventArgs e)
        {
            string tekstPodatka = noviKandidatPolje.Text;
            aktivni.dodajKandidata(tekstPodatka);

            List<kandidati> privremenaLista = aktivni.spisakKandidata();
            listaKandidataItems.ItemsSource = null;
            listaKandidataItems.ItemsSource = privremenaLista;

            noviKandidatPolje.Text = "";
        }

        private void dodajStranku_Click(object sender, RoutedEventArgs e)
        {
            string tekstPodatka = imeStrankeUnos.Text;
            aktivni.dodajPartiju(tekstPodatka);

            List<partije> privremenaLista = aktivni.spisakPartija();
            listaPartija.ItemsSource = null;
            listaPartija.ItemsSource = privremenaLista;

            imeStrankeUnos.Text = "";
        }
    }
}
