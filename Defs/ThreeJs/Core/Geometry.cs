using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Geometry
    {
        public Geometry() {}

        //properties
        public JsNumber id { get; set; }
        public JsString name { get; set; }
	    public JsArray<Vector3> vertices { get; set; }
	    public JsArray<Color> colors { get; set; }
	    public JsArray<Material> materials { get; set; }
	    public JsArray<Face3> faces { get; set; }
	    public JsArray<JsArray<UV>> faceUvs { get; set; }
	    public JsArray<JsArray<UV>> faceVertexUvs { get; set; }
        /*
	    this.morphTargets = [];
	    this.morphColors = [];
	    this.morphNormals = [];

	    this.skinWeights = [];
	    this.skinIndices = [];
        */
	    public BoundingBox boundingBox { get; set; }
        public BoundingSphere boundingSphere { get; set; }
        public JsBoolean hasTangents { get; set; }
        public JsBoolean dynamic { get; set; }

        public JsBoolean verticesNeedUpdate { get; set; }
        public JsBoolean elementsNeedUpdate { get; set; }
        public JsBoolean uvsNeedUpdate { get; set; }
        public JsBoolean normalsNeedUpdate { get; set; }
        public JsBoolean tangentsNeedUpdate { get; set; }
        public JsBoolean colorsNeedUpdate { get; set; }
    
        //methods
        public void applyMatrix(Matrix4 matrix) { }
        public void computeCentroids() { }
        public void computeFaceNormals() { }
        public void computeVertexNormals() { }
        public void computeMorphNormals() { }
        public void computeTangents() { }
        public void computeBoundingBox() { }
        public void computeBoundingSphere() { }
        public JsNumber mergeVertices() { return null; }
        public void clone() { }
        public void deallocate() { }
    }

    [JsType(JsMode.Json, Export = false)]
    public class BoundingBox
    {
        public Vector3 min;
        public Vector3 max;
    }

    [JsType(JsMode.Json, Export = false)]
    public class BoundingSphere
    {
        public JsNumber radius;
    }
}