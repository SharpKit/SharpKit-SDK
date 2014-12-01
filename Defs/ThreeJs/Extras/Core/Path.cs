using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Path : CurvePath
    {
        public Path() { }
        public Path(Vector2[] points) { }

        public void fromPoints(Vector2[] vectors) { }
        public void moveTo(JsNumber x, JsNumber y) { }
        public void lineTo(JsNumber x, JsNumber y) { }
        public void quadraticCurveTo(JsNumber aCPx, JsNumber aCPy, JsNumber aX, JsNumber aY) { }
        public void bezierCurveTo(JsNumber aCP1x, JsNumber aCP1y, JsNumber aCP2x, JsNumber aCP2y, JsNumber aX, JsNumber aY) { }
        public void splineThru(Vector2[] pts) { }
        public void arc(JsNumber aX, JsNumber aY, JsNumber aRadius, JsNumber aStartAngle, JsNumber aEndAngle,JsNumber aClockwise) { }
        public void ellipse(JsNumber aX, JsNumber aY, JsNumber xRadius, JsNumber yRadius, JsNumber aStartAngle, JsNumber aEndAngle, JsNumber aClockwise) { }
        public void absellipse(JsNumber aX, JsNumber aY, JsNumber xRadius, JsNumber yRadius, JsNumber aStartAngle, JsNumber aEndAngle, JsNumber aClockwise) { }
        public Vector2[] getSpacedPoints(JsNumber divisions,JsBoolean closedPath) { return null; }
        public Vector2[] getPoints(JsNumber divisions, JsBoolean closedPath) { return null; }
        public Shape[] toShapes() { return null; }

    }
}