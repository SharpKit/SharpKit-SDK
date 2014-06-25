using SharpKit.JavaScript;

namespace SharpKit.Html
{
    partial class TouchEvent
    {
        [JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createEvent('TouchEvent')")]
        public TouchEvent() { }
    }
}
