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
            catch (Exception e)
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
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditClient(Client updatedClient)
        {
            try
            {
                var currentClient = _ctx.Clients.SingleOrDefault(x => x.Id == updatedClient.Id);

                if (currentClient == null)
                {
                    return false;
                }

                currentClient.Date = updatedClient.Date;
                currentClient.Feedback = updatedClient.Feedback;
                currentClient.Grade = updatedClient.Grade;
                currentClient.Name = updatedClient.Name;
                currentClient.PocName = updatedClient.PocName;
                currentClient.ProjectName = updatedClient.ProjectName;

                _ctx.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteClient()
        {
            return true;
        }
    }
}
