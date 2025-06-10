using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class Powiadomienia
    {
        private List<IObserwator> _obserwatorzy;

        public Powiadomienia()
        {
            _obserwatorzy = new List<IObserwator>();
        }

        public void Dodaj(IObserwator observer)
        {
            _obserwatorzy.Add(observer);
        }

        public void WyslijWiadomosc(string tekst)
        {
            foreach (IObserwator obs in _obserwatorzy)
            {
                obs.Aktualizuj(tekst);
            }
        }
    }
}
