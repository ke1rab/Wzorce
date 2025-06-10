using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    class Pdf:Dokument
    {
        public override void Drukuj()
        {
            Console.WriteLine("Drukuję PDF");
        }
    }
}
