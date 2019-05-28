using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using System.Web;

namespace UYGULAMA.Models
{
    public class Kisiler
    {
        public virtual int Numara { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual int Ders { get; set; }
        public virtual string Sifre { get; set; }
        public virtual int Yetki { get; set; }
    }

    public class KisilerMap : ClassMapping<Kisiler>
    {

        public KisilerMap()
        {
            Id(x => x.Numara, x => x.Generator(Generators.Identity));
            Property(x => x.Ad);
            Property(x => x.Soyad);
            Property(x => x.Sifre, x => x.NotNullable(true));
            Property(x => x.Ders);
            Property(x => x.Yetki);


        }
    }
}