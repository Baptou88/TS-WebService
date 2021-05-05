using System;
using System.Collections.Generic;
using System.Web.Http;
using TopSolid.Kernel.Automating;
using TS_WebService.Models;
using TS_WebService.Models.TopSolid;

namespace TS_WebService.Controllers
{
    public class ProjectController : ApiController
    {
        private PdmObjectId pobject;

        public ProjectController()
        {
            if (!TopSolidHost.IsConnected)
            {
                TopSolidHost.Connect();
            }
        }
        // GET: api/Project
        public IHttpActionResult Get()
        {
            List<PdmObject>PdmObjects = new List<PdmObject>();
            foreach (PdmObjectId pdmobject in TopSolidHost.Pdm.GetProjects(true,false))
            {
                PdmObjects.Add(new PdmObject(pdmobject));
            }
            return Json(PdmObjects);
        }

        // GET: api/Project/5
        [HttpGet]
        public IHttpActionResult Get([FromBody]Class1 r,string id)
        {
            try
            {
                pobject = TopSolidHost.Pdm.GetProject(new PdmObjectId(id));
            }
            catch (Exception e)

            {
                return Json(e);
            }
            return Json(pobject);
        }

        [HttpPost]
        
        public IHttpActionResult PostDoc(MyTestClass er)
        {
            var ipdmobject = new PdmObject(new PdmObjectId(er.id)); 
            return Json(ipdmobject);
        }
        //// POST: api/Project
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/Project/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Project/5
        public void Delete(int id)
        {
        }
    }
}
