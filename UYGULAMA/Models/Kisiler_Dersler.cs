using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using System.Web;

namespace UYGULAMA.Models
{
    public class Kisiler_Dersler
    {
        public virtual int Ders { get; set; }
        public virtual int Numara { get; set; }
        public virtual int kisiler_dersID { get; set; }


    }
    public class KisilerDerslerMap : ClassMapping<Kisiler_Dersler>
    {

        public KisilerDerslerMap()
        {
            Id(x => x.kisiler_dersID, x => x.Generator(Generators.Identity));
            Property(x => x.Ders);
            Property(x => x.Numara);
        }
    }
}