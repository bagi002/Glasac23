using Glasac23.Objekti;
using Glasac23.pages;
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

namespace Glasac23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<izbori> arhivaIzbora = new List<izbori>();
        izbori aktivni;


        public MainWindow()
        {
            InitializeComponent();
            ucitavanjeMenija();
        }

        public void ucitavanjeMenija()
        {

            MainMenu meni = new MainMenu(ref Okvir, ref aktivni, ref arhivaIzbora);
            Okvir.NavigationService.Navigate(meni);

        }
    }
}
