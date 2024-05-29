using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranje
{
    class IP_AdresaMapiranje : ClassMap<IP_Adresa>
    {
        public IP_AdresaMapiranje()
        {
            Table("IP_ADRESA");

            Id(x => x.Adresa, "ADRESA").GeneratedBy.Assigned();

            References(x => x.ImaGrupuKorisnika).Column("JEDINSTVENO_IME").LazyLoad();
            //HasOne(x => x.Adresa).PropertyRef(x => x.Adresa);
            HasOne(x => x.ImaKorisnika).PropertyRef(x => x.Adresa);
            //References(x => x.ImaKorisnika).Column("ADRESA").Unique();
        }
    }
}
