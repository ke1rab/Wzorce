using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    abstract class Handler
    {
        protected Handler _nastepny;

        public void UstawNastepny(Handler handler)
        {
            _nastepny = handler;
        }

        public abstract void Obsluz(string wiadomosc);
    }
}
