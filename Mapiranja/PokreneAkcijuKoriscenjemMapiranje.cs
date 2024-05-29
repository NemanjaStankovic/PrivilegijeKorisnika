using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class PokreneAkcijuKoriscenjemMapiranje:SubclassMap<PokreneAkcijuKoriscenjem>
    {
        public PokreneAkcijuKoriscenjemMapiranje() {
            Table("POKRENE_AKCIJU_KORISCENJEM");

            KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
        }
    }
}
