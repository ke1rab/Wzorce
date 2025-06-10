using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Serwis
    {
        private ILogger _logger;

        public Serwis(ILogger logger)
        {
            _logger = logger;
        }

        public void Wykonaj()
        {
            _logger.Loguj("Wykonywanie operacji");
        }
    }
}
