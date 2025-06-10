using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class SamochodFasada
    {
        private Silinik _silnik;
        private SkrzyniaBiegow _skrzynia;

        public SamochodFasada()
        {
            _silnik = new Silinik();
            _skrzynia = new SkrzyniaBiegow();
        }

        public void UruchomSamochod()
        {
            _skrzynia.ZmienNaPoczatek();
            _silnik.Start();
        }
    }
}
