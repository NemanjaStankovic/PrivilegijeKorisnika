using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class GrupaKorisnika
    {
        public virtual string JedinstvenoIme { get; set; }
        public virtual string KratakOpis { get; set; }
        public virtual DateTime PeriodPocetka { get; set; }
        public virtual DateTime PeriodZavrsetka { get; set; }
        public virtual DateTime DatumKreiranja { get; set; }
        public virtual IList<Korisnik> Korisnici { get; set; }
        //public virtual IList<IP_Adresa> IpAdrese { get; set; }
        public virtual IList<IP_Adresa> IpAdrese { get; set; }
        public virtual Dodeli DodeljujeSeG { get; set; }
        public GrupaKorisnika()
        {
            Korisnici = new List<Korisnik>();
            IpAdrese = new List<IP_Adresa>();
        }
    }
}
