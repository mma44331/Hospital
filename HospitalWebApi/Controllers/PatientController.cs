using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalWebApi.Controllers
{
    public class PatientController : ApiController
    {
        // GET: api/Patient
        public List<Patzient> Get()
        {
            return Patzient.GetAll();
        }

        // GET: api/Patient/5
        public Patzient Get(int id)
        {
            return Patzient.GetByiD(id);
        }

        // POST: api/Patient
        public void Post([FromBody] Patzient value)
        {
            value.PCId = -1;
            value.Save();
        }

        // PUT: api/Patient/5
        public void Put(int id, [FromBody] Patzient value)
        {
            value.PCId = id;
            value.Save();
        }

        // DELETE: api/Patient/5
        public void Delete(int id)
        {
            Patzient.DeleteByiD(id);
        }
    }
}
