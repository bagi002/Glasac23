using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasac23.Objekti
{
    public class listic
    {
        int id;
        List<bool> kandidatiGlasovi = new List<bool>();
        List<String> ImenaIPrezimenaKandidata = new List<String>();
        List<bool> strankeGlasovi = new List<bool>();
        List<String> listaImenaPartija = new List<String>();

        public listic(List<kandidati> predsednickiKandidati, List<partije> stranke) 
        {
            foreach(kandidati prolaz in  predsednickiKandidati)
            {
                string x = prolaz.dajImePrezime();
                ImenaIPrezimenaKandidata.Add(x);

                kandidatiGlasovi.Add(false);
            }

            foreach(partije prolaz in stranke)
            {
                string x = prolaz.vratiNaziv();
                listaImenaPartija.Add(x);

                strankeGlasovi.Add(false);
            }
        } 
    }
}
