using System;
using System.Collections.Generic;
using System.Web.Http;
using TopSolid.Kernel.Automating;
using TS_WebService.Models;
using TS_WebService.Models.TopSolid;

namespace TS_WebService.Controllers
{
    //[Route("[controller]/[action]")]
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
        /// <summary>
        /// Gets some very important data from the server.
        /// </summary>
        //[Route("Project/")]
        public IHttpActionResult Get()
        {
            List<PdmObject>PdmObjects = new List<PdmObject>();
            foreach (PdmObjectId pdmobject in TopSolidHost.Pdm.GetProjects(true,false))
            {
                PdmObjects.Add(new PdmObject(pdmobject));
            }
            return Json(PdmObjects);
        }

        /// <summary>
        /// Looks up some data by ID.
        /// </summary>
        /// <param name="id">The ID of the data.</param>
        [HttpPost]
        //[Route("Project/{id}")]
        public IHttpActionResult PostDoc(MyTestClass er)
        {
            var ipdmobject = new PdmObject(new PdmObjectId(er.id));
            return Json(ipdmobject);
        }
        
        [HttpGet]
        //[Route("api/project/search/{name}")]
        public IHttpActionResult Search(string name)
        {
            List<PdmObject> projets= new List<PdmObject>();
            try
            {
                
                //pobject = TopSolidHost.Pdm.GetProject(new PdmObjectId(name));
                
                
                foreach(PdmObjectId projet in TopSolidHost.Pdm.SearchProjectByName(name))
                {
                    projets.Add(new PdmObject(projet));
                }
            }
            catch (Exception e)

            {
                return Json(e);
            }
            return Json(projets);
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
