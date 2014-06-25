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

    [JsType(JsMode.Prototype, NativeEnumerator = false, NativeArrayEnumerator = true, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "CSSStyleDeclaration")]
    public partial class CssStyleDeclaration : IJsArrayEnumerable<JsString>
    {
        public JsString cssText { get; set; }
        public JsString azimuth { get; set; }
        public JsString background { get; set; }
        public JsString backgroundAttachment { get; set; }
        public JsString backgroundColor { get; set; }
        public JsString backgroundImage { get; set; }
        public JsString backgroundPosition { get; set; }
        public JsString backgroundRepeat { get; set; }
        public JsString backgroundSize { get; set; }
        public JsString border { get; set; }
        public JsString borderCollapse { get; set; }
        public JsString borderColor { get; set; }
        public JsString borderSpacing { get; set; }
        public JsString borderStyle { get; set; }
        public JsString borderTop { get; set; }
        public JsString borderRight { get; set; }
        public JsString borderBottom { get; set; }
        public JsString borderLeft { get; set; }
        public JsString borderTopColor { get; set; }
        public JsString borderRightColor { get; set; }
        public JsString borderBottomColor { get; set; }
        public JsString borderLeftColor { get; set; }
        public JsString borderTopStyle { get; set; }
        public JsString borderRightStyle { get; set; }
        public JsString borderBottomStyle { get; set; }
        public JsString borderLeftStyle { get; set; }
        public JsString borderTopWidth { get; set; }
        public JsString borderRightWidth { get; set; }
        public JsString borderBottomWidth { get; set; }
        public JsString borderLeftWidth { get; set; }
        public JsString borderWidth { get; set; }
        public JsString bottom { get; set; }
        public JsString captionSide { get; set; }
        public JsString clear { get; set; }
        public JsString clip { get; set; }
        public JsString color { get; set; }
        public JsString content { get; set; }
        public JsString counterIncrement { get; set; }
        public JsString counterReset { get; set; }
        public JsString cue { get; set; }
        public JsString cueAfter { get; set; }
        public JsString cueBefore { get; set; }
        public JsString cursor { get; set; }
        public JsString direction { get; set; }
        public JsString display { get; set; }
        public JsString elevation { get; set; }
        public JsString emptyCells { get; set; }
        public JsString cssFloat { get; set; }
        public JsString font { get; set; }
        public JsString fontFamily { get; set; }
        public JsString fontSize { get; set; }
        public JsString fontSizeAdjust { get; set; }
        public JsString fontStretch { get; set; }
        public JsString fontStyle { get; set; }
        public JsString fontVariant { get; set; }
        public JsString fontWeight { get; set; }
        public JsString height { get; set; }
        public JsString left { get; set; }
        public JsString letterSpacing { get; set; }
        public JsString lineHeight { get; set; }
        public JsString listStyle { get; set; }
        public JsString listStyleImage { get; set; }
        public JsString listStylePosition { get; set; }
        public JsString listStyleType { get; set; }
        public JsString margin { get; set; }
        public JsString marginTop { get; set; }
        public JsString marginRight { get; set; }
        public JsString marginBottom { get; set; }
        public JsString marginLeft { get; set; }
        public JsString markerOffset { get; set; }
        public JsString marks { get; set; }
        public JsString maxHeight { get; set; }
        public JsString maxWidth { get; set; }
        public JsString minHeight { get; set; }
        public JsString minWidth { get; set; }
        public JsString opacity { get; set; }
        public JsString orphans { get; set; }
        public JsString outline { get; set; }
        public JsString outlineColor { get; set; }
        public JsString outlineStyle { get; set; }
        public JsString outlineWidth { get; set; }
        public JsString overflow { get; set; }
        public JsString padding { get; set; }
        public JsString paddingTop { get; set; }
        public JsString paddingRight { get; set; }
        public JsString paddingBottom { get; set; }
        public JsString paddingLeft { get; set; }
        public JsString page { get; set; }
        public JsString pageBreakAfter { get; set; }
        public JsString pageBreakBefore { get; set; }
        public JsString pageBreakInside { get; set; }
        public JsString pause { get; set; }
        public JsString pauseAfter { get; set; }
        public JsString pauseBefore { get; set; }
        public JsString pitch { get; set; }
        public JsString pitchRange { get; set; }
        public JsString playDuring { get; set; }
        public JsString position { get; set; }
        public JsString quotes { get; set; }
        public JsString richness { get; set; }
        public JsString right { get; set; }
        public JsString size { get; set; }
        public JsString speak { get; set; }
        public JsString speakHeader { get; set; }
        public JsString speakNumeral { get; set; }
        public JsString speakPunctuation { get; set; }
        public JsString speechRate { get; set; }
        public JsString stress { get; set; }
        public JsString tableLayout { get; set; }
        public JsString textAlign { get; set; }
        public JsString textDecoration { get; set; }
        public JsString textIndent { get; set; }
        public JsString textShadow { get; set; }
        public JsString textTransform { get; set; }
        public JsString top { get; set; }
        public JsString unicodeBidi { get; set; }
        public JsString verticalAlign { get; set; }
        public JsString visibility { get; set; }
        public JsString voiceFamily { get; set; }
        public JsString volume { get; set; }
        public JsString whiteSpace { get; set; }
        public JsString widows { get; set; }
        public JsString width { get; set; }
        public JsString wordSpacing { get; set; }
        public JsString zIndex { get; set; }

        [JsMethod(Name = "getPropertyValue")]
        public JsString GetPropertyValue(JsString propertyName) { return default(JsString); }
        [JsMethod(Name = "getPropertyCSSValue")]
        public CssValue GetPropertyCSSValue(JsString propertyName) { return default(CssValue); }
        [JsMethod(Name = "removeProperty")]
        public JsString RemoveProperty(JsString propertyName) { return default(JsString); }
        [JsMethod(Name = "getPropertyPriority")]
        public JsString GetPropertyPriority(JsString propertyName) { return default(JsString); }
        [JsMethod(Name = "setProperty")]
        public void SetProperty(JsString propertyName, JsString value, JsString priority) { }
        public int length { get; set; }
        [JsProperty(NativeIndexer = true)]
        public JsString this[int index] { get { return default(JsString); } set { } }
        public CssRule parentRule { get; set; }
        [JsMethod(Name = "getPropertyShorthand")]
        public JsString GetPropertyShorthand(JsString propertyName) { return default(JsString); }
        [JsMethod(Name = "isPropertyImplicit")]
        public bool IsPropertyImplicit(JsString propertyName) { return default(bool); }

        JsString IJsArrayEnumerable<JsString>.this[JsNumber index]
        {
            get { throw new NotImplementedException(); }
        }

        JsNumber IJsArrayEnumerable<JsString>.length
        {
            get { throw new NotImplementedException(); }
        }

        System.Collections.Generic.IEnumerator<JsString> System.Collections.Generic.IEnumerable<JsString>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}