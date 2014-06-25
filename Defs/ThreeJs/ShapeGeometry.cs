using System;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ShapeGeometry : Geometry
    {
        public ShapeGeometry(Shape shapes, ShapeGeometryOptions options) { }
        public ShapeGeometry(Shape[] shapes, ShapeGeometryOptions options) { }

        public ShapeGeometry addShapeList(Shape[] shapes, ShapeGeometryOptions options) { return null; }

        public void addShape(Shape shape, ShapeGeometryOptions options){}
    }

    [JsType(JsMode.Json, Export = false)]
    public struct ShapeGeometryOptions
    {
        public JsNumber curveSegments;  // number of points on the curves. NOT USED AT THE MOMENT.
        public JsNumber material;       // material index for front and back faces
        public JsObject uvGenerator;    // object that provides UV generator functions
    }
}