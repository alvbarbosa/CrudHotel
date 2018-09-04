using Hotel.Bussines;
using Hotel.Contratos;
using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hotel.Api.Controllers
{
    public class ServicesController : ApiController
    {
        private readonly IManagementServices management;

        public ServicesController(IManagementServices management)
        {
            this.management = management;
        }

        // GET: api/Services
        public IEnumerable<SERVICES> Get()
        {
            return management.ObtenerTodos();
        }

        // GET: api/Services/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Services
        public void Post([FromBody]SERVICES service)
        {
            this.management.Agregar(service);
        }

        // PUT: api/Services/5
        public void Put(int id, [FromBody]SERVICES service)
        {
            this.management.Editar(service);
        }

        // DELETE: api/Services/5
        public void Delete(int id)
        {
        }
    }
}
