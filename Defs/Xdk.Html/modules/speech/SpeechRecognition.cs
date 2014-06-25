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

namespace SharpKit.DotNet.Html.speech
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SpeechRecognition")]
    public partial class SpeechRecognition : EventTarget,
                                        IEventTarget<SpeechRecognitionEventType, SpeechRecognitionEvent>,
                                        IEventTarget<SpeechRecognitionErrorEventType, SpeechRecognitionErrorEvent>
    {
        public SpeechRecognition() { }
        public SpeechGrammarList grammars { get; set; }
        public JsString lang { get; set; }
        public bool continuous { get; set; }
        public bool interimResults { get; set; }
        public int maxAlternatives { get; set; }
        [JsMethod(Name = "start")]
        public void Start() { }
        [JsMethod(Name = "stop")]
        public void Stop() { }
        [JsMethod(Name = "abort")]
        public void Abort() { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onaudiostart", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onAudioStart { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnAudioStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"audiostart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"audiostart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsoundstart", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onSoundStart { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnSoundStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"soundstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"soundstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onspeechstart", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onSpeechStart { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnSpeechStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"speechstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"speechstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onspeechend", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onSpeechEnd { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnSpeechEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"speechend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"speechend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsoundend", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onSoundEnd { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnSoundEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"soundend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"soundend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onaudioend", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onAudioEnd { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnAudioEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"audioend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"audioend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onresult", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onResult { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnResult
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"result\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"result\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onnomatch", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onNoMatch { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnNoMatch
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"nomatch\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"nomatch\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onstart", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onStart { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"start\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"start\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onend", NativeField = true)]
        public EventListener<SpeechRecognitionEvent> onEnd { get; set; }
#endif
        public event EventListener<SpeechRecognitionEvent> OnEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"end\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"end\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(SpeechRecognitionEventType type, EventListener<SpeechRecognitionEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(SpeechRecognitionEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(SpeechRecognitionEventType type, EventListener<SpeechRecognitionEvent> listener, bool useCapture = false) { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<SpeechRecognitionErrorEvent> onError { get; set; }
#endif
        public event EventListener<SpeechRecognitionErrorEvent> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(SpeechRecognitionErrorEventType type, EventListener<SpeechRecognitionErrorEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(SpeechRecognitionErrorEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(SpeechRecognitionErrorEventType type, EventListener<SpeechRecognitionErrorEvent> listener, bool useCapture = false) { }

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