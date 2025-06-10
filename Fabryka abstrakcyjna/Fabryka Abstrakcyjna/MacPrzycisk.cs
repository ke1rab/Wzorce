using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna
{
    class MacPrzycisk : IPrzycisk
    {
        public void Rysuj()
        {
            Console.WriteLine("Rysuję przycisk Mac");
        }
    }
}
