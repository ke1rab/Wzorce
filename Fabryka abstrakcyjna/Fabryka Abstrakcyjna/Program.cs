using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            IUIPakietFabryka fabryka = new WinFabryka();
            IPrzycisk przycisk = fabryka.StworzPrzycisk();
            przycisk.Rysuj();
        }
    }
}
