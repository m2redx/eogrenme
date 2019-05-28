using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using System.Web;


namespace UYGULAMA.Models
{
    public class Dersler
    {
        public virtual int DersId { get; set; }
        public virtual string DersAd { get; set; }
    }
    public class DerslerMap : ClassMapping<Dersler>
    {

        public DerslerMap()
        {
            Id(d => d.DersId,d=> d.Generator(Generators.Identity));
            Property(d => d.DersAd);

        }
    }
}