using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.DragAndDrop
{
    [JsType(GlobalObject = true, Filename = "../js/demo-draganddrop.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables

        public static int iPortraitWidth = 768;
        public static int iLandscapeWidth = 1024;
        public static bool boolSelected = false;
        public static int dragItemHeight = 110;
        public static int dragItemWidth = 90;
        public static int imgOffset = dragItemWidth;
        public static JsObject<int> movingItems = new JsObject<int>();
        public static bool isMoving = false;

        #endregion

        #region Functions delegate
        //*** Prevent Default Scroll ******
        /// <summary>
        /// Prevent Default Scroll
        /// </summary>
        /// <param name="evt"></param>
        public static EventListener<TouchEvent> PreventDefaultScroll = delegate(TouchEvent evt)
        {
            evt.PreventDefault();
            window.Scroll(0, 0);
            @return(false);
        };
        #endregion

        /// <summary>
        /// Global code
        /// </summary>
        static Global()
        {
            //initial event handler to detect when appMobi is ready to roll
            Xdk.OnDeviceReady += DeviceReady;
            // or, if DeviceReady as Event parameter (and not DeviceEvent):
            // document.addEventListener(AppMobiEventType.DeviceReady, DeviceReady, false);
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, PreventDefaultScroll);
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, TouchMove);
            Xdk.multitouch.Add(window.document, TouchEventType.TouchEnd, TouchEnd);
            Xdk.multitouch.Add(window.document, TouchEventType.TouchStart, TouchStart);
        }

        /// <summary>
        /// AppMobi is ready to roll
        /// </summary>
        /// <param name="evt"></param>
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            try
            {
                //user AppMobi viewport
                Xdk.display.UseViewport(iPortraitWidth, iLandscapeWidth);
            }
            catch (JsError e) { }

            try
            {
                //lock orientation
                Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
                Xdk.device.SetAutoRotate(false);
            }
            catch (JsError e) { }

            try
            {
                //manage power
                Xdk.device.ManagePower(true, false);
            }
            catch (JsError e) { }

            //hide splash screen
            Xdk.device.HideSplashScreen();
        }

        public static void Init()
        {
            AddMovingItem("dragItem");
            AddMovingItem("dragItem2");
        }

        public static void TouchStart(TouchEvent evt)
        {
            // With JQuery: $(document).bind("touchstart", function(e) {...}
            evt.PreventDefault();
            JsString target_id = evt.target.id;
            if (isMoving == false && movingItems[target_id] == 1)
            {
                isMoving = true;
                //var orig = e.originalEvent;
                TouchEvent orig = evt;
                int x = orig.touches[0].pageX - imgOffset;
                int y = orig.touches[0].pageY - imgOffset;
                //Set the item to moving, and update the position and zIndex
                movingItems[target_id] = 2;
                HtmlElement.GetById(target_id).style.top = y + "px";
                HtmlElement.GetById(target_id).style.left = x + "px";
                // With JQuery: $("#dragItem").css({top: y, left: x});
                HtmlElement.GetById(target_id).style.zIndex = "2000";
            }
        }

        public static void TouchMove(TouchEvent evt)
        {
            // With JQuery: $(document).bind("touchmove", function(e) {...}
            evt.PreventDefault();
            JsString target_id = evt.target.id;
            //Check that the target element is registered and flagged as moving
            if (movingItems[target_id].As<bool>() && movingItems[target_id] == 2)
            {
                //var orig = e.originalEvent;
                TouchEvent orig = evt;
                if (orig.touches.length > 1)
                    return;
                int x = orig.touches[0].pageX - imgOffset;
                int y = orig.touches[0].pageY - imgOffset;

                HtmlElement.GetById(target_id).style.top = y + "px";
                HtmlElement.GetById(target_id).style.left = x + "px";
                // With JQuery: $("#dragItem").css({top: y, left: x});
            }
        }
        public static void TouchEnd(TouchEvent evt)
        {
            JsString target_id = evt.target.id;
            if (movingItems[target_id].As<bool>())
            {
                isMoving = false;
                //Deactivate the current moving object and set the zIndex to 1;
                movingItems[target_id] = 1;
                HtmlElement.GetById(target_id).style.zIndex = "2";
                foreach (JsString j in movingItems)
                {
                    if (j != target_id)
                    {
                        HtmlElement.GetById(j).style.zIndex = "1";
                    }
                }
            }
        }
        public static void AddMovingItem(JsString ind)
        {
            movingItems[ind] = 1;
        }
    }
}