using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class StavkaMenijaMapiranje : SubclassMap<StavkaMenija>
    {
        public StavkaMenijaMapiranje()
        {
            Table("STAVKA_MENIJA");
            KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
            //id(x => x.JedinstveniIdentifikator, "JEDINSTVENI_IDENTIFIKATOR").GeneratedBy.TriggerIdentity();
            //KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
            Map(x => x.SM_FK, "JEDINSTVENI_IDENTIFIKATORFK");
            //HasMany(x => x.Deca).KeyColumn("NAZIV_PROTIVNIČKOG_TIMA").Inverse().Cascade.All();
            //References(x => x.Roditelj).Column("JEDINSTVENI_IDENTIFIKATORFK").LazyLoad();
            //HasMany(x => x.Deca).KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
            //HasMany(x => x.Deca).KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
            HasMany(x => x.Deca).KeyColumn("JEDINSTVENI_IDENTIFIKATORFK").Cascade.All();
        }

    }
}
