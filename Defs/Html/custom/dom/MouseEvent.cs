using SharpKit.JavaScript;

namespace SharpKit.Html
{
    partial class MouseEvent
    {
        [JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createEvent('MouseEvent')")]
        public MouseEvent() { }
    }
}
