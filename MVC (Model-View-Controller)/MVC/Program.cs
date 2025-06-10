using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Widok widok = new Widok();
            Kontroler kontroler = new Kontroler(model, widok);

            kontroler.AktualizujDane("Hello MVC");
        }
    }
}
