using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasac23.Objekti
{
    public class kandidati
    {
        int id;
        string ime;
        string prezime;
        int brojGlasova;
        double postotak;

        public string dajImePrezime()
        {
            string podatak = ime + " " + prezime;
            return podatak;
        }

        public kandidati(string imePrezime , int n) 
        {
            string[] x = imePrezime.Split(' ');
            ime = x[0];
            prezime = x[1];
            id = n;
        }

        public string IspisUListu
        {
            get 
            {
                string podatak;
                podatak = id+1 + ".   " + ime + " " + prezime;
                return podatak;
            }
            set { }
        }
    }
}
