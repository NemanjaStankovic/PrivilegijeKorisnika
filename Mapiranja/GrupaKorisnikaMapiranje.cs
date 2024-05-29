using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
     class GrupaKorisnikaMapiranje : ClassMap<GrupaKorisnika>
    {
        public GrupaKorisnikaMapiranje()
        {
            //Mapiranje tabele
            Table("GRUPA_KORISNIKA");
            //mapiranje svojstava.

            Id(x => x.JedinstvenoIme, "JEDINSTVENO_IME").GeneratedBy.Assigned();
            Map(x => x.DatumKreiranja, "DATUM_KREIRANJA");
            //Map(x => x.JedinstvenoIme, "JEDINSTVENO_IME");
            Map(x => x.KratakOpis, "KRATAK_OPIS");
            Map(x => x.PeriodPocetka, "PERIOD_POCETKA");
            Map(x => x.PeriodZavrsetka, "PERIOD_ZAVRSETKA");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            // HasMany(x => x.Odeljenja).KeyColumn("BROJP");
            // HasMany(x => x.Odeljenja).KeyColumn("BROJP").LazyLoad().Cascade.All();
            //HasMany(x => x.Odeljenja).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.IpAdrese).KeyColumn("JEDINSTVENO_IME").LazyLoad().Cascade.All().Inverse();


            HasManyToMany(x => x.Korisnici)
                .Table("SADRZI")
                .ParentKeyColumn("JEDINSTVENO_IME")
                .ChildKeyColumn("JMBG")
                .Inverse()
                .Cascade.All();

            HasOne(x => x.DodeljujeSeG).PropertyRef(x => x.DodeljujeGrupi);
            //References(x => x.DodeljujeSeG, "JEDINSTVENO_IME").Unique();



            //HasMany(x => x.RadiURadnici).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();

            //HasMany(x => x.SefujeSefovi).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();


        }
    }
}
