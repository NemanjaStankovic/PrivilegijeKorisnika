using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class KoriscenjeKorisnickogInterfejsa : Privilegija
    {
        public virtual StavkaMenija? Stavka { get; set; }
        public virtual String TipKKI { get; set; }
        public KoriscenjeKorisnickogInterfejsa()
        {
        }
    }
}
