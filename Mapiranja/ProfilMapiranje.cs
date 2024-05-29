using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    class ProfilMapiranje : ClassMap<Profil>
    {
        public ProfilMapiranje()
        {
            Table("PROFIL");

            Id(x => x.Redni_broj, "REDNI_BROJ").GeneratedBy.TriggerIdentity();

            Map(x => x.Boja_pozadine, "BOJA_POZADINE");

            References(x => x.KorisnikJMBG).Column("JMBG").LazyLoad();

        }
    }
}
