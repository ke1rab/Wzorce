using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosta_Fabryka
{
    class Rower:IPojazd
    {
        public void Jedz()
        {
            Console.WriteLine("Rower jedzie");
        }
    }
}
