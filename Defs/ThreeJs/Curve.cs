using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public abstract class Curve
    {
        public Curve(){}

        public virtual Vector2 getPoint(JsNumber t) { return null; }
        public virtual Vector2 getPointAt(JsNumber u) { return null; }
        public virtual Vector2[] getPoints(JsNumber divisions) { return null; }
        public virtual Vector2[] getSpacedPoints(JsNumber divisions) { return null; }

        public virtual JsNumber getLength() { return null; }
        public virtual JsNumber getLengths(JsNumber divisions) { return null; }
        public virtual void updateArcLengths() { }
        public virtual JsNumber getUtoTmapping(JsNumber u, JsNumber distance) { return null; }
        public virtual Vector2 getNormalVector(JsNumber t) { return null; }
        public virtual Vector2 getTangent(JsNumber t) { return null; }
        public virtual Vector2 getTangentAt(JsNumber u) { return null; }

        public static class Utils
        {
            public static JsNumber tangentQuadraticBezier(JsNumber t, JsNumber p0, JsNumber p1, JsNumber p2) { return null; }
            public static JsNumber tangentCubicBezier(JsNumber t, JsNumber p0, JsNumber p1, JsNumber p2, JsNumber p3) { return null; }
            public static JsNumber tangentSpline(JsNumber t, JsNumber p0, JsNumber p1, JsNumber p2, JsNumber p3) { return null; }
            public static JsNumber interpolate(JsNumber p0, JsNumber p1, JsNumber p2, JsNumber p3, JsNumber t) { return null; }
        }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class LineCurve : Curve
    {
        public LineCurve(Vector2 v1, Vector2 v2){}

        public Vector2 getPoint(JsNumber t) { return null; }
        public Vector2 getPointAt(JsNumber u) { return null; }
        public Vector2 getTangent(JsNumber t) { return null; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class QuadraticBezierCurve : Curve
    {
        public QuadraticBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2) { }
        public Vector2 getPoint(JsNumber t) { return null; }
        public Vector2 getTangent(JsNumber t) { return null; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CubicBezierCurve : Curve
    {
        public CubicBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3) { }
        public Vector2 getPoint(JsNumber t) { return null; }
        public Vector2 getTangent(JsNumber t) { return null; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class SplineCurve : Curve
    {
        public SplineCurve(Vector2[] points) { }
        public Vector2 getPoint(JsNumber t) { return null; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class EllipseCurve : Curve
    {
        public EllipseCurve(JsNumber aX, JsNumber aY, JsNumber xRadius, JsNumber yRadius, JsNumber aStartAngle, JsNumber aEndAngle, JsNumber aClockwise) { }
        public Vector2 getPoint(JsNumber t) { return null; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ArcCurve : EllipseCurve
    {
        public ArcCurve(JsNumber aX, JsNumber aY, JsNumber aRadius, JsNumber aStartAngle, JsNumber aEndAngle, JsNumber aClockwise) : base(aX,aY,aRadius,aRadius,aStartAngle,aEndAngle,aClockwise){ }
    }
    /* TODO:
    // A Factory method for creating new curve subclasses
    THREE.Curve.create = function ( constructor, getPointFunc ) {
	    constructor.prototype = Object.create( THREE.Curve.prototype );
	    constructor.prototype.getPoint = getPointFunc;
	    return constructor;
    };

    THREE.LineCurve3 = THREE.Curve.create(
	    function ( v1, v2 ) {
		    this.v1 = v1;
		    this.v2 = v2;
	    },
	    function ( t ) {
		    var r = new THREE.Vector3();
		    r.sub( this.v2, this.v1 ); // diff
		    r.multiplyScalar( t );
		    r.addSelf( this.v1 );
		    return r;
	    }
    );

    THREE.QuadraticBezierCurve3 = THREE.Curve.create(
	    function ( v0, v1, v2 ) {
		    this.v0 = v0;
		    this.v1 = v1;
		    this.v2 = v2;

	    },
	    function ( t ) {
		    var tx, ty, tz;
		    tx = THREE.Shape.Utils.b2( t, this.v0.x, this.v1.x, this.v2.x );
		    ty = THREE.Shape.Utils.b2( t, this.v0.y, this.v1.y, this.v2.y );
		    tz = THREE.Shape.Utils.b2( t, this.v0.z, this.v1.z, this.v2.z );
		    return new THREE.Vector3( tx, ty, tz );
	    }
    );

    THREE.CubicBezierCurve3 = THREE.Curve.create(
	    function ( v0, v1, v2, v3 ) {
		    this.v0 = v0;
		    this.v1 = v1;
		    this.v2 = v2;
		    this.v3 = v3;
	    },
	    function ( t ) {
		    var tx, ty, tz;
		    tx = THREE.Shape.Utils.b3( t, this.v0.x, this.v1.x, this.v2.x, this.v3.x );
		    ty = THREE.Shape.Utils.b3( t, this.v0.y, this.v1.y, this.v2.y, this.v3.y );
		    tz = THREE.Shape.Utils.b3( t, this.v0.z, this.v1.z, this.v2.z, this.v3.z );
		    return new THREE.Vector3( tx, ty, tz );
	    }
    );

    THREE.SplineCurve3 = THREE.Curve.create(
	    function ( points ) {// array of Vector3 
		    this.points = (points == undefined) ? [] : points;
	    },
	    function ( t ) {
		    var v = new THREE.Vector3();
		    var c = [];
		    var points = this.points, point, intPoint, weight;
		    point = ( points.length - 1 ) * t;
		    intPoint = Math.floor( point );
		    weight = point - intPoint;
		    c[ 0 ] = intPoint == 0 ? intPoint : intPoint - 1;
		    c[ 1 ] = intPoint;
		    c[ 2 ] = intPoint  > points.length - 2 ? points.length - 1 : intPoint + 1;
		    c[ 3 ] = intPoint  > points.length - 3 ? points.length - 1 : intPoint + 2;
		    var pt0 = points[ c[0] ],
			    pt1 = points[ c[1] ],
			    pt2 = points[ c[2] ],
			    pt3 = points[ c[3] ];
		    v.x = THREE.Curve.Utils.interpolate(pt0.x, pt1.x, pt2.x, pt3.x, weight);
		    v.y = THREE.Curve.Utils.interpolate(pt0.y, pt1.y, pt2.y, pt3.y, weight);
		    v.z = THREE.Curve.Utils.interpolate(pt0.z, pt1.z, pt2.z, pt3.z, weight);
		    return v;
	    }
    );

    THREE.ClosedSplineCurve3 = THREE.Curve.create(
	    function ( points ) {// array of Vector3 
		    this.points = (points == undefined) ? [] : points;
	    },
        function ( t ) {
            var v = new THREE.Vector3();
            var c = [];
            var points = this.points, point, intPoint, weight;
            point = ( points.length - 0 ) * t;
                // This needs to be from 0-length +1
            intPoint = Math.floor( point );
            weight = point - intPoint;
            intPoint += intPoint > 0 ? 0 : ( Math.floor( Math.abs( intPoint ) / points.length ) + 1 ) * points.length;
            c[ 0 ] = ( intPoint - 1 ) % points.length;
            c[ 1 ] = ( intPoint ) % points.length;
            c[ 2 ] = ( intPoint + 1 ) % points.length;
            c[ 3 ] = ( intPoint + 2 ) % points.length;
            v.x = THREE.Curve.Utils.interpolate( points[ c[ 0 ] ].x, points[ c[ 1 ] ].x, points[ c[ 2 ] ].x, points[ c[ 3 ] ].x, weight );
            v.y = THREE.Curve.Utils.interpolate( points[ c[ 0 ] ].y, points[ c[ 1 ] ].y, points[ c[ 2 ] ].y, points[ c[ 3 ] ].y, weight );
            v.z = THREE.Curve.Utils.interpolate( points[ c[ 0 ] ].z, points[ c[ 1 ] ].z, points[ c[ 2 ] ].z, points[ c[ 3 ] ].z, weight );
            return v;
        }
    );*/
}
