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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Node")]
    public partial class Node : EventTarget
    {
        public JsString nodeName { get; set; }
        public JsString nodeValue { get; set; }
        public NodeType nodeType { get; set; }
        public Node parentNode { get; set; }
        public NodeList childNodes { get; set; }
        public Node firstChild { get; set; }
        public Node lastChild { get; set; }
        public Node previousSibling { get; set; }
        public Node nextSibling { get; set; }
        public NamedNodeMap attributes { get; set; }
        public Document ownerDocument { get; set; }
        [JsMethod(Name = "insertBefore")]
        public Node InsertBefore(Node newChild, Node refChild) { return default(Node); }
        [JsMethod(Name = "replaceChild")]
        public Node ReplaceChild(Node newChild, Node oldChild) { return default(Node); }
        [JsMethod(Name = "removeChild")]
        public Node RemoveChild(Node oldChild) { return default(Node); }
        [JsMethod(Name = "appendChild")]
        public Node AppendChild(Node newChild) { return default(Node); }
        [JsMethod(Name = "hasChildNodes")]
        public bool HasChildNodes() { return default(bool); }
        [JsMethod(Name = "cloneNode")]
        public Node CloneNode(bool deep) { return default(Node); }
        [JsMethod(Name = "normalize")]
        public void Normalize() { }
        [JsMethod(Name = "isSupported")]
        public bool IsSupported(JsString feature, JsString version) { return default(bool); }
        public JsString namespaceURI { get; set; }
        public JsString prefix { get; set; }
        public JsString localName { get; set; }
        [JsMethod(Name = "hasAttributes")]
        public bool HasAttributes() { return default(bool); }
        public JsString baseURI { get; set; }
        public JsString textContent { get; set; }
        [JsMethod(Name = "isSameNode")]
        public bool IsSameNode(Node other) { return default(bool); }
        [JsMethod(Name = "isEqualNode")]
        public bool IsEqualNode(Node other) { return default(bool); }
        [JsMethod(Name = "lookupPrefix")]
        public JsString LookupPrefix(JsString namespaceURI) { return default(JsString); }
        [JsMethod(Name = "isDefaultNamespace")]
        public bool IsDefaultNamespace(JsString namespaceURI) { return default(bool); }
        [JsMethod(Name = "lookupNamespaceURI")]
        public JsString LookupNamespaceURI(JsString prefix) { return default(JsString); }

        [JsMethod(Name = "compareDocumentPosition")]
        public NodeDocumentPosition CompareDocumentPosition(Node other) { return default(NodeDocumentPosition); }
        [JsMethod(Name = "contains")]
        public bool Contains(Node other) { return default(bool); }
        public Element parentElement { get; set; }


        #region Properties and methods inherited to hide for Intellisense
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(Event evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        #endregion
    }

}