using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class TrackballControls
    {
        public double rotateSpeed;
        public double zoomSpeed;
        public double panSpeed;
        public bool noZoom;
        public bool noPan;
        public bool staticMoving;
        public double dynamicDampingFactor;
        public int[] keys;
        public Vector3 target;

        public TrackballControls(Camera camera, HtmlElement domElement)
        {
        }

        public void addEventListener(string c, Action render)
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
