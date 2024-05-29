using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Entiteti
{
    public class Korisnik
    {
        public virtual int JMBG { get; set; }

        public virtual string Licno_ime { get; set; }
        public virtual string Ime_roditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Email_adresa { get; set; }
        public virtual string Korisnicko_ime { get; set; }
        public virtual string Funkcija { get; set; }
        public virtual int Broj_kancelarije { get; set; }
        public virtual DateTime Datum_rodjenja { get; set; }
        public virtual string Radno_mesto { get; set; }
        public virtual string Trenutna_sifra { get; set; }

        public virtual DateTime DatumIVreme { get; set; }
        public virtual string PogresnaSifra { get; set; }
        public virtual IP_Adresa Adresa { get; set; }
        public virtual IList<GrupaKorisnika> GrupeKorisnika { get; set; }

        public virtual IList<Profil> Profili { get; set; }
        public virtual IList<Telefon> Telefoni { get; set; }


        //Korisnik
        public virtual Dodeli DodeljujeK { get; set; }

        public Korisnik()
        {
            GrupeKorisnika = new List<GrupaKorisnika>();

            Profili = new List<Profil>();

            Telefoni = new List<Telefon>();
        } 
    }
}
