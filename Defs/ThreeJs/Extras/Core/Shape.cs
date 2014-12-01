using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Shape : Path
    {
        public Shape() { }

        public ExtrudeGeometry extrude(ExtrudeGeometryOptions options){return null;}
        public ShapeGeometry makeGeometry(ShapeGeometryOptions options) { return null; }
        public Vector2[] getPointsHoles(JsNumber divisions) { return null; }
        public Vector2[] getSpacedPointsHoles(JsNumber divisions) { return null; }
        public extractAllPointsReturn extractAllPoints(JsNumber divisions) { return new extractAllPointsReturn(); }
        public struct extractAllPointsReturn
        {
            public Vector2[] shape;
            public Vector2[][] holes;
        }
        public extractAllPointsReturn extractPoints(JsNumber divisions) { return new extractAllPointsReturn(); }
        public extractAllPointsReturn extractAllPointsWithBend(JsNumber divisions, Curve bend) { return new extractAllPointsReturn(); }
        public extractAllPointsReturn extractAllSpacedPoints(JsNumber divisions) { return new extractAllPointsReturn(); }

        public static class Utils
        {
            public static removeHolesReturn removeHoles(Vector2[] contour,Vector2[][] holes) { return new removeHolesReturn(); }
            public struct removeHolesReturn
            {
                public Vector2[] shape;
                public Vector2[] isolatedPts;
                public Vector2[] allpoints;
            }

            public static Vector2[] triangulateShape(Vector2[] contour, Vector2[][] holes) { return null; }

            public static JsBoolean isClockWise(Vector2[] pts) { return null; }

            public static JsNumber b2p0(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b2p1(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b2p2(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b2(JsNumber t, JsNumber p0, JsNumber p1, JsNumber p2) { return null; }
            public static JsNumber b3p0(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b3p1(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b3p2(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b3p3(JsNumber t, JsNumber p) { return null; }
            public static JsNumber b3(JsNumber t, JsNumber p0, JsNumber p1, JsNumber p2, JsNumber p3) { return null; }
        }
    }
}
