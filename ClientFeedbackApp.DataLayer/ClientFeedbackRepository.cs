using System;
using System.Linq;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.DataLayer
{
    public class ClientFeedbackRepository : IClientFeedbackRepository
    {
        private ClientFeedbackContext _ctx;

        public ClientFeedbackRepository(ClientFeedbackContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Client> GetClients()
        {
            return _ctx.Clients;
        }

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddClient(Client newClient)
        {
            try
            {
                _ctx.Clients.Add(newClient);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditClient()
        {
            return true;
        }

        public bool DeleteClient()
        {
            return true;
        }
    }
}
