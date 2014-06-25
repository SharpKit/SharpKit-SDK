using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class TubeGeometry : Geometry
    {
        public TubeGeometry() { }
        public TubeGeometry(Path path) { }
        public TubeGeometry(Path path, JsNumber segments) { }
        public TubeGeometry(Path path, JsNumber segments, JsNumber radius) { }
        public TubeGeometry(Path path, JsNumber segments, JsNumber radius, JsNumber radiusSegments) { }
        public TubeGeometry(Path path, JsNumber segments, JsNumber radius, JsNumber radiusSegments, JsBoolean closed) { }
        public TubeGeometry(Path path, JsNumber segments, JsNumber radius, JsNumber radiusSegments, JsBoolean closed, JsBoolean debug) { }

        public class FrenetFrames
        {
            public FrenetFrames(Path path, JsNumber segments) { }
            public FrenetFrames(Path path, JsNumber segments, JsBoolean closed) { }
        }
    }
}