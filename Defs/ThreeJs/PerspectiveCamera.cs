using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PerspectiveCamera : Camera
    {
        public PerspectiveCamera(JsNumber fov, JsNumber aspect, JsNumber near, JsNumber far) { }

        public void setLens(JsNumber focalLength, JsNumber frameHeight) { }
        public void setViewOffset(JsNumber fullWidth, JsNumber fullHeight, JsNumber x, JsNumber y, JsNumber width, JsNumber height) { }
        public void updateProjectionMatrix() { }

        public JsNumber fov {get; set;}
        public JsNumber aspect { get; set; }
        public JsNumber near { get; set; }
        public JsNumber far { get; set; }
        public JsNumber fullWidth { get; set; }
        public JsNumber fullHeight { get; set; }
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber width { get; set; }
        public JsNumber height { get; set; }

        public void rotateOnAxis(object o, double d)
        {
            throw new NotImplementedException();
        }
    }
}