using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class GeometryUtils
    {
        public static void merge(Geometry geometry1, Geometry object2) { }
        public static void merge(Geometry geometry1, Mesh object2) { }
        public static Geometry clone(Geometry geometry) { return null; }
        public static Vector3 randomPointInTriangle(Vector3 vectorA, Vector3 vectorB, Vector3 vectorC) { return null; }
        public static Vector3 randomPointInFace(Face3 face, Geometry geometry, JsBoolean useCachedAreas) { return null; }
        public static Vector3 randomPointInFace(Face4 face, Geometry geometry, JsBoolean useCachedAreas) { return null; }
        public static Vector3[] randomPointsInGeometry(Geometry geometry, JsNumber n) { return null; }
        public static JsNumber triangleArea(Vector3 vectorA, Vector3 vectorB, Vector3 vectorC) { return null; }
        public static Vector3 center(Geometry geometry) { return null; }
        public static void normalizeUVs(Geometry geometry) { }
        public static void triangulateQuads(Geometry geometry) { }
        public static void explode(Geometry geometry) { }
        public static void tessellate(Geometry geometry, JsNumber maxEdgeLength) { }
    }
}