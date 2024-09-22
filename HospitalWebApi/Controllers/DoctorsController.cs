using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalWebApi.Controllers
{
    public class DoctorsController : ApiController
    {
        // GET: api/Doctors
        public IEnumerable<Doctors> Get()
        {
            return Doctors.GetAll();
        }

        // GET: api/Doctors/5
        public Doctors Get(int id)
        {
            return Doctors.GetByiD(id);
        }

        // POST: api/Doctors
        public void Post([FromBody] Doctors value)
        {
            value.Id = -1;
            value.Save();
        }

        // PUT: api/Doctors/5
        public void Put(int id, [FromBody] Doctors value)
        {
            value.Id = id;
            value.Save();
        }

        // DELETE: api/Doctors/5
        public void Delete(int id)
        {
            Doctors.DeleteByiD(id);
        }
    }
}
