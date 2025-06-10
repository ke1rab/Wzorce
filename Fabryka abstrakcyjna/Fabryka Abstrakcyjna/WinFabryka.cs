using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Abstrakcyjna
{
    class WinFabryka:IUIPakietFabryka
    {
        public IPrzycisk StworzPrzycisk()
        {
            return new WinPrzycisk();
        }
    }
}
