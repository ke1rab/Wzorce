using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class EmailHandler:Handler
    {
        public override void Obsluz(string wiadomosc)
        {
            if (wiadomosc.Contains("@"))
            {
                Console.WriteLine("Obsłużono jako e-mail.");
            }
            else if (_nastepny != null)
            {
                _nastepny.Obsluz(wiadomosc);
            }
        }
    }
}
