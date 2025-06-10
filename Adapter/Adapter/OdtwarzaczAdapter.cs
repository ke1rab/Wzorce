using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class OdtwarzaczAdapter : INowyOdtwarzacz
    {
        private StaryOdtwarzacz _stary;

        public OdtwarzaczAdapter(StaryOdtwarzacz stary)
        {
            _stary = stary;
        }

        public void OdtworzDzwiek()
        {
            _stary.PlayOldSound();
        }
    }
}
