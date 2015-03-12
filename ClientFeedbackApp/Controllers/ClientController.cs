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

        [ActionName("GetClients")]
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _repo.GetClients();
        }

        [ActionName("AddClient")]
        [HttpPost]
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

        [ActionName("DeleteClient")]
        [HttpPost]
        public HttpResponseMessage PostDelete(int id)
        {
            if (_repo.DeleteClient(id) &&
                _repo.Save())
            {
            return Request.CreateResponse(HttpStatusCode.OK,
                _repo.GetClients());
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [ActionName("EditClient")]
        [HttpPost]
        public HttpResponseMessage PostEdit([FromBody] Client updatedClient)
        {
            if (_repo.EditClient(updatedClient) &&
                _repo.Save())
            {
                return Request.CreateResponse(HttpStatusCode.OK,
                    _repo.GetClients());
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
