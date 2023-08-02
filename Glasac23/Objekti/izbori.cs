using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Glasac23.Objekti
{
    public class izbori
    {
        int id;
        bool predsednicki = false;
        bool parlamentarni = false;
        int brojGlasaca;
        string datum;
        
        List<kandidati> predsednickiKandidati = new List<kandidati>();
        List<partije> stranke = new List<partije>();

        int brGlasova = 0;
        int brNevazecih = 0;
        double izlaznost = 0;
        bool aktivni = false;

        List<listic> ListaListica = new List<listic>();
        listic primerakBlanko;

        public izbori() 
        { 

        }

        public void kreirajBlankoListica()
        {
            primerakBlanko = new listic(predsednickiKandidati, stranke);
        }

        public void izbornaDodjelka(int a, int b) // bez promene 0 , nije cekirano 1 , cekirano 2 , prva cifra predsenicki druga parlamentarni
        {
            if(a != 0)
            {
                if (a == 1) predsednicki = false;
                if (a == 2) predsednicki = true;
            }
            if (b != 0)
            {
                if (b == 1) parlamentarni = false;
                if (b == 2) parlamentarni = true;
            }

        }

        public void dodajKandidata(string podatak)
        {
            kandidati privremeni = new kandidati(podatak, predsednickiKandidati.Count());
            predsednickiKandidati.Add(privremeni);
            privremeni = null;
        }

        public void dodajPartiju(string podatak)
        {
            partije privremena = new partije(podatak, stranke.Count());
            stranke.Add(privremena);
            privremena = null;
        }

        public List<kandidati> spisakKandidata()
        {
            return predsednickiKandidati;
        }

        public List<partije> spisakPartija()
        {
            return stranke;
        }

        public void Kreiranje(string dd,int n)
        {
            datum = dd;
            brojGlasaca = n;
            aktivni = true;
            this.kreirajBlankoListica();
        }

        public bool PostojeIzbori()
        {
            return aktivni;
        }

    }
}
