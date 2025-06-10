using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class KonsolaLogger:ILogger
    {
        public void Loguj(string tekst)
        {
            Console.WriteLine("[Log] " + tekst);
        }
    }
}
