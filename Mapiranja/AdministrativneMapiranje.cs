using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Privilegije_korisnika.Entiteti;

namespace Privilegije_korisnika.Mapiranja
{
    public class AdministrativneMapiranje : SubclassMap<Administrativne>
    {
        public AdministrativneMapiranje()
        {
            Table("ADMINISTRATIVNE");

            KeyColumn("JEDINSTVENI_IDENTIFIKATOR");

            DiscriminatorValue("ADMINISTRATIVNI");

        }

    }
}
