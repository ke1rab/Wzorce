using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosta_Fabryka
{
    class PojazdFabryka
    {
        public IPojazd StworzPojazd(string typ)
        {
            if (typ == "samochod")
                return new Samochod();
            else if (typ == "rower")
                return new Rower();
            else
                throw new ArgumentException("Nieznany typ pojazdu");
        }
    }
}
