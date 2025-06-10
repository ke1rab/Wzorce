using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new KonsolaLogger();
            Serwis serwis = new Serwis(logger);
            serwis.Wykonaj();
        }
    }
}
