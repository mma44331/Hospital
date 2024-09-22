using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalWebApi.Controllers
{
    public class DepartmentsController : ApiController
    {
        // GET: api/Departments
        public List<Departments> Get()
        {
            return Departments.GetAll();
        }

        // GET: api/Departments/5
        public Departments Get(int id)
        {
            return Departments.GetByiD(id);
        }

        // POST: api/Departments
        public void Post([FromBody] Departments value)
        {
            value.DId = -1;
            value.Save();
        }

        // PUT: api/Departments/5
        public void Put(int id, [FromBody] Departments value)
        {
            value.DId = id;
            value.Save();
        }

        // DELETE: api/Departments/5
        public void Delete(int id)
        {
            Departments.DeleteByiD(id);
        }
    }
}
