using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalWebApi.Controllers
{
    public class HIzationsController : ApiController
    {
        // GET: api/HIzations
        public List<HIzations> Get()
        {
            return HIzations.GetAll();
        }

        // GET: api/HIzations/5
        public HIzations Get(int id)
        {
            return HIzations.GetByiD(id);
        }

        // POST: api/HIzations
        public void Post([FromBody] HIzations value)
        {
            value.HId = -1;
            value.Save();
        }

        // PUT: api/HIzations/5
        public void Put(int id, [FromBody] HIzations value)
        {
            value.HId = id;
            value.Save();   
        }

        // DELETE: api/HIzations/5
        public void Delete(int id)
        {
            HIzations.DeleteByiD(id);
        }
    }
}
