using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class KoriscenjeFunkcionalnihModulaMapiranje : SubclassMap<KoriscenjeFunkcionalnihModula>
    {
        public KoriscenjeFunkcionalnihModulaMapiranje()
        {
            Table("KORISCENJE_FUNK_MOD");

            KeyColumn("JEDINSTVENI_IDENTIFIKATOR");

            DiscriminatorValue("KORISCENJE FUNK MOD");
        }
    }
}
