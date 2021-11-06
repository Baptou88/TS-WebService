using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSolid.Cam.NC.Kernel.Automating;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Controllers
{
    public class MachinesController : ApiController
    {
        public MachinesController()
        {
            if (!TopSolidHost.IsConnected)
            {
                TopSolidHost.Connect();
            }
            if (!TopSolidCamHost.IsConnected)
            {
                TopSolidCamHost.Connect();
            }
        }
        // GET: api/Machines
        //public IEnumerable<ElementId> Get()
        //{
        //    return new ElementId[] { TopSolidCamHost.Documents.GetMachine()};
        //}

        // GET: api/Machines/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Machines
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Machines/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Machines/5
        public void Delete(int id)
        {
        }
    }
}
