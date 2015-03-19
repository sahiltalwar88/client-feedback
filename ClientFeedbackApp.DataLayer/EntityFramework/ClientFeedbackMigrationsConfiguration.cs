using System.Data.Entity.Migrations;

namespace ClientFeedbackApp.DataLayer.EntityFramework
{
    public class ClientFeedbackMigrationsConfiguration : DbMigrationsConfiguration<ClientFeedbackContext>
    {
        public ClientFeedbackMigrationsConfiguration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }
    }
}
