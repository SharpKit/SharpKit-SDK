using System;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ExtrudeGeometry  : Geometry
    {
        public ExtrudeGeometry(object shapes, ExtrudeGeometryOptions options) { }
        public ExtrudeGeometry(object[] shapes, ExtrudeGeometryOptions options) { }

        public void addShapeList(object[] shapes, ExtrudeGeometryOptions options) { }
        public void addShape(object shape, ExtrudeGeometryOptions options) { }


        public class WorldUVGenerator 
        {
	        public UV[] generateTopUV(Geometry geometry, Shape extrudedShape, object extrudeOptions, JsNumber indexA, JsNumber indexB, JsNumber indexC )
	        {
	            throw new NotImplementedException();
	        }
	        public UV[] generateBottomUV(Geometry geometry, Shape extrudedShape, object extrudeOptions, JsNumber indexA, JsNumber indexB, JsNumber indexC ) 
            {
	            throw new NotImplementedException();
	        }
	        public UV[] generateSideWallUV(Geometry geometry, Shape extrudedShape, object wallContour, object extrudeOptions,JsNumber indexA, JsNumber indexB, JsNumber indexC, JsNumber indexD, object stepIndex, object stepsLength, object contourIndex1, object contourIndex2 ) 
            {
		        throw new NotImplementedException();
		    }
	    }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public struct ExtrudeGeometryOptions
    {
        public JsNumber size;                           // size of the text
        public JsNumber height;                         // thickness to extrude text
        public JsNumber curveSegments;                  // number of points on the curves
        public JsNumber steps;                          // number of points for z-side extrusions / used for subdividing segements of extrude spline too
        public JsNumber amount;                         // Amount
        public JsBoolean bevelEnabled;                  // turn on bevel
        public JsNumber bevelThickness;                 // how deep into text bevel goes
        public JsNumber bevelSize;                      // how far from text outline is bevel
        public JsNumber bevelSegments;                  // number of bevel layers
        public CurvePath extrudePath;             // 3d spline path to extrude shape along. (creates Frames if .frames aren't defined)
        public TubeGeometry.FrenetFrames frames;  // containing arrays of tangents, normals, binormals
        public JsNumber material;                       // material index for front and back faces
        public JsNumber extrudeMaterial;                // material index for extrusion and beveled faces
        public JsObject uvGenerator;                    // object that provides UV generator functions
    }
}