using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export=false)] 
    public class OrthographicCamera : Camera
    {
        public OrthographicCamera(JsNumber left, JsNumber right, JsNumber top, JsNumber bottom, JsNumber near, JsNumber far){}
        public JsNumber left {get; set;}
        public JsNumber right {get; set;}
        public JsNumber top {get; set;}
        public JsNumber bottom {get; set;}
        public JsNumber near {get; set;}
        public JsNumber far {get; set;}
        public void updateProjectionMatrix() {} 
    }
}