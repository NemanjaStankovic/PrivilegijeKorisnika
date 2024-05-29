using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    class KorisnikMapiranje: ClassMap<Korisnik>
    {
        public KorisnikMapiranje()
        {
            //Mapiranje tabele
            Table("KORISNIK");
            //mapiranje svojstava.

            Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();
            Map(x => x.Datum_rodjenja, "DATUM_RODJENJA");
            Map(x => x.Korisnicko_ime, "KORISNICKO_IME");
            Map(x => x.Radno_mesto, "RADNO_MESTO");
            Map(x => x.Email_adresa, "EMAIL_ADRESA");
            Map(x => x.Licno_ime, "LICNO_IME");
            Map(x => x.Ime_roditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Funkcija, "FUNKCIJA");
            Map(x => x.Broj_kancelarije, "BROJ_KANCELARIJE");
            Map(x => x.Trenutna_sifra, "TRENUTNA_SIFRA");
            Map(x => x.DatumIVreme, "DATUM_I_VREME");
            Map(x => x.PogresnaSifra, "POGRESNA_SIFRA");
            //Map(x => x.Tre, "PREZIME");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            // HasMany(x => x.Odeljenja).KeyColumn("BROJP");
            // HasMany(x => x.Odeljenja).KeyColumn("BROJP").LazyLoad().Cascade.All();
            //HasMany(x => x.Odeljenja).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();
            //References(x => x.ImaKorisnika).Column("ADRESA").Unique();
            References(x => x.Adresa, "ADRESA").Unique();
            //HasOne(x => x.Adresa).PropertyRef(x => x.Adresa);


            //KorisnikMapiranje
            HasOne(x => x.DodeljujeK).PropertyRef(x => x.DodeljujeKorisnik);
            //References(x => x.DodeljujeK, "JMBG").Unique();


            HasMany(x => x.Profili).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.Telefoni).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();


            HasManyToMany(x => x.GrupeKorisnika)
                .Table("SADRZI")
                .ParentKeyColumn("JMBG")
                .ChildKeyColumn("JEDINSTVENO_IME")
            //    .Inverse()
                .Cascade.All();

            //HasMany(x => x.RadiURadnici).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();

            //HasMany(x => x.SefujeSefovi).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();


        }
    }
}
