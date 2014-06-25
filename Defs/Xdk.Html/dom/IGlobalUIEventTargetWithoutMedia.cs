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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public interface IGlobalUIEventTargetWithoutMedia<TEventCurrentTarget, TEventTarget> :
        IEventTarget<InputEventType, InputEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<FormEventType, FormEvent<TEventCurrentTarget>>,
        IEventTarget<MouseEventType, MouseEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<WheelEventType, WheelEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<TouchEventType, TouchEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<KeyboardEventType, KeyboardEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<ClipboardEventType, ClipboardEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<GlobalUIEventType, GlobalUIEvent<TEventCurrentTarget, TEventTarget>>
    {

        #region Input events
#if COMP_WITH_EVENTS_PROP
        EventListener<InputEvent<TEventCurrentTarget, TEventTarget>> onInput { get; set; }
#endif
        event EventListener<InputEvent<TEventCurrentTarget, TEventTarget>> OnInput;
        #endregion

        #region Form events
#if COMP_WITH_EVENTS_PROP
        EventListener<FormEvent<TEventCurrentTarget>> onSubmit { get; set; }
#endif
        event EventListener<FormEvent<TEventCurrentTarget>> OnSubmit;
#if COMP_WITH_EVENTS_PROP
        EventListener<FormEvent<TEventCurrentTarget>> onReset { get; set; }
#endif
        event EventListener<FormEvent<TEventCurrentTarget>> OnReset;
        #endregion

        #region UI Global events
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onSelect { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnSelect;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onCancel { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnCancel;
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onSelectionChange { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnSelectionChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onChange { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onContextMenu { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnContextMenu;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onCueChange { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnCueChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onInvalid { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnInvalid;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onSort { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnSort;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onShow { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnShow;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> onClose { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget, TEventTarget>> OnClose;
        void Select();
        #endregion

        #region Clipboard events
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> onCopy { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> OnCopy;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> onCut { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> OnCut;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> onPaste { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> OnPaste;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> onBeforeCopy { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> OnBeforeCopy;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> onBeforeCut { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> OnBeforeCut;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> onBeforePaste { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget, TEventTarget>> OnBeforePaste;
        #endregion

        #region Keyboard events
#if COMP_WITH_EVENTS_PROP
        EventListener<KeyboardEvent<TEventCurrentTarget, TEventTarget>> onKeyDown { get; set; }
#endif
        event EventListener<KeyboardEvent<TEventCurrentTarget, TEventTarget>> OnKeyDown;
#if COMP_WITH_EVENTS_PROP
        EventListener<KeyboardEvent<TEventCurrentTarget, TEventTarget>> onKeyPress { get; set; }
#endif
        event EventListener<KeyboardEvent<TEventCurrentTarget, TEventTarget>> OnKeyPress;
#if COMP_WITH_EVENTS_PROP
        EventListener<KeyboardEvent<TEventCurrentTarget, TEventTarget>> onKeyUp { get; set; }
#endif
        event EventListener<KeyboardEvent<TEventCurrentTarget, TEventTarget>> OnKeyUp;
        #endregion

        #region Touch events
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> onTouchMove { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> OnTouchMove;
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> onTouchStart { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> OnTouchStart;
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> onTouchEnd { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> OnTouchEnd;
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> onTouchCancel { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget, TEventTarget>> OnTouchCancel;
        #endregion

        #region Mouse events
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onClick { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnClick;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDblClick { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDblClick;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseDown { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseDown;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseUp { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseUp;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseOver { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseOver;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseMove { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseMove;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseOut { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseOut;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseEnter { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseEnter;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onMouseLeave { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnMouseLeave;

#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDrag { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDrag;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDragStart { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDragStart;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDragEnter { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDragEnter;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDragOver { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDragOver;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDragLeave { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDragLeave;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDragEnd { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDragEnd;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onDrop { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnDrop;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> onSelectStart { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget, TEventTarget>> OnSelectStart;

#if COMP_WITH_EVENTS_PROP
        EventListener<WheelEvent<TEventCurrentTarget, TEventTarget>> onMouseWheel { get; set; }
#endif
        event EventListener<WheelEvent<TEventCurrentTarget, TEventTarget>> OnMouseWheel;
#if COMP_WITH_EVENTS_PROP
        EventListener<WheelEvent<TEventCurrentTarget, TEventTarget>> onWheel { get; set; }
#endif
        event EventListener<WheelEvent<TEventCurrentTarget, TEventTarget>> OnWheel;
        #endregion
    }

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public interface IGlobalUIEventTargetWithoutMedia<TEventCurrentTarget> :
        IEventTarget<InputEventType, InputEvent<TEventCurrentTarget>>, IEventTarget<FormEventType, FormEvent<TEventCurrentTarget>>,
        IEventTarget<MouseEventType, MouseEvent<TEventCurrentTarget>>, IEventTarget<WheelEventType, WheelEvent<TEventCurrentTarget>>,
        IEventTarget<TouchEventType, TouchEvent<TEventCurrentTarget>>, IEventTarget<KeyboardEventType, KeyboardEvent<TEventCurrentTarget>>,
        IEventTarget<ClipboardEventType, ClipboardEvent<TEventCurrentTarget>>, IEventTarget<GlobalUIEventType, GlobalUIEvent<TEventCurrentTarget>>
    {

        #region Input events
#if COMP_WITH_EVENTS_PROP
        EventListener<InputEvent<TEventCurrentTarget>> onInput { get; set; }
#endif
        event EventListener<InputEvent<TEventCurrentTarget>> OnInput;
        #endregion

        #region Form events
#if COMP_WITH_EVENTS_PROP
        EventListener<FormEvent<TEventCurrentTarget>> onSubmit { get; set; }
#endif
        event EventListener<FormEvent<TEventCurrentTarget>> OnSubmit;
#if COMP_WITH_EVENTS_PROP
        EventListener<FormEvent<TEventCurrentTarget>> onReset { get; set; }
#endif
        event EventListener<FormEvent<TEventCurrentTarget>> OnReset;
        #endregion

        #region UI Global events
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onSelect { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnSelect;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onCancel { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnCancel;
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onSelectionChange { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnSelectionChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onChange { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onContextMenu { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnContextMenu;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onCueChange { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnCueChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onInvalid { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnInvalid;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onSort { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnSort;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onShow { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnShow;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalUIEvent<TEventCurrentTarget>> onClose { get; set; }
#endif
        event EventListener<GlobalUIEvent<TEventCurrentTarget>> OnClose;
        void Select();
        #endregion

        #region Clipboard events
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget>> onCopy { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget>> OnCopy;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget>> onCut { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget>> OnCut;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget>> onPaste { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget>> OnPaste;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget>> onBeforeCopy { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget>> OnBeforeCopy;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget>> onBeforeCut { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget>> OnBeforeCut;
#if COMP_WITH_EVENTS_PROP
        EventListener<ClipboardEvent<TEventCurrentTarget>> onBeforePaste { get; set; }
#endif
        event EventListener<ClipboardEvent<TEventCurrentTarget>> OnBeforePaste;
        #endregion

        #region Keyboard events
#if COMP_WITH_EVENTS_PROP
        EventListener<KeyboardEvent<TEventCurrentTarget>> onKeyDown { get; set; }
#endif
        event EventListener<KeyboardEvent<TEventCurrentTarget>> OnKeyDown;
#if COMP_WITH_EVENTS_PROP
        EventListener<KeyboardEvent<TEventCurrentTarget>> onKeyPress { get; set; }
#endif
        event EventListener<KeyboardEvent<TEventCurrentTarget>> OnKeyPress;
#if COMP_WITH_EVENTS_PROP
        EventListener<KeyboardEvent<TEventCurrentTarget>> onKeyUp { get; set; }
#endif
        event EventListener<KeyboardEvent<TEventCurrentTarget>> OnKeyUp;
        #endregion

        #region Touch events
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget>> onTouchMove { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget>> OnTouchMove;
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget>> onTouchStart { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget>> OnTouchStart;
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget>> onTouchEnd { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget>> OnTouchEnd;
#if COMP_WITH_EVENTS_PROP
        EventListener<TouchEvent<TEventCurrentTarget>> onTouchCancel { get; set; }
#endif
        event EventListener<TouchEvent<TEventCurrentTarget>> OnTouchCancel;
        #endregion

        #region Mouse events
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onClick { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnClick;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDblClick { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDblClick;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseDown { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseDown;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseUp { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseUp;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseOver { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseOver;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseMove { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseMove;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseOut { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseOut;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseEnter { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseEnter;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onMouseLeave { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnMouseLeave;

#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDrag { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDrag;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDragStart { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDragStart;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDragEnter { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDragEnter;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDragOver { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDragOver;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDragLeave { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDragLeave;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDragEnd { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDragEnd;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onDrop { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnDrop;
#if COMP_WITH_EVENTS_PROP
        EventListener<MouseEvent<TEventCurrentTarget>> onSelectStart { get; set; }
#endif
        event EventListener<MouseEvent<TEventCurrentTarget>> OnSelectStart;

#if COMP_WITH_EVENTS_PROP
        EventListener<WheelEvent<TEventCurrentTarget>> onMouseWheel { get; set; }
#endif
        event EventListener<WheelEvent<TEventCurrentTarget>> OnMouseWheel;
#if COMP_WITH_EVENTS_PROP
        EventListener<WheelEvent<TEventCurrentTarget>> onWheel { get; set; }
#endif
        event EventListener<WheelEvent<TEventCurrentTarget>> OnWheel;
        void Click();
        #endregion
    }

}