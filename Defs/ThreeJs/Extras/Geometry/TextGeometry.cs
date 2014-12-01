using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class TextGeometry : Geometry
    {
        public TextGeometry(JsString text, TextGeometryOptions parameters) { }
       
    }

    [JsType(JsMode.Prototype, Export = false)]
    public struct TextGeometryOptions
    {
        public JsNumber size; 			 	// size of the text
        public JsNumber  height; 		 	// thickness to extrude text
        public JsNumber  curveSegments; 	// number of points on the curves
        public JsString  font; 				// font name
        public JsString  weight; 			// font weight (normal, bold)
        public JsString  style; 			// font style  (normal, italics)
        public JsBoolean  bevelEnabled;		// turn on bevel
        public JsNumber  bevelThickness;  	// how deep into text bevel goes
        public JsNumber  bevelSize;		 	// how far from text outline is bevel
    }
}