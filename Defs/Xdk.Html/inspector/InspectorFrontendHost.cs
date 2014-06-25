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

namespace SharpKit.DotNet.Html.inspector
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "InspectorFrontendHost")]
    public partial class InspectorFrontendHost
    {
        [JsMethod(Name = "loaded")]
        public void Loaded() { }
        [JsMethod(Name = "closeWindow")]
        public void CloseWindow() { }
        [JsMethod(Name = "bringToFront")]
        public void BringToFront() { }
        [JsMethod(Name = "setZoomFactor")]
        public void SetZoomFactor(double zoom) { }
        [JsMethod(Name = "inspectedURLChanged")]
        public void InspectedURLChanged(JsString newURL) { }
        [JsMethod(Name = "requestSetDockSide")]
        public void RequestSetDockSide(JsString side) { }
        [JsMethod(Name = "setAttachedWindowHeight")]
        public void SetAttachedWindowHeight(int height) { }
        [JsMethod(Name = "moveWindowBy")]
        public void MoveWindowBy(double x, double y) { }
        [JsMethod(Name = "setInjectedScriptForOrigin")]
        public void SetInjectedScriptForOrigin(JsString origin, JsString script) { }
        [JsMethod(Name = "localizedStringsURL")]
        public JsString LocalizedStringsURL() { return default(JsString); }
        [JsMethod(Name = "hiddenPanels")]
        public JsString HiddenPanels() { return default(JsString); }
        [JsMethod(Name = "copyText")]
        public void CopyText(JsString text) { }
        [JsMethod(Name = "openInNewTab")]
        public void OpenInNewTab(JsString url) { }
        [JsMethod(Name = "canSave")]
        public bool CanSave() { return default(bool); }
        [JsMethod(Name = "save")]
        public void Save(JsString url, JsString content, bool forceSaveAs) { }
        [JsMethod(Name = "append")]
        public void Append(JsString url, JsString content) { }
        [JsMethod(Name = "close")]
        public void Close(JsString url) { }
        [JsMethod(Name = "canInspectWorkers")]
        public bool CanInspectWorkers() { return default(bool); }
        [JsMethod(Name = "platform")]
        public JsString Platform() { return default(JsString); }
        [JsMethod(Name = "port")]
        public JsString Port() { return default(JsString); }
        [JsMethod(Name = "showContextMenu")]
        public void ShowContextMenu(MouseEvent @event, object items) { }
        [JsMethod(Name = "sendMessageToBackend")]
        public void SendMessageToBackend(JsString message) { }
        [JsMethod(Name = "recordActionTaken")]
        public void RecordActionTaken(int actionCode) { }
        [JsMethod(Name = "recordPanelShown")]
        public void RecordPanelShown(int panelCode) { }
        [JsMethod(Name = "recordSettingChanged")]
        public void RecordSettingChanged(int settingChanged) { }
        [JsMethod(Name = "loadResourceSynchronously")]
        public JsString LoadResourceSynchronously(JsString url) { return default(JsString); }
    }

}