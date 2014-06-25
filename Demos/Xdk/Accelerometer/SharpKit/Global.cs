using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Accelerometer
{
    [JsType(GlobalObject = true, Filename = "../js/demo-accelerometer.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables
        public static long timer = 0;

        public static int portrait_width = 768;
        public static int landscape_width = 1024;

        public static Element metatag = null;
        public static Element masthead = null;
        public static Element tabletop = null;

        public static Element label = null;
        public static Element container = null;
        public static JsNumber current_left = 0;
        public static JsNumber current_top = 0;
        public static JsNumber absx = 0;
        public static JsNumber absy = 0;
        public static JsNumber dx = 0;
        public static JsNumber dy = 0;

        public static JsNumber x_ispos = 1;
        public static JsNumber y_ispos = 1;
        public static int o_width = portrait_width;
        public static int o_height = landscape_width;
        public static JsNumber labelleft = 0;
        public static JsNumber canangle = 0;
        public static JsNumber labeldirection = 1;
        public static JsNumber lastangle = 0;
        public static JsNumber nextrot = 0;
        public static JsNumber vectangle = 0;
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

        public static JsAction Fail = delegate() { };
        public static JsAction WatchAccel = delegate()
        {
            XdkAccelerationOptions opt = new XdkAccelerationOptions();
            opt.frequency = 5;
            //opt.frequency = 1000;
            timer = Xdk.accelerometer.WatchAcceleration(Suc, opt);
        };
        #endregion

        /// <summary>
        /// Global code
        /// </summary>
        static Global()
        {
            //normally, global variables are discouraged. Here we use them for two reasons,
            //1) the accelerometer readings are coming potentially 100s of times per second
            // - allocating 15 variables 100s of times per second will be an unnecessary resource drain on slower device like gen1 iTouches
            //2) webkit transforms just make an animation happen - THEY DON'T change the actual CSS position of 
            //of an element that was animated. To keep track of the position a global variable is helpful (current_left, current_top)
            //although we could accomplish this differently with a little more work.
            //
            //NOTE - we said right above that webkit animations don't reposition the an element as reported by CSS. 
            //SO, why don't we then correct CSS's position? Because the can doesn't visually have time to repaint at it's pre-animation position
            //given that we are doing an new webkit animation every 100th of a second based on
            //accelerometer readings - so no need to 
            //invoke the extra overhead of telling the DOM that the element is being repositioned constantly by resetting the CSS
            //pixelLeft and pixelTop of the cokecan.
            Xdk.OnDeviceReady += DeviceReady;
            // or, if DeviceReady as Event parameter (and not DeviceEvent):
            // document.AddEventListener(AppMobiEventType.DeviceReady, DeviceReady, false);
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        }


        /// <summary>
        /// use this to round to a percent (0 to 100)
        /// </summary>
        public static double RoundNumber(double num)
        {
            int dec = 2;
            double result = 100 * JsMath.Round(num * JsMath.Pow(10, dec)) / JsMath.Pow(10, dec);
            return result;
        }

        //the following function handles the "physics" of how the can moves
        //calculating roation of the can and the direction of movement etc.
        //can be ignored if you only care about how to grab accelerometer readings
        //and do animations.
        //        //the can wants to slide in the direction of the slope of the table.
        //        //and wants to rotate such that the can is perpendicular to that direction (has reciprocal slope)
        //        //the label of the can want to rotate in the direction opposite to gravity. 
        public static void DoCanPhysics(XdkAcceleration a)
        {

            x_ispos = 1;
            y_ispos = 1;

            //take the abs tilt values so we don't
            //get stupid results while doing interim
            //calculations
            absx = JsMath.Abs(a.x);
            absy = JsMath.Abs(a.y);


            if (absx < .1)
            {
                absx = 0;
            }
            if (absy < .1)
            {
                absy = 0;
            }

            //skip the calculations if there is no movement;
            if (absx == absy && absx == 0)
            {
                return;
            }
            //var opp;
            //var adj;

            //what is the angle of the vector of motion of the can?
            //first calc without regard to sign of the accelerometer vectors
            lastangle = vectangle;

            vectangle = JsMath.Round(JsMath.Atan2(a.y, a.x) * 180 / JsMath.PI);

            //        //ignore small variations in rotation so that the can doesn't shake incessantly
            //        if (lastangle > vectangle) {
            //            if (Math.abs(lastangle - vectangle) < 10) {
            //                vectangle = lastangle;
            //            }
            //        }
            //        else {
            //            if (Math.abs(vectangle - lastangle) < 10) {
            //                vectangle = lastangle;
            //            }
            //        }

            //now, adjust the arctan calculation for direction of the accel vectors
            //by adding the correct angle based on the quatrant
            // that the motion occurs in.
            //quadrant 1
            if (x_ispos > 0 && y_ispos > 0)
            {
                vectangle = 90 - vectangle;
            }
            //quadrant 2
            else if (x_ispos > 0 && y_ispos < 0)
            {
                vectangle = 90 + vectangle;
            }
            //quadrant 3
            else if (x_ispos < 0 && y_ispos < 0)
            {
                vectangle = 270 - vectangle;
            }
            //quadrant 4
            else if (x_ispos < 0 && y_ispos > 0)
            {
                vectangle = 270 + vectangle;
            }

            //make the motion vect angle positive.
            if (vectangle < 0)
            {
                vectangle = (vectangle + 360) % 360;
            }

            //allow some accelerated movement based on how tilted the device is
            dx = JsMath.Floor(JsMath.Log(RoundNumber(absx) * 5));
            dx = JsMath.Max(dx, 0);

            dy = JsMath.Floor(JsMath.Log(RoundNumber(absy) * 5));
            dy = JsMath.Max(dy, 0);

            x_ispos = 1;
            y_ispos = 1;

            if (a.x < 0)
            {
                x_ispos = -1;
            }
            if (a.y < 0)
            {
                y_ispos = -1;
            }

            //now put back the sign
            dx = dx * x_ispos;
            dy = dy * y_ispos;

            //calculate can movements
            current_left += dx;
            current_top -= dy;

            canangle = (canangle + 360) % 360;

            double a1, a2, a3, a4, af;
            //a1 and a2 then can is within 90
            //a3 and a4 can is upside down relative to 
            //the motion vector
            labeldirection = 1;
            a1 = vectangle + 90 - canangle;
            //HtmlElement.GetById("accel_z").innerHTML = "case 1: " ;
            af = a1;
            a2 = vectangle - 90 - canangle;

            if (JsMath.Abs(a2) < JsMath.Abs(af))
            {
                af = a2;
                // HtmlElement.GetById("accel_z").innerHTML = "case 2: ";
            }
            a3 = vectangle + 90 - canangle + 180;
            if (JsMath.Abs(a3) < JsMath.Abs(af))
            {
                af = a3;
                //HtmlElement.GetById("accel_z").innerHTML = "case 3: ";
                labeldirection = -1;
            }
            a4 = vectangle - 90 - canangle + 180;
            if (JsMath.Abs(a4) < JsMath.Abs(af))
            {
                af = a4;
                // HtmlElement.GetById("accel_z").innerHTML = "case 4: a4 = " + a4 + "a3 = " + a3 + "a2 = " + a2 + "a1 = " + a1;
                labeldirection = -1;
            }

            if (af > 180)
            {
                af = -1 * (360 - af);
            }

            //HtmlElement.GetById("accel_y").innerHTML = "vectangle= " + vectangle + "; canangle=" + canangle + " rotpos=" + af; //  + "; rotneg=" + rotneg + "; nextrot=" + nextrot;
            // HtmlElement.GetById("accel_x").innerHTML = "a.x = " + a.x + ", a.y = " + a.y;


            //which way should the label spin?
            //it should spin right when moving at 90deg to the
            //motion vector, spin left when moving at 270deg
            if (canangle > vectangle)
            {
                labeldirection = -1;
            }

            if (JsMath.Abs(canangle - vectangle) > 180)
            {
                labeldirection = labeldirection * -1;
            }


            //if the movement is right or down then the label and can is upright, label move left
            labelleft += labeldirection * JsMath.Ceil(JsMath.Sqrt(dx * dx + dy * dy));



            if (af > 3)
            {
                canangle++;
            }
            else if (af < -3)
            {
                canangle--;
            }


        }

        //this is the event handler for successful accelerometer readings
        public static void Suc(XdkAcceleration a)
        {
            //readings are from -1 to 1 (with 0 being equilibrium in a plane). Assumes holding in portrait mode
            //with screen pointed straight at your chest.
            //e.g. in the X plane -1 = tilted all the way left, 1 = tilted all the way right.
            //e.g. in the Y plane -1 = tilted all the way left, 1 = tilted all the way right.

            //  HtmlElement.GetById("accel_x").innerHTML = "a.x = " + a.x + ", a.y = " + a.y;

            DoCanPhysics(a);

            //make sure the can isn't off the screen
            current_left = JsMath.Max(current_left, 0);
            current_top = JsMath.Max(current_top, -100);

            current_left = JsMath.Min(current_left, o_width - 100);
            current_top = JsMath.Min(current_top, o_height - 200);

            //visible width of label on can is 164
            //total widht of label is 1074
            if (labelleft <= -910)
            {
                labelleft = -373;
            }
            if (labelleft >= 0)
            {
                labelleft = -537;
            }

            //labelleft = labelleft % 537;
            //basically, we're going to slide and rotate the can around on the screen based on the physics
            //computed in the previous funciton. The animation calls are really fairly simple ...
            //need to check that container and label have been initialized in case deviceready happens before load
            JsCode(@"if (container != null) container.style.webkitTransform = ""translate("" + current_left + ""px, "" + current_top + ""px) rotate("" + canangle + ""deg) scale(.85, .85)""");
            JsCode(@"if (label != null) label.style.webkitTransform = ""translate("" + labelleft + ""px, 0px)""");
            //TODO	        if (container != null) container.style.webkitTransform = "translate(" + current_left + "px, " + current_top + "px) rotate(" + canangle + "deg) scale(.85, .85)";
            //TODO	        if (label != null) label.style.webkitTransform = "translate(" + labelleft + "px, 0px)";
        }



        public static void DeviceReady(XdkDeviceEvent evt)
        {
            //use AppMobi viewport
            int landscapewidth = 1360;
            Xdk.display.UseViewport(portrait_width, landscapewidth);

            //lock orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            //manage power
            Xdk.device.ManagePower(true, false);

            //hide splash screen
            Xdk.device.HideSplashScreen();

            WatchAccel();
        }

        public static void BodyLoad()
        {
            metatag = Element.GetById("meta_view");
            label = Element.GetById("img_cokelabel");
            container = Element.GetById("div_cokecan");
            masthead = Element.GetById("img_masthead");
        }
    }
}