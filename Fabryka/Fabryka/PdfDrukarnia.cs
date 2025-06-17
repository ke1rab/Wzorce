using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fabryka
{
    class PdfDrukarnia:Drukarnia
    {
        public override Dokument UtworzDokument()
        {
            return new Pdf();
        }
    }
}
