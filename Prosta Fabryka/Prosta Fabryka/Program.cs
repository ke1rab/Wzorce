using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosta_Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            PojazdFabryka fabryka = new PojazdFabryka();
            IPojazd pojazd = fabryka.StworzPojazd("samochod");
            pojazd.Jedz();
        }
    }
}
