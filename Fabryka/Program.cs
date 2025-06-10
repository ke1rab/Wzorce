using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            Drukarnia drukarnia = new PdfDrukarnia();
            Dokument dokument = drukarnia.UtworzDokument();
            dokument.Drukuj();
        }
    }
}
