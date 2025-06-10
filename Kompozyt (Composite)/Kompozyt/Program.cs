using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            Panel panel = new Panel();
            panel.Dodaj(new Przycisk());
            panel.Dodaj(new Przycisk());
            panel.Wyswietl();
        }
    }
}
