using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Kontroler
    {
        private Model _model;
        private Widok _widok;

        public Kontroler(Model model, Widok widok)
        {
            _model = model;
            _widok = widok;
        }

        public void AktualizujDane(string noweDane)
        {
            _model.Dane = noweDane;
            _widok.Pokaz(_model.Dane);
        }
    }
}
