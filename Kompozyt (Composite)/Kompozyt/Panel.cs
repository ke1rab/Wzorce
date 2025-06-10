using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    class Panel:Kompnent
    {
        private List<Kompnent> _komponenty;

        public Panel()
        {
            _komponenty = new List<Kompnent>();
        }

        public void Dodaj(Kompnent komponent)
        {
            _komponenty.Add(komponent);
        }

        public override void Wyswietl()
        {
            Console.WriteLine("Panel:");
            foreach (Kompnent k in _komponenty)
            {
                k.Wyswietl();
            }
        }
    }
}
