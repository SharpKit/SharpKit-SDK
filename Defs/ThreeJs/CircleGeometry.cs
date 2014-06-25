using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class CircleGeometry : Geometry
    {
        public CircleGeometry(){}
        public CircleGeometry(JsNumber radius) { }
        public CircleGeometry(JsNumber radius, JsNumber segments) { }
        public CircleGeometry(JsNumber radius, JsNumber segments, JsNumber thetaStart) { }
        public CircleGeometry(JsNumber radius, JsNumber segments, JsNumber thetaStart, JsNumber thetaLength) { }    
    }
}