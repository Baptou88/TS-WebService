using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TopSolid.Kernel.Automating;
using TS_WebService.Models.TopSolid;

namespace TS_WebService.Controllers
{
    public class DocumentController : ApiController
    {
        public DocumentController()
        {
            if (!TopSolidHost.IsConnected)
            {
                TopSolidHost.Connect();
            }
        }
        [HttpPost]
        public IHttpActionResult PostDoc(MyTestClass er)
        {

            var ipdmobject = new Document(new DocumentId(er.id));

            // Save Code will be here


            return Json(ipdmobject);
        }
    }
}
