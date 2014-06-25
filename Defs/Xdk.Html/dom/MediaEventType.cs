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
    public enum MediaEventType
    {
        /// <summary>
        /// The user agent begins looking for media data, as part of the resource selection algorithm.
        /// </summary>
        [JsField(Name = "loadstart")]
        LoadStart,
        /// <summary>
        /// The user agent is fetching media data.
        /// </summary>
        [JsField(Name = "progress")]
        Progress,
        /// <summary>
        /// The user agent is intentionally not currently fetching media data, but does not have the entire media resource downloaded.
        /// </summary>
        [JsField(Name = "suspend")]
        Suspend,
        /// <summary>
        /// The user agent stops fetching the media data before it is completely downloaded, but not due to an error.
        /// </summary>
        [JsField(Name = "abort")]
        Abort,
        /*        /// <summary>
                /// An error occurs while fetching the media data.
                /// </summary>
                [JsField(Name = "error")]
                Error,
         */
        /// <summary>
        /// A media element whose networkState was previously not in the NETWORK_EMPTY state has just switched to that state (either because of a fatal error during load that's about to be reported, or because the load() method was invoked while the resource selection algorithm was already running).
        /// </summary>
        [JsField(Name = "emptied")]
        Emptied,
        /// <summary>
        /// The user agent is trying to fetch media data, but data is unexpectedly not forthcoming.
        /// </summary>
        [JsField(Name = "stalled")]
        Stalled,
        /// <summary>
        /// Playback has begun. Fired after the play() method has returned, or when the autoplay attribute has caused playback to begin.
        /// </summary>
        [JsField(Name = "play")]
        Play,
        /// <summary>
        /// Playback has been paused. Fired after the pause() method has returned.
        /// </summary>
        [JsField(Name = "pause")]
        Pause,
        /// <summary>
        /// The user agent has just determined the duration and dimensions of the media resource.
        /// </summary>
        [JsField(Name = "loadedmetadata")]
        LoadedMetadata,
        /// <summary>
        /// The user agent can render the media data at the current playback position for the first time.
        /// </summary>
        [JsField(Name = "loadeddata")]
        LoadedData,
        /// <summary>
        /// Playback has stopped because the next frame is not available, but the user agent expects that frame to become available in due course.
        /// </summary>
        [JsField(Name = "waiting")]
        Waiting,
        /// <summary>
        /// Playback has started.
        /// </summary>
        [JsField(Name = "playing")]
        Playing,
        /// <summary>
        /// The user agent can resume playback of the media data, but estimates that if playback were to be started now, the media resource could not be rendered at the current playback rate up to its end without having to stop for further buffering of content.
        /// </summary>
        [JsField(Name = "canplay")]
        CanPlay,
        /// <summary>
        /// The user agent estimates that if playback were to be started now, the media resource could be rendered at the current playback rate all the way to its end without having to stop for further buffering.
        /// </summary>
        [JsField(Name = "canplaythrough")]
        CanPlayThrough,
        /// <summary>
        /// The seeking IDL attribute changed to true and the seek operation is taking long enough that the user agent has time to fire the event.
        /// </summary>
        [JsField(Name = "seeking")]
        Seeking,
        /// <summary>
        /// The seeking IDL attribute changed to false.
        /// </summary>
        [JsField(Name = "seeked")]
        Seeked,
        /// <summary>
        /// The current playback position changed as part of normal playback or in an especially interesting way, for example discontinuously.
        /// </summary>
        [JsField(Name = "timeupdate")]
        TimeUpdate,
        /// <summary>
        /// Playback has stopped because the end of the media resource was reached.
        /// </summary>
        [JsField(Name = "Ended")]
        Ended,
        /// <summary>
        /// Either the defaultPlaybackRate or the playbackRate attribute has just been updated.
        /// </summary>
        [JsField(Name = "ratechange")]
        RateChange,
        /// <summary>
        /// The duration attribute has just been updated.
        /// </summary>
        [JsField(Name = "durationchange")]
        DurationChange,
        /// <summary>
        /// Either the volume attribute or the muted attribute has changed. Fired after the relevant attribute's setter has returned.
        /// </summary>
        [JsField(Name = "volumechange")]
        VolumeChange,
    }
}