using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.DB
{
    public class SessionFactory
    {
        public SessionFactory()
        {
            if (_sessionFactory is null)
            {
                _sessionFactory = BuildSessionFactory();
            }
        }

        public bool Commit(ISession session)
        {
            using var transaction = session.BeginTransaction();
            try
            {
                if (transaction.IsActive)
                {
                    transaction.Commit();
                }
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public ISession Session => _sessionFactory.OpenSession();

        public ISessionFactory _sessionFactory;
        private ISessionFactory BuildSessionFactory()
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(_connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SessionFactory>())
                .ExposeConfiguration(BuildSchema);

            var sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory;
        }

        private void BuildSchema(Configuration config)
        {
            new SchemaExport(config).Create(false, true);
        }

        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hunt\Desktop\Sites\cypherCrescentProgramme\backend\dbSetup\dataBaseTest\theFirst.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
