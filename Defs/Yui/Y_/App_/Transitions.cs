//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.App_
{
    /// <summary>
    /// Provides view transitions for `Y.App` in browsers which support native CSS3
    /// transitions.
    /// View transitions provide an nice way to move from one "page" to the next that is
    /// both pleasant to the user and helps to communicate a hierarchy between sections
    /// of an application.
    /// When this module is used, it will automatically mix itself in to `Y.App` and
    /// transition between `activeView` changes using the following effects:
    /// * **`fade`**: Cross-fades between the old an new active views.
    /// * **`slideLeft`**: The old and new active views are positioned next to each
    /// other and both slide to the left.
    /// * **`slideRight`**: The old and new active views are positioned next to each
    /// other and both slide to the right.
    /// **Note:** Transitions are an opt-in feature and are enabled via an app's
    /// `transitions` attribute.
    /// </summary>
    public partial class Transitions
    {
        /// <summary>
        /// Setter for `transitions` attribute.
        /// When specified as `true`, the defaults will be use as specified by the
        /// `transitions` prototype property.
        /// </summary>
        protected object _setTransitions(object transitions){return null;}
        /// <summary>
        /// Sets which view is active/visible for the application. This will set the
        /// app's `activeView` attribute to the specified `view`.
        /// When a string-name is provided for a view which has been registered on this
        /// app's `views` object, the referenced metadata will be used and the
        /// `activeView` will be set to either a preserved view instance, or a new
        /// instance of the registered view will be created using the specified `config`
        /// object passed-into this method.
        /// A callback function can be specified as either the third or fourth argument,
        /// and this function will be called after the new `view` becomes the
        /// `activeView`, is rendered to the `viewContainer`, and is ready to use.
        /// </summary>
        public void showView(object view){}
        /// <summary>
        /// Sets which view is active/visible for the application. This will set the
        /// app's `activeView` attribute to the specified `view`.
        /// When a string-name is provided for a view which has been registered on this
        /// app's `views` object, the referenced metadata will be used and the
        /// `activeView` will be set to either a preserved view instance, or a new
        /// instance of the registered view will be created using the specified `config`
        /// object passed-into this method.
        /// A callback function can be specified as either the third or fourth argument,
        /// and this function will be called after the new `view` becomes the
        /// `activeView`, is rendered to the `viewContainer`, and is ready to use.
        /// </summary>
        public void showView(object view, JsAction callback){}
        /// <summary>
        /// Sets which view is active/visible for the application. This will set the
        /// app's `activeView` attribute to the specified `view`.
        /// When a string-name is provided for a view which has been registered on this
        /// app's `views` object, the referenced metadata will be used and the
        /// `activeView` will be set to either a preserved view instance, or a new
        /// instance of the registered view will be created using the specified `config`
        /// object passed-into this method.
        /// A callback function can be specified as either the third or fourth argument,
        /// and this function will be called after the new `view` becomes the
        /// `activeView`, is rendered to the `viewContainer`, and is ready to use.
        /// </summary>
        public void showView(object view, object options){}
        /// <summary>
        /// Sets which view is active/visible for the application. This will set the
        /// app's `activeView` attribute to the specified `view`.
        /// When a string-name is provided for a view which has been registered on this
        /// app's `views` object, the referenced metadata will be used and the
        /// `activeView` will be set to either a preserved view instance, or a new
        /// instance of the registered view will be created using the specified `config`
        /// object passed-into this method.
        /// A callback function can be specified as either the third or fourth argument,
        /// and this function will be called after the new `view` becomes the
        /// `activeView`, is rendered to the `viewContainer`, and is ready to use.
        /// </summary>
        public void showView(object view, object options, JsAction callback){}
        /// <summary>
        /// Sets which view is active/visible for the application. This will set the
        /// app's `activeView` attribute to the specified `view`.
        /// When a string-name is provided for a view which has been registered on this
        /// app's `views` object, the referenced metadata will be used and the
        /// `activeView` will be set to either a preserved view instance, or a new
        /// instance of the registered view will be created using the specified `config`
        /// object passed-into this method.
        /// A callback function can be specified as either the third or fourth argument,
        /// and this function will be called after the new `view` becomes the
        /// `activeView`, is rendered to the `viewContainer`, and is ready to use.
        /// </summary>
        public void showView(object view, object config, object options){}
        /// <summary>
        /// Sets which view is active/visible for the application. This will set the
        /// app's `activeView` attribute to the specified `view`.
        /// When a string-name is provided for a view which has been registered on this
        /// app's `views` object, the referenced metadata will be used and the
        /// `activeView` will be set to either a preserved view instance, or a new
        /// instance of the registered view will be created using the specified `config`
        /// object passed-into this method.
        /// A callback function can be specified as either the third or fourth argument,
        /// and this function will be called after the new `view` becomes the
        /// `activeView`, is rendered to the `viewContainer`, and is ready to use.
        /// </summary>
        public void showView(object view, object config, object options, JsAction callback){}
        /// <summary>
        /// CSS classes used by `App.Transitions`.
        /// When an app is transitioning between `activeView`s, its `container` node will
        /// have the "yui3-app-transitioning" CSS class added.
        /// </summary>
        public object CLASS_NAMES{get;set;}
        /// <summary>
        /// Collect of transitions -> fx.
        /// A transition (e.g. "fade") is a simple name given to a configuration of fx to
        /// apply, consisting of `viewIn` and `viewOut` properties who's values are names of
        /// fx registered on `Y.Transition.fx`.
        /// By default transitions: `fade`, `slideLeft`, and `slideRight` have fx defined.
        /// </summary>
        public object FX{get;set;}
        /// <summary>
        /// Default transitions to use when the `activeView` changes.
        /// The following are types of changes for which transitions can be defined that
        /// correspond to the relationship between the new and previous `activeView`:
        /// * `navigate`: The default transition to use when changing the `activeView`
        /// of the application.
        /// * `toChild`: The transition to use when the new `activeView` is configured
        /// as a child of the previously active view via its `parent` property as
        /// defined in this app's `views`.
        /// * `toParent`: The transition to use when the new `activeView` is
        /// configured as the `parent` of the previously active view as defined in
        /// this app's `views`.
        /// **Note:** Transitions are an opt-in feature and will only be used in
        /// browsers which support native CSS3 transitions.
        /// </summary>
        public object transitions{get;set;}
    }
}
