using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucitaj_privilegije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Privilegije_korisnika.Entiteti.Privilegija p = s.Load<Privilegije_korisnika.Entiteti.Privilegija>(59);
                MessageBox.Show(p.Ime);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btndodaj_privilegiju_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Entiteti.Privilegija pri = new Entiteti.Privilegija();
            pri.Ime = "PrivilegijaNova";

            s.Save(pri);

            s.Flush();
            s.Close();
        }

        private void hasmanytomany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Korisnik k1 = s.Load<Entiteti.Korisnik>(123456789);

                foreach (Entiteti.GrupaKorisnika gk in k1.GrupeKorisnika)
                {
                    MessageBox.Show(gk.JedinstvenoIme + " : " + gk.KratakOpis);
                }

                Entiteti.GrupaKorisnika gk2 = s.Load<Entiteti.GrupaKorisnika>("grupa1");

                foreach (Entiteti.Korisnik k2 in gk2.Korisnici)
                {
                    MessageBox.Show(k2.Licno_ime + " " + k2.Prezime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Entiteti.Korisnik k1 = new Entiteti.Korisnik();
            k1.Korisnicko_ime = "draganche";
            k1.Datum_rodjenja = DateTime.Now;
            k1.JMBG = 23142354;
            k1.Radno_mesto = "fakultet";
            k1.Email_adresa = "draganche@elfak.rs";
            k1.Licno_ime = "Dragan";
            k1.Ime_roditelja = "Predrag";
            k1.Prezime = "Petrovic";
            k1.Funkcija = "student";
            k1.Broj_kancelarije = 6;
            k1.Trenutna_sifra = "sifra123";

            s.Save(k1);

            s.Flush();
            s.Close();
        }

        private void btnIzmeniKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k1 = s.Load<Korisnik>(987654321);

                //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
                s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                k1.Funkcija = "sef";

                //otvara se nova sesija
                ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s1.Update(k1);

                s1.Flush();
                s1.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Administrativne a = new Administrativne();

                a.Ime = "Prva admin p";
                s.Save(a);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajKoriscenjeFModula_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KoriscenjeFunkcionalnihModula a = new KoriscenjeFunkcionalnihModula();

                a.Ime = "Prva KFM p";
                s.Save(a);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVidiElement_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KoriscenjeKorisnickogInterfejsa v = new KoriscenjeKorisnickogInterfejsa();
                v.Tip = "KKI";
                v.Ime = "Prvi KORKORINT";
                v.TipKKI = "Vidi Element";
                v.Stavka = null;
                s.Save(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IP_Adresa a = s.Load<IP_Adresa>(12345);

                MessageBox.Show(a.ImaGrupuKorisnika.JedinstvenoIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaKorisnika gk = s.Load<GrupaKorisnika>("grupa1");

                foreach (IP_Adresa a in gk.IpAdrese)
                {
                    MessageBox.Show($"{a.Adresa}");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(123456789);

                MessageBox.Show($"{k.Adresa.Adresa}");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikazDodeli_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dodeli d = s.Load<Dodeli>(1);

                MessageBox.Show($"{d.DodeljujeKorisnik.Licno_ime} dodelio {d.DodeljujeGrupi.JedinstvenoIme} privilegiju broj {d.DodeljujuSePrivilegija.Id} datuma {d.Datum_Dodeljivanja}");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnStavkaMenija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StavkaMenija sm1 = new StavkaMenija();
                //sm1.SM_FK =60;
                sm1.Tip = "KKI";
                sm1.TipKKI = "Vidi Element";
                StavkaMenija sm2 = s.Load<Privilegije_korisnika.Entiteti.StavkaMenija>(65);
                sm1.Roditelj = sm2;
                sm2.Deca.Add(sm1);
                sm1.SM_FK = 65;
                sm1.Ime = "IMEEE";
                s.Save(sm2);
                //s.Save(sm2);
                //s.Save(sm3);
                //s.Save(sm4);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cdmDodajDodelu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dodeli d = new Dodeli();
                Korisnik k1 = s.Load<Korisnik>(123456789);
                Privilegija p1 = s.Load<Privilegija>(72);
                GrupaKorisnika gk1 = s.Load<GrupaKorisnika>("grupa2");
                d.DodeljujeKorisnik = k1;
                d.DodeljujeGrupi = gk1;
                d.DodeljujuSePrivilegija = p1;
                d.Datum_Dodeljivanja = DateTime.Now;
                s.Save(d);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdPrikaziProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Profil p = s.Load<Profil>(1);

                MessageBox.Show($"{p.KorisnikJMBG.Licno_ime} ima profil cija je boja pozadine {p.Boja_pozadine}!");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}