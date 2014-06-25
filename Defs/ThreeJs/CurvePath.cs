using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class CurvePath : Curve
    {
        public CurvePath() { }
        public void add(Curve curve) { }
        public void closePath() { }

        public Vector2 getPoint(JsNumber t) { return null; }
        public JsNumber getLength() { return null; }

        public JsNumber getCurveLengths() { return null; }

        public getBoundingBoxReturn getBoundingBox() { return new getBoundingBoxReturn(); }
        
        public struct getBoundingBoxReturn
        {
            public JsNumber minX;
            public JsNumber minY;
            public JsNumber maxX;
            public JsNumber maxY;
            public JsNumber centroid;
        }

        public Geometry createPointsGeometry(JsNumber divisions) { return null; }
        public Geometry createSpacedPointsGeometry(JsNumber divisions) { return null; }
        public Geometry createGeometry(Vector3[] points) { return null; }

        public void addWrapPath(Curve bendpath ) { }

        public Vector2[] getTransformedPoints(JsNumber segments) { return null; }
        public Vector2[] getTransformedSpacedPoints(JsNumber segments, Curve[] bends) { return null; }
        public Vector2[] getWrapPoints(Vector2[] oldPts, Path path) { return null; }
    }
}
