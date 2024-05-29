using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class IP_Adresa
    {
        public virtual int Adresa { get; set; }
        public virtual GrupaKorisnika ImaGrupuKorisnika { get; set; }


        public virtual Korisnik ImaKorisnika { get; set; }

        public IP_Adresa()
        {


        }
    }
}
