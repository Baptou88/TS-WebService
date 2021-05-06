using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSolid.Kernel.Automating;
using TS_WebService.Models.TopSolid;

namespace TS_WebService.Controllers
{
    public class ShapeController : ApiController
    {
        public ShapeController()
        {
            if (!TopSolidHost.IsConnected)
            {
                TopSolidHost.Connect();
            }
        }
        // GET: api/Shape
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        

        // POST: api/Shape
        [HttpPost]
        public IHttpActionResult Post(MyTestClass er)
        {
            List<ElementItem> elements = new List<ElementItem>();
            foreach (ElementId Element in TopSolidHost.Shapes.GetShapes(new DocumentId(er.id)))
            {
                elements.Add(new ElementItem(Element));
            }
            return Json(elements);
        }

        

        
    }
}
