using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {
            Powiadomienia powiadomienia = new Powiadomienia();
            powiadomienia.Dodaj(new Uzytkownik("Jan"));
            powiadomienia.Dodaj(new Uzytkownik("Anna"));

            powiadomienia.WyslijWiadomosc("Nowa wiadomość!");
        }
    }
}
