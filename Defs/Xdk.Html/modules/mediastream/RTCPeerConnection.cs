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

namespace SharpKit.DotNet.Html.mediastream
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "RTCPeerConnection")]
    public partial class RTCPeerConnection : EventTarget,
                        IEventTarget<RTCIceCandidateEventType, RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>>
    {
        public RTCPeerConnection(object rtcIceServers, object mediaConstraints) { }
        [JsMethod(Name = "createOffer")]
        public void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback) { }
        [JsMethod(Name = "createOffer")]
        public void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback, object mediaConstraints) { }
        [JsMethod(Name = "createAnswer")]
        public void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback) { }
        [JsMethod(Name = "createAnswer")]
        public void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback, object mediaConstraints) { }
        [JsMethod(Name = "setLocalDescription")]
        public void SetLocalDescription(RTCSessionDescription description, VoidCallback successCallback, RTCErrorCallback failureCallback) { }
        public RTCSessionDescription localDescription { get; set; }
        [JsMethod(Name = "setRemoteDescription")]
        public void SetRemoteDescription(RTCSessionDescription description, VoidCallback successCallback, RTCErrorCallback failureCallback) { }
        public RTCSessionDescription remoteDescription { get; set; }
        public JsString readyState { get; set; }
        [JsMethod(Name = "updateIce")]
        public void UpdateIce() { }
        [JsMethod(Name = "updateIce")]
        public void UpdateIce(object configuration) { }
        [JsMethod(Name = "updateIce")]
        public void UpdateIce(object configuration, object mediaConstraints) { }
        [JsMethod(Name = "addIceCandidate")]
        public void AddIceCandidate(RTCIceCandidate candidate) { }
        public JsString iceGatheringState { get; set; }
        public JsString iceState { get; set; }
        public MediaStreamList localStreams { get; set; }
        public MediaStreamList remoteStreams { get; set; }
        [JsMethod(Name = "addStream")]
        public void AddStream(MediaStream stream) { }
        [JsMethod(Name = "addStream")]
        public void AddStream(MediaStream stream, object mediaConstraints) { }
        [JsMethod(Name = "removeStream")]
        public void RemoveStream(MediaStream stream) { }
        [JsMethod(Name = "getStats")]
        public void GetStats(RTCStatsCallback successCallback, MediaStreamTrack selector) { }
        [JsMethod(Name = "createDataChannel")]
        public RTCDataChannel CreateDataChannel(JsString label) { return default(RTCDataChannel); }
        [JsMethod(Name = "createDataChannel")]
        public RTCDataChannel CreateDataChannel(JsString label, object options) { return default(RTCDataChannel); }
        [JsMethod(Name = "close")]
        public void Close() { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onnegotiationneeded", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onNegotiationNeeded { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnNegotiationNeeded
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"negotiationneeded\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"negotiationneeded\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onicecandidate", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onIceCandidate { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnIceCandidate
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"icecandidate\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"icecandidate\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onopen", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onOpen { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnOpen
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"open\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"open\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onstatechange", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onStateChange { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnStateChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"statechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"statechange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onaddstream", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onAddStream { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnAddStream
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"addstream\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"addstream\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onremovestream", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onRemoveStream { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnRemoveStream
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"removestream\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"removestream\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ongatheringchange", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onGatheringChange { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnGatheringChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"gatheringchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"gatheringchange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onicechange", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onIceChange { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnIceChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"icechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"icechange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondatachannel", NativeField = true)]
        public EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> onDataChannel { get; set; }
#endif
        public event EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> OnDataChannel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"datachannel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"datachannel\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(RTCIceCandidateEventType type, EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(RTCIceCandidateEventType type, EventListener<RTCIceCandidateEvent<RTCPeerConnection, RTCPeerConnection>> listener, bool useCapture = false) { }

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