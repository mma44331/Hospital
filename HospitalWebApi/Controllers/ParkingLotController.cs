using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalWebApi.Controllers
{
    public class ParkingLotController : ApiController
    {
        // GET: api/ParkingLot
        public List<ParkingLot> Get()
        {
            return ParkingLot.GetAll();
        }

        // GET: api/ParkingLot/5
        public ParkingLot Get(int id)
        {
            return ParkingLot.GetByiD(id);
        }

        // POST: api/ParkingLot
        public void Post([FromBody] ParkingLot value)
        {
            value.CId = -1;
            value.Save();
        }

        // PUT: api/ParkingLot/5
        public void Put(int id, [FromBody] ParkingLot value)
        {
            value.CId = id;
            value.Save();
        }

        // DELETE: api/ParkingLot/5
        public void Delete(int id)
        {
            ParkingLot.DeleteByiD(id);
        }
    }
}
