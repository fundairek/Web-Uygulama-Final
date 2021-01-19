﻿using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using System.Data;
//using Core.Models;

namespace PojeFinal
{
    public class NhibernateHelper
    {
        protected static Configuration NhConfiguration;
        protected static ISessionFactory LocalSessionFactory;

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = ConfigureNhibernate();
                    var mapping = GetMappings();
                    configuration.AddDeserializedMapping(mapping, "Urun");
                    SchemaMetadataUpdater.QuoteTableAndColumns(configuration);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }


        public static Configuration ConfigureNhibernate()
        {

            var configure = new Configuration();
            configure.SessionFactoryName("BuildIt");

            configure.DataBaseIntegration(db =>
            {
                //*** SQL 2012 Express
                db.Dialect<MsSql2012Dialect>();
                db.Driver<SqlClientDriver>();
                db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                db.IsolationLevel = IsolationLevel.ReadCommitted;
                db.ConnectionString = "Data Source=LAPTOP-MDRLE3C1\\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True";

                db.Timeout = 10;

                //*** Testing Settings
                db.LogFormattedSql = true;
                db.LogSqlInConsole = true;
                db.AutoCommentSql = true;
            });
            return configure;
        }

        protected static HbmMapping GetMappings()
        {
            var mapper = new ModelMapper();
            mapper.AddMapping<Models.MusteriMap>();
            mapper.AddMapping<Models.SıparisMap>();
            //mapper.AddMapping<PackageMap>();

            //mapper.CompileMappingForEachExplicitlyAddedEntity().WriteAllXmlMapping();
            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            return mapping;
        }
    }
}
