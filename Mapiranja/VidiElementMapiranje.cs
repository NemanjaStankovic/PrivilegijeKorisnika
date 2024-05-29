using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class VidiElementMapiranje:SubclassMap<VidiElement>
    {
        public VidiElementMapiranje()
        {
            Table("VIDI_ELEMENT");

            KeyColumn("JEDINSTVENI_IDENTIFIKATOR");
        }
    }
}
