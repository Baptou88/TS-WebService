using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class Vertice
    {
        public Vertice(ElementItemId _id)
        {

            //coord = TopSolidHost.Geometries3D.GetPointGeometry(_id);
            coord = TopSolidHost.Shapes.GetVertexPoint(_id);
            TypeGeometry = TopSolidHost.Geometries3D.GetGeometryType(_id.ElementId);
            
        }
        public Point3D coord { get; set; }
        public GeometryType TypeGeometry { get; private set; }

        
    }
}