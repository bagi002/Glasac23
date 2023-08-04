using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasac23.Objekti.modelViewObjects
{
    public class GlasackiLIsticKandidatMV
    {

        string Tekst;
        bool Glas = false;

        public GlasackiLIsticKandidatMV(string x)
        {
            Tekst = x;
        }

        public string nazivKandidata
        {
            get { return Tekst; }
            set { Tekst = value; }
        }

        public bool glas
        {
            get { return Glas; }
            set { 

                if(value != Glas)
                {
                    Glas = value;
                }

            }
        }

    }
}
