using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClientFeedbackApp.DataLayer;
using ClientFeedbackApp.DataLayer.Models;

namespace ClientFeedbackApp.Controllers
{
    [RoutePrefix("client")]
    public class ClientController : ApiController
    {
        private readonly IClientFeedbackContext database;

        public ClientController(IClientFeedbackContext database)
        {
            this.database = database;
        }

        [HttpGet]
        [Route("get")]
        public IEnumerable<Client> Get()
        {
            return database.Clients.ToList();
        }

        [HttpPost]
        [Route("add/{newClient}")]
        public HttpResponseMessage Post([FromBody] Client newClient)
        {
            database.Add(newClient);

            return database.SaveChanges<Client>() > 0
                ? Request.CreateResponse(HttpStatusCode.Created, newClient)
                : Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [Route("delete/{id}")]
        public HttpResponseMessage PostDelete(int id)
        {
            //if (database.DeleteClient(id) &&
            //    database.Save())
            //{
            //return Request.CreateResponse(HttpStatusCode.OK,
            //    database.GetClients());
            //}

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [Route("edit/{client}")]
        public HttpResponseMessage PostEdit([FromBody] Client updatedClient)
        {
            var myUpdatedClient = Client.MergeChanges(database.Clients.SingleOrDefault(x => x.Id == updatedClient.Id), updatedClient);

            return database.SaveChanges<Client>() > 0
                ? Request.CreateResponse(HttpStatusCode.Created, myUpdatedClient)
                : Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
