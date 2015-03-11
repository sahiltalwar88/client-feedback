using System.Data.Entity;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.DataLayer
{
    public class ClientFeedbackContext : DbContext
    {
        public ClientFeedbackContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ClientFeedbackContext, ClientFeedbackMigrationsConfiguration>());
        }

        public DbSet<Client> Clients { get; set; }
    }
}
