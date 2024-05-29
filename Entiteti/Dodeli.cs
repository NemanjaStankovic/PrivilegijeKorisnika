using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class Dodeli
    {
        public virtual int Id{get; set;}
        public virtual GrupaKorisnika DodeljujeGrupi { get; set; }
        public virtual Korisnik DodeljujeKorisnik { get; set; }
        public virtual Privilegija DodeljujuSePrivilegija { get; set; }

        public virtual DateTime Datum_Dodeljivanja { get; set; }

        public Dodeli() { }
    }
}
