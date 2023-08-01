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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {

        Frame Okvir;
        List<izbori> arhivaIzbora = new List<izbori>();
        izbori aktivni;

        public MainMenu(ref Frame frejm, ref izbori aktivni, ref List<izbori> arhivaIzbora)
        {
            InitializeComponent();
            Okvir = frejm;
            this.aktivni = aktivni;
            this.arhivaIzbora = arhivaIzbora;

            if(aktivni == null) 
            {
                this.aktivni = new izbori();
                
            }
        }

        private void kreatorIzbora_Click(object sender, RoutedEventArgs e)
        {

            if (!aktivni.PostojeIzbori())
            {
                Kreiranje kreator = new Kreiranje(ref aktivni, ref Okvir, ref arhivaIzbora);
                Okvir.NavigationService.Navigate(kreator);
            }
            else
            {
                MessageBox.Show("Vec postoje kreirani izbori, koji jos nisu zavrseni!!!");
            }

          
          
        }
    }
}
