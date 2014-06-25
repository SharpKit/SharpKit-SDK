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

namespace SharpKit.DotNet.Html.webaudio
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "AudioContext")]
    public partial class AudioContext : EventTarget,
                                                       IEventTarget<AudioContextEventType, AudioContextEvent>
    {
        public AudioDestinationNode destination { get; set; }
        public double currentTime { get; set; }
        public double sampleRate { get; set; }
        public AudioListener listener { get; set; }
        public int activeSourceCount { get; set; }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncomplete", NativeField = true)]
        public EventListener<AudioContextEvent> onComplete { get; set; }
#endif
        public event EventListener<AudioContextEvent> OnComplete
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"complete\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"open\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(AudioContextEventType type, EventListener<AudioContextEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(AudioContextEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(AudioContextEventType type, EventListener<AudioContextEvent> listener, bool useCapture = false) { }


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

        [JsMethod(Name = "createBuffer")]
        public AudioBuffer CreateBuffer(int numberOfChannels, int numberOfFrames, double sampleRate) { return default(AudioBuffer); }
        [JsMethod(Name = "createBuffer")]
        public AudioBuffer CreateBuffer(ArrayBuffer buffer, bool mixToMono) { return default(AudioBuffer); }
        [JsMethod(Name = "decodeAudioData")]
        public void DecodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback) { }
        [JsMethod(Name = "decodeAudioData")]
        public void DecodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback, AudioBufferCallback errorCallback) { }
        [JsMethod(Name = "createBufferSource")]
        public AudioBufferSourceNode CreateBufferSource() { return default(AudioBufferSourceNode); }
        [JsMethod(Name = "createGain")]
        public GainNode CreateGain() { return default(GainNode); }
        [JsMethod(Name = "createDelay")]
        public DelayNode CreateDelay() { return default(DelayNode); }
        [JsMethod(Name = "createDelay")]
        public DelayNode CreateDelay(double maxDelayTime) { return default(DelayNode); }
        [JsMethod(Name = "createBiquadFilter")]
        public BiquadFilterNode CreateBiquadFilter() { return default(BiquadFilterNode); }
        [JsMethod(Name = "createWaveShaper")]
        public WaveShaperNode CreateWaveShaper() { return default(WaveShaperNode); }
        [JsMethod(Name = "createPanner")]
        public PannerNode CreatePanner() { return default(PannerNode); }
        [JsMethod(Name = "createConvolver")]
        public ConvolverNode CreateConvolver() { return default(ConvolverNode); }
        [JsMethod(Name = "createDynamicsCompressor")]
        public DynamicsCompressorNode CreateDynamicsCompressor() { return default(DynamicsCompressorNode); }
        [JsMethod(Name = "createAnalyser")]
        public AnalyserNode CreateAnalyser() { return default(AnalyserNode); }
        [JsMethod(Name = "createScriptProcessor")]
        public ScriptProcessorNode CreateScriptProcessor(int bufferSize) { return default(ScriptProcessorNode); }
        [JsMethod(Name = "createScriptProcessor")]
        public ScriptProcessorNode CreateScriptProcessor(int bufferSize, int numberOfInputChannels) { return default(ScriptProcessorNode); }
        [JsMethod(Name = "createScriptProcessor")]
        public ScriptProcessorNode CreateScriptProcessor(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels) { return default(ScriptProcessorNode); }
        [JsMethod(Name = "createOscillator")]
        public OscillatorNode CreateOscillator() { return default(OscillatorNode); }
        [JsMethod(Name = "createWaveTable")]
        public WaveTable CreateWaveTable(Float32Array real, Float32Array imag) { return default(WaveTable); }
        [JsMethod(Name = "createChannelSplitter")]
        public ChannelSplitterNode CreateChannelSplitter() { return default(ChannelSplitterNode); }
        [JsMethod(Name = "createChannelSplitter")]
        public ChannelSplitterNode CreateChannelSplitter(int numberOfOutputs) { return default(ChannelSplitterNode); }
        [JsMethod(Name = "createChannelMerger")]
        public ChannelMergerNode CreateChannelMerger() { return default(ChannelMergerNode); }
        [JsMethod(Name = "createChannelMerger")]
        public ChannelMergerNode CreateChannelMerger(int numberOfInputs) { return default(ChannelMergerNode); }
        [JsMethod(Name = "startRendering")]
        public void StartRendering() { }
    }

}