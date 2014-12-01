using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)] 
    public class JSONLoader : Loader
    {
        public void load(JsString url, JsAction<Geometry> callback) { }
        public void load(JsString url, JsAction<Geometry> callback, JsString texturePath){}
    }
}
