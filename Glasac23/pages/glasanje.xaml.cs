using Glasac23.Objekti;
using Glasac23.Objekti.modelViewObjects;
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
    /// Interaction logic for glasanje.xaml
    /// </summary>
    public partial class glasanje : Page
    {

        Frame Okvir;
        List<izbori> arhivaIzbora;
        izbori aktivni;
        listic trenutni;

        int activPage = 1;

        List<GlasackiLIsticKandidatMV> prikazKandidata;
        List<GlasackiListicPartijaVM> prikazPartija;

        public glasanje(ref izbori aktivni, ref List<izbori> arhivaIzbora, ref Frame Okvir)
        {
            InitializeComponent();
            this.aktivni = aktivni;
            this.Okvir = Okvir;
            this.arhivaIzbora = arhivaIzbora;

            trenutni = aktivni.dajPrimerakListica();

            prikazKandidata = trenutni.dajListuKandidata();
            prikazPartija = trenutni.dajListuPartija();

            listaKandidataGlasanje.ItemsSource = prikazKandidata;
            listaPartijaGlasanje.ItemsSource = prikazPartija;




            if (!aktivni.PostojePredsednicki())
            {
                activPage = 2;
                ImeIzboraUI.Text = "PARLAMENTARNI IZBORI";
                GlasanjePredsednickiUI.Visibility = Visibility.Hidden;
                GlasanjePalamentarniUI.Visibility = Visibility.Visible;

                FirstPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF91F7FF"));
                secondPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF67A1FF"));
            }

        }

        private void DugmeDalje_Click(object sender, RoutedEventArgs e)
        {
            if(activPage == 1)
            {
                trenutni.vratiListuKandidata(prikazKandidata);

                if (aktivni.PostojePArlamentarni())
                {
                    activPage = 2;
                    ImeIzboraUI.Text = "PARLAMENTARNI IZBORI";
                    GlasanjePredsednickiUI.Visibility = Visibility.Hidden;
                    GlasanjePalamentarniUI.Visibility = Visibility.Visible;

                    FirstPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF91F7FF"));
                    secondPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF67A1FF"));
                }
                else
                {
                    activPage = 3;
                    FirstPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF91F7FF"));
                    thirdPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF67A1FF"));

                    ImeIzboraUI.Text = "POTVRDITE GLASACKI LISTIC";

                    GlasanjePredsednickiUI.Visibility = Visibility.Hidden;
                    PozdravnaPorukaUI.Visibility = Visibility.Visible;

                    DugmeDalje.Visibility = Visibility.Hidden;
                    DugmeGlasaj.Visibility = Visibility.Visible;

                    DugmeDalje.Width = 0;
                    DugmeDalje.Height = 0;
                    DugmeDalje.Margin = new Thickness(0);
                }
            }
            else if(activPage == 2)
            {
                trenutni.vratiListuPartija(prikazPartija);

                FirstPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF91F7FF"));
                secondPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF67A1FF"));

                activPage = 3;
                    secondPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF91F7FF"));
                    thirdPageUI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF67A1FF"));

                    ImeIzboraUI.Text = "POTVRDITE GLASACKI LISTIC";

                    GlasanjePalamentarniUI.Visibility = Visibility.Hidden;
                    PozdravnaPorukaUI.Visibility = Visibility.Visible;

                    DugmeDalje.Visibility = Visibility.Hidden;
                    DugmeGlasaj.Visibility = Visibility.Visible;

                    DugmeDalje.Width = 0;
                    DugmeDalje.Height = 0;
                    DugmeDalje.Margin = new Thickness(0);
                
            }
        }

        private void DugmeGlasaj_Click(object sender, RoutedEventArgs e)
        {

            aktivni.dodajUKutiju(trenutni);

            MainMenu meni = new MainMenu(ref Okvir, ref aktivni, ref arhivaIzbora);
            Okvir.NavigationService.Navigate(meni);

        }
    }
}
