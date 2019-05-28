using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Cfg;

using System.Web;
using NHibernate;
using NHibernate.Mapping.ByCode;

using UYGULAMA.Models;

namespace UYGULAMA
{
    public static class Database
    {
        private const string SessionKey = "UYGULAMA.Database.SessionKey";
        private static ISessionFactory _sessionfactory;

        public static ISession Session
        {
            get
            {
                return (ISession)HttpContext.Current.Items[SessionKey];
            }
        }

        public static void Configure()
        {
            var Wconfig = new Configuration();
            Wconfig.Configure();
            var mapper = new ModelMapper();
            mapper.AddMapping<DerslerMap>();
            mapper.AddMapping<KisilerMap>();
            mapper.AddMapping<YetkiMap>();
            mapper.AddMapping<KisilerDerslerMap>();
            Wconfig.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
            _sessionfactory = Wconfig.BuildSessionFactory();
        }
        public static void OpenSession()
        {
            HttpContext.Current.Items[SessionKey] = _sessionfactory.OpenSession();
        }
        public static void CloseSession()
        {
            var session = HttpContext.Current.Items[SessionKey] as ISession;
            if (session != null)
                session.Close();
            HttpContext.Current.Items.Remove(SessionKey);
        }

    }
}