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
        }

        private void kreatorIzbora_Click(object sender, RoutedEventArgs e)
        {

          Kreiranje kreator = new Kreiranje(ref aktivni);
          Okvir.NavigationService.Navigate(kreator);

        }
    }
}
