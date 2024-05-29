using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class TelefonMapiranje : ClassMap<Telefon>
    {
        public TelefonMapiranje()
        {
            Table("BROJ_TELEFONA");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            References(x => x.Vlasnik).Column("JMBG").LazyLoad();
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
        }
    }
}