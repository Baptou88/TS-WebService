using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class DocumentProperty
    {
        public DocumentProperty(DocumentId _doc, string _property)
        {
            Type = TopSolidHost.Documents.GetPropertyType(_doc, _property);
            
        }

        public PropertyType Type { get; private set; }
    }
}