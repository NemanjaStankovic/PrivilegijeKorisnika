using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class Telefon
    {
        public virtual Korisnik Vlasnik { get; set; }
        public virtual int BrojTelefona { get; set; }
        public virtual int ID { get; set; }
    }
}