using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasac23.Objekti
{
    public class partije
    {
        string ime;
        int id;
        int brojGlasova;
        double procenat;

        public partije(string podatak, int n)
        {
            ime = podatak;
            id = n;
        }

        public string IspisUListu
        {
            get
            {
                string podatak;
                podatak = id + 1 + ".   " + ime;
                return podatak;
            }
            set { }
        }
    }
}
