using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosta_Fabryka
{
    class Samochod:IPojazd
    {
        public void Jedz()
        {
            Console.WriteLine("Samochód jedzie");
        }
    }
}
