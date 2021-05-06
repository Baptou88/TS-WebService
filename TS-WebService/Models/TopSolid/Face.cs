using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class Face
    {
        public Face(ElementItemId _face)
        {

            Type = TopSolidHost.Geometries3D.GetGeometryType(_face.ElementId);
            Vertices = new List<Vertice>();

            foreach (ElementItemId Vertice in TopSolidHost.Shapes.GetFaceVertices(_face))
            {
                Vertices.Add(new Vertice(Vertice));

            }
        }

        public ElementItemId Fac { get; private set; }
        public GeometryType Type { get; private set; }
        public List<Vertice> Vertices { get; private set; }
    }
}