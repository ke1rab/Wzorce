using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class Uzytkownik:IObserwator
    {
        private string _nazwa;

        public Uzytkownik(string nazwa)
        {
            _nazwa = nazwa;
        }

        public void Aktualizuj(string wiadomosc)
        {
            Console.WriteLine(_nazwa + " otrzymał: " + wiadomosc);
        }
    }
}
