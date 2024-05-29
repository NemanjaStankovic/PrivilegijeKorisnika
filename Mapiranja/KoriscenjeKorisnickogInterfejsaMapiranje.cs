using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class KoriscenjeKorisnickogInterfejsaMapiranje : SubclassMap<KoriscenjeKorisnickogInterfejsa>
    {
        public KoriscenjeKorisnickogInterfejsaMapiranje()
        {

            Table("KORISCENJE_KORIS_INT");
            KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
            //DiscriminatorValue("KORISCENJE KOR INT");
            Map(x => x.TipKKI, "TIPKKI");
        }
    }
}
