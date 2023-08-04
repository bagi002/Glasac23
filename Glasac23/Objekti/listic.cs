using Glasac23.Objekti.modelViewObjects;
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
        List<bool> strankeGlasovi = new List<bool>();
        List<String> listaImenaPartija = new List<String>();

        List<GlasackiLIsticKandidatMV> ListaKaandidata = new List<GlasackiLIsticKandidatMV>();

        public listic(List<kandidati> predsednickiKandidati, List<partije> stranke) 
        {
            foreach(kandidati prolaz in  predsednickiKandidati)
            {
                string x = prolaz.dajImePrezime();
                GlasackiLIsticKandidatMV dodaj = new GlasackiLIsticKandidatMV(x);

                ListaKaandidata.Add(dodaj);
            }

            foreach(partije prolaz in stranke)
            {
                string x = prolaz.vratiNaziv();
                listaImenaPartija.Add(x);

                strankeGlasovi.Add(false);
            }
        }
        
        public List<GlasackiLIsticKandidatMV> dajListuKandidata()
        {
            return ListaKaandidata;
        }

        public void vratiListuKandidata(List<GlasackiLIsticKandidatMV> x)
        {
            ListaKaandidata = x;
        }
    }
}
