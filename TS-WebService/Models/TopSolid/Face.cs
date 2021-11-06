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
            FacesSurfaceType = TopSolidHost.Shapes.GetFaceSurfaceType(_face).ToString();
            Vertices = new List<Vertice>();
            Edges = new List<Edge>();
            foreach (ElementItemId Edge in TopSolidHost.Shapes.GetFaceEdges(_face))
            {
                Edges.Add(new Edge(Edge));

            }
            foreach (ElementItemId Vertice in TopSolidHost.Shapes.GetFaceVertices(_face))
            {
                Vertices.Add(new Vertice(Vertice));

            }
            Loops = new List<Loup>();
            foreach (int loop in TopSolidHost.Shapes.GetFaceLoops(_face))
            {
                Loops.Add(new Loup(_face.ElementId,loop));

            }

        }

        public ElementItemId Fac { get; private set; }
        public GeometryType Type { get; private set; }
        public String FacesSurfaceType { get; private set; }
        public List<Vertice> Vertices { get; private set; }
        public List<Edge> Edges { get; private set; }
        public List<Loup> Loops { get; private set; }
    }
}