using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privilegije_korisnika.Entiteti
{
    public class StavkaMenija : KoriscenjeKorisnickogInterfejsa
    {
        public virtual int? SM_FK { get; set; }
        public virtual StavkaMenija Roditelj { get; set; }
        public virtual IList<StavkaMenija> Deca { get; set; }
        //public virtual StavkaMenija Roditelj { get; set; }
        //public virtual IList<StavkaMenija> Deca{ get; set; }
        //public virtual IList<KoriscenjeKorisnickogInterfejsa> KorKorInt { get; set; }
        public StavkaMenija()
        {
            Deca = new List<StavkaMenija>();
            //KorKorInt = new List<KoriscenjeKorisnickogInterfejsa>();
        }
    }
}
