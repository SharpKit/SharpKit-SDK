
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLMediaElement.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2014 Sebastian Loncar, Web: http://loncar.de
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

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.fileapi;
using SharpKit.Html.html.shadow;
using SharpKit.Html.html.track;
using SharpKit.Html.inspector;
using SharpKit.Html.loader.appcache;
using SharpKit.Html.battery;
using SharpKit.Html.filesystem;
using SharpKit.Html.gamepad;
using SharpKit.Html.geolocation;
using SharpKit.Html.indexeddb;
using SharpKit.Html.intents;
using SharpKit.Html.mediasource;
using SharpKit.Html.mediastream;
using SharpKit.Html.navigatorcontentutils;
using SharpKit.Html.networkinfo;
using SharpKit.Html.notifications;
using SharpKit.Html.proximity;
using SharpKit.Html.quota;
using SharpKit.Html.speech;
using SharpKit.Html.vibration;
using SharpKit.Html.webaudio;
using SharpKit.Html.webdatabase;
using SharpKit.Html.plugins;
using SharpKit.Html.storage;
using SharpKit.Html.svg;
using SharpKit.Html.workers;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "HTMLMediaElement")]
public partial class HtmlMediaElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('media')")]
	public   HtmlMediaElement() {}
	public  MediaError error {get; set; }
	public  JsString src {get; set; }
	public  JsString currentSrc {get; set; }
	public  const int NETWORK_EMPTY = 0;
	public  const int NETWORK_IDLE = 1;
	public  const int NETWORK_LOADING = 2;
	public  const int NETWORK_NO_SOURCE = 3;
	public  int networkState {get; set; }
	public  JsString preload {get; set; }
	public  TimeRanges buffered {get; set; }
	public  void load() {}
	public  JsString canPlayType(string type) { return default(JsString); }
	public  const int HAVE_NOTHING = 0;
	public  const int HAVE_METADATA = 1;
	public  const int HAVE_CURRENT_DATA = 2;
	public  const int HAVE_FUTURE_DATA = 3;
	public  const int HAVE_ENOUGH_DATA = 4;
	public  int readyState {get; set; }
	public  bool seeking {get; set; }
	public  double currentTime {get; set; }
	public  double initialTime {get; set; }
	public  double startTime {get; set; }
	public  double duration {get; set; }
	public  bool paused {get; set; }
	public  double defaultPlaybackRate {get; set; }
	public  double playbackRate {get; set; }
	public  TimeRanges played {get; set; }
	public  TimeRanges seekable {get; set; }
	public  bool ended {get; set; }
	public  bool autoplay {get; set; }
	public  bool loop {get; set; }
	public  void play() {}
	public  void pause() {}
	public  bool controls {get; set; }
	public  double volume {get; set; }
	public  bool muted {get; set; }
	public  bool defaultMuted {get; set; }
	public  JsString mediaGroup {get; set; }
	public  MediaController controller {get; set; }
}

}