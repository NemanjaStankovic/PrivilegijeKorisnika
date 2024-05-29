using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Entiteti
{
    public class Privilegija
    {
        public virtual int Id { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Tip { get; set; }
        public virtual IList<Dodeli> DodeljujeP { get; set; }
        public Privilegija() 
        {
            DodeljujeP = new List<Dodeli>();
        }
    }
}
