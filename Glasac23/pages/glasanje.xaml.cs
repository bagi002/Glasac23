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
    /// Interaction logic for glasanje.xaml
    /// </summary>
    public partial class glasanje : Page
    {

        Frame Okvir;
        List<izbori> arhivaIzbora;
        izbori aktivni;

        public glasanje(ref izbori aktivni, ref List<izbori> arhivaIzbora, ref Frame Okvir)
        {
            InitializeComponent();
            this.aktivni = aktivni;
            this.Okvir = Okvir;
            this.arhivaIzbora = arhivaIzbora;
        }
    }
}
