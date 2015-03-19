using System.Linq;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.DataLayer
{
    public interface IClientFeedbackContext
    {
        IQueryable<Client> Clients { get; }

        void Add<T>(T entity) where T : class;

        int SaveChanges<T>() where T : class;
    }
}
