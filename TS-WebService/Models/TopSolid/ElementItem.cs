using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;
using TS_WebService.Models.TopSolid;

namespace TS_WebService.Models.TopSolid
{
    public class ElementItem
    {
        public ElementItem(ElementId _el)
        {

            Name = TopSolidHost.Elements.GetName(_el);
            Properties = new List<String>();
            Properties = TopSolidHost.Elements.GetProperties(_el);
            FriendlyName = TopSolidHost.Elements.GetFriendlyName(_el);
            FullName = TopSolidHost.Elements.GetTypeFullName(_el);
            Edges = new List<Edge>();
            Faces = new List<Face>();
            try
            {
                
                foreach (ElementItemId Ed in TopSolidHost.Shapes.GetEdges(_el))
                {
                    Edges.Add(new Edge(Ed));
                }
                foreach (ElementItemId Face in TopSolidHost.Shapes.GetFaces(_el))
                {
                    Faces.Add(new Face(Face));
                }
            }
            catch 
            {

                
            }







            typeG = TopSolidHost.Geometries3D.GetGeometryType(_el).ToString();
            

            Constituents = new List<ElementItem>();
            foreach (ElementId Constituent in TopSolidHost.Elements.GetConstituents(_el))
            {
                Constituents.Add(new ElementItem(Constituent));
            }

        }

        public String Name { get; private set; }
        public List<string> Properties { get; private set; }
        public string FriendlyName { get; private set; }
        public string FullName { get; private set; }
        public List<Edge> Edges { get; private set; }
        public List<Face> Faces { get; private set; }
        public string typeG { get; private set; }
        public List<ElementItem> Constituents { get; private set; }
    }
}