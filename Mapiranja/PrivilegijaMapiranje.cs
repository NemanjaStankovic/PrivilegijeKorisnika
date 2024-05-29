using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    class PrivilegijaMapiranje : ClassMap<Privilegija>
    {
        public PrivilegijaMapiranje()
        {
            //Mapiranje tabele
            Table("PRIVILEGIJA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "JEDINSTVENI_IDENTIFIKATOR").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Ime, "IME");
            Map(x => x.Tip, "TIP");
            //mapiranje veze 1:N Prodavnica-Odeljenje
            // HasMany(x => x.Odeljenja).KeyColumn("BROJP");
            // HasMany(x => x.Odeljenja).KeyColumn("BROJP").LazyLoad().Cascade.All();
            //HasMany(x => x.Odeljenja).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();


            //HasManyToMany(x => x.Radnici)
            //    .Table("RADI_U")
            //    .ParentKeyColumn("BROJP")
            //    .ChildKeyColumn("JBR_RADNIK")
            //    .Inverse()
            //    .Cascade.All();




            HasMany(x => x.DodeljujeP).KeyColumn("JEDINSTVENI_IDENTIFIKATOR").LazyLoad().Cascade.All().Inverse();

            



            //HasMany(x => x.RadiURadnici).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();

            //HasMany(x => x.SefujeSefovi).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();


        }
    }
}
