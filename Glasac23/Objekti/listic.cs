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
       

        List<GlasackiListicPartijaVM> listaPartija = new List<GlasackiListicPartijaVM>();
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

                GlasackiListicPartijaVM test =  new GlasackiListicPartijaVM(x);
                listaPartija.Add(test);
               
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

        public List<GlasackiListicPartijaVM> dajListuPartija()
        {
            return listaPartija;
        }

        public void vratiListuPartija(List<GlasackiListicPartijaVM> x)
        {
            listaPartija = x;
        }
    }
}
