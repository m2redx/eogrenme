using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using System.Web;

namespace UYGULAMA.Models
{
    public class Yetki
    {
        public virtual int YetkiId { get; set; }
        public virtual string YetkiAdı { get; set; }

    }

    public class YetkiMap : ClassMapping<Yetki>
    {

        public YetkiMap()
        {

            Id(x => x.YetkiId, x => x.Generator(Generators.Identity));
            Property(x => x.YetkiAdı);
         
        }
    }
}