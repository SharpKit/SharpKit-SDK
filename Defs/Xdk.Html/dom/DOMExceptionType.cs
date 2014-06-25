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

    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum DOMExceptionType
    {
        [JsField(Name = "UnknownError")]
        UnknownError = 0,
        [JsField(Name = "IndexSizeError")]
        IndexSizeError = 1,
        [JsField(Name = "HierarchyRequestError")]
        HierarchyRequestError = 3,
        [JsField(Name = "WrongDocumentError")]
        WrongDocumentError = 4,
        [JsField(Name = "InvalidCharacterError")]
        InvalidCharacterError = 5,
        [JsField(Name = "NoModificationAllowedError")]
        NoModificationAllowedError = 7,
        [JsField(Name = "NotFoundError")]
        NotFoundError = 8,
        [JsField(Name = "NotSupportedError")]
        NotSupportedError = 9,
        [JsField(Name = "InvalidStateError")]
        InvalidStateError = 11,
        [JsField(Name = "SyntaxError")]
        SyntaxError = 12,
        [JsField(Name = "InvalidModificationError")]
        InvalidModificationError = 13,
        [JsField(Name = "NamespaceError")]
        NamespaceError = 14,
        [JsField(Name = "InvalidAccessError")]
        InvalidAccessError = 15,
        [JsField(Name = "SecurityError")]
        SecurityError = 18,
        [JsField(Name = "NetworkError")]
        NetworkError = 19,
        [JsField(Name = "AbortError")]
        AbortError = 20,
        [JsField(Name = "URLMismatchError")]
        URLMismatchError = 21,
        [JsField(Name = "QuotaExceededError")]
        QuotaExceededError = 22,
        [JsField(Name = "TimeoutError")]
        TimeoutError = 23,
        [JsField(Name = "InvalidNodeTypeError")]
        InvalidNodeTypeError = 24,
        [JsField(Name = "DataCloneError")]
        DataCloneError = 25
    }
    ///// <summary>
    ///// historical
    ///// </summary>
    //DOMSTRING_SIZE_ERR = 2,
    ///// <summary>
    ///// historical
    ///// </summary>
    //NO_DATA_ALLOWED_ERR = 6,
    ///// <summary>
    ///// historical
    ///// </summary>
    //INUSE_ATTRIBUTE_ERR = 10,
    ///// <summary>
    ///// historical
    ///// </summary>
    //VALIDATION_ERR = 16,
    ///// <summary>
    ///// historical, use JavaScript's TypeError instead
    ///// </summary>
    //TYPE_MISMATCH_ERR = 17,

}