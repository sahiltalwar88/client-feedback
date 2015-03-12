using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClientFeedbackApp.DataLayer;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.Controllers
{
    public class ClientController : ApiController
    {
        //TODO: DI this!
        private IClientFeedbackRepository _repo = new ClientFeedbackRepository(new ClientFeedbackContext());

        public IEnumerable<Client> Get()
        {
            return _repo.GetClients();
        }

        public HttpResponseMessage Post([FromBody] Client newClient)
        {
            if (_repo.AddClient(newClient) &&
                _repo.Save())
            {
                return Request.CreateResponse(HttpStatusCode.Created,
                    newClient);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
