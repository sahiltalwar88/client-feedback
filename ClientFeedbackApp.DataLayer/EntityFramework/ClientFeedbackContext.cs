using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.DataLayer.EntityFramework
{
    public class ClientFeedbackContext : DbContext, IClientFeedbackContext
    {
        public ClientFeedbackContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ClientFeedbackContext, ClientFeedbackMigrationsConfiguration>());
        }

        private DbSet<Client> ClientSet { get; set; }

        public IQueryable<Client> Clients
        {
            get { return this.ClientSet; }
        }

        public void Add<T>(T entity) where T : class
        {
            var set = this.Set(entity.GetType());
            set.Add(entity);
        }

        public int SaveChanges<T>() where T : class
        {
#if DEBUG
            try
            {
                return this.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw;
            }
            catch (DbUpdateException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
#else
            return this.SaveChanges();
#endif
        }

        //public object Delete<T>(T entity) where T : class
        //{
        //    var set = this.Set(entity.GetType());
        //    return set.Remove(entity);
        //}
    }
}
