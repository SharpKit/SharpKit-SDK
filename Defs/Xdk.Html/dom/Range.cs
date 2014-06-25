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

    /* OBSOLETE
[JsType(JsMode.Json, Export = false)]
public enum RangeCompareNodeResult
{
		NODE_BEFORE = 0,
		NODE_AFTER = 1,
		NODE_BEFORE_AND_AFTER = 2,
		NODE_INSIDE = 3
}
     */

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Range")]
    public partial class Range
    {
        public Node startContainer { get; set; }
        public int startOffset { get; set; }
        public Node endContainer { get; set; }
        public int endOffset { get; set; }
        public bool collapsed { get; set; }
        public Node commonAncestorContainer { get; set; }
        [JsMethod(Name = "setStart")]
        public void SetStart(Node refNode, int offset) { }
        [JsMethod(Name = "setEnd")]
        public void SetEnd(Node refNode, int offset) { }
        [JsMethod(Name = "setStartBefore")]
        public void SetStartBefore(Node refNode) { }
        [JsMethod(Name = "setStartAfter")]
        public void SetStartAfter(Node refNode) { }
        [JsMethod(Name = "setEndBefore")]
        public void SetEndBefore(Node refNode) { }
        [JsMethod(Name = "setEndAfter")]
        public void SetEndAfter(Node refNode) { }
        [JsMethod(Name = "collapse")]
        public void Collapse(bool toStart) { }
        [JsMethod(Name = "selectNode")]
        public void SelectNode(Node refNode) { }
        [JsMethod(Name = "selectNodeContents")]
        public void SelectNodeContents(Node refNode) { }
        /// <summary>
        /// Compare the boundary-points of two Ranges in a document.
        /// <para>Returns -1, 0 or 1 depending on whether the corresponding boundary-point of the Range is respectively before, equal to, or after the corresponding boundary-point of sourceRange.</para>
        /// </summary>
        /// <param name="how">A code representing the type of comparison.</param>
        /// <param name="sourceRange">The Range on which this current Range is compared to.</param>
        /// <returns>Returns -1, 0 or 1 depending on whether the corresponding boundary-point of the Range is respectively before, equal to, or after the corresponding boundary-point of sourceRange.</returns>
        [JsMethod(Name = "compareBoundaryPoints")]
        public short CompareBoundaryPoints(RangeCompareBoundaryPointsCode how, Range sourceRange) { return default(short); }
        [JsMethod(Name = "deleteContents")]
        public void DeleteContents() { }
        [JsMethod(Name = "extractContents")]
        public DocumentFragment ExtractContents() { return default(DocumentFragment); }
        [JsMethod(Name = "cloneContents")]
        public DocumentFragment CloneContents() { return default(DocumentFragment); }
        [JsMethod(Name = "insertNode")]
        public void InsertNode(Node newNode) { }
        [JsMethod(Name = "surroundContents")]
        public void SurroundContents(Node newParent) { }
        [JsMethod(Name = "cloneRange")]
        public Range CloneRange() { return default(Range); }
        [JsMethod(Name = "toString")]
        public JsString ToStringJs() { return default(JsString); }
        [JsMethod(Name = "detach")]
        public void Detach() { }
        [JsMethod(Name = "getClientRects")]
        public ClientRectList GetClientRects() { return default(ClientRectList); }
        [JsMethod(Name = "getBoundingClientRect")]
        public ClientRect GetBoundingClientRect() { return default(ClientRect); }
        [JsMethod(Name = "createContextualFragment")]
        public DocumentFragment CreateContextualFragment(JsString html) { return default(DocumentFragment); }
        [JsMethod(Name = "intersectsNode")]
        public bool IntersectsNode(Node refNode) { return default(bool); }
        /* OBSOLETE
	[JsMethod(Name = "compareNode")]
	public  short CompareNode(Node refNode) { return default(short); }
//const->enum// public  static int NODE_BEFORE = 0;
//const->enum// public  static int NODE_AFTER = 1;
//const->enum// public  static int NODE_BEFORE_AND_AFTER = 2;
//const->enum// public  static int NODE_INSIDE = 3;
         */
        /// <summary>
        /// Returns −1 if the point is before the range, 0 if the point is in the range, and 1 if the point is after the range.
        /// </summary>
        /// <param name="refNode"></param>
        /// <param name="offset"></param>
        /// <returns>Returns −1 if the point is before the range, 0 if the point is in the range, and 1 if the point is after the range.</returns>
        [JsMethod(Name = "comparePoint")]
        public short ComparePoint(Node refNode, int offset) { return default(short); }
        [JsMethod(Name = "isPointInRange")]
        public bool IsPointInRange(Node refNode, int offset) { return default(bool); }
        [JsMethod(Name = "expand")]
        public void Expand(JsString unit) { }
    }

}