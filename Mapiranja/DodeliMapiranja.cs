using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    class DodeliMapiranja : ClassMap<Dodeli>
    {
        public DodeliMapiranja()
        {
            Table("DODELI");


            
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Datum_Dodeljivanja, "DATUM_DODELJIVANJA");


            References(x => x.DodeljujeGrupi, "JEDINSTVENO_IME").Unique();

            References(x => x.DodeljujeKorisnik, "JMBG").Unique();

            References(x => x.DodeljujuSePrivilegija, "JEDINSTVENI_IDENTIFIKATOR").Unique();

        }

    }
}
