using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class SmsHandler:Handler
    {
        public override void Obsluz(string wiadomosc)
        {
            Console.WriteLine("Obsłużono jako SMS.");
        }
    }
}
