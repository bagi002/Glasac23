using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasac23.Objekti.modelViewObjects
{
    public class GlasackiListicPartijaVM
    {

        string Tekst;
        bool Glas = false;

        public GlasackiListicPartijaVM(string x)
        {
            Tekst = x;
        }

        public string nazivPartije
        {
            get { return Tekst; }
            set { Tekst = value; }
        }

        public bool glas
        {
            get { return Glas; }
            set
            {

                if (value != Glas)
                {
                    Glas = value;
                }

            }
        }
    }
}
