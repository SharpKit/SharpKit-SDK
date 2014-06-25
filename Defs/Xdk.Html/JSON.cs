/*******************************************************************************************************
  This file was created/modified by Hervé PHILIPPE alchiweb[at]gmail.com
********************************************************************************************************

  Copyright (C) 2013 Hervé PHILIPPE, Web: http://xmadevlab.net

  Project based on the files auto generated with the tool "WebIDLParser"
  Copyright (C) 2013 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.ComponentModel;

namespace SharpKit.DotNet.Html
{

    using SharpKit.JavaScript;
    using SharpKit.DotNet.JavaScript;
    using SharpKit.DotNet.Html.fileapi;
    using SharpKit.DotNet.Html.html.shadow;
    using SharpKit.DotNet.Html.html.track;
    using SharpKit.DotNet.Html.inspector;
    using SharpKit.DotNet.Html.loader.appcache;
    using SharpKit.DotNet.Html.battery;
    using SharpKit.DotNet.Html.gamepad;
    using SharpKit.DotNet.Html.geolocation;
    using SharpKit.DotNet.Html.indexeddb;
    using SharpKit.DotNet.Html.intents;
    using SharpKit.DotNet.Html.mediasource;
    using SharpKit.DotNet.Html.mediastream;
    using SharpKit.DotNet.Html.networkinfo;
    using SharpKit.DotNet.Html.notifications;
    using SharpKit.DotNet.Html.proximity;
    using SharpKit.DotNet.Html.quota;
    using SharpKit.DotNet.Html.speech;
    using SharpKit.DotNet.Html.webaudio;
    using SharpKit.DotNet.Html.webdatabase;
    using SharpKit.DotNet.Html.plugins;
    using SharpKit.DotNet.Html.storage;
    using SharpKit.DotNet.Html.svg;
    using SharpKit.DotNet.Html.workers;

    [JsType(JsMode.Prototype, Name = "JSON", Export = false, NativeCasts = true)]
    public class JSON
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty JsString: "".
        /// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
        /// <returns></returns>
        [JsMethod(Name = "stringify")]
        public static JsString Stringify(object obj, JsFunc<object, object, object> replacer) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty JsString: "".
        /// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
        /// <param name="space"></param>
        /// <returns></returns>
        [JsMethod(Name = "stringify")]
        public static JsString Stringify(object obj, JsFunc<object, object, object> replacer, int space) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty JsString: "".
        /// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
        /// <param name="space"></param>
        /// <returns></returns>
        [JsMethod(Name = "stringify")]
        public static JsString Stringify(object obj, JsFunc<object, object, object> replacer, JsString space) { return null; }

        [JsMethod(Name = "stringify")]
        public static JsString Stringify(object obj) { return null; }

        [JsMethod(Name = "parse")]
        public static object Parse(JsString json) { return null; }

    }


}