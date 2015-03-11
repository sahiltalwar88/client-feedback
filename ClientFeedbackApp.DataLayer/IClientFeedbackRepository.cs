using System.Linq;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.DataLayer
{
    public interface IClientFeedbackRepository
    {
        IQueryable<Client> GetClients();
        bool Save();
        bool AddClient(Client newClient);
        bool EditClient();
        bool DeleteClient();
    }
}
