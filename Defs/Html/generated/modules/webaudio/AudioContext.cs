
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/webaudio/AudioContext.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

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

namespace SharpKit.Html.webaudio
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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "AudioContext")]
public partial class AudioContext
{
	public  AudioDestinationNode destination {get; set; }
	public  double currentTime {get; set; }
	public  double sampleRate {get; set; }
	public  AudioListener listener {get; set; }
	public  int activeSourceCount {get; set; }
	public  AudioBuffer createBuffer(int numberOfChannels, int numberOfFrames, double sampleRate) { return default(AudioBuffer); }
	public  AudioBuffer createBuffer(ArrayBuffer buffer, bool mixToMono) { return default(AudioBuffer); }
	public  void decodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback) {}
	public  void decodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback, AudioBufferCallback errorCallback) {}
	public  AudioBufferSourceNode createBufferSource() { return default(AudioBufferSourceNode); }
	public  GainNode createGain() { return default(GainNode); }
	public  DelayNode createDelay() { return default(DelayNode); }
	public  DelayNode createDelay(double maxDelayTime) { return default(DelayNode); }
	public  BiquadFilterNode createBiquadFilter() { return default(BiquadFilterNode); }
	public  WaveShaperNode createWaveShaper() { return default(WaveShaperNode); }
	public  PannerNode createPanner() { return default(PannerNode); }
	public  ConvolverNode createConvolver() { return default(ConvolverNode); }
	public  DynamicsCompressorNode createDynamicsCompressor() { return default(DynamicsCompressorNode); }
	public  AnalyserNode createAnalyser() { return default(AnalyserNode); }
	public  ScriptProcessorNode createScriptProcessor(int bufferSize) { return default(ScriptProcessorNode); }
	public  ScriptProcessorNode createScriptProcessor(int bufferSize, int numberOfInputChannels) { return default(ScriptProcessorNode); }
	public  ScriptProcessorNode createScriptProcessor(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels) { return default(ScriptProcessorNode); }
	public  OscillatorNode createOscillator() { return default(OscillatorNode); }
	public  WaveTable createWaveTable(Float32Array real, Float32Array imag) { return default(WaveTable); }
	public  ChannelSplitterNode createChannelSplitter() { return default(ChannelSplitterNode); }
	public  ChannelSplitterNode createChannelSplitter(int numberOfOutputs) { return default(ChannelSplitterNode); }
	public  ChannelMergerNode createChannelMerger() { return default(ChannelMergerNode); }
	public  ChannelMergerNode createChannelMerger(int numberOfInputs) { return default(ChannelMergerNode); }
	public  EventListener oncomplete {get; set; }
	public  void startRendering() {}
}

}