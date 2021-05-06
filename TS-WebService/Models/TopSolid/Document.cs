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
            Elements = new List<ElementItem>();
            //IsPart = 
            //Shape = new Shapes(new ElementId(Document, 0));

            foreach (ElementId element in TopSolidHost.Elements.GetElements(DocumentObject))
            {
                Elements.Add(new ElementItem(element));
            }
        }

        public DocumentId DocumentObject { get; private set; }

        public string Name{get;set;}
        public List<ElementItem> Elements { get; private set; }

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