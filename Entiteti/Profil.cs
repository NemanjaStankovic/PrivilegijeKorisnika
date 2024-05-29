using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class Profil
    {
        public virtual int Redni_broj { get; set; }
        public virtual String Boja_pozadine { get; set; }
        public virtual Korisnik KorisnikJMBG { get; set; }
    }
}
