using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class Document
    {
        public Document(DocumentId _doc)
        {
            DocumentObject = _doc;
            Name = TopSolidHost.Documents.GetName(DocumentObject);
        }

        public DocumentId DocumentObject { get; private set; }

        public string Name{get;set;}
        public PdmMinorRevisionId MinorRevisionId
        {
            get
            {
                return TopSolidHost.Documents.GetPdmMinorRevision(DocumentObject);
            }
        }
        //public PdmMajorRevisionId MajorRevisionId
        //{
        //    get
        //    {
        //        return TopSolidHost.Documents.getpdm
        //    }
        //}
        public List<DocumentProperty> Properties
        {
            get
            {
                List<DocumentProperty> Prop = new List<DocumentProperty>();
                foreach (string property in TopSolidHost.Documents.GetProperties(DocumentObject))
                {
                    Prop.Add(new DocumentProperty(DocumentObject, property));
                }
                return Prop;

            }
        }
    }
}