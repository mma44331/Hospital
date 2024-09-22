using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalWebApi.Controllers
{
    public class MedicinesController : ApiController
    {
        // GET: api/Medicines
        public List<Medicines> Get()
        {
            return Medicines.GetAll();
        }

        // GET: api/Medicines/5
        public Medicines Get(int id)
        {
            return Medicines.GetByiD(id);
        }

        // POST: api/Medicines
        public void Post([FromBody] Medicines value)
        {
            value.MId = -1;
            value.Save();
        }

        // PUT: api/Medicines/5
        public void Put(int id, [FromBody] Medicines value)
        {
            value.MId = id;
            value.Save();
        }

        // DELETE: api/Medicines/5
        public void Delete(int id)
        {
            Medicines.DeleteByiD(id);
        }
    }
}
