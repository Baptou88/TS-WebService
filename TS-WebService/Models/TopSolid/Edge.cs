using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class Edge
    {
        public Edge(ElementItemId _el)
        {

            ElementItemId = _el;
            TopSolidHost.Shapes.GetEdgeVertices(_el, out ElementItemId outStartVertexId, out ElementItemId outEndVertexId);
            StartVertexId = new Vertice(outStartVertexId);
            EndVertexId = new Vertice(outEndVertexId);
            Length = TopSolidHost.Shapes.GetEdgeLength(_el);
            TypeGeometry = TopSolidHost.Geometries3D.GetGeometryType(_el.ElementId);
            TypeCurve = TopSolidHost.Shapes.GetEdgeCurveType(_el).ToString();
            if ((CurveType)TopSolidHost.Shapes.GetEdgeCurveType(_el) == CurveType.Circle)
            {
                Plane3D outplane;
                double Radius;
                TopSolidHost.Shapes.GetEdgeCircleCurve(_el, out outplane, out Radius);
                Plan3D = outplane;
                Rayon = Radius;

                double outTmin;
                double outTmax;
                TopSolidHost.Shapes.GetEdgeRange(_el, out outTmin,out  outTmax);
                Tmin = outTmin;
                Tmax = outTmax;

                P1 = TopSolidHost.Shapes.GetEdgePoint(_el, ((Tmax - Tmin) / 3) + Tmin);
                P2 = TopSolidHost.Shapes.GetEdgePoint(_el, ((2*(Tmax - Tmin)) / 3) + Tmin);

            }
        }

        public ElementItemId ElementItemId { get; private set; }
        public Vertice StartVertexId { get; private set; }
        public Vertice EndVertexId { get; private set; }
        public double Length { get; private set; }
        public GeometryType TypeGeometry { get; private set; }
        public string TypeCurve { get; private set; }
        public Plane3D Plan3D { get; }
        public double Rayon { get; private set; }

        public double Tmin { get; private set; }
        public double Tmax { get; private set; }
        public Point3D P1 { get; private set; }
        public Point3D P2 { get; private set; }
    }
    public enum CurveType
    {
       Unclassified = -1,
       None = 0,
       Line = 1,
       Circle = 2,
       Ellipse = 3,
       BSpline = 4,
       Polyline = 5,
       Intersection = 6,
       SPCurve = 7

    }

}