using System;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Google.Maps
{
    [JsType(JsMode.Prototype, Name = "google.maps.Map")]
    public class Map
    {
        /// <summary>
        ///Creates a new map inside of the given HTML container, which is typically a DIV element.
        /// </summary>
        public Map(Node mapDiv, MapOptions opts = null) { }
        /// <summary>
        ///Sets the viewport to contain the given bounds.
        /// </summary>
        public void fitBounds(LatLngBounds bounds) { }
        /// <summary>
        ///Returns the lat/lng bounds of the current viewport. If more than one copy of the world is visible, the bounds range in longitude from -180 to 180 degrees inclusive. If the map is not yet initialized (i.e. the mapType is still null), or center and zoom have not been set then the result is null or undefined.
        /// </summary>
        public LatLngBounds getBounds() { return null; }
        /// <summary>
        ///Returns the position displayed at the center of the map. Note that this LatLng object is not wrapped. See LatLng for more information.
        /// </summary>
        public LatLng getCenter() { return null; }
        public Node getDiv() { return null; }
        /// <summary>
        ///Returns the compass heading of aerial imagery. The heading value is measured in degrees (clockwise) from cardinal direction North.
        /// </summary>
        public JsNumber getHeading() { return null; }
        public object getMapTypeId() { return null; }
        /// <summary>
        ///Returns the current Projection. If the map is not yet initialized (i.e. the mapType is still null) then the result is null. Listen to projection_changed and check its value to ensure it is not null.
        /// </summary>
        public Projection getProjection() { return null; }
        /// <summary>
        ///Returns the default StreetViewPanorama bound to the map, which may be a default panorama embedded within the map, or the panorama set using setStreetView(). Changes to the map's streetViewControl will be reflected in the display of such a bound panorama.
        /// </summary>
        public StreetViewPanorama getStreetView() { return null; }
        /// <summary>
        ///Returns the angle of incidence for aerial imagery (available for SATELLITE and HYBRID map types) measured in degrees from the viewport plane to the map plane. A value of 0 indicates no angle of incidence (no tilt) while 45Â° imagery will return a value of 45.
        /// </summary>
        public JsNumber getTilt() { return null; }
        public JsNumber getZoom() { return null; }
        /// <summary>
        ///Changes the center of the map by the given distance in pixels. If the distance is less than both the width and height of the map, the transition will be smoothly animated. Note that the map coordinate system increases from west to east (for x values) and north to south (for y values).
        /// </summary>
        public void panBy(JsNumber x, JsNumber y) { }
        /// <summary>
        ///Changes the center of the map to the given LatLng. If the change is less than both the width and height of the map, the transition will be smoothly animated.
        /// </summary>
        public void panTo(LatLng latLng) { }
        /// <summary>
        ///Pans the map by the minimum amount necessary to contain the given LatLngBounds. It makes no guarantee where on the map the bounds will be, except that as much of the bounds as possible will be visible. The bounds will be positioned inside the area bounded by the map type and navigation (pan, zoom, and Street View) controls, if they are present on the map. If the bounds is larger than the map, the map will be shifted to include the northwest corner of the bounds. If the change in the map's position is less than both the width and height of the map, the transition will be smoothly animated.
        /// </summary>
        public void panToBounds(LatLngBounds latLngBounds) { }
        public void setCenter(LatLng latlng) { }
        /// <summary>
        ///Sets the compass heading for aerial imagery measured in degrees from cardinal direction North.
        /// </summary>
        public void setHeading(JsNumber heading) { }
        public void setMapTypeId(object mapTypeId) { }
        public void setOptions(MapOptions options) { }
        /// <summary>
        ///Binds a StreetViewPanorama to the map. This panorama overrides the default StreetViewPanorama, allowing the map to bind to an external panorama outside of the map. Setting the panorama to null binds the default embedded panorama back to the map.
        /// </summary>
        public void setStreetView(StreetViewPanorama panorama) { }
        /// <summary>
        ///Sets the angle of incidence for aerial imagery (available for SATELLITE and HYBRID map types) measured in degrees from the viewport plane to the map plane. The only supported values are 0, indicating no angle of incidence (no tilt), and 45 indicating a tilt of 45deg;.
        /// </summary>
        public void setTilt(JsNumber tilt) { }
        public void setZoom(JsNumber zoom) { }
        /// <summary>
        ///Additional controls to attach to the map. To add a control to the map, add the control's &lt;div&gt; to the MVCArray corresponding to the ControlPosition where it should be rendered.
        /// </summary>
        public JsArray<MVCArray<Node>> controls { get; set; }
        /// <summary>
        ///A registry of MapType instances by JsString ID.
        /// </summary>
        public MapTypeRegistry mapTypes { get; set; }
        /// <summary>
        ///Additional map types to overlay.
        /// </summary>
        public MVCArray<MapType> overlayMapTypes { get; set; }
        /// <summary>
        ///This event is fired when the viewport bounds have changed.
        /// </summary>
        public event JsAction bounds_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"bounds_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"bounds_changed\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the map center property changes.
        /// </summary>
        public event JsAction center_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"center_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"center_changed\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user clicks on the map (but not when they click on a marker or infowindow).
        /// </summary>
        public event JsAction<MouseEvent> click
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"click\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"click\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user double-clicks on the map. Note that the click event will also fire, right before this one.
        /// </summary>
        public event JsAction<MouseEvent> dblclick
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"dblclick\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"dblclick\"")]
            remove { }
        }

        /// <summary>
        ///This event is repeatedly fired while the user drags the map.
        /// </summary>
        public event JsAction drag
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"drag\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"drag\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user stops dragging the map.
        /// </summary>
        public event JsAction dragend
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"dragend\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"dragend\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user starts dragging the map.
        /// </summary>
        public event JsAction dragstart
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"dragstart\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"dragstart\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the map heading property changes.
        /// </summary>
        public event JsAction heading_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"heading_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"heading_changed\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the map becomes idle after panning or zooming.
        /// </summary>
        public event JsAction idle
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"idle\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"idle\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the mapTypeId property changes.
        /// </summary>
        public event JsAction maptypeid_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"maptypeid_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"maptypeid_changed\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired whenever the user's mouse moves over the map container.
        /// </summary>
        public event JsAction<MouseEvent> mousemove
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mousemove\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mousemove\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user's mouse exits the map container.
        /// </summary>
        public event JsAction<MouseEvent> mouseout
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mouseout\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mouseout\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user's mouse enters the map container.
        /// </summary>
        public event JsAction<MouseEvent> mouseover
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mouseover\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mouseover\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the projection has changed.
        /// </summary>
        public event JsAction projection_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"projection_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"projection_changed\"")]
            remove { }
        }

        /// <summary>
        ///Developers should trigger this event on the map when the div changes size: google.maps.event.trigger(map, 'resize') .
        /// </summary>
        public event JsAction resize
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"resize\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"resize\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the DOM contextmenu event is fired on the map container.
        /// </summary>
        public event JsAction<MouseEvent> rightclick
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"rightclick\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"rightclick\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the visible tiles have finished loading.
        /// </summary>
        public event JsAction tilesloaded
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"tilesloaded\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"tilesloaded\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the map tilt property changes.
        /// </summary>
        public event JsAction tilt_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"tilt_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"tilt_changed\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the map zoom property changes.
        /// </summary>
        public event JsAction zoom_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"zoom_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"zoom_changed\"")]
            remove { }
        }

    }
    [JsType(JsMode.Json)]
    public class MapOptions
    {
        /// <summary>
        ///Color used for the background of the Map div. This color will be visible when tiles have not yet loaded as the user pans. This option can only be set when the map is initialized.
        /// </summary>
        public JsString backgroundColor { get; set; }
        /// <summary>
        ///The initial Map center. Required.
        /// </summary>
        public LatLng center { get; set; }
        /// <summary>
        ///Enables/disables all default UI. May be overridden individually.
        /// </summary>
        public bool disableDefaultUI { get; set; }
        /// <summary>
        ///Enables/disables zoom and center on double click. Enabled by default.
        /// </summary>
        public bool disableDoubleClickZoom { get; set; }
        /// <summary>
        ///If false, prevents the map from being dragged. Dragging is enabled by default.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///The name or url of the cursor to display when mousing over a draggable map.
        /// </summary>
        public JsString draggableCursor { get; set; }
        /// <summary>
        ///The name or url of the cursor to display when the map is being dragged.
        /// </summary>
        public JsString draggingCursor { get; set; }
        /// <summary>
        ///The heading for aerial imagery in degrees measured clockwise from cardinal direction North. Headings are snapped to the nearest available angle for which imagery is available.
        /// </summary>
        public JsNumber heading { get; set; }
        /// <summary>
        ///If false, prevents the map from being controlled by the keyboard. Keyboard shortcuts are enabled by default.
        /// </summary>
        public bool keyboardShortcuts { get; set; }
        /// <summary>
        ///True if Map Maker tiles should be used instead of regular tiles.
        /// </summary>
        public bool mapMaker { get; set; }
        /// <summary>
        ///The initial enabled/disabled state of the Map type control.
        /// </summary>
        public bool mapTypeControl { get; set; }
        /// <summary>
        ///The initial display options for the Map type control.
        /// </summary>
        public MapTypeControlOptions mapTypeControlOptions { get; set; }
        /// <summary>
        ///The initial Map mapTypeId. Required.
        /// </summary>
        public MapTypeId mapTypeId { get; set; }
        /// <summary>
        ///The maximum zoom level which will be displayed on the map. If omitted, or set to null, the maximum zoom from the current map type is used instead.
        /// </summary>
        public JsNumber maxZoom { get; set; }
        /// <summary>
        ///The minimum zoom level which will be displayed on the map. If omitted, or set to null, the minimum zoom from the current map type is used instead.
        /// </summary>
        public JsNumber minZoom { get; set; }
        /// <summary>
        ///If true, do not clear the contents of the Map div.
        /// </summary>
        public bool noClear { get; set; }
        /// <summary>
        ///The enabled/disabled state of the Overview Map control.
        /// </summary>
        public bool overviewMapControl { get; set; }
        /// <summary>
        ///The display options for the Overview Map control.
        /// </summary>
        public OverviewMapControlOptions overviewMapControlOptions { get; set; }
        /// <summary>
        ///The enabled/disabled state of the Pan control.
        /// </summary>
        public bool panControl { get; set; }
        /// <summary>
        ///The display options for the Pan control.
        /// </summary>
        public PanControlOptions panControlOptions { get; set; }
        /// <summary>
        ///The enabled/disabled state of the Rotate control.
        /// </summary>
        public bool rotateControl { get; set; }
        /// <summary>
        ///The display options for the Rotate control.
        /// </summary>
        public RotateControlOptions rotateControlOptions { get; set; }
        /// <summary>
        ///The initial enabled/disabled state of the Scale control.
        /// </summary>
        public bool scaleControl { get; set; }
        /// <summary>
        ///The initial display options for the Scale control.
        /// </summary>
        public ScaleControlOptions scaleControlOptions { get; set; }
        /// <summary>
        ///If false, disables scrollwheel zooming on the map. The scrollwheel is enabled by default.
        /// </summary>
        public bool scrollwheel { get; set; }
        /// <summary>
        ///A StreetViewPanorama to display when the Street View pegman is dropped on the map. If no panorama is specified, a default StreetViewPanorama will be displayed in the map's div when the pegman is dropped.
        /// </summary>
        public StreetViewPanorama streetView { get; set; }
        /// <summary>
        ///The initial enabled/disabled state of the Street View Pegman control. This control is part of the default UI, and should be set to false when displaying a map type on which the Street View road overlay should not appear (e.g. a non-Earth map type).
        /// </summary>
        public bool streetViewControl { get; set; }
        /// <summary>
        ///The initial display options for the Street View Pegman control.
        /// </summary>
        public StreetViewControlOptions streetViewControlOptions { get; set; }
        /// <summary>
        ///Styles to apply to each of the default map types. Note that styles will apply only to the labels and geometry in Satellite/Hybrid and Terrain modes.
        /// </summary>
        public JsArray<MapTypeStyle> styles { get; set; }
        /// <summary>
        ///The angle of incidence of the map as measured in degrees from the viewport plane to the map plane. The only currently supported values are 0, indicating no angle of incidence (no tilt), and 45, indicating a tilt of 45deg;. 45deg; imagery is only available for SATELLITE and HYBRID map types, within some locations, and at some zoom levels.
        /// </summary>
        public JsNumber tilt { get; set; }
        /// <summary>
        ///The initial Map zoom level. Required.
        /// </summary>
        public JsNumber zoom { get; set; }
        /// <summary>
        ///The enabled/disabled state of the Zoom control.
        /// </summary>
        public bool zoomControl { get; set; }
        /// <summary>
        ///The display options for the Zoom control.
        /// </summary>
        public ZoomControlOptions zoomControlOptions { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MapTypeId")]
    public class MapTypeId
    {
        /// <summary>
        ///This map type displays a transparent layer of major streets on satellite images.
        /// </summary>
        public static MapTypeId HYBRID { get; private set; }
        /// <summary>
        ///This map type displays a normal street map.
        /// </summary>
        public static MapTypeId ROADMAP { get; private set; }
        /// <summary>
        ///This map type displays satellite images.
        /// </summary>
        public static MapTypeId SATELLITE { get; private set; }
        /// <summary>
        ///This map type displays maps with physical features such as terrain and vegetation.
        /// </summary>
        public static MapTypeId TERRAIN { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class MapTypeControlOptions
    {
        /// <summary>
        ///IDs of map types to show in the control.
        /// </summary>
        public object mapTypeIds { get; set; }
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is TOP_RIGHT.
        /// </summary>
        public ControlPosition position { get; set; }
        /// <summary>
        ///Style id. Used to select what style of map type control to display.
        /// </summary>
        public MapTypeControlStyle style { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MapTypeControlStyle")]
    public class MapTypeControlStyle
    {
        /// <summary>
        ///Uses the default map type control. The control which DEFAULT maps to will vary according to window size and other factors. It may change in future versions of the API.
        /// </summary>
        public static object DEFAULT { get; private set; }
        /// <summary>
        ///A dropdown menu for the screen realestate conscious.
        /// </summary>
        public static object DROPDOWN_MENU { get; private set; }
        /// <summary>
        ///The standard horizontal radio buttons bar.
        /// </summary>
        public static object HORIZONTAL_BAR { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class OverviewMapControlOptions
    {
        /// <summary>
        ///Whether the control should display in opened mode or collapsed (minimized) mode. By default, the control is closed.
        /// </summary>
        public bool opened { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PanControlOptions
    {
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition position { get; set; }
    }
    [JsType(JsMode.Json)]
    public class RotateControlOptions
    {
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition position { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ScaleControlOptions
    {
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is BOTTOM_LEFT.
        /// </summary>
        public ControlPosition position { get; set; }
        /// <summary>
        ///Style id. Used to select what style of scale control to display.
        /// </summary>
        public ScaleControlStyle style { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.ScaleControlStyle")]
    public class ScaleControlStyle
    {
        /// <summary>
        ///The standard scale control.
        /// </summary>
        public static object DEFAULT { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewControlOptions
    {
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is embedded within the navigation (zoom and pan) controls. If this position is empty or the same as that specified in the zoomControlOptions or panControlOptions, the Street View control will be displayed as part of the navigation controls. Otherwise, it will be displayed separately.
        /// </summary>
        public ControlPosition position { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ZoomControlOptions
    {
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition position { get; set; }
        /// <summary>
        ///Style id. Used to select what style of zoom control to display.
        /// </summary>
        public ZoomControlStyle style { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.ZoomControlStyle")]
    public class ZoomControlStyle
    {
        /// <summary>
        ///The default zoom control. The control which DEFAULT maps to will vary according to map size and other factors. It may change in future versions of the API.
        /// </summary>
        public static object DEFAULT { get; private set; }
        /// <summary>
        ///The larger control, with the zoom slider in addition to +/- buttons.
        /// </summary>
        public static object LARGE { get; private set; }
        /// <summary>
        ///A small control with buttons to zoom in and out.
        /// </summary>
        public static object SMALL { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.ControlPosition")]
    public class ControlPosition : JsNumber
    {
        protected ControlPosition() : base(0) { }
        /// <summary>
        ///Elements are positioned in the center of the bottom row.
        /// </summary>
        public static ControlPosition BOTTOM_CENTER { get; private set; }
        /// <summary>
        ///Elements are positioned in the bottom left and flow towards the middle. Elements are positioned to the right of the Google logo.
        /// </summary>
        public static ControlPosition BOTTOM_LEFT { get; private set; }
        /// <summary>
        ///Elements are positioned in the bottom right and flow towards the middle. Elements are positioned to the left of the copyrights.
        /// </summary>
        public static ControlPosition BOTTOM_RIGHT { get; private set; }
        /// <summary>
        ///Elements are positioned on the left, above bottom-left elements, and flow upwards.
        /// </summary>
        public static ControlPosition LEFT_BOTTOM { get; private set; }
        /// <summary>
        ///Elements are positioned in the center of the left side.
        /// </summary>
        public static ControlPosition LEFT_CENTER { get; private set; }
        /// <summary>
        ///Elements are positioned on the left, below top-left elements, and flow downwards.
        /// </summary>
        public static ControlPosition LEFT_TOP { get; private set; }
        /// <summary>
        ///Elements are positioned on the right, above bottom-right elements, and flow upwards.
        /// </summary>
        public static ControlPosition RIGHT_BOTTOM { get; private set; }
        /// <summary>
        ///Elements are positioned in the center of the right side.
        /// </summary>
        public static ControlPosition RIGHT_CENTER { get; private set; }
        /// <summary>
        ///Elements are positioned on the right, below top-right elements, and flow downwards.
        /// </summary>
        public static ControlPosition RIGHT_TOP { get; private set; }
        /// <summary>
        ///Elements are positioned in the center of the top row.
        /// </summary>
        public static ControlPosition TOP_CENTER { get; private set; }
        /// <summary>
        ///Elements are positioned in the top left and flow towards the middle.
        /// </summary>
        public static ControlPosition TOP_LEFT { get; private set; }
        /// <summary>
        ///Elements are positioned in the top right and flow towards the middle.
        /// </summary>
        public static ControlPosition TOP_RIGHT { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Marker")]
    public class Marker
    {
        /// <summary>
        ///Creates a marker with the options specified. If a map is specified, the marker is added to the map upon construction. Note that the position must be set for the marker to display.
        /// </summary>
        public Marker(MarkerOptions opts = null) { }
        public Animation getAnimation() { return null; }
        public bool getClickable() { return false; }
        public JsString getCursor() { return null; }
        public bool getDraggable() { return false; }
        public bool getFlat() { return false; }
        public object getIcon() { return null; }
        public object getMap() { return null; }
        public LatLng getPosition() { return null; }
        public object getShadow() { return null; }
        public MarkerShape getShape() { return null; }
        public JsString getTitle() { return null; }
        public bool getVisible() { return false; }
        public JsNumber getZIndex() { return null; }
        /// <summary>
        ///Start an animation. Any ongoing animation will be cancelled. Currently supported animations are: BOUNCE, DROP. Passing in null will cause any animation to stop.
        /// </summary>
        public void setAnimation(Animation animation) { }
        public void setClickable(bool flag) { }
        public void setCursor(JsString cursor) { }
        public void setDraggable(bool flag) { }
        public void setFlat(bool flag) { }
        public void setIcon(object icon) { }
        /// <summary>
        ///Renders the marker on the specified map or panorama. If map is set to null, the marker will be removed.
        /// </summary>
        public void setMap(object map) { }
        public void setOptions(MarkerOptions options) { }
        public void setPosition(LatLng latlng) { }
        public void setShadow(object shadow) { }
        public void setShape(MarkerShape shape) { }
        public void setTitle(JsString title) { }
        public void setVisible(bool visible) { }
        public void setZIndex(JsNumber zIndex) { }
        /// <summary>
        ///The maximum default z-index that the API will assign to a marker. You may set a higher z-index to bring a marker to the front.
        /// </summary>
        public static object MAX_ZINDEX { get; private set; }
        /// <summary>
        ///This event is fired when the marker's animation property changes.
        /// </summary>
        public JsAction animation_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker icon was clicked.
        /// </summary>
        public JsAction<MouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the marker's clickable property changes.
        /// </summary>
        public JsAction clickable_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker's cursor property changes.
        /// </summary>
        public JsAction cursor_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker icon was double clicked.
        /// </summary>
        public JsAction<MouseEvent> dblclick { get; set; }
        /// <summary>
        ///This event is repeatedly fired while the user drags the marker.
        /// </summary>
        public JsAction<MouseEvent> drag { get; set; }
        /// <summary>
        ///This event is fired when the user stops dragging the marker.
        /// </summary>
        public JsAction<MouseEvent> dragend { get; set; }
        /// <summary>
        ///This event is fired when the marker's draggable property changes.
        /// </summary>
        public JsAction draggable_changed { get; set; }
        /// <summary>
        ///This event is fired when the user starts dragging the marker.
        /// </summary>
        public JsAction<MouseEvent> dragstart { get; set; }
        /// <summary>
        ///This event is fired when the marker's flat property changes.
        /// </summary>
        public JsAction flat_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker icon property changes.
        /// </summary>
        public JsAction icon_changed { get; set; }
        /// <summary>
        ///This event is fired for a mousedown on the marker.
        /// </summary>
        public JsAction<MouseEvent> mousedown { get; set; }
        /// <summary>
        ///This event is fired when the mouse leaves the area of the marker icon.
        /// </summary>
        public JsAction<MouseEvent> mouseout { get; set; }
        /// <summary>
        ///This event is fired when the mouse enters the area of the marker icon.
        /// </summary>
        public event JsAction<MouseEvent> mouseover
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mouseover\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mouseover\"")]
            remove { }
        }
        /// <summary>
        ///This event is fired for a mouseup on the marker.
        /// </summary>
        public JsAction<MouseEvent> mouseup { get; set; }
        /// <summary>
        ///This event is fired when the marker position property changes.
        /// </summary>
        public JsAction position_changed { get; set; }
        /// <summary>
        ///This event is fired for a rightclick on the marker.
        /// </summary>
        public JsAction<MouseEvent> rightclick { get; set; }
        /// <summary>
        ///This event is fired when the marker's shadow property changes.
        /// </summary>
        public JsAction shadow_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker's shape property changes.
        /// </summary>
        public JsAction shape_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker title property changes.
        /// </summary>
        public JsAction title_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker's visible property changes.
        /// </summary>
        public JsAction visible_changed { get; set; }
        /// <summary>
        ///This event is fired when the marker's zIndex property changes.
        /// </summary>
        public JsAction zindex_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MarkerOptions
    {
        /// <summary>
        ///The offset from the marker's position to the tip of an InfoWindow that has been opened with the marker as anchor.
        /// </summary>
        public Point anchorPoint { get; set; }
        /// <summary>
        ///Which animation to play when marker is added to a map.
        /// </summary>
        public Animation animation { get; set; }
        /// <summary>
        ///If true, the marker receives mouse and touch events. Default value is true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///Mouse cursor to show on hover
        /// </summary>
        public JsString cursor { get; set; }
        /// <summary>
        ///If true, the marker can be dragged. Default value is false.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///If true, the marker shadow will not be displayed.
        /// </summary>
        public bool flat { get; set; }
        /// <summary>
        ///Icon for the foreground. If a JsString is provided, it is treated as though it were an Icon with the JsString as url.
        /// </summary>
        public object icon { get; set; }
        /// <summary>
        ///Map on which to display Marker.
        /// </summary>
        public object map { get; set; }
        /// <summary>
        ///Optimization renders many markers as a single static element. Optimized rendering is enabled by default. Disable optimized rendering for animated GIFs or PNGs, or when each marker must be rendered as a separate DOM element (advanced usage only).
        /// </summary>
        public bool optimized { get; set; }
        /// <summary>
        ///Marker position. Required.
        /// </summary>
        public LatLng position { get; set; }
        /// <summary>
        ///If false, disables raising and lowering the marker on drag. This option is true by default.
        /// </summary>
        public bool raiseOnDrag { get; set; }
        /// <summary>
        ///Shadow image. If a JsString is provided, it is treated as though it were an Icon with the JsString as url.
        /// </summary>
        public object shadow { get; set; }
        /// <summary>
        ///Image map region definition used for drag/click.
        /// </summary>
        public MarkerShape shape { get; set; }
        /// <summary>
        ///Rollover text
        /// </summary>
        public JsString title { get; set; }
        /// <summary>
        ///If true, the marker is visible
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        ///All markers are displayed on the map in order of their zIndex, with higher values displaying in front of markers with lower values. By default, markers are displayed according to their vertical position on screen, with lower markers appearing in front of markers further up the screen.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }
    [JsType(JsMode.Json)]
    public class Icon
    {
        /// <summary>
        ///The position at which to anchor an image in correspondance to the location of the marker on the map. By default, the anchor is located along the center point of the bottom of the image.
        /// </summary>
        public Point anchor { get; set; }
        /// <summary>
        ///The position of the image within a sprite, if any. By default, the origin is located at the top left corner of the image (0, 0).
        /// </summary>
        public Point origin { get; set; }
        /// <summary>
        ///The size of the entire image after scaling, if any. Use this property to stretch/shrink an image or a sprite.
        /// </summary>
        public Size scaledSize { get; set; }
        /// <summary>
        ///The display size of the sprite or image. When using sprites, you must specify the sprite size. If the size is not provided, it will be set when the image loads.
        /// </summary>
        public Size size { get; set; }
        /// <summary>
        ///The URL of the image or sprite sheet.
        /// </summary>
        public JsString url { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MarkerShape
    {
        /// <summary>
        ///The format of this attribute depends on the value of the type and follows the w3 AREA coords specification found at http://www.w3.org/TR/REC-html40/struct/objects.html#adef-coords. The coords attribute is an array of integers that specify the pixel position of the shape relative to the top-left corner of the target image. The coordinates depend on the value of type as follows:   - circle: coords is [x1,y1,r] where x1,y2 are the coordinates of the center of the circle, and r is the radius of the circle.   - poly: coords is [x1,y1,x2,y2...xn,yn] where each x,y pair contains the coordinates of one vertex of the polygon.   - rect: coords is [x1,y1,x2,y2] where x1,y1 are the coordinates of the upper-left corner of the rectangle and x2,y2 are the coordinates of the lower-right coordinates of the rectangle.
        /// </summary>
        public JsArray<JsNumber> coords { get; set; }
        /// <summary>
        ///Describes the shape's type and can be circle, poly or rect.
        /// </summary>
        public JsString type { get; set; }
    }
    [JsType(JsMode.Json)]
    public class Symbol
    {
        /// <summary>
        ///The position of the symbol relative to the marker or polyline. The coordinates of the symbol's path are translated left and up by the anchor's x and y coordinates respectively. By default, a symbol is anchored at (0, 0). The position is expressed in the same coordinate system as the symbol's path.
        /// </summary>
        public Point anchor { get; set; }
        /// <summary>
        ///The symbol's fill color. All CSS3 colors are supported except for extended named colors. For symbol markers, this defaults to 'black'. For symbols on polylines, this defaults to the stroke color of the corresponding polyline.
        /// </summary>
        public JsString fillColor { get; set; }
        /// <summary>
        ///The symbol's fill opacity. Defaults to 0.
        /// </summary>
        public JsNumber fillOpacity { get; set; }
        /// <summary>
        ///The symbol's path, which is a built-in symbol path, or a custom path expressed using SVG path notation. Required.
        /// </summary>
        public object path { get; set; }
        /// <summary>
        ///The angle by which to rotate the symbol, expressed clockwise in degrees. Defaults to 0. A symbol in an IconSequence where fixedRotation is false is rotated relative to the angle of the edge on which it lies.
        /// </summary>
        public JsNumber rotation { get; set; }
        /// <summary>
        ///The amount by which the symbol is scaled in size. For symbol markers, this defaults to 1; after scaling, the symbol may be of any size. For symbols on a polyline, this defaults to the stroke weight of the polyline; after scaling, the symbol must lie inside a square 22 pixels in size centered at the symbol's anchor.
        /// </summary>
        public JsNumber scale { get; set; }
        /// <summary>
        ///The symbol's stroke color. All CSS3 colors are supported except for extended named colors. For symbol markers, this defaults to 'black'. For symbols on a polyline, this defaults to the stroke color of the polyline.
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The symbol's stroke opacity. For symbol markers, this defaults to 1. For symbols on a polyline, this defaults to the stroke opacity of the polyline.
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The symbol's stroke weight. Defaults to the scale of the symbol.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.SymbolPath")]
    public class SymbolPath
    {
        /// <summary>
        ///A backward-pointing closed arrow.
        /// </summary>
        public static object BACKWARD_CLOSED_ARROW { get; private set; }
        /// <summary>
        ///A backward-pointing open arrow.
        /// </summary>
        public static object BACKWARD_OPEN_ARROW { get; private set; }
        /// <summary>
        ///A circle.
        /// </summary>
        public static object CIRCLE { get; private set; }
        /// <summary>
        ///A forward-pointing closed arrow.
        /// </summary>
        public static object FORWARD_CLOSED_ARROW { get; private set; }
        /// <summary>
        ///A forward-pointing open arrow.
        /// </summary>
        public static object FORWARD_OPEN_ARROW { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Animation")]
    public class Animation
    {
        /// <summary>
        ///Marker bounces until animation is stopped.
        /// </summary>
        public static object BOUNCE { get; private set; }
        /// <summary>
        ///Marker falls from the top of the map ending with a small bounce.
        /// </summary>
        public static object DROP { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.InfoWindow")]
    public class InfoWindow
    {
        /// <summary>
        ///Creates an info window with the given options. An InfoWindow can be placed on a map at a particular position or above a marker, depending on what is specified in the options. Unless auto-pan is disabled, an InfoWindow will pan the map to make itself visible when it is opened. After constructing an InfoWindow, you must call open to display it on the map. The user can click the close button on the InfoWindow to remove it from the map, or the developer can call close() for the same effect.
        /// </summary>
        public InfoWindow(InfoWindowOptions opts = null) { }
        /// <summary>
        ///Closes this InfoWindow by removing it from the DOM structure.
        /// </summary>
        public void close() { }
        public object getContent() { return null; }
        public LatLng getPosition() { return null; }
        public JsNumber getZIndex() { return null; }
        /// <summary>
        ///Opens this InfoWindow on the given map. Optionally, an InfoWindow can be associated with an anchor. In the core API, the only anchor is the Marker class. However, an anchor can be any MVCObject that exposes a LatLng position property and optionally a Point anchorPoint property for calculating the pixelOffset (see InfoWindowOptions). The anchorPoint is the offset from the anchor's position to the tip of the InfoWindow.
        /// </summary>
        public void open(object map = null, MVCObject anchor = null) { }
        public void setContent(object content) { }
        public void setOptions(InfoWindowOptions options) { }
        public void setPosition(LatLng position) { }
        public void setZIndex(JsNumber zIndex) { }
        /// <summary>
        ///This event is fired when the close button was clicked.
        /// </summary>
        public JsAction closeclick { get; set; }
        /// <summary>
        ///This event is fired when the content property changes.
        /// </summary>
        public JsAction content_changed { get; set; }
        /// <summary>
        ///This event is fired when the &lt;div&gt; containing the InfoWindow's content is attached to the DOM. You may wish to monitor this event if you are building out your info window content dynamically.
        /// </summary>
        public JsAction domready { get; set; }
        /// <summary>
        ///This event is fired when the position property changes.
        /// </summary>
        public JsAction position_changed { get; set; }
        /// <summary>
        ///This event is fired when the InfoWindow's zIndex changes.
        /// </summary>
        public JsAction zindex_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class InfoWindowOptions
    {
        /// <summary>
        ///Content to display in the InfoWindow. This can be an HTML element, a plain-text JsString, or a JsString containing HTML. The InfoWindow will be sized according to the content. To set an explicit size for the content, set content to be a HTML element with that size.
        /// </summary>
        public object content { get; set; }
        /// <summary>
        ///Disable auto-pan on open. By default, the info window will pan the map so that it is fully visible when it opens.
        /// </summary>
        public bool disableAutoPan { get; set; }
        /// <summary>
        ///Maximum width of the infowindow, regardless of content's width. This value is only considered if it is set before a call to open. To change the maximum width when changing content, call close, setOptions, and then open.
        /// </summary>
        public JsNumber maxWidth { get; set; }
        /// <summary>
        ///The offset, in pixels, of the tip of the info window from the point on the map at whose geographical coordinates the info window is anchored. If an InfoWindow is opened with an anchor, the pixelOffset will be calculated from the anchor's anchorPoint property.
        /// </summary>
        public Size pixelOffset { get; set; }
        /// <summary>
        ///The LatLng at which to display this InfoWindow. If the InfoWindow is opened with an anchor, the anchor's position will be used instead.
        /// </summary>
        public LatLng position { get; set; }
        /// <summary>
        ///All InfoWindows are displayed on the map in order of their zIndex, with higher values displaying in front of InfoWindows with lower values. By default, InfoWinodws are displayed according to their latitude, with InfoWindows of lower latitudes appearing in front of InfoWindows at higher latitudes. InfoWindows are always displayed in front of markers.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Polyline")]
    public class Polyline
    {
        /// <summary>
        ///Create a polyline using the passed PolylineOptions, which specify both the path of the polyline and the stroke style to use when drawing the polyline. You may pass either an array of LatLngs or an MVCArray of LatLngs when constructing a polyline, though simple arrays are converted to MVCArrays within the polyline upon instantiation.
        /// </summary>
        public Polyline(PolylineOptions opts = null) { }
        /// <summary>
        ///Returns whether this shape can be dragged by the user.
        /// </summary>
        public bool getDraggable() { return false; }
        /// <summary>
        ///Returns whether this shape can be edited by the user.
        /// </summary>
        public bool getEditable() { return false; }
        /// <summary>
        ///Returns the map on which this shape is attached.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Retrieves the first path.
        /// </summary>
        public MVCArray<LatLng> getPath() { return null; }
        /// <summary>
        ///Returns whether this poly is visible on the map.
        /// </summary>
        public bool getVisible() { return false; }
        /// <summary>
        ///If set to true, the user can drag this shape over the map. The geodesic property defines the mode of dragging.
        /// </summary>
        public void setDraggable(bool draggable) { }
        /// <summary>
        ///If set to true, the user can edit this shape by dragging the control points shown at the vertices and on each segment.
        /// </summary>
        public void setEditable(bool editable) { }
        /// <summary>
        ///Renders this shape on the specified map. If map is set to null, the shape will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(PolylineOptions options) { }
        /// <summary>
        ///Sets the first path. See PolylineOptions for more details.
        /// </summary>
        public void setPath(object path) { }
        /// <summary>
        ///Hides this poly if set to false.
        /// </summary>
        public void setVisible(bool visible) { }
        /// <summary>
        ///This event is fired when the DOM click event is fired on the Polyline.
        /// </summary>
        public JsAction<PolyMouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the DOM dblclick event is fired on the Polyline.
        /// </summary>
        public JsAction<PolyMouseEvent> dblclick { get; set; }
        /// <summary>
        ///This event is fired when the DOM mousedown event is fired on the Polyline.
        /// </summary>
        public JsAction<PolyMouseEvent> mousedown { get; set; }
        /// <summary>
        ///This event is fired when the DOM mousemove event is fired on the Polyline.
        /// </summary>
        public JsAction<PolyMouseEvent> mousemove { get; set; }
        /// <summary>
        ///This event is fired on Polyline mouseout.
        /// </summary>
        public JsAction<PolyMouseEvent> mouseout { get; set; }
        /// <summary>
        ///This event is fired on Polyline mouseover.
        /// </summary>
        public JsAction<PolyMouseEvent> mouseover { get; set; }
        /// <summary>
        ///This event is fired when the DOM mouseup event is fired on the Polyline.
        /// </summary>
        public JsAction<PolyMouseEvent> mouseup { get; set; }
        /// <summary>
        ///This event is fired when the Polyline is right-clicked on.
        /// </summary>
        public JsAction<PolyMouseEvent> rightclick { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PolylineOptions
    {
        /// <summary>
        ///Indicates whether this Polyline handles mouse events. Defaults to true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///If set to true, the user can drag this shape over the map. The geodesic property defines the mode of dragging. Defaults to false.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///If set to true, the user can edit this shape by dragging the control points shown at the vertices and on each segment. Defaults to false.
        /// </summary>
        public bool editable { get; set; }
        /// <summary>
        ///When true, edges of the polygon are interpreted as geodesic and will follow the curvature of the Earth. When false, edges of the polygon are rendered as straight lines in screen space. Note that the shape of a geodesic polygon may appear to change when dragged, as the dimensions are maintained relative to the surface of the earth. Defaults to false.
        /// </summary>
        public bool geodesic { get; set; }
        /// <summary>
        ///The icons to be rendered along the polyline.
        /// </summary>
        public JsArray<IconSequence> icons { get; set; }
        /// <summary>
        ///Map on which to display Polyline.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The ordered sequence of coordinates of the Polyline. This path may be specified using either a simple array of LatLngs, or an MVCArray of LatLngs. Note that if you pass a simple array, it will be converted to an MVCArray Inserting or removing LatLngs in the MVCArray will automatically update the polyline on the map.
        /// </summary>
        public object path { get; set; }
        /// <summary>
        ///The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0.
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The stroke width in pixels.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
        /// <summary>
        ///Whether this polyline is visible on the map. Defaults to true.
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        ///The zIndex compared to other polys.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }
    [JsType(JsMode.Json)]
    public class IconSequence
    {
        /// <summary>
        ///If true, each icon in the sequence has the same fixed rotation regardless of the angle of the edge on which it lies. Defaults to false, in which case each icon in the sequence is rotated to align with its edge.
        /// </summary>
        public bool fixedRotation { get; set; }
        /// <summary>
        ///The icon to render on the line.
        /// </summary>
        public Symbol icon { get; set; }
        /// <summary>
        ///The distance from the start of the line at which an icon is to be rendered. This distance may be expressed as a percentage of line's length (e.g. '50%') or in pixels (e.g. '50px'). Defaults to '100%'.
        /// </summary>
        public JsString offset { get; set; }
        /// <summary>
        ///The distance between consecutive icons on the line. This distance may be expressed as a percentage of the line's length (e.g. '50%') or in pixels (e.g. '50px'). To disable repeating of the icon, specify '0'. Defaults to '0'.
        /// </summary>
        public JsString repeat { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Polygon")]
    public class Polygon
    {
        /// <summary>
        ///Create a polygon using the passed PolygonOptions, which specify the polygon's path, the stroke style for the polygon's edges, and the fill style for the polygon's interior regions. A polygon may contain one or more paths, where each path consists of an array of LatLngs. You may pass either an array of LatLngs or an MVCArray of LatLngs when constructing these paths. Arrays are converted to MVCArrays within the polygon upon instantiation.
        /// </summary>
        public Polygon(PolygonOptions opts = null) { }
        /// <summary>
        ///Returns whether this shape can be dragged by the user.
        /// </summary>
        public bool getDraggable() { return false; }
        /// <summary>
        ///Returns whether this shape can be edited by the user.
        /// </summary>
        public bool getEditable() { return false; }
        /// <summary>
        ///Returns the map on which this shape is attached.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Retrieves the first path.
        /// </summary>
        public MVCArray<LatLng> getPath() { return null; }
        /// <summary>
        ///Retrieves the paths for this polygon.
        /// </summary>
        public MVCArray<MVCArray<LatLng>> getPaths() { return null; }
        /// <summary>
        ///Returns whether this poly is visible on the map.
        /// </summary>
        public bool getVisible() { return false; }
        /// <summary>
        ///If set to true, the user can drag this shape over the map. The geodesic property defines the mode of dragging.
        /// </summary>
        public void setDraggable(bool draggable) { }
        /// <summary>
        ///If set to true, the user can edit this shape by dragging the control points shown at the vertices and on each segment.
        /// </summary>
        public void setEditable(bool editable) { }
        /// <summary>
        ///Renders this shape on the specified map. If map is set to null, the shape will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(PolygonOptions options) { }
        /// <summary>
        ///Sets the first path. See PolylineOptions for more details.
        /// </summary>
        public void setPath(object path) { }
        /// <summary>
        ///Sets the path for this polygon.
        /// </summary>
        public void setPaths(object paths) { }
        /// <summary>
        ///Hides this poly if set to false.
        /// </summary>
        public void setVisible(bool visible) { }
        /// <summary>
        ///This event is fired when the DOM click event is fired on the Polygon.
        /// </summary>
        public JsAction<PolyMouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the DOM dblclick event is fired on the Polygon.
        /// </summary>
        public JsAction<PolyMouseEvent> dblclick { get; set; }
        /// <summary>
        ///This event is fired when the DOM mousedown event is fired on the Polygon.
        /// </summary>
        public JsAction<PolyMouseEvent> mousedown { get; set; }
        /// <summary>
        ///This event is fired when the DOM mousemove event is fired on the Polygon.
        /// </summary>
        public JsAction<PolyMouseEvent> mousemove { get; set; }
        /// <summary>
        ///This event is fired on Polygon mouseout.
        /// </summary>
        public JsAction<PolyMouseEvent> mouseout { get; set; }
        /// <summary>
        ///This event is fired on Polygon mouseover.
        /// </summary>
        public JsAction<PolyMouseEvent> mouseover { get; set; }
        /// <summary>
        ///This event is fired when the DOM mouseup event is fired on the Polygon.
        /// </summary>
        public JsAction<PolyMouseEvent> mouseup { get; set; }
        /// <summary>
        ///This event is fired when the Polygon is right-clicked on.
        /// </summary>
        public JsAction<PolyMouseEvent> rightclick { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PolygonOptions
    {
        /// <summary>
        ///Indicates whether this Polygon handles mouse events. Defaults to true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///If set to true, the user can drag this shape over the map. The geodesic property defines the mode of dragging. Defaults to false.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///If set to true, the user can edit this shape by dragging the control points shown at the vertices and on each segment. Defaults to false.
        /// </summary>
        public bool editable { get; set; }
        /// <summary>
        ///The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString fillColor { get; set; }
        /// <summary>
        ///The fill opacity between 0.0 and 1.0
        /// </summary>
        public JsNumber fillOpacity { get; set; }
        /// <summary>
        ///When true, edges of the polygon are interpreted as geodesic and will follow the curvature of the Earth. When false, edges of the polygon are rendered as straight lines in screen space. Note that the shape of a geodesic polygon may appear to change when dragged, as the dimensions are maintained relative to the surface of the earth. Defaults to false.
        /// </summary>
        public bool geodesic { get; set; }
        /// <summary>
        ///Map on which to display Polygon.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The ordered sequence of coordinates that designates a closed loop. Unlike polylines, a polygon may consist of one or more paths. 
        ///As a result, the paths property may specify one or more arrays of LatLng coordinates. 
        ///Paths are closed automatically; do not repeat the first vertex of the path as the last vertex. 
        ///Simple polygons may be defined using a single array of LatLngs. More complex polygons may specify an array of arrays. 
        ///Any simple arrays are converted into MVCArrays. Inserting or removing LatLngs from the MVCArray will automatically update the polygon on the map.
        /// </summary>
        public JsArray<LatLng> paths { get; set; }
        /// <summary>
        ///The ordered sequence of coordinates that designates a closed loop. Unlike polylines, a polygon may consist of one or more paths. 
        ///As a result, the paths property may specify one or more arrays of LatLng coordinates. 
        ///Paths are closed automatically; do not repeat the first vertex of the path as the last vertex. 
        ///Simple polygons may be defined using a single array of LatLngs. More complex polygons may specify an array of arrays. 
        ///Any simple arrays are converted into MVCArrays. Inserting or removing LatLngs from the MVCArray will automatically update the polygon on the map.
        /// </summary>
        [JsProperty(Name = "paths")]
        public JsArray<JsArray<LatLng>> ComplexPaths { get; set; }
        /// <summary>
        ///The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The stroke position. Defaults to CENTER. This property is not supported on Internet Explorer 8 and earlier.
        /// </summary>
        public StrokePosition strokePosition { get; set; }
        /// <summary>
        ///The stroke width in pixels.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
        /// <summary>
        ///Whether this polygon is visible on the map. Defaults to true.
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        ///The zIndex compared to other polys.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PolyMouseEvent
    {
        /// <summary>
        ///The index of the edge within the path beneath the cursor when the event occurred, if the event occurred on a mid-point on an editable polygon.
        /// </summary>
        public JsNumber edge { get; set; }
        /// <summary>
        ///The index of the path beneath the cursor when the event occurred, if the event occurred on a vertex and the polygon is editable. Otherwise undefined.
        /// </summary>
        public JsNumber path { get; set; }
        /// <summary>
        ///The index of the vertex beneath the cursor when the event occurred, if the event occurred on a vertex and the polyline or polygon is editable. If the event does not occur on a vertex, the value is undefined.
        /// </summary>
        public JsNumber vertex { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Rectangle")]
    public class Rectangle
    {
        /// <summary>
        ///Create a rectangle using the passed RectangleOptions, which specify the bounds and style.
        /// </summary>
        public Rectangle(RectangleOptions opts = null) { }
        /// <summary>
        ///Returns the bounds of this rectangle.
        /// </summary>
        public LatLngBounds getBounds() { return null; }
        /// <summary>
        ///Returns whether this rectangle can be dragged by the user.
        /// </summary>
        public bool getDraggable() { return false; }
        /// <summary>
        ///Returns whether this rectangle can be edited by the user.
        /// </summary>
        public bool getEditable() { return false; }
        /// <summary>
        ///Returns the map on which this rectangle is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns whether this rectangle is visible on the map.
        /// </summary>
        public bool getVisible() { return false; }
        /// <summary>
        ///Sets the bounds of this rectangle.
        /// </summary>
        public void setBounds(LatLngBounds bounds) { }
        /// <summary>
        ///If set to true, the user can drag this rectangle over the map.
        /// </summary>
        public void setDraggable(bool draggable) { }
        /// <summary>
        ///If set to true, the user can edit this rectangle by dragging the control points shown at the corners and on each edge.
        /// </summary>
        public void setEditable(bool editable) { }
        /// <summary>
        ///Renders the rectangle on the specified map. If map is set to null, the rectangle will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(RectangleOptions options) { }
        /// <summary>
        ///Hides this rectangle if set to false.
        /// </summary>
        public void setVisible(bool visible) { }
        /// <summary>
        ///This event is fired when the rectangle's bounds are changed.
        /// </summary>
        public event JsAction bounds_changed
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"bounds_changed\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"bounds_changed\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the DOM click event is fired on the rectangle.
        /// </summary>
        public event JsAction<MouseEvent> click
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"click\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"click\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the DOM dblclick event is fired on the rectangle.
        /// </summary>
        public event JsAction<MouseEvent> dblclick
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"dblclick\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"dblclick\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the DOM mousedown event is fired on the rectangle.
        /// </summary>
        public event JsAction<MouseEvent> mousedown
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mousedown\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mousedown\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the DOM mousemove event is fired on the rectangle.
        /// </summary>
        public event JsAction<MouseEvent> mousemove
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mousemove\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mousemove\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired on rectangle mouseout.
        /// </summary>
        public event JsAction<MouseEvent> mouseout
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mouseout\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mouseout\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired on rectangle mouseover.
        /// </summary>
        public event JsAction<MouseEvent> mouseover
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mouseover\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mouseover\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the DOM mouseup event is fired on the rectangle.
        /// </summary>
        public event JsAction<MouseEvent> mouseup
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"mouseup\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"mouseup\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the rectangle is right-clicked on.
        /// </summary>
        public event JsAction<MouseEvent> rightclick
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"rightclick\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"rightclick\"")]
            remove { }
        }

    }
    [JsType(JsMode.Json)]
    public class RectangleOptions
    {
        /// <summary>
        ///The bounds.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///Indicates whether this Rectangle handles mouse events. Defaults to true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///If set to true, the user can drag this rectangle over the map. Defaults to false.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///If set to true, the user can edit this rectangle by dragging the control points shown at the corners and on each edge. Defaults to false.
        /// </summary>
        public bool editable { get; set; }
        /// <summary>
        ///The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString fillColor { get; set; }
        /// <summary>
        ///The fill opacity between 0.0 and 1.0
        /// </summary>
        public JsNumber fillOpacity { get; set; }
        /// <summary>
        ///Map on which to display Rectangle.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The stroke position. Defaults to CENTER. This property is not supported on Internet Explorer 8 and earlier.
        /// </summary>
        public StrokePosition strokePosition { get; set; }
        /// <summary>
        ///The stroke width in pixels.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
        /// <summary>
        ///Whether this rectangle is visible on the map. Defaults to true.
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        ///The zIndex compared to other polys.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Circle")]
    public class Circle
    {
        /// <summary>
        ///Create a circle using the passed CircleOptions, which specify the center, radius, and style.
        /// </summary>
        public Circle(CircleOptions opts = null) { }
        /// <summary>
        ///Gets the LatLngBounds of this Circle.
        /// </summary>
        public LatLngBounds getBounds() { return null; }
        /// <summary>
        ///Returns the center of this circle.
        /// </summary>
        public LatLng getCenter() { return null; }
        /// <summary>
        ///Returns whether this circle can be dragged by the user.
        /// </summary>
        public bool getDraggable() { return false; }
        /// <summary>
        ///Returns whether this circle can be edited by the user.
        /// </summary>
        public bool getEditable() { return false; }
        /// <summary>
        ///Returns the map on which this circle is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns the radius of this circle (in meters).
        /// </summary>
        public JsNumber getRadius() { return null; }
        /// <summary>
        ///Returns whether this circle is visible on the map.
        /// </summary>
        public bool getVisible() { return false; }
        /// <summary>
        ///Sets the center of this circle.
        /// </summary>
        public void setCenter(LatLng center) { }
        /// <summary>
        ///If set to true, the user can drag this circle over the map.
        /// </summary>
        public void setDraggable(bool draggable) { }
        /// <summary>
        ///If set to true, the user can edit this circle by dragging the control points shown at the center and around the circumference of the circle.
        /// </summary>
        public void setEditable(bool editable) { }
        /// <summary>
        ///Renders the circle on the specified map. If map is set to null, the circle will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(CircleOptions options) { }
        /// <summary>
        ///Sets the radius of this circle (in meters).
        /// </summary>
        public void setRadius(JsNumber radius) { }
        /// <summary>
        ///Hides this circle if set to false.
        /// </summary>
        public void setVisible(bool visible) { }
        /// <summary>
        ///This event is fired when the circle's center is changed.
        /// </summary>
        public JsAction center_changed { get; set; }
        /// <summary>
        ///This event is fired when the DOM click event is fired on the circle.
        /// </summary>
        public JsAction<MouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the DOM dblclick event is fired on the circle.
        /// </summary>
        public JsAction<MouseEvent> dblclick { get; set; }
        /// <summary>
        ///This event is fired when the DOM mousedown event is fired on the circle.
        /// </summary>
        public JsAction<MouseEvent> mousedown { get; set; }
        /// <summary>
        ///This event is fired when the DOM mousemove event is fired on the circle.
        /// </summary>
        public JsAction<MouseEvent> mousemove { get; set; }
        /// <summary>
        ///This event is fired on circle mouseout.
        /// </summary>
        public JsAction<MouseEvent> mouseout { get; set; }
        /// <summary>
        ///This event is fired on circle mouseover.
        /// </summary>
        public JsAction<MouseEvent> mouseover { get; set; }
        /// <summary>
        ///This event is fired when the DOM mouseup event is fired on the circle.
        /// </summary>
        public JsAction<MouseEvent> mouseup { get; set; }
        /// <summary>
        ///This event is fired when the circle's radius is changed.
        /// </summary>
        public JsAction radius_changed { get; set; }
        /// <summary>
        ///This event is fired when the circle is right-clicked on.
        /// </summary>
        public JsAction<MouseEvent> rightclick { get; set; }
    }
    [JsType(JsMode.Json)]
    public class CircleOptions
    {
        /// <summary>
        ///The center
        /// </summary>
        public LatLng center { get; set; }
        /// <summary>
        ///Indicates whether this Circle handles mouse events. Defaults to true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///If set to true, the user can drag this circle over the map. Defaults to false.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///If set to true, the user can edit this circle by dragging the control points shown at the center and around the circumference of the circle. Defaults to false.
        /// </summary>
        public bool editable { get; set; }
        /// <summary>
        ///The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString fillColor { get; set; }
        /// <summary>
        ///The fill opacity between 0.0 and 1.0
        /// </summary>
        public JsNumber fillOpacity { get; set; }
        /// <summary>
        ///Map on which to display Circle.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The radius in meters on the Earth's surface
        /// </summary>
        public JsNumber radius { get; set; }
        /// <summary>
        ///The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The stroke position. Defaults to CENTER. This property is not supported on Internet Explorer 8 and earlier.
        /// </summary>
        public StrokePosition strokePosition { get; set; }
        /// <summary>
        ///The stroke width in pixels.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
        /// <summary>
        ///Whether this circle is visible on the map. Defaults to true.
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        ///The zIndex compared to other polys.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StrokePosition
    {
        /// <summary>
        ///The stroke is centered on the polygon's path, with half the stroke inside the polygon and half the stroke outside the polygon.
        /// </summary>
        public static object CENTER { get; private set; }
        /// <summary>
        ///The stroke lies inside the polygon.
        /// </summary>
        public static object INSIDE { get; private set; }
        /// <summary>
        ///The stroke lies outside the polygon.
        /// </summary>
        public static object OUTSIDE { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.GroundOverlay")]
    public class GroundOverlay
    {
        /// <summary>
        ///Creates a ground overlay from the provided image URL and its LatLngBounds. The image is scaled to fit the current bounds, and projected using the current map projection.
        /// </summary>
        public GroundOverlay(JsString url, LatLngBounds bounds, GroundOverlayOptions opts = null) { }
        /// <summary>
        ///Gets the LatLngBounds of this overlay.
        /// </summary>
        public LatLngBounds getBounds() { return null; }
        /// <summary>
        ///Returns the map on which this ground overlay is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns the opacity of this ground overlay.
        /// </summary>
        public JsNumber getOpacity() { return null; }
        /// <summary>
        ///Gets the url of the projected image.
        /// </summary>
        public JsString getUrl() { return null; }
        /// <summary>
        ///Renders the ground overlay on the specified map. If map is set to null, the overlay is removed.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Sets the opacity of this ground overlay.
        /// </summary>
        public void setOpacity(JsNumber opacity) { }
        /// <summary>
        ///This event is fired when the DOM click event is fired on the GroundOverlay.
        /// </summary>
        public JsAction<MouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the DOM dblclick event is fired on the GroundOverlay.
        /// </summary>
        public JsAction<MouseEvent> dblclick { get; set; }
    }
    [JsType(JsMode.Json)]
    public class GroundOverlayOptions
    {
        /// <summary>
        ///If true, the ground overlay can receive mouse events.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///The map on which to display the overlay.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The opacity of the overlay, expressed as a number between 0 and 1. Optional. Defaults to 1.
        /// </summary>
        public JsNumber opacity { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.OverlayView")]
    public class OverlayView
    {
        /// <summary>
        ///You should inherit from this public class by setting your overlay's prototype to new OverlayView. You must implement three methods: onAdd(), draw(), and onRemove(). In the add() method, you should create DOM objects and append them as children of the panes. In the draw() method, you should position these elements. In the onRemove() method, you should remove the objects from the DOM. You must call setMap() with a valid Map object to trigger the call to the onAdd() method and setMap(null) in order to trigger the onRemove() method. The setMap() method can be called at the time of construction or at any point afterward when the overlay should be re-shown after removing. The draw() method will then be called whenever a map property changes that could change the position of the element, such as zoom, center, or map type.
        /// </summary>
        public OverlayView() { }
        /// <summary>
        ///Implement this method to draw or update the overlay. This method is called after onAdd() and when the position from projection.fromLatLngToPixel() would return a new value for a given LatLng. This can happen on change of zoom, center, or map type. It is not necessarily called on drag or resize.
        /// </summary>
        public void draw() { }
        public object getMap() { return null; }
        /// <summary>
        ///Returns the panes in which this OverlayView can be rendered. The panes are not initialized until onAdd is called by the API.
        /// </summary>
        public MapPanes getPanes() { return null; }
        /// <summary>
        ///Returns the MapCanvasProjection object associated with this OverlayView. The projection is not initialized until onAdd is called by the API.
        /// </summary>
        public MapCanvasProjection getProjection() { return null; }
        /// <summary>
        ///Implement this method to initialize the overlay DOM elements. This method is called once after setMap() is called with a valid map. At this point, panes and projection will have been initialized.
        /// </summary>
        public void onAdd() { }
        /// <summary>
        ///Implement this method to remove your elements from the DOM. This method is called once following a call to setMap(null).
        /// </summary>
        public void onRemove() { }
        /// <summary>
        ///Adds the overlay to the map or panorama.
        /// </summary>
        public void setMap(object map) { }
    }
    [JsType(JsMode.Json)]
    public class MapPanes
    {
        /// <summary>
        ///This pane contains the info window. It is above all map overlays. (Pane 6).
        /// </summary>
        public Node floatPane { get; set; }
        /// <summary>
        ///This pane contains the info window shadow. It is above the overlayImage, so that markers can be in the shadow of the info window. (Pane 4).
        /// </summary>
        public Node floatShadow { get; set; }
        /// <summary>
        ///This pane is the lowest pane and is above the tiles. It may not receive DOM events. (Pane 0).
        /// </summary>
        public Node mapPane { get; set; }
        /// <summary>
        ///This pane contains the marker foreground images. (Pane 3).
        /// </summary>
        public Node overlayImage { get; set; }
        /// <summary>
        ///This pane contains polylines, polygons, ground overlays and tile layer overlays. It may not receive DOM events. (Pane 1).
        /// </summary>
        public Node overlayLayer { get; set; }
        /// <summary>
        ///This pane contains elements that receive DOM mouse events, such as the transparent targets for markers. It is above the floatShadow, so that markers in the shadow of the info window can be clickable. (Pane 5).
        /// </summary>
        public Node overlayMouseTarget { get; set; }
        /// <summary>
        ///This pane contains the marker shadows. It may not receive DOM events. (Pane 2).
        /// </summary>
        public Node overlayShadow { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapCanvasProjection
    {
        /// <summary>
        ///Computes the geographical coordinates from pixel coordinates in the map's container.
        /// </summary>
        public LatLng fromContainerPixelToLatLng(Point pixel, bool nowrap = false) { return null; }
        /// <summary>
        ///Computes the geographical coordinates from pixel coordinates in the div that holds the draggable map.
        /// </summary>
        public LatLng fromDivPixelToLatLng(Point pixel, bool nowrap = false) { return null; }
        /// <summary>
        ///Computes the pixel coordinates of the given geographical location in the map's container element.
        /// </summary>
        public Point fromLatLngToContainerPixel(LatLng latLng) { return null; }
        /// <summary>
        ///Computes the pixel coordinates of the given geographical location in the DOM element that holds the draggable map.
        /// </summary>
        public Point fromLatLngToDivPixel(LatLng latLng) { return null; }
        /// <summary>
        ///The width of the world in pixels in the current zoom level. For projections with a heading angle of either 90 or 270 degress, this corresponds to the pixel span in the Y-axis.
        /// </summary>
        public JsNumber getWorldWidth() { return null; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Geocoder")]
    public class Geocoder
    {
        /// <summary>
        ///Creates a new instance of a Geocoder that sends geocode requests to Google servers.
        /// </summary>
        public Geocoder() { }
        /// <summary>
        ///Geocode a request.
        /// </summary>
        public void geocode() { }
    }
    [JsType(JsMode.Json)]
    public class GeocoderRequest
    {
        /// <summary>
        ///Address. Optional.
        /// </summary>
        public JsString address { get; set; }
        /// <summary>
        ///LatLngBounds within which to search. Optional.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///LatLng about which to search. Optional.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///Country code used to bias the search, specified as a Unicode region subtag / CLDR identifier. Optional.
        /// </summary>
        public JsString region { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.GeocoderStatus")]
    public class GeocoderStatus
    {
        /// <summary>
        ///There was a problem contacting the Google servers.
        /// </summary>
        public static object ERROR { get; private set; }
        /// <summary>
        ///This GeocoderRequest was invalid.
        /// </summary>
        public static object INVALID_REQUEST { get; private set; }
        /// <summary>
        ///The response contains a valid GeocoderResponse.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The webpage has gone over the requests limit in too short a period of time.
        /// </summary>
        public static object OVER_QUERY_LIMIT { get; private set; }
        /// <summary>
        ///The webpage is not allowed to use the geocoder.
        /// </summary>
        public static object REQUEST_DENIED { get; private set; }
        /// <summary>
        ///A geocoding request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
        /// <summary>
        ///No result was found for this GeocoderRequest.
        /// </summary>
        public static object ZERO_RESULTS { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class GeocoderResult
    {
        /// <summary>
        ///An array of GeocoderAddressComponents
        /// </summary>
        public JsArray<GeocoderAddressComponent> address_components { get; set; }
        /// <summary>
        ///A JsString containing the human-readable address of this location.
        /// </summary>
        public JsString formatted_address { get; set; }
        /// <summary>
        ///A GeocoderGeometry object
        /// </summary>
        public GeocoderGeometry geometry { get; set; }
        /// <summary>
        ///An array of strings denoting the type of the returned geocoded element. For a list of possible strings, refer to the Address Component Types section of the Developer's Guide.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Json)]
    public class GeocoderAddressComponent
    {
        /// <summary>
        ///The full text of the address component
        /// </summary>
        public JsString long_name { get; set; }
        /// <summary>
        ///The abbreviated, short text of the given address component
        /// </summary>
        public JsString short_name { get; set; }
        /// <summary>
        ///An array of strings denoting the type of this address component. A list of valid types can be found here
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Json)]
    public class GeocoderGeometry
    {
        /// <summary>
        ///The precise bounds of this GeocodeResult, if applicable
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///The latitude/longitude coordinates of this result
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The type of location returned in location
        /// </summary>
        public GeocoderLocationType location_type { get; set; }
        /// <summary>
        ///The bounds of the recommended viewport for displaying this GeocodeResult
        /// </summary>
        public LatLngBounds viewport { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.GeocoderLocationType")]
    public class GeocoderLocationType
    {
        /// <summary>
        ///The returned result is approximate.
        /// </summary>
        public static object APPROXIMATE { get; private set; }
        /// <summary>
        ///The returned result is the geometric center of a result such a line (e.g. street) or polygon (region).
        /// </summary>
        public static object GEOMETRIC_CENTER { get; private set; }
        /// <summary>
        ///The returned result reflects an approximation (usually on a road) interpolated between two precise points (such as intersections). Interpolated results are generally returned when rooftop geocodes are unavailable for a street address.
        /// </summary>
        public static object RANGE_INTERPOLATED { get; private set; }
        /// <summary>
        ///The returned result reflects a precise geocode.
        /// </summary>
        public static object ROOFTOP { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.DirectionsRenderer")]
    public class DirectionsRenderer
    {
        /// <summary>
        ///Creates the renderer with the given options. Directions can be rendered on a map (as visual overlays) or additionally on a &lt;div&gt; panel (as textual instructions).
        /// </summary>
        public DirectionsRenderer(DirectionsRendererOptions opts = null) { }
        /// <summary>
        ///Returns the renderer's current set of directions.
        /// </summary>
        public DirectionsResult getDirections() { return null; }
        /// <summary>
        ///Returns the map on which the DirectionsResult is rendered.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns the panel &lt;div&gt; in which the DirectionsResult is rendered.
        /// </summary>
        public Node getPanel() { return null; }
        /// <summary>
        ///Returns the current (zero-based) route index in use by this DirectionsRenderer object.
        /// </summary>
        public JsNumber getRouteIndex() { return null; }
        /// <summary>
        ///Set the renderer to use the result from the DirectionsService. Setting a valid set of directions in this manner will display the directions on the renderer's designated map and panel.
        /// </summary>
        public void setDirections(DirectionsResult directions) { }
        /// <summary>
        ///This method specifies the map on which directions will be rendered. Pass null to remove the directions from the map.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Change the options settings of this DirectionsRenderer after initialization.
        /// </summary>
        public void setOptions(DirectionsRendererOptions options) { }
        /// <summary>
        ///This method renders the directions in a &lt;div&gt;. Pass null to remove the content from the panel.
        /// </summary>
        public void setPanel(Node panel) { }
        /// <summary>
        ///Set the (zero-based) index of the route in the DirectionsResult object to render. By default, the first route in the array will be rendered.
        /// </summary>
        public void setRouteIndex(JsNumber routeIndex) { }
        /// <summary>
        ///This event is fired when the rendered directions change, either when a new DirectionsResult is set or when the user finishes dragging a change to the directions path.
        /// </summary>
        public JsAction directions_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DirectionsRendererOptions
    {
        /// <summary>
        ///The directions to display on the map and/or in a &lt;div&gt; panel, retrieved as a DirectionsResult object from DirectionsService.
        /// </summary>
        public DirectionsResult directions { get; set; }
        /// <summary>
        ///If true, allows the user to drag and modify the paths of routes rendered by this DirectionsRenderer.
        /// </summary>
        public bool draggable { get; set; }
        /// <summary>
        ///This property indicates whether the renderer should provide UI to select amongst alternative routes. By default, this flag is false and a user-selectable list of routes will be shown in the directions' associated panel. To hide that list, set hideRouteList to true.
        /// </summary>
        public bool hideRouteList { get; set; }
        /// <summary>
        ///The InfoWindow in which to render text information when a marker is clicked. Existing info window content will be overwritten and its position moved. If no info window is specified, the DirectionsRenderer will create and use its own info window. This property will be ignored if suppressInfoWindows is set to true.
        /// </summary>
        public InfoWindow infoWindow { get; set; }
        /// <summary>
        ///Map on which to display the directions.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///Options for the markers. All markers rendered by the DirectionsRenderer will use these options.
        /// </summary>
        public MarkerOptions markerOptions { get; set; }
        /// <summary>
        ///The &lt;div&gt; in which to display the directions steps.
        /// </summary>
        public Node panel { get; set; }
        /// <summary>
        ///Options for the polylines. All polylines rendered by the DirectionsRenderer will use these options.
        /// </summary>
        public PolylineOptions polylineOptions { get; set; }
        /// <summary>
        ///By default, the input map is centered and zoomed to the bounding box of this set of directions. If this option is set to true, the viewport is left unchanged, unless the map's center and zoom were never set.
        /// </summary>
        public bool preserveViewport { get; set; }
        /// <summary>
        ///The index of the route within the DirectionsResult object. The default value is 0.
        /// </summary>
        public JsNumber routeIndex { get; set; }
        /// <summary>
        ///Suppress the rendering of the BicyclingLayer when bicycling directions are requested.
        /// </summary>
        public bool suppressBicyclingLayer { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows.
        /// </summary>
        public bool suppressInfoWindows { get; set; }
        /// <summary>
        ///Suppress the rendering of markers.
        /// </summary>
        public bool suppressMarkers { get; set; }
        /// <summary>
        ///Suppress the rendering of polylines.
        /// </summary>
        public bool suppressPolylines { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.DirectionsService")]
    public class DirectionsService
    {
        /// <summary>
        ///Creates a new instance of a DirectionsService that sends directions queries to Google servers.
        /// </summary>
        public DirectionsService() { }
        /// <summary>
        ///Issue a directions search request.
        /// </summary>
        public void route() { }
    }
    [JsType(JsMode.Json)]
    public class DirectionsRequest
    {
        /// <summary>
        ///If true, instructs the Directions service to avoid highways where possible. Optional.
        /// </summary>
        public bool avoidHighways { get; set; }
        /// <summary>
        ///If true, instructs the Directions service to avoid toll roads where possible. Optional.
        /// </summary>
        public bool avoidTolls { get; set; }
        /// <summary>
        ///Location of destination. This can be specified as either a JsString to be geocoded or a LatLng. Required.
        /// </summary>
        public object destination { get; set; }
        /// <summary>
        ///Whether or not we should provide trip duration based on current traffic conditions. Only available to Maps API for Business customers.
        /// </summary>
        public bool durationInTraffic { get; set; }
        /// <summary>
        ///If set to true, the DirectionService will attempt to re-order the supplied intermediate waypoints to minimize overall cost of the route. If waypoints are optimized, inspect DirectionsRoute.waypoint_order in the response to determine the new ordering.
        /// </summary>
        public bool optimizeWaypoints { get; set; }
        /// <summary>
        ///Location of origin. This can be specified as either a JsString to be geocoded or a LatLng. Required.
        /// </summary>
        public object origin { get; set; }
        /// <summary>
        ///Whether or not route alternatives should be provided. Optional.
        /// </summary>
        public bool provideRouteAlternatives { get; set; }
        /// <summary>
        ///Region code used as a bias for geocoding requests. Optional.
        /// </summary>
        public JsString region { get; set; }
        /// <summary>
        ///Settings that apply only to requests where travelMode is TRANSIT. This object will have no effect for other travel modes.
        /// </summary>
        public TransitOptions transitOptions { get; set; }
        /// <summary>
        ///Type of routing requested. Required.
        /// </summary>
        public TravelMode travelMode { get; set; }
        /// <summary>
        ///Preferred unit system to use when displaying distance. Defaults to the unit system used in the country of origin.
        /// </summary>
        public UnitSystem unitSystem { get; set; }
        /// <summary>
        ///Array of intermediate waypoints. Directions will be calculated from the origin to the destination by way of each waypoint in this array. The maximum allowed waypoints is 8, plus the origin, and destination. Maps API for Business customers are allowed 23 waypoints, plus the origin, and destination. Waypoints are not supported for transit directions. Optional.
        /// </summary>
        public JsArray<DirectionsWaypoint> waypoints { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.TravelMode")]
    public class TravelMode
    {
        /// <summary>
        ///Specifies a bicycling directions request.
        /// </summary>
        public static object BICYCLING { get; private set; }
        /// <summary>
        ///Specifies a driving directions request.
        /// </summary>
        public static object DRIVING { get; private set; }
        /// <summary>
        ///Specifies a transit directions request.
        /// </summary>
        public static object TRANSIT { get; private set; }
        /// <summary>
        ///Specifies a walking directions request.
        /// </summary>
        public static object WALKING { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.UnitSystem")]
    public class UnitSystem
    {
        /// <summary>
        ///Specifies that distances in the DirectionsResult should be expressed in imperial units.
        /// </summary>
        public static object IMPERIAL { get; private set; }
        /// <summary>
        ///Specifies that distances in the DirectionsResult should be expressed in metric units.
        /// </summary>
        public static object METRIC { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class TransitOptions
    {
        /// <summary>
        ///The desired arrival time for the route, specified as a Date object. The Date object measures time in milliseconds since 1 January 1970. If arrival time is specified, departure time is ignored.
        /// </summary>
        public JsDate arrivalTime { get; set; }
        /// <summary>
        ///The desired departure time for the route, specified as a Date object. The Date object measures time in milliseconds since 1 January 1970. If neither departure time nor arrival time is specified, the time is assumed to be "now".
        /// </summary>
        public JsDate departureTime { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DirectionsWaypoint
    {
        /// <summary>
        ///Waypoint location. Can be an address JsString or LatLng. Optional.
        /// </summary>
        public object location { get; set; }
        /// <summary>
        ///If true, indicates that this waypoint is a stop between the origin and destination. This has the effect of splitting the route into two. This value is true by default. Optional.
        /// </summary>
        public bool stopover { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.DirectionsStatus")]
    public class DirectionsStatus
    {
        /// <summary>
        ///The DirectionsRequest provided was invalid.
        /// </summary>
        public static object INVALID_REQUEST { get; private set; }
        /// <summary>
        ///Too many DirectionsWaypoints were provided in the DirectionsRequest. The total allowed waypoints is 8, plus the origin and destination. Maps API for Business customers are allowed 23 waypoints, plus the origin, and destination.
        /// </summary>
        public static object MAX_WAYPOINTS_EXCEEDED { get; private set; }
        /// <summary>
        ///At least one of the origin, destination, or waypoints could not be geocoded.
        /// </summary>
        public static object NOT_FOUND { get; private set; }
        /// <summary>
        ///The response contains a valid DirectionsResult.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The webpage has gone over the requests limit in too short a period of time.
        /// </summary>
        public static object OVER_QUERY_LIMIT { get; private set; }
        /// <summary>
        ///The webpage is not allowed to use the directions service.
        /// </summary>
        public static object REQUEST_DENIED { get; private set; }
        /// <summary>
        ///A directions request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
        /// <summary>
        ///No route could be found between the origin and destination.
        /// </summary>
        public static object ZERO_RESULTS { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class DirectionsResult
    {
        /// <summary>
        ///An array of DirectionsRoutes, each of which contains information about the legs and steps of which it is composed. There will only be one route unless the DirectionsRequest was made with provideRouteAlternatives set to true.
        /// </summary>
        public JsArray<DirectionsRoute> routes { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DirectionsRoute
    {
        /// <summary>
        ///The bounds for this route.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///Copyrights text to be displayed for this route.
        /// </summary>
        public JsString copyrights { get; set; }
        /// <summary>
        ///An array of DirectionsLegs, each of which contains information about the steps of which it is composed. There will be one leg for each waypoint or destination specified. So a route with no waypoints will contain one DirectionsLeg and a route with one waypoint will contain two.
        /// </summary>
        public JsArray<DirectionsLeg> legs { get; set; }
        /// <summary>
        ///An array of LatLngs representing the entire course of this route. The path is simplified in order to make it suitable in contexts where a small number of vertices is required (such as Static Maps API URLs).
        /// </summary>
        public JsArray<LatLng> overview_path { get; set; }
        /// <summary>
        ///Warnings to be displayed when showing these directions.
        /// </summary>
        public JsArray<JsString> warnings { get; set; }
        /// <summary>
        ///If optimizeWaypoints was set to true, this field will contain the re-ordered permutation of the input waypoints. For example, if the input was:   Origin: Los Angeles   Waypoints: Dallas, Bangor, Phoenix   Destination: New York and the optimized output was ordered as follows:   Origin: Los Angeles   Waypoints: Phoenix, Dallas, Bangor   Destination: New York then this field will be an Array containing the values [2, 0, 1]. Note that the numbering of waypoints is zero-based. If any of the input waypoints has stopover set to false, this field will be empty, since route optimization is not available for such queries.
        /// </summary>
        public JsArray<JsNumber> waypoint_order { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DirectionsLeg
    {
        /// <summary>
        ///An estimated arrival time for this leg. Only applicable for TRANSIT requests.
        /// </summary>
        public Time arrival_time { get; set; }
        /// <summary>
        ///An estimated departure time for this leg. Only applicable for TRANSIT requests.
        /// </summary>
        public Time departure_time { get; set; }
        /// <summary>
        ///The total distance covered by this leg. This property may be undefined as the distance may be unknown.
        /// </summary>
        public Distance distance { get; set; }
        /// <summary>
        ///The total duration of this leg. This property may be undefined as the duration may be unknown.
        /// </summary>
        public Duration duration { get; set; }
        /// <summary>
        ///The address of the destination of this leg.
        /// </summary>
        public JsString end_address { get; set; }
        /// <summary>
        ///The DirectionsService calculates directions between locations by using the nearest transportation option (usually a road) at the start and end locations. end_location indicates the actual geocoded destination, which may be different than the end_location of the last step if, for example, the road is not near the destination of this leg.
        /// </summary>
        public LatLng end_location { get; set; }
        /// <summary>
        ///The address of the origin of this leg.
        /// </summary>
        public JsString start_address { get; set; }
        /// <summary>
        ///The DirectionsService calculates directions between locations by using the nearest transportation option (usually a road) at the start and end locations. start_location indicates the actual geocoded origin, which may be different than the start_location of the first step if, for example, the road is not near the origin of this leg.
        /// </summary>
        public LatLng start_location { get; set; }
        /// <summary>
        ///An array of DirectionsSteps, each of which contains information about the individual steps in this leg.
        /// </summary>
        public JsArray<DirectionsStep> steps { get; set; }
        /// <summary>
        ///An array of waypoints along this leg that were not specified in the original request, either as a result of a user dragging the polyline or selecting an alternate route.
        /// </summary>
        public JsArray<LatLng> via_waypoints { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DirectionsStep
    {
        /// <summary>
        ///The distance covered by this step. This property may be undefined as the distance may be unknown.
        /// </summary>
        public Distance distance { get; set; }
        /// <summary>
        ///The typical time required to perform this step in seconds and in text form. This property may be undefined as the duration may be unknown.
        /// </summary>
        public Duration duration { get; set; }
        /// <summary>
        ///The ending location of this step.
        /// </summary>
        public LatLng end_location { get; set; }
        /// <summary>
        ///Instructions for this step.
        /// </summary>
        public JsString instructions { get; set; }
        /// <summary>
        ///A sequence of LatLngs describing the course of this step.
        /// </summary>
        public JsArray<LatLng> path { get; set; }
        /// <summary>
        ///The starting location of this step.
        /// </summary>
        public LatLng start_location { get; set; }
        /// <summary>
        ///Sub-steps of this step. Specified for non-transit sections of transit routes.
        /// </summary>
        public DirectionsStep steps { get; set; }
        /// <summary>
        ///Transit-specific details about this step. This property will be undefined unless the travel mode of this step is TRANSIT.
        /// </summary>
        public TransitDetails transit { get; set; }
        /// <summary>
        ///The mode of travel used in this step.
        /// </summary>
        public TravelMode travel_mode { get; set; }
    }
    [JsType(JsMode.Json)]
    public class Distance
    {
        /// <summary>
        ///A JsString representation of the distance value, using the UnitSystem specified in the request.
        /// </summary>
        public JsString text { get; set; }
        /// <summary>
        ///The distance in meters.
        /// </summary>
        public JsNumber value { get; set; }
    }
    [JsType(JsMode.Json)]
    public class Duration
    {
        /// <summary>
        ///A JsString representation of the duration value.
        /// </summary>
        public JsString text { get; set; }
        /// <summary>
        ///The duration in seconds.
        /// </summary>
        public JsNumber value { get; set; }
    }
    [JsType(JsMode.Json)]
    public class Time
    {
        /// <summary>
        ///A JsString representing the time's value. The time is displayed in the time zone of the transit stop.
        /// </summary>
        public JsString text { get; set; }
        /// <summary>
        ///The time zone in which this stop lies. The value is the name of the time zone as defined in the IANA Time Zone Database, e.g. "America/New_York".
        /// </summary>
        public JsString time_zone { get; set; }
        /// <summary>
        ///The time of this departure or arrival, specified as a JavaScript Date object.
        /// </summary>
        public JsDate value { get; set; }
    }
    [JsType(JsMode.Json)]
    public class TransitDetails
    {
        /// <summary>
        ///The arrival stop of this transit step.
        /// </summary>
        public TransitStop arrival_stop { get; set; }
        /// <summary>
        ///The arrival time of this step, specified as a Time object.
        /// </summary>
        public Time arrival_time { get; set; }
        /// <summary>
        ///The departure stop of this transit step.
        /// </summary>
        public TransitStop departure_stop { get; set; }
        /// <summary>
        ///The departure time of this step, specified as a Time object.
        /// </summary>
        public Time departure_time { get; set; }
        /// <summary>
        ///The direction in which to travel on this line, as it is marked on the vehicle or at the departure stop.
        /// </summary>
        public JsString headsign { get; set; }
        /// <summary>
        ///The expected number of seconds between equivalent vehicles at this stop.
        /// </summary>
        public JsNumber headway { get; set; }
        /// <summary>
        ///Details about the transit line used in this step.
        /// </summary>
        public TransitLine line { get; set; }
        /// <summary>
        ///The number of stops on this step. Includes the arrival stop, but not the departure stop.
        /// </summary>
        public JsNumber num_stops { get; set; }
    }
    [JsType(JsMode.Json)]
    public class TransitStop
    {
        /// <summary>
        ///The location of this stop.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The name of this transit stop.
        /// </summary>
        public JsString name { get; set; }
    }
    [JsType(JsMode.Json)]
    public class TransitLine
    {
        /// <summary>
        ///The transit agency that operates this transit line.
        /// </summary>
        public JsArray<TransitAgency> agencies { get; set; }
        /// <summary>
        ///The color commonly used in signage for this transit line, represented as a hex JsString.
        /// </summary>
        public JsString color { get; set; }
        /// <summary>
        ///The URL for an icon associated with this line.
        /// </summary>
        public JsString icon { get; set; }
        /// <summary>
        ///The full name of this transit line, e.g. "8 Avenue Local".
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The short name of this transit line, e.g. "E".
        /// </summary>
        public JsString short_name { get; set; }
        /// <summary>
        ///The text color commonly used in signage for this transit line, represented as a hex JsString.
        /// </summary>
        public JsString text_color { get; set; }
        /// <summary>
        ///The agency's URL which is specific to this transit line.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        ///The type of vehicle used, e.g. train or bus.
        /// </summary>
        public TransitVehicle vehicle { get; set; }
    }
    [JsType(JsMode.Json)]
    public class TransitAgency
    {
        /// <summary>
        ///The name of this transit agency.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The transit agency's phone number.
        /// </summary>
        public JsString phone { get; set; }
        /// <summary>
        ///The transit agency's URL.
        /// </summary>
        public JsString url { get; set; }
    }
    [JsType(JsMode.Json)]
    public class TransitVehicle
    {
        /// <summary>
        ///A URL for an icon that corresponds to the type of vehicle used on this line.
        /// </summary>
        public JsString icon { get; set; }
        /// <summary>
        ///A URL for an icon that corresponds to the type of vehicle used in this region instead of the more general icon.
        /// </summary>
        public JsString local_icon { get; set; }
        /// <summary>
        ///A name for this type of TransitVehicle, e.g. "Train" or "Bus".
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The type of vehicle used, e.g. train, bus, or ferry.
        /// </summary>
        public VehicleType type { get; set; }
    }
    [JsType(JsMode.Json)]
    public class VehicleType
    {
        /// <summary>
        ///Bus.
        /// </summary>
        public static object BUS { get; private set; }
        /// <summary>
        ///A vehicle that operates on a cable, usually on the ground. Aerial cable cars may be of the type GONDOLA_LIFT.
        /// </summary>
        public static object CABLE_CAR { get; private set; }
        /// <summary>
        ///Commuter rail.
        /// </summary>
        public static object COMMUTER_TRAIN { get; private set; }
        /// <summary>
        ///Ferry.
        /// </summary>
        public static object FERRY { get; private set; }
        /// <summary>
        ///A vehicle that is pulled up a steep incline by a cable.
        /// </summary>
        public static object FUNICULAR { get; private set; }
        /// <summary>
        ///An aerial cable car.
        /// </summary>
        public static object GONDOLA_LIFT { get; private set; }
        /// <summary>
        ///Heavy rail.
        /// </summary>
        public static object HEAVY_RAIL { get; private set; }
        /// <summary>
        ///High speed train.
        /// </summary>
        public static object HIGH_SPEED_TRAIN { get; private set; }
        /// <summary>
        ///Intercity bus.
        /// </summary>
        public static object INTERCITY_BUS { get; private set; }
        /// <summary>
        ///Light rail.
        /// </summary>
        public static object METRO_RAIL { get; private set; }
        /// <summary>
        ///Monorail.
        /// </summary>
        public static object MONORAIL { get; private set; }
        /// <summary>
        ///Other vehicles.
        /// </summary>
        public static object OTHER { get; private set; }
        /// <summary>
        ///Rail.
        /// </summary>
        public static object RAIL { get; private set; }
        /// <summary>
        ///Share taxi is a sort of bus transport with ability to drop off and pick up passengers anywhere on its route. Generally share taxi uses minibus vehicles.
        /// </summary>
        public static object SHARE_TAXI { get; private set; }
        /// <summary>
        ///Underground light rail.
        /// </summary>
        public static object SUBWAY { get; private set; }
        /// <summary>
        ///Above ground light rail.
        /// </summary>
        public static object TRAM { get; private set; }
        /// <summary>
        ///Trolleybus.
        /// </summary>
        public static object TROLLEYBUS { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.ElevationService")]
    public class ElevationService
    {
        /// <summary>
        ///Creates a new instance of a ElevationService that sends elevation queries to Google servers.
        /// </summary>
        public ElevationService() { }
        /// <summary>
        ///Makes an elevation request along a path, where the elevation data are returned as distance-based samples along that path.
        /// </summary>
        public void getElevationAlongPath() { }
        /// <summary>
        ///Makes an elevation request for a list of discrete locations.
        /// </summary>
        public void getElevationForLocations() { }
    }
    [JsType(JsMode.Json)]
    public class LocationElevationRequest
    {
        /// <summary>
        ///The discrete locations for which to retrieve elevations.
        /// </summary>
        public JsArray<LatLng> locations { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PathElevationRequest
    {
        /// <summary>
        ///The path along which to collect elevation values.
        /// </summary>
        public JsArray<LatLng> path { get; set; }
        /// <summary>
        ///Required. The number of equidistant points along the given path for which to retrieve elevation data, including the endpoints. The number of samples must be a value between 2 and 512 inclusive.
        /// </summary>
        public JsNumber samples { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ElevationResult
    {
        /// <summary>
        ///The elevation of this point on Earth, in meters above sea level.
        /// </summary>
        public JsNumber elevation { get; set; }
        /// <summary>
        ///The location of this elevation result.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The distance, in meters, between sample points from which the elevation was interpolated. This property will be missing if the resolution is not known. Note that elevation data becomes more coarse (larger resolution values) when multiple points are passed. To obtain the most accurate elevation value for a point, it should be queried independently.
        /// </summary>
        public JsNumber resolution { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.ElevationStatus")]
    public class ElevationStatus
    {
        /// <summary>
        ///This request was invalid.
        /// </summary>
        public static object INVALID_REQUEST { get; private set; }
        /// <summary>
        ///The request did not encounter any errors.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The webpage has gone over the requests limit in too short a period of time.
        /// </summary>
        public static object OVER_QUERY_LIMIT { get; private set; }
        /// <summary>
        ///The webpage is not allowed to use the elevation service for some reason.
        /// </summary>
        public static object REQUEST_DENIED { get; private set; }
        /// <summary>
        ///A geocoding, directions or elevation request could not be successfully processed, yet the exact reason for the failure is not known.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MaxZoomService")]
    public class MaxZoomService
    {
        /// <summary>
        ///Creates a new instance of a MaxZoomService that can be used to send queries about the maximum zoom level available for satellite imagery.
        /// </summary>
        public MaxZoomService() { }
        /// <summary>
        ///Returns the maximum zoom level available at a particular LatLng for the Satellite map type. As this request is asynchronous, you must pass a callback function which will be executed upon completion of the request, being passed a MaxZoomResult.
        /// </summary>
        public void getMaxZoomAtLatLng() { }
    }
    [JsType(JsMode.Json)]
    public class MaxZoomResult
    {
        /// <summary>
        ///Status of the request.
        /// </summary>
        public MaxZoomStatus status { get; set; }
        /// <summary>
        ///The maximum zoom level found at the given LatLng.
        /// </summary>
        public JsNumber zoom { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MaxZoomStatus")]
    public class MaxZoomStatus
    {
        /// <summary>
        ///There was a problem contacting the Google servers.
        /// </summary>
        public static object ERROR { get; private set; }
        /// <summary>
        ///The response contains a valid MaxZoomResult.
        /// </summary>
        public static object OK { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.DistanceMatrixService")]
    public class DistanceMatrixService
    {
        /// <summary>
        ///Creates a new instance of a DistanceMatrixService that sends distance matrix queries to Google servers.
        /// </summary>
        public DistanceMatrixService() { }
        /// <summary>
        ///Issues a distance matrix request.
        /// </summary>
        public void getDistanceMatrix() { }
    }
    [JsType(JsMode.Json)]
    public class DistanceMatrixRequest
    {
        /// <summary>
        ///If true, instructs the Distance Matrix service to avoid highways where possible. Optional.
        /// </summary>
        public bool avoidHighways { get; set; }
        /// <summary>
        ///If true, instructs the Distance Matrix service to avoid toll roads where possible. Optional.
        /// </summary>
        public bool avoidTolls { get; set; }
        /// <summary>
        ///An array containing destination address strings and/or LatLngs, to which to calculate distance and time. Required.
        /// </summary>
        public object destinations { get; set; }
        /// <summary>
        ///An array containing origin address strings and/or LatLngs, from which to calculate distance and time. Required.
        /// </summary>
        public object origins { get; set; }
        /// <summary>
        ///Region code used as a bias for geocoding requests. Optional.
        /// </summary>
        public JsString region { get; set; }
        /// <summary>
        ///Type of routing requested. Required.
        /// </summary>
        public TravelMode travelMode { get; set; }
        /// <summary>
        ///Preferred unit system to use when displaying distance. Optional; defaults to metric.
        /// </summary>
        public UnitSystem unitSystem { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DistanceMatrixResponse
    {
        /// <summary>
        ///The formatted destination addresses.
        /// </summary>
        public JsArray<JsString> destinationAddresses { get; set; }
        /// <summary>
        ///The formatted origin addresses.
        /// </summary>
        public JsArray<JsString> originAddresses { get; set; }
        /// <summary>
        ///The rows of the matrix, corresponding to the origin addresses.
        /// </summary>
        public JsArray<DistanceMatrixResponseRow> rows { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DistanceMatrixResponseRow
    {
        /// <summary>
        ///The row's elements, corresponding to the destination addresses.
        /// </summary>
        public JsArray<DistanceMatrixResponseElement> elements { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DistanceMatrixResponseElement
    {
        /// <summary>
        ///The distance for this origin-destination pairing. This property may be undefined as the distance may be unknown.
        /// </summary>
        public Distance distance { get; set; }
        /// <summary>
        ///The duration for this origin-destination pairing. This property may be undefined as the duration may be unknown.
        /// </summary>
        public Duration duration { get; set; }
        /// <summary>
        ///The status of this particular origin-destination pairing.
        /// </summary>
        public DistanceMatrixElementStatus status { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.DistanceMatrixStatus")]
    public class DistanceMatrixStatus
    {
        /// <summary>
        ///The provided request was invalid.
        /// </summary>
        public static object INVALID_REQUEST { get; private set; }
        /// <summary>
        ///The request contains more than 25 origins, or more than 25 destinations.
        /// </summary>
        public static object MAX_DIMENSIONS_EXCEEDED { get; private set; }
        /// <summary>
        ///The product of origins and destinations exceeds the per-query limit.
        /// </summary>
        public static object MAX_ELEMENTS_EXCEEDED { get; private set; }
        /// <summary>
        ///The response contains a valid result.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///Too many elements have been requested within the allowed time period. The request should succeed if you try again after a reasonable amount of time.
        /// </summary>
        public static object OVER_QUERY_LIMIT { get; private set; }
        /// <summary>
        ///The service denied use of the Distance Matrix service by your web page.
        /// </summary>
        public static object REQUEST_DENIED { get; private set; }
        /// <summary>
        ///A Distance Matrix request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.DistanceMatrixElementStatus")]
    public class DistanceMatrixElementStatus
    {
        /// <summary>
        ///The origin and/or destination of this pairing could not be geocoded.
        /// </summary>
        public static object NOT_FOUND { get; private set; }
        /// <summary>
        ///The response contains a valid result.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///No route could be found between the origin and destination.
        /// </summary>
        public static object ZERO_RESULTS { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class MapType
    {
        /// <summary>
        ///Returns a tile for the given tile coordinate (x, y) and zoom level. This tile will be appended to the given ownerDocument. Not available for base map types.
        /// </summary>
        public Node getTile(Point tileCoord, JsNumber zoom, Document ownerDocument) { return null; }
        /// <summary>
        ///Releases the given tile, performing any necessary cleanup. The provided tile will have already been removed from the document. Optional.
        /// </summary>
        public void releaseTile(Node tile) { }
        /// <summary>
        ///Alt text to display when this MapType's button is hovered over in the MapTypeControl. Optional.
        /// </summary>
        public JsString alt { get; set; }
        /// <summary>
        ///The maximum zoom level for the map when displaying this MapType. Required for base MapTypes, ignored for overlay MapTypes.
        /// </summary>
        public JsNumber maxZoom { get; set; }
        /// <summary>
        ///The minimum zoom level for the map when displaying this MapType. Optional; defaults to 0.
        /// </summary>
        public JsNumber minZoom { get; set; }
        /// <summary>
        ///Name to display in the MapTypeControl. Optional.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The Projection used to render this MapType. Optional; defaults to Mercator.
        /// </summary>
        public Projection projection { get; set; }
        /// <summary>
        ///Radius of the planet for the map, in meters. Optional; defaults to Earth's equatorial radius of 6378137 meters.
        /// </summary>
        public JsNumber radius { get; set; }
        /// <summary>
        ///The dimensions of each tile. Required.
        /// </summary>
        public Size tileSize { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MapTypeRegistry")]
    public class MapTypeRegistry
    {
        /// <summary>
        ///The MapTypeRegistry holds the collection of custom map types available to the map for its use. The API consults this registry when providing the list of avaiable map types within controls, for example.
        /// </summary>
        public MapTypeRegistry() { }
        /// <summary>
        ///Sets the registry to associate the passed JsString identifier with the passed MapType.
        /// </summary>
        public void set(JsString id, MapType mapType) { }
    }
    [JsType(JsMode.Json)]
    public class Projection
    {
        /// <summary>
        ///Translates from the LatLng cylinder to the Point plane. This interface specifies a function which implements translation from given LatLng values to world coordinates on the map projection. The Maps API calls this method when it needs to plot locations on screen. Projection objects must implement this method.
        /// </summary>
        public Point fromLatLngToPoint(LatLng latLng, Point point = null) { return null; }
        /// <summary>
        ///This interface specifies a function which implements translation from world coordinates on a map projection to LatLng values. The Maps API calls this method when it needs to translate actions on screen to positions on the map. Projection objects must implement this method.
        /// </summary>
        public LatLng fromPointToLatLng(Point pixel, bool nowrap = false) { return null; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.ImageMapType")]
    public class ImageMapType
    {
        /// <summary>
        ///Constructs an ImageMapType using the provided ImageMapTypeOptions
        /// </summary>
        public ImageMapType(ImageMapTypeOptions opts) { }
        /// <summary>
        ///Returns the opacity level (0 (transparent) to 1.0) of the ImageMapType tiles.
        /// </summary>
        public JsNumber getOpacity() { return null; }
        /// <summary>
        ///Sets the opacity level (0 (transparent) to 1.0) of the ImageMapType tiles.
        /// </summary>
        public void setOpacity(JsNumber opacity) { }
        /// <summary>
        ///This event is fired when the visible tiles have finished loading.
        /// </summary>
        public JsAction tilesloaded { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ImageMapTypeOptions
    {
        /// <summary>
        ///Alt text to display when this MapType's button is hovered over in the MapTypeControl.
        /// </summary>
        public JsString alt { get; set; }
        /// <summary>
        ///Returns a JsString (URL) for given tile coordinate (x, y) and zoom level. This function should have a signature of: getTileUrl(Point, number):JsString
        /// </summary>
        public JsFunc<Point, JsNumber, JsString> getTileUrl { get; set; }
        /// <summary>
        ///The maximum zoom level for the map when displaying this MapType.
        /// </summary>
        public JsNumber maxZoom { get; set; }
        /// <summary>
        ///The minimum zoom level for the map when displaying this MapType. Optional.
        /// </summary>
        public JsNumber minZoom { get; set; }
        /// <summary>
        ///Name to display in the MapTypeControl.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The opacity to apply to the tiles. The opacity should be specified as a float value between 0 and 1.0, where 0 is fully transparent and 1 is fully opaque.
        /// </summary>
        public JsNumber opacity { get; set; }
        /// <summary>
        ///The tile size.
        /// </summary>
        public Size tileSize { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.StyledMapType")]
    public class StyledMapType
    {
        /// <summary>
        ///Creates a styled MapType with the specified options. The StyledMapType takes an array of MapTypeStyles, where each MapTypeStyle is applied to the map consecutively. A later MapTypeStyle that applies the same MapTypeStylers to the same selectors as an earlier MapTypeStyle will override the earlier MapTypeStyle.
        /// </summary>
        public StyledMapType(JsArray<MapTypeStyle> styles, StyledMapTypeOptions options = null) { }
    }
    [JsType(JsMode.Json)]
    public class StyledMapTypeOptions
    {
        /// <summary>
        ///Text to display when this MapType's button is hovered over in the map type control.
        /// </summary>
        public JsString alt { get; set; }
        /// <summary>
        ///The maximum zoom level for the map when displaying this MapType. Optional.
        /// </summary>
        public JsNumber maxZoom { get; set; }
        /// <summary>
        ///The minimum zoom level for the map when displaying this MapType. Optional.
        /// </summary>
        public JsNumber minZoom { get; set; }
        /// <summary>
        ///The name to display in the map type control.
        /// </summary>
        public JsString name { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapTypeStyle
    {
        /// <summary>
        ///Selects the element type to which a styler should be applied. An element type distinguishes between the different representations of a feature. Optional; if elementType is not specified, the value is assumed to be 'all'.
        /// </summary>
        public MapTypeStyleElementType elementType { get; set; }
        /// <summary>
        ///Selects the feature, or group of features, to which a styler should be applied. Optional; if featureType is not specified, the value is assumed to be 'all'.
        /// </summary>
        public MapTypeStyleFeatureType featureType { get; set; }
        /// <summary>
        ///The style rules to apply to the selectors. The rules are applied to the map's elements in the order they are listed in this array.
        /// </summary>
        public JsArray<MapTypeStyler> stylers { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapTypeStyleFeatureType
    {
        /// <summary>
        ///Apply the rule to administrative areas.
        /// </summary>
        public static object administrative { get; private set; }
        ///// <summary>
        /////Apply the rule to countries.
        ///// </summary>
        //public static object administrative.country{get; private set;}
        ///// <summary>
        /////Apply the rule to land parcels.
        ///// </summary>
        //public static object administrative.land_parcel{get; private set;}
        ///// <summary>
        /////Apply the rule to localities.
        ///// </summary>
        //public static object administrative.locality{get; private set;}
        ///// <summary>
        /////Apply the rule to neighborhoods.
        ///// </summary>
        //public static object administrative.neighborhood{get; private set;}
        ///// <summary>
        /////Apply the rule to provinces.
        ///// </summary>
        //public static object administrative.province{get; private set;}
        /// <summary>
        ///Apply the rule to all selector types.
        /// </summary>
        public static object all { get; private set; }
        /// <summary>
        ///Apply the rule to landscapes.
        /// </summary>
        public static object landscape { get; private set; }
        ///// <summary>
        /////Apply the rule to man made structures.
        ///// </summary>
        //public static object landscape.man_made{get; private set;}
        ///// <summary>
        /////Apply the rule to natural features.
        ///// </summary>
        //public static object landscape.natural{get; private set;}
        ///// <summary>
        /////Apply the rule to landcover.
        ///// </summary>
        //public static object landscape.natural.landcover{get; private set;}
        ///// <summary>
        /////Apply the rule to terrain.
        ///// </summary>
        //public static object landscape.natural.terrain{get; private set;}
        /// <summary>
        ///Apply the rule to points of interest.
        /// </summary>
        public static object poi { get; private set; }
        ///// <summary>
        /////Apply the rule to attractions for tourists.
        ///// </summary>
        //public static object poi.attraction{get; private set;}
        ///// <summary>
        /////Apply the rule to businesses.
        ///// </summary>
        //public static object poi.business{get; private set;}
        ///// <summary>
        /////Apply the rule to government buildings.
        ///// </summary>
        //public static object poi.government{get; private set;}
        ///// <summary>
        /////Apply the rule to emergency services (hospitals, pharmacies, police, doctors, etc).
        ///// </summary>
        //public static object poi.medical{get; private set;}
        ///// <summary>
        /////Apply the rule to parks.
        ///// </summary>
        //public static object poi.park{get; private set;}
        ///// <summary>
        /////Apply the rule to places of worship, such as church, temple, or mosque.
        ///// </summary>
        //public static object poi.place_of_worship{get; private set;}
        ///// <summary>
        /////Apply the rule to schools.
        ///// </summary>
        //public static object poi.school{get; private set;}
        ///// <summary>
        /////Apply the rule to sports complexes.
        ///// </summary>
        //public static object poi.sports_complex{get; private set;}
        /// <summary>
        ///Apply the rule to all roads.
        /// </summary>
        public static object road { get; private set; }
        ///// <summary>
        /////Apply the rule to arterial roads.
        ///// </summary>
        //public static object road.arterial{get; private set;}
        ///// <summary>
        /////Apply the rule to highways.
        ///// </summary>
        //public static object road.highway{get; private set;}
        ///// <summary>
        /////Apply the rule to controlled-access highways.
        ///// </summary>
        //public static object road.highway.controlled_access{get; private set;}
        ///// <summary>
        /////Apply the rule to local roads.
        ///// </summary>
        //public static object road.local{get; private set;}
        /// <summary>
        ///Apply the rule to all transit stations and lines.
        /// </summary>
        public static object transit { get; private set; }
        ///// <summary>
        /////Apply the rule to transit lines.
        ///// </summary>
        //public static object transit.line{get; private set;}
        ///// <summary>
        /////Apply the rule to all transit stations.
        ///// </summary>
        //public static object transit.station{get; private set;}
        ///// <summary>
        /////Apply the rule to airports.
        ///// </summary>
        //public static object transit.station.airport{get; private set;}
        ///// <summary>
        /////Apply the rule to bus stops.
        ///// </summary>
        //public static object transit.station.bus{get; private set;}
        ///// <summary>
        /////Apply the rule to rail stations.
        ///// </summary>
        //public static object transit.station.rail{get; private set;}
        /// <summary>
        ///Apply the rule to bodies of water.
        /// </summary>
        public static object water { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class MapTypeStyleElementType
    {
        /// <summary>
        ///Apply the rule to all elements of the specified feature.
        /// </summary>
        public static object all { get; private set; }
        /// <summary>
        ///Apply the rule to the feature's geometry.
        /// </summary>
        public static object geometry { get; private set; }
        ///// <summary>
        /////Apply the rule to the fill of the feature's geometry.
        ///// </summary>
        //public static object geometry.fill{get; private set;}
        ///// <summary>
        /////Apply the rule to the stroke of the feature's geometry.
        ///// </summary>
        //public static object geometry.stroke{get; private set;}
        /// <summary>
        ///Apply the rule to the feature's labels.
        /// </summary>
        public static object labels { get; private set; }
        ///// <summary>
        /////Apply the rule to icons within the feature's labels.
        ///// </summary>
        //public static object labels.icon{get; private set;}
        ///// <summary>
        /////Apply the rule to the text in the feature's label.
        ///// </summary>
        //public static object labels.text{get; private set;}
        ///// <summary>
        /////Apply the rule to the fill of the text in the feature's labels.
        ///// </summary>
        //public static object labels.text.fill{get; private set;}
        ///// <summary>
        /////Apply the rule to the stroke of the text in the feature's labels.
        ///// </summary>
        //public static object labels.text.stroke{get; private set;}
    }
    [JsType(JsMode.Json)]
    public class MapTypeStyler
    {
        /// <summary>
        ///Sets the color of the feature. Valid values: An RGB hex JsString, i.e. '#ff0000'.
        /// </summary>
        public JsString color { get; set; }
        /// <summary>
        ///Modifies the gamma by raising the lightness to the given power. Valid values: Floating point numbers, [0.01, 10], with 1.0 representing no change.
        /// </summary>
        public JsNumber gamma { get; set; }
        /// <summary>
        ///Sets the hue of the feature to match the hue of the color supplied. Note that the saturation and lightness of the feature is conserved, which means that the feature will not match the color supplied exactly. Valid values: An RGB hex JsString, i.e. '#ff0000'.
        /// </summary>
        public JsString hue { get; set; }
        /// <summary>
        ///A value of true will invert the lightness of the feature while preserving the hue and saturation.
        /// </summary>
        public bool invert_lightness { get; set; }
        /// <summary>
        ///Shifts lightness of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public JsNumber lightness { get; set; }
        /// <summary>
        ///Shifts the saturation of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public JsNumber saturation { get; set; }
        /// <summary>
        ///Sets the visibility of the feature. Valid values: 'on', 'off' or 'simplifed'.
        /// </summary>
        public JsString visibility { get; set; }
        /// <summary>
        ///Sets the weight of the feature, in pixels. Valid values: Integers greater than or equal to zero.
        /// </summary>
        public JsNumber weight { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.BicyclingLayer")]
    public class BicyclingLayer
    {
        /// <summary>
        ///A layer that displays bike lanes and paths and demotes large roads.
        /// </summary>
        public BicyclingLayer() { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.FusionTablesLayer")]
    public class FusionTablesLayer
    {
        /// <summary>
        ///A layer that displays data from a Fusion Table.
        /// </summary>
        public FusionTablesLayer(FusionTablesLayerOptions options) { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(FusionTablesLayerOptions options) { }
        /// <summary>
        ///This event is fired when a feature in the layer is clicked.
        /// </summary>
        public JsAction<FusionTablesMouseEvent> click { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesLayerOptions
    {
        /// <summary>
        ///If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///Options which define the appearance of the layer as a heatmap.
        /// </summary>
        public FusionTablesHeatmap heatmap { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///Options defining the data to display.
        /// </summary>
        public FusionTablesQuery query { get; set; }
        /// <summary>
        ///An array of up to 5 style specifications, which control the appearance of features within the layer.
        /// </summary>
        public JsArray<FusionTablesStyle> styles { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows when layer features are clicked.
        /// </summary>
        public bool suppressInfoWindows { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesQuery
    {
        /// <summary>
        ///The ID of the Fusion Tables table to display. This ID can be found in the table's URL, as the value of the dsrcid parameter. Required.
        /// </summary>
        public JsString from { get; set; }
        /// <summary>
        ///Limit on the number of results returned by the query.
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        ///Offset into the sorted results.
        /// </summary>
        public JsNumber offset { get; set; }
        /// <summary>
        ///The method by which to sort the results. Accepts either of: A column name. The column name may be suffixed with ASC or DESC (e.g. col2 DESC) to specify ascending or descending sort. An ST_DISTANCE spatial relationship (sort by distance). A column and the coordinate from which to calculate distance must be passed, for example, orderBy: 'ST_DISTANCE(col1, LATLNG(1.2, 3.4))'.
        /// </summary>
        public JsString orderBy { get; set; }
        /// <summary>
        ///A column, containing geographic features to be displayed on the map. See Fusion Tables Setup in the Maps API documentation for information about valid columns.
        /// </summary>
        public JsString select { get; set; }
        /// <summary>
        ///The SQL predicate to be applied to the layer.
        /// </summary>
        public JsString where { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesStyle
    {
        /// <summary>
        ///Options which control the appearance of point features.
        /// </summary>
        public FusionTablesMarkerOptions markerOptions { get; set; }
        /// <summary>
        ///Options which control the appearance of polygons.
        /// </summary>
        public FusionTablesPolygonOptions polygonOptions { get; set; }
        /// <summary>
        ///Options which control the appearance of polylines.
        /// </summary>
        public FusionTablesPolylineOptions polylineOptions { get; set; }
        /// <summary>
        ///The SQL predicate to be applied to the layer.
        /// </summary>
        public JsString where { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesHeatmap
    {
        /// <summary>
        ///If true, render the layer as a heatmap.
        /// </summary>
        public bool enabled { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesMarkerOptions
    {
        /// <summary>
        ///The name of a Fusion Tables supported icon
        /// </summary>
        public JsString iconName { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesPolygonOptions
    {
        /// <summary>
        ///The fill color, defined by a six-digit hexadecimal number in RRGGBB format (e.g. #00AAFF).
        /// </summary>
        public JsString fillColor { get; set; }
        /// <summary>
        ///The fill opacity between 0.0 and 1.0.
        /// </summary>
        public JsNumber fillOpacity { get; set; }
        /// <summary>
        ///The fill color, defined by a six-digit hexadecimal number in RRGGBB format (e.g. #00AAFF).
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0.
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The stroke width in pixels, between 0 and 10.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesPolylineOptions
    {
        /// <summary>
        ///The fill color, defined by a six-digit hexadecimal number in RRGGBB format (e.g. #00AAFF).
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0.
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///The stroke width in pixels.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesMouseEvent
    {
        /// <summary>
        ///Pre-rendered HTML content, as placed in the infowindow by the default UI.
        /// </summary>
        public JsString infoWindowHtml { get; set; }
        /// <summary>
        ///The position at which to anchor an infowindow on the clicked feature.
        /// </summary>
        public LatLng latLng { get; set; }
        /// <summary>
        ///The offset to apply to an infowindow anchored on the clicked feature.
        /// </summary>
        public Size pixelOffset { get; set; }
        /// <summary>
        ///A collection of FusionTablesCell objects, indexed by column name, representing the contents of the table row which included the clicked feature.
        /// </summary>
        public JsObject<FusionTablesCell> row { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FusionTablesCell
    {
        /// <summary>
        ///The name of the column in which the cell was located.
        /// </summary>
        public JsString columnName { get; set; }
        /// <summary>
        ///The contents of the cell.
        /// </summary>
        public JsString value { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.KmlLayer")]
    public class KmlLayer
    {
        /// <summary>
        ///Creates a KmlLayer which renders the contents of the specified KML/KMZ file (https://developers.google.com/kml/documentation/kmlreference) or GeoRSS file (http://www.georss.org).
        /// </summary>
        public KmlLayer(KmlLayerOptions opts = null) { }
        /// <summary>
        ///Get the default viewport for the layer being displayed.
        /// </summary>
        public LatLngBounds getDefaultViewport() { return null; }
        /// <summary>
        ///Get the map on which the KML Layer is being rendered.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Get the metadata associated with this layer, as specified in the layer markup.
        /// </summary>
        public KmlLayerMetadata getMetadata() { return null; }
        /// <summary>
        ///Get the status of the layer, set once the requested document has loaded.
        /// </summary>
        public KmlLayerStatus getStatus() { return null; }
        /// <summary>
        ///The URL of the KML file being displayed.
        /// </summary>
        public JsString getUrl() { return null; }
        /// <summary>
        ///Renders the KML Layer on the specified map. If map is set to null, the layer is removed.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Set the URL of the KML file to display.
        /// </summary>
        public void setUrl(JsString url) { }
        /// <summary>
        ///This event is fired when a feature in the layer is clicked.
        /// </summary>
        public JsAction<KmlMouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the KML layers default viewport has changed.
        /// </summary>
        public JsAction defaultviewport_changed { get; set; }
        /// <summary>
        ///This event is fired when the KML layer has finished loading. At this point it is safe to read the status property to determine if the layer loaded successfully.
        /// </summary>
        public JsAction status_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class KmlLayerOptions
    {
        /// <summary>
        ///If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///By default, the input map is centered and zoomed to the bounding box of the contents of the layer. If this option is set to true, the viewport is left unchanged, unless the map's center and zoom were never set.
        /// </summary>
        public bool preserveViewport { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows when layer features are clicked.
        /// </summary>
        public bool suppressInfoWindows { get; set; }
        /// <summary>
        ///The URL of the KML document to display.
        /// </summary>
        public JsString url { get; set; }
    }
    [JsType(JsMode.Json)]
    public class KmlLayerMetadata
    {
        /// <summary>
        ///The layer's -atom:author-, extracted from the layer markup.
        /// </summary>
        public KmlAuthor author { get; set; }
        /// <summary>
        ///The layer's -description-, extracted from the layer markup.
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///The layer's -name-, extracted from the layer markup.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The layer's -Snippet-, extracted from the layer markup
        /// </summary>
        public JsString snippet { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.KmlLayerStatus")]
    public class KmlLayerStatus
    {
        /// <summary>
        ///The document could not be found. Most likely it is an invalid URL, or the document is not publicly available.
        /// </summary>
        public static object DOCUMENT_NOT_FOUND { get; private set; }
        /// <summary>
        ///The document exceeds the file size limits of KmlLayer.
        /// </summary>
        public static object DOCUMENT_TOO_LARGE { get; private set; }
        /// <summary>
        ///The document could not be fetched.
        /// </summary>
        public static object FETCH_ERROR { get; private set; }
        /// <summary>
        ///The document is not a valid KML, KMZ or GeoRSS document.
        /// </summary>
        public static object INVALID_DOCUMENT { get; private set; }
        /// <summary>
        ///The KmlLayer is invalid.
        /// </summary>
        public static object INVALID_REQUEST { get; private set; }
        /// <summary>
        ///The document exceeds the feature limits of KmlLayer.
        /// </summary>
        public static object LIMITS_EXCEEDED { get; private set; }
        /// <summary>
        ///The layer loaded successfully.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The document could not be loaded within a reasonable amount of time.
        /// </summary>
        public static object TIMED_OUT { get; private set; }
        /// <summary>
        ///The document failed to load for an unknown reason.
        /// </summary>
        public static object UNKNOWN { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class KmlMouseEvent
    {
        /// <summary>
        ///A KmlFeatureData object, containing information about the clicked feature.
        /// </summary>
        public KmlFeatureData featureData { get; set; }
        /// <summary>
        ///The position at which to anchor an infowindow on the clicked feature.
        /// </summary>
        public LatLng latLng { get; set; }
        /// <summary>
        ///The offset to apply to an infowindow anchored on the clicked feature.
        /// </summary>
        public Size pixelOffset { get; set; }
    }
    [JsType(JsMode.Json)]
    public class KmlFeatureData
    {
        /// <summary>
        ///The feature's -atom:author-, extracted from the layer markup (if specified).
        /// </summary>
        public KmlAuthor author { get; set; }
        /// <summary>
        ///The feature's -description-, extracted from the layer markup.
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///The feature's -id-, extracted from the layer markup. If no -id- has been specified, a unique ID will be generated for this feature.
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        ///The feature's balloon styled text, if set.
        /// </summary>
        public JsString infoWindowHtml { get; set; }
        /// <summary>
        ///The feature's -name-, extracted from the layer markup.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The feature's -Snippet-, extracted from the layer markup.
        /// </summary>
        public JsString snippet { get; set; }
    }
    [JsType(JsMode.Json)]
    public class KmlAuthor
    {
        /// <summary>
        ///The author's e-mail address, or an empty JsString if not specified.
        /// </summary>
        public JsString email { get; set; }
        /// <summary>
        ///The author's name, or an empty JsString if not specified.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The author's home page, or an empty JsString if not specified.
        /// </summary>
        public JsString uri { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.TrafficLayer")]
    public class TrafficLayer
    {
        /// <summary>
        ///A layer that displays current road traffic.
        /// </summary>
        public TrafficLayer() { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.TransitLayer")]
    public class TransitLayer
    {
        /// <summary>
        ///A layer that displays transit lines.
        /// </summary>
        public TransitLayer() { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.StreetViewPanorama")]
    public class StreetViewPanorama
    {
        /// <summary>
        ///Creates a panorama with the passed StreetViewPanoramaOptions.
        /// </summary>
        public StreetViewPanorama(Node container, StreetViewPanoramaOptions opts = null) { }
        /// <summary>
        ///Returns the set of navigation links for the Street View panorama.
        /// </summary>
        public JsArray<StreetViewLink> getLinks() { return null; }
        /// <summary>
        ///Returns the current panorama ID for the Street View panorama. This id is stable within the browser's current session only.
        /// </summary>
        public JsString getPano() { return null; }
        /// <summary>
        ///Returns the heading and pitch of the photographer when this panorama was taken. For Street View panoramas on the road, this also reveals in which direction the car was travelling. This data is available after the pano_changed event.
        /// </summary>
        public StreetViewPov getPhotographerPov() { return null; }
        /// <summary>
        ///Returns the current LatLng position for the Street View panorama.
        /// </summary>
        public LatLng getPosition() { return null; }
        /// <summary>
        ///Returns the current point of view for the Street View panorama.
        /// </summary>
        public StreetViewPov getPov() { return null; }
        /// <summary>
        ///Returns true if the panorama is visible. It does not specify whether Street View imagery is available at the specified position.
        /// </summary>
        public bool getVisible() { return false; }
        /// <summary>
        ///Returns the zoom level of the panorama. Fully zoomed-out is level 0, where the field of view is 180 degrees. Zooming in increases the zoom level.
        /// </summary>
        public JsNumber getZoom() { return null; }
        /// <summary>
        ///Set the custom panorama provider called on pano change to load custom panoramas.
        /// </summary>
        public void registerPanoProvider() { }
        /// <summary>
        ///Sets the current panorama ID for the Street View panorama.
        /// </summary>
        public void setPano(JsString pano) { }
        /// <summary>
        ///Sets the current LatLng position for the Street View panorama.
        /// </summary>
        public void setPosition(LatLng latLng) { }
        /// <summary>
        ///Sets the point of view for the Street View panorama.
        /// </summary>
        public void setPov(StreetViewPov pov) { }
        /// <summary>
        ///Sets to true to make the panorama visible. If set to false, the panorama will be hidden whether it is embedded in the map or in its own &lt;div&gt;.
        /// </summary>
        public void setVisible(bool flag) { }
        /// <summary>
        ///Sets the zoom level of the panorama. Fully zoomed-out is level 0, where the field of view is 180 degrees. Zooming in increases the zoom level.
        /// </summary>
        public void setZoom(JsNumber zoom) { }
        /// <summary>
        ///Additional controls to attach to the panorama. To add a control to the panorama, add the control's &lt;div&gt; to the MVCArray corresponding to the ControlPosition where it should be rendered.
        /// </summary>
        public JsArray<MVCArray<Node>> controls { get; set; }
        /// <summary>
        ///This event is fired when the close button is clicked.
        /// </summary>
        public JsAction<DOMEvent> closeclick { get; set; }
        /// <summary>
        ///This event is fired when the panorama's links change. The links change asynchronously following a pano id change.
        /// </summary>
        public JsAction links_changed { get; set; }
        /// <summary>
        ///This event is fired when the panorama's pano id changes. The pano may change as the user navigates through the panorama or the position is manually set. Note that not all position changes trigger a pano_changed.
        /// </summary>
        public JsAction pano_changed { get; set; }
        /// <summary>
        ///This event is fired when the panorama's position changes. The position changes as the user navigates through the panorama or the position is set manually.
        /// </summary>
        public JsAction position_changed { get; set; }
        /// <summary>
        ///This event is fired when the panorama's point-of-view changes. The point of view changes as the pitch, zoom, or heading changes.
        /// </summary>
        public JsAction pov_changed { get; set; }
        /// <summary>
        ///Developers should trigger this event on the panorama when its div changes size: google.maps.event.trigger(panorama, 'resize').
        /// </summary>
        public JsAction resize { get; set; }
        /// <summary>
        ///This event is fired when the panorama's visibility changes. The visibility is changed when the Pegman id dragged onto the map, the close button is clicked, or setVisible() is called.
        /// </summary>
        public JsAction visible_changed { get; set; }
        /// <summary>
        ///This event is fired when the panorama's zoom level changes.
        /// </summary>
        public JsAction zoom_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewPanoramaOptions
    {
        /// <summary>
        ///The enabled/disabled state of the address control.
        /// </summary>
        public bool addressControl { get; set; }
        /// <summary>
        ///The display options for the address control.
        /// </summary>
        public StreetViewAddressControlOptions addressControlOptions { get; set; }
        /// <summary>
        ///The enabled/disabled state of click-to-go.
        /// </summary>
        public bool clickToGo { get; set; }
        /// <summary>
        ///Enables/disables zoom on double click. Disabled by default.
        /// </summary>
        public bool disableDoubleClickZoom { get; set; }
        /// <summary>
        ///If true, the close button is displayed. Disabled by default.
        /// </summary>
        public bool enableCloseButton { get; set; }
        /// <summary>
        ///The enabled/disabled state of the imagery acquisition date control.
        /// </summary>
        public bool imageDateControl { get; set; }
        /// <summary>
        ///The enabled/disabled state of the links control.
        /// </summary>
        public bool linksControl { get; set; }
        /// <summary>
        ///The enabled/disabled state of the pan control.
        /// </summary>
        public bool panControl { get; set; }
        /// <summary>
        ///The display options for the pan control.
        /// </summary>
        public PanControlOptions panControlOptions { get; set; }
        /// <summary>
        ///The panorama ID, which should be set when specifying a custom panorama.
        /// </summary>
        public JsString pano { get; set; }
        /// <summary>
        ///Custom panorama provider, which takes a JsString pano id and returns an object defining the panorama given that id. This function must be defined to specify custom panorama imagery.
        /// </summary>
        public JsFunc<JsString, StreetViewPanoramaData> panoProvider { get; set; }
        /// <summary>
        ///The LatLng position of the Street View panorama.
        /// </summary>
        public LatLng position { get; set; }
        /// <summary>
        ///The camera orientation, specified as heading and pitch, for the panorama.
        /// </summary>
        public StreetViewPov pov { get; set; }
        /// <summary>
        ///If false, disables scrollwheel zooming in Street View. The scrollwheel is enabled by default.
        /// </summary>
        public bool scrollwheel { get; set; }
        /// <summary>
        ///If true, the Street View panorama is visible on load.
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        ///The enabled/disabled state of the zoom control.
        /// </summary>
        public bool zoomControl { get; set; }
        /// <summary>
        ///The display options for the zoom control.
        /// </summary>
        public ZoomControlOptions zoomControlOptions { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewAddressControlOptions
    {
        /// <summary>
        ///Position id. This id is used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition position { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewLink
    {
        /// <summary>
        ///A localized JsString describing the link.
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///The heading of the link.
        /// </summary>
        public JsNumber heading { get; set; }
        /// <summary>
        ///A unique identifier for the panorama. This id is stable within a session but unstable across sessions.
        /// </summary>
        public JsString pano { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewPov
    {
        /// <summary>
        ///The camera heading in degrees relative to true north. True north is 0Â°, east is 90Â°, south is 180Â°, west is 270Â°.
        /// </summary>
        public JsNumber heading { get; set; }
        /// <summary>
        ///The camera pitch in degrees, relative to the street view vehicle. Ranges from 90Â° (directly upwards) to -90Â° (directly downwards).
        /// </summary>
        public JsNumber pitch { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewPanoramaData
    {
        /// <summary>
        ///Specifies the copyright text for this panorama.
        /// </summary>
        public JsString copyright { get; set; }
        /// <summary>
        ///Specifies the year and month in which the imagery in this panorama was acquired. The date JsString is in the form YYYY-MM.
        /// </summary>
        public JsString imageDate { get; set; }
        /// <summary>
        ///Specifies the navigational links to adjacent panoramas.
        /// </summary>
        public JsArray<StreetViewLink> links { get; set; }
        /// <summary>
        ///Specifies the location meta-data for this panorama.
        /// </summary>
        public StreetViewLocation location { get; set; }
        /// <summary>
        ///Specifies the custom tiles for this panorama.
        /// </summary>
        public StreetViewTileData tiles { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewLocation
    {
        /// <summary>
        ///A localized JsString describing the location.
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///The latlng of the panorama.
        /// </summary>
        public LatLng latLng { get; set; }
        /// <summary>
        ///A unique identifier for the panorama. This is stable within a session but unstable across sessions.
        /// </summary>
        public JsString pano { get; set; }
    }
    [JsType(JsMode.Json)]
    public class StreetViewTileData
    {
        /// <summary>
        ///Gets the tile image URL for the specified tile. pano is the panorama ID of the Street View tile. tileZoom is the zoom level of the tile. tileX is the x-coordinate of the tile. tileY is the y-coordinate of the tile. Returns the URL for the tile image.
        /// </summary>
        public JsString getTileUrl(JsString pano, JsNumber tileZoom, JsNumber tileX, JsNumber tileY) { return null; }
        /// <summary>
        ///The heading (in degrees) at the center of the panoramic tiles.
        /// </summary>
        public JsNumber centerHeading { get; set; }
        /// <summary>
        ///The size (in pixels) at which tiles will be rendered. This may not be the native tile image size.
        /// </summary>
        public Size tileSize { get; set; }
        /// <summary>
        ///The size (in pixels) of the whole panorama's "world".
        /// </summary>
        public Size worldSize { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.StreetViewService")]
    public class StreetViewService
    {
        /// <summary>
        ///Retrieves the data for the given pano id and passes it to the provided callback as a StreetViewPanoramaData object. Pano ids are unique per panorama and stable for the lifetime of a session, but are liable to change between sessions.
        /// </summary>
        public void getPanoramaById() { }
        /// <summary>
        ///Retrieves the StreetViewPanoramaData for a panorama within a given radius of the given LatLng. The StreetViewPanoramaData is passed to the provided callback. If the radius is less than 50 meters, the nearest panorama will be returned.
        /// </summary>
        public void getPanoramaByLocation() { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.StreetViewStatus")]
    public class StreetViewStatus
    {
        /// <summary>
        ///The request was successful.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The request could not be successfully processed, yet the exact reason for failure is unknown.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
        /// <summary>
        ///There are no nearby panoramas.
        /// </summary>
        public static object ZERO_RESULTS { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.StreetViewCoverageLayer")]
    public class StreetViewCoverageLayer
    {
        /// <summary>
        ///Creates a new instance of StreetViewCoverageLayer.
        /// </summary>
        public StreetViewCoverageLayer() { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If the map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
    }
    [JsType(JsMode.Json)]
    public class MapsEventListener
    {
    }
    [JsType(JsMode.Prototype, Name = "google.maps.event")]
    public class MapEvent
    {
        /// <summary>
        ///Cross browser event handler registration. This listener is removed by calling removeListener(handle) for the handle that is returned by this function.
        /// </summary>
        public static MapsEventListener addDomListener(Object instance, JsString eventName, JsAction<DOMEvent> handler, bool capture = false) { return null; }
        /// <summary>
        ///Wrapper around addDomListener that removes the listener after the first event.
        /// </summary>
        public static MapsEventListener addDomListenerOnce(Object instance, JsString eventName, JsAction handler, bool capture = false) { return null; }
        /// <summary>
        ///Adds the given listener function to the given event name for the given object instance. Returns an identifier for this listener that can be used with removeListener().
        /// </summary>
        public static MapsEventListener addListener(Object instance, JsString eventName, JsAction handler) { return null; }
        /// <summary>
        ///Adds the given listener function to the given event name for the given object instance. Returns an identifier for this listener that can be used with removeListener().
        /// </summary>
        public static MapsEventListener addListener<T>(Object instance, JsString eventName, JsAction<T> handler) { return null; }
        /// <summary>
        ///Like addListener, but the handler removes itself after handling the first event.
        /// </summary>
        public static MapsEventListener addListenerOnce(Object instance, JsString eventName, JsAction handler) { return null; }
        /// <summary>
        ///Removes all listeners for all events for the given instance.
        /// </summary>
        public static void clearInstanceListeners(Object instance) { }
        /// <summary>
        ///Removes all listeners for the given event for the given instance.
        /// </summary>
        public static void clearListeners(Object instance, JsString eventName) { }
        /// <summary>
        ///Removes the given listener, which should have been returned by addListener above.
        /// </summary>
        public static void removeListener(MapsEventListener listener) { }
        /// <summary>
        ///Triggers the given event. All arguments after eventName are passed as arguments to the listeners.
        /// </summary>
        public static void trigger(Object instance, JsString eventName, object var_args) { }
    }
    [JsType(JsMode.Json)]
    public class MouseEvent
    {
        /// <summary>
        ///Prevents this event from propagating further.
        /// </summary>
        public void stop() { }
        /// <summary>
        ///The latitude/longitude that was below the cursor when the event occurred.
        /// </summary>
        public LatLng latLng { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.LatLng")]
    public class LatLng
    {
        /// <summary>
        ///Creates a LatLng object representing a geographic point. Latitude is specified in degrees within the range [-90, 90]. Longitude is specified in degrees within the range [-180, 180]. Set noWrap to true to enable values outside of this range. Note the ordering of latitude and longitude.
        /// </summary>
        public LatLng(JsNumber lat, JsNumber lng, bool noWrap = false) { }
        /// <summary>
        ///Comparison function.
        /// </summary>
        public bool equals(LatLng other) { return false; }
        /// <summary>
        ///Returns the latitude in degrees.
        /// </summary>
        public JsNumber lat() { return null; }
        /// <summary>
        ///Returns the longitude in degrees.
        /// </summary>
        public JsNumber lng() { return null; }
        /// <summary>
        ///Converts to JsString representation.
        /// </summary>
        public JsString toString() { return null; }
        /// <summary>
        ///Returns a JsString of the form "lat,lng" for this LatLng. We round the lat/lng values to 6 decimal places by default.
        /// </summary>
        public JsString toUrlValue(JsNumber precision = null) { return null; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.LatLngBounds")]
    public class LatLngBounds
    {
        /// <summary>
        ///Constructs a rectangle from the points at its south-west and north-east corners.
        /// </summary>
        public LatLngBounds(LatLng sw = null, LatLng ne = null) { }
        /// <summary>
        ///Returns true if the given lat/lng is in this bounds.
        /// </summary>
        public bool contains(LatLng latLng) { return false; }
        /// <summary>
        ///Returns true if this bounds approximately equals the given bounds.
        /// </summary>
        public bool equals(LatLngBounds other) { return false; }
        /// <summary>
        ///Extends this bounds to contain the given point.
        /// </summary>
        public LatLngBounds extend(LatLng point) { return null; }
        /// <summary>
        ///Computes the center of this LatLngBounds
        /// </summary>
        public LatLng getCenter() { return null; }
        /// <summary>
        ///Returns the north-east corner of this bounds.
        /// </summary>
        public LatLng getNorthEast() { return null; }
        /// <summary>
        ///Returns the south-west corner of this bounds.
        /// </summary>
        public LatLng getSouthWest() { return null; }
        /// <summary>
        ///Returns true if this bounds shares any points with this bounds.
        /// </summary>
        public bool intersects(LatLngBounds other) { return false; }
        /// <summary>
        ///Returns if the bounds are empty.
        /// </summary>
        public bool isEmpty() { return false; }
        /// <summary>
        ///Converts the given map bounds to a lat/lng span.
        /// </summary>
        public LatLng toSpan() { return null; }
        /// <summary>
        ///Converts to JsString.
        /// </summary>
        public JsString toString() { return null; }
        /// <summary>
        ///Returns a JsString of the form "lat_lo,lng_lo,lat_hi,lng_hi" for this bounds, where "lo" corresponds to the southwest corner of the bounding box, while "hi" corresponds to the northeast corner of that box.
        /// </summary>
        public JsString toUrlValue(JsNumber precision = null) { return null; }
        /// <summary>
        ///Extends this bounds to contain the union of this and the given bounds.
        /// </summary>
        public LatLngBounds union(LatLngBounds other) { return null; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Point")]
    public class Point
    {
        /// <summary>
        ///A point on a two-dimensional plane.
        /// </summary>
        public Point(JsNumber x, JsNumber y) { }
        /// <summary>
        ///Compares two Points
        /// </summary>
        public bool equals(Point other) { return false; }
        /// <summary>
        ///Returns a JsString representation of this Point.
        /// </summary>
        public JsString toString() { return null; }
        /// <summary>
        ///The X coordinate
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        ///The Y coordinate
        /// </summary>
        public JsNumber y { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.Size")]
    public class Size
    {
        /// <summary>
        ///Two-dimensonal size, where width is the distance on the x-axis, and height is the distance on the y-axis.
        /// </summary>
        public Size(JsNumber width, JsNumber height, JsString widthUnit = null, JsString heightUnit = null) { }
        /// <summary>
        ///Compares two Sizes.
        /// </summary>
        public bool equals(Size other) { return false; }
        /// <summary>
        ///Returns a JsString representation of this Size.
        /// </summary>
        public JsString toString() { return null; }
        /// <summary>
        ///The height along the y-axis, in pixels.
        /// </summary>
        public JsNumber height { get; set; }
        /// <summary>
        ///The width along the x-axis, in pixels.
        /// </summary>
        public JsNumber width { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MVCObject")]
    public class MVCObject
    {
        /// <summary>
        ///Base public class implementing KVO.
        /// </summary>
        public MVCObject() { }
        /// <summary>
        ///Adds the given listener function to the given event name. Returns an identifier for this listener that can be used with google.maps.event.removeListener.
        /// </summary>
        public MapsEventListener addListener(JsString eventName, JsAction handler) { return null; }
        /// <summary>
        ///Binds a View to a Model.
        /// </summary>
        public void bindTo(JsString key, MVCObject target, JsString targetKey = null, bool noNotify = false) { }
        /// <summary>
        ///Generic handler for state changes. Override this in derived classes to handle arbitrary state changes.
        /// </summary>
        public void changed(JsString key) { }
        /// <summary>
        ///Gets a value.
        /// </summary>
        public object get(JsString key) { return null; }
        /// <summary>
        ///Notify all observers of a change on this property. This notifies both objects that are bound to the object's property as well as the object that it is bound to.
        /// </summary>
        public void notify(JsString key) { }
        /// <summary>
        ///Sets a value.
        /// </summary>
        public void set(JsString key, object value) { }
        /// <summary>
        ///Sets a collection of key-value pairs.
        /// </summary>
        public void setValues(object values) { }
        /// <summary>
        ///Removes a binding. Unbinding will set the unbound property to the current value. The object will not be notified, as the value has not changed.
        /// </summary>
        public void unbind(JsString key) { }
        /// <summary>
        ///Removes all bindings.
        /// </summary>
        public void unbindAll() { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.MVCArray")]
    public class MVCArray<T>
    {
        /// <summary>
        ///A mutable MVC Array.
        /// </summary>
        public MVCArray(JsArray<T> array = null) { }
        /// <summary>
        ///Removes all elements from the array.
        /// </summary>
        public void clear() { }
        /// <summary>
        ///Iterate over each element, calling the provided callback. The callback is called for each element like: callback(element, index).
        /// </summary>
        public void forEach() { }
        /// <summary>
        ///Returns a reference to the underlying Array. Warning: if the Array is mutated, no events will be fired by this object.
        /// </summary>
        public Array getArray() { return null; }
        /// <summary>
        ///Returns the element at the specified index.
        /// </summary>
        public object getAt(JsNumber i) { return null; }
        /// <summary>
        ///Returns the number of elements in this array.
        /// </summary>
        public JsNumber getLength() { return null; }
        /// <summary>
        ///Inserts an element at the specified index.
        /// </summary>
        public void insertAt(JsNumber i, T elem) { }
        /// <summary>
        ///Removes the last element of the array and returns that element.
        /// </summary>
        public object pop() { return null; }
        /// <summary>
        ///Adds one element to the end of the array and returns the new length of the array.
        /// </summary>
        public JsNumber push(object elem) { return null; }
        /// <summary>
        ///Removes an element from the specified index.
        /// </summary>
        public object removeAt(JsNumber i) { return null; }
        /// <summary>
        ///Sets an element at the specified index.
        /// </summary>
        public void setAt(JsNumber i, T elem) { }
        /// <summary>
        ///This event is fired when insertAt() is called. The event passes the index that was passed to insertAt().
        /// </summary>
        public JsAction<JsNumber> insert_at { get; set; }
        /// <summary>
        ///This event is fired when removeAt() is called. The event passes the index that was passed to removeAt() and the element that was removed from the array.
        /// </summary>
        public JsAction<JsNumber, T> remove_at { get; set; }
        /// <summary>
        ///This event is fired when setAt() is called. The event passes the index that was passed to setAt() and the element that was previously in the array at that index.
        /// </summary>
        public JsAction<JsNumber, T> set_at { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.geometry.encoding")]
    public class encoding
    {
        /// <summary>
        ///Decodes an encoded path JsString into a sequence of LatLngs.
        /// </summary>
        public static JsArray<LatLng> decodePath(JsString encodedPath) { return null; }
        /// <summary>
        ///Encodes a sequence of LatLngs into an encoded path JsString.
        /// </summary>
        public static JsString encodePath(object path) { return null; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.geometry.spherical")]
    public class spherical
    {
        /// <summary>
        ///Returns the area of a closed path. The computed area uses the same units as the radius. The radius defaults to the Earth's radius in meters, in which case the area is in square meters.
        /// </summary>
        public static JsNumber computeArea(JsArray<LatLng> path, JsNumber radius = null) { return null; }
        /// <summary>
        ///Returns the distance between two LatLngs.
        /// </summary>
        public static JsNumber computeDistanceBetween(LatLng from, LatLng to, JsNumber radius = null) { return null; }
        /// <summary>
        ///Returns the heading from one LatLng to another LatLng. Headings are expressed in degrees clockwise from North within the range [-180,180).
        /// </summary>
        public static JsNumber computeHeading(LatLng from, LatLng to) { return null; }
        /// <summary>
        ///Returns the length of the given path.
        /// </summary>
        public static JsNumber computeLength(object path, JsNumber radius = null) { return null; }
        /// <summary>
        ///Returns the LatLng resulting from moving a distance from an origin in the specified heading (expressed in degrees clockwise from north).
        /// </summary>
        public static LatLng computeOffset(LatLng from, JsNumber distance, JsNumber heading, JsNumber radius = null) { return null; }
        /// <summary>
        ///Returns the location of origin when provided with a LatLng destination, meters travelled and original heading. Headings are expressed in degrees clockwise from North. This function returns null when no solution is available.
        /// </summary>
        public static LatLng computeOffsetOrigin(LatLng to, JsNumber distance, JsNumber heading, JsNumber radius = null) { return null; }
        /// <summary>
        ///Returns the signed area of a closed path. The signed area may be used to determine the orientation of the path. The computed area uses the same units as the radius. The radius defaults to the Earth's radius in meters, in which case the area is in square meters.
        /// </summary>
        public static JsNumber computeSignedArea(object loop, JsNumber radius = null) { return null; }
        /// <summary>
        ///Returns the LatLng which lies the given fraction of the way between the origin LatLng and the destination LatLng.
        /// </summary>
        public static LatLng interpolate(LatLng from, LatLng to, JsNumber fraction) { return null; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.geometry.poly")]
    public class poly
    {
        /// <summary>
        ///Computes whether the given point lies inside the specified polygon.
        /// </summary>
        public static bool containsLocation(LatLng point, Polygon polygon) { return false; }
        /// <summary>
        ///Computes whether the given point lies on or near to a polyline, or the edge of a polygon, within a specified tolerance. Returns true when the difference between the latitude and longitude of the supplied point, and the closest point on the edge, is less than the tolerance. The tolerance defaults to 10-9 degrees.
        /// </summary>
        public static bool isLocationOnEdge(LatLng point, object poly, JsNumber tolerance = null) { return false; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.adsense.AdUnit")]
    public class AdUnit
    {
        /// <summary>
        ///Creates an AdSense for Content display ad on the associated map.
        /// </summary>
        public AdUnit(Node container, AdUnitOptions opts) { }
        /// <summary>
        ///Returns the AdUnit's background color.
        /// </summary>
        public JsString getBackgroundColor() { return null; }
        /// <summary>
        ///Returns the AdUnit's border color.
        /// </summary>
        public JsString getBorderColor() { return null; }
        /// <summary>
        ///Returns the channel number in use by this AdUnit.
        /// </summary>
        public JsString getChannelNumber() { return null; }
        /// <summary>
        ///Returns the containing element of the AdUnit.
        /// </summary>
        public Node getContainer() { return null; }
        /// <summary>
        ///Returns the format in use by this AdUnit.
        /// </summary>
        public AdFormat getFormat() { return null; }
        /// <summary>
        ///Returns the map to which this AdUnit's ads are targeted.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns the ControlPosition at which this AdUnit is displayed on the map.
        /// </summary>
        public ControlPosition getPosition() { return null; }
        /// <summary>
        ///Returns the specified AdSense For Content publisher ID.
        /// </summary>
        public JsString getPublisherId() { return null; }
        /// <summary>
        ///Returns the AdUnit's text color.
        /// </summary>
        public JsString getTextColor() { return null; }
        /// <summary>
        ///Returns the AdUnit's title color.
        /// </summary>
        public JsString getTitleColor() { return null; }
        /// <summary>
        ///Returns the AdUnit's URL color.
        /// </summary>
        public JsString getUrlColor() { return null; }
        /// <summary>
        ///Sets the AdUnit's background color.
        /// </summary>
        public JsString setBackgroundColor() { return null; }
        /// <summary>
        ///Sets the AdUnit's border color.
        /// </summary>
        public JsString setBorderColor() { return null; }
        /// <summary>
        ///Specifies the channel number for this AdUnit. Channel numbers are optional and can be created for Google AdSense tracking.
        /// </summary>
        public void setChannelNumber(JsString channelNumber) { }
        /// <summary>
        ///Specifies the display format for this AdUnit.
        /// </summary>
        public void setFormat(AdFormat format) { }
        /// <summary>
        ///Associates this AdUnit with the specified map. Ads will be targeted to the map's viewport. The map must be specified in order to display ads.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Sets the ControlPosition at which to display the AdUnit on the map. If the position is set to null, the AdUnit is removed from the map.
        /// </summary>
        public void setPosition(ControlPosition position) { }
        /// <summary>
        ///Sets the AdUnit's text color.
        /// </summary>
        public JsString setTextColor() { return null; }
        /// <summary>
        ///Sets the AdUnit's title color.
        /// </summary>
        public JsString setTitleColor() { return null; }
        /// <summary>
        ///Sets the AdUnit's URL color.
        /// </summary>
        public JsString setUrlColor() { return null; }
    }
    [JsType(JsMode.Json)]
    public class AdUnitOptions
    {
        /// <summary>
        ///The AdUnit's background color. (Optional)
        /// </summary>
        public JsString backgroundColor { get; set; }
        /// <summary>
        ///The AdUnit's border color. (Optional)
        /// </summary>
        public JsString borderColor { get; set; }
        /// <summary>
        ///The AdSense For Content channel number for tracking the performance of this AdUnit. It must be stored as a JsString as it will typically be a large UINT64. (Optional)
        /// </summary>
        public JsString channelNumber { get; set; }
        /// <summary>
        ///the Format of the AdUnit. See https://google.com/adsense/adformats. (Optional)
        /// </summary>
        public AdFormat format { get; set; }
        /// <summary>
        ///The map associated with this AdUnit. Ads will be targeted to the location the map's viewport. (Required)
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The position of the AdUnit. If specified, the AdUnit will be displayed at this position. Otherwise, it will not be added to the map. (Optional)
        /// </summary>
        public ControlPosition position { get; set; }
        /// <summary>
        ///Your AdSense for Content publisher ID. Required and must be set at the time of initialization. (Required)
        /// </summary>
        public JsString publisherId { get; set; }
        /// <summary>
        ///The AdUnit's text color. (Optional)
        /// </summary>
        public JsString textColor { get; set; }
        /// <summary>
        ///The AdUnit's title color. (Optional)
        /// </summary>
        public JsString titleColor { get; set; }
        /// <summary>
        ///The AdUnit's URL color. (Optional)
        /// </summary>
        public JsString urlColor { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.adsense.AdFormat")]
    public class AdFormat
    {
        /// <summary>
        ///A horizontal "banner" ad. (468x60px)
        /// </summary>
        public static object BANNER { get; private set; }
        /// <summary>
        ///A small ad. (125x125px)
        /// </summary>
        public static object BUTTON { get; private set; }
        /// <summary>
        ///A smaller horizontal "banner" ad. (234x60px)
        /// </summary>
        public static object HALF_BANNER { get; private set; }
        /// <summary>
        ///A large horizontal ad link unit. (728x15px)
        /// </summary>
        public static object LARGE_HORIZONTAL_LINK_UNIT { get; private set; }
        /// <summary>
        ///A large rectangular ad. (336x280px)
        /// </summary>
        public static object LARGE_RECTANGLE { get; private set; }
        /// <summary>
        ///A large vertical ad link unit. (180x90px)
        /// </summary>
        public static object LARGE_VERTICAL_LINK_UNIT { get; private set; }
        /// <summary>
        ///A fully horizontal display area. (728x90px)
        /// </summary>
        public static object LEADERBOARD { get; private set; }
        /// <summary>
        ///A medium rectangular ad. (300x250px)
        /// </summary>
        public static object MEDIUM_RECTANGLE { get; private set; }
        /// <summary>
        ///A medium vertical ad link unit. (160x90px)
        /// </summary>
        public static object MEDIUM_VERTICAL_LINK_UNIT { get; private set; }
        /// <summary>
        ///A large vertical ad. (120x600px)
        /// </summary>
        public static object SKYSCRAPER { get; private set; }
        /// <summary>
        ///A small horizontal ad link unit. (468x15px)
        /// </summary>
        public static object SMALL_HORIZONTAL_LINK_UNIT { get; private set; }
        /// <summary>
        ///A small rectangular ad. (180x150px)
        /// </summary>
        public static object SMALL_RECTANGLE { get; private set; }
        /// <summary>
        ///A smaller square ad. (200x200px)
        /// </summary>
        public static object SMALL_SQUARE { get; private set; }
        /// <summary>
        ///A small vertical ad link unit. (120x90px)
        /// </summary>
        public static object SMALL_VERTICAL_LINK_UNIT { get; private set; }
        /// <summary>
        ///A square ad with large type. (250x250px)
        /// </summary>
        public static object SQUARE { get; private set; }
        /// <summary>
        ///A medium-sized vertical ad. (120x240px)
        /// </summary>
        public static object VERTICAL_BANNER { get; private set; }
        /// <summary>
        ///A wide, vertical ad using larger type. (160x600px)
        /// </summary>
        public static object WIDE_SKYSCRAPER { get; private set; }
        /// <summary>
        ///An extra large vertical ad link unit. (200x90px)
        /// </summary>
        public static object X_LARGE_VERTICAL_LINK_UNIT { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.panoramio.PanoramioLayer")]
    public class PanoramioLayer
    {
        /// <summary>
        ///A layer that displays data from Panoramio.
        /// </summary>
        public PanoramioLayer(PanoramioLayerOptions opts = null) { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        public JsString getTag() { return null; }
        public JsString getUserId() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(PanoramioLayerOptions options) { }
        public void setTag(JsString tag) { }
        public void setUserId(JsString userId) { }
        /// <summary>
        ///This event is fired when a feature in the layer is clicked.
        /// </summary>
        public JsAction<PanoramioMouseEvent> click { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PanoramioLayerOptions
    {
        /// <summary>
        ///If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows when layer features are clicked.
        /// </summary>
        public bool suppressInfoWindows { get; set; }
        /// <summary>
        ///A panoramio tag used to filter the photos which are displayed. Only photos which have been tagged with the supplied JsString will be shown.
        /// </summary>
        public JsString tag { get; set; }
        /// <summary>
        ///A Panoramio user ID. If provided, only photos by this user will be displayed on the map. If both a tag and user ID are provided, the tag will take precedence.
        /// </summary>
        public JsString userId { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PanoramioFeature
    {
        /// <summary>
        ///The username of the user who uploaded this photo.
        /// </summary>
        public JsString author { get; set; }
        /// <summary>
        ///The unique identifier for this photo, as used in the Panoramio API (see http://www.panoramio.com/api/widget/api.html).
        /// </summary>
        public JsString photoId { get; set; }
        /// <summary>
        ///The title of the photo.
        /// </summary>
        public JsString title { get; set; }
        /// <summary>
        ///The URL of the photo.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        ///The unique identifier for the user who uploaded this photo, as used in the Panoramio API (see http://www.panoramio.com/api/widget/api.html).
        /// </summary>
        public JsString userId { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PanoramioMouseEvent
    {
        /// <summary>
        ///A PanoramioFeature object containing information about the clicked feature.
        /// </summary>
        public PanoramioFeature featureDetails { get; set; }
        /// <summary>
        ///Pre-rendered HTML content to display within a feature's InfoWindow when clicked.
        /// </summary>
        public JsString infoWindowHtml { get; set; }
        /// <summary>
        ///The position at which to anchor an info window on the clicked feature.
        /// </summary>
        public LatLng latLng { get; set; }
        /// <summary>
        ///The offset to apply to an info window anchored on the clicked feature.
        /// </summary>
        public Size pixelOffset { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.places.Autocomplete")]
    public class Autocomplete
    {
        /// <summary>
        ///Creates a new instance of Autocomplete that attaches to the specified input text field with the given options.
        /// </summary>
        public Autocomplete(HtmlInputElement el, AutocompleteOptions opts = null) { }
        /// <summary>
        ///Returns the bounds to which predictions are biased.
        /// </summary>
        public LatLngBounds getBounds() { return null; }
        /// <summary>
        ///Returns the details of the Place selected by user if the details were successfully retrieved. Otherwise returns a stub Place object, with the name property set to the current value of the input field.
        /// </summary>
        public PlaceResult getPlace() { return null; }
        /// <summary>
        ///Sets the preferred area within which to return Place results. Results are biased towards, but not restricted to, this area.
        /// </summary>
        public void setBounds(LatLngBounds bounds) { }
        /// <summary>
        ///Sets the component restrictions. Component restrictions are used to restrict predictions to only those within the parent component. E.g., the country.
        /// </summary>
        public void setComponentRestrictions(ComponentRestrictions restrictions) { }
        /// <summary>
        ///Sets the types of predictions to be returned. Supported types are 'establishment' for businesses and 'geocode' for addresses. If no type is specified, both types will be returned. The setTypes method accepts a single element array.
        /// </summary>
        public void setTypes(JsArray<JsString> types) { }
        /// <summary>
        ///This event is fired when a PlaceResult is made available for a Place the user has selected. If the user enters the name of a Place that was not suggested by the control and presses the Enter key, or if a Place detail request fails, a place_changed event will be fired that contains the user input in the name property, with no other properties defined.
        /// </summary>
        public JsAction place_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class AutocompleteOptions
    {
        /// <summary>
        ///The area in which to search for places. Results are biased towards, but not restricted to, places contained within these bounds.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///The component restrictions. Component restrictions are used to restrict predictions to only those within the parent component. E.g., the country.
        /// </summary>
        public ComponentRestrictions componentRestrictions { get; set; }
        /// <summary>
        ///The types of predictions to be returned. Four types are supported: 'establishment' for businesses, 'geocode' for addresses, '(regions)' for administrative regions and '(cities)' for localities. If nothing is specified, all types are returned.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Json)]
    public class AutocompletePrediction
    {
        /// <summary>
        ///This is the unformatted version of the query suggested by the Places service.
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///A stable ID for this place, intended to be interoperable with those returned by the place search service.
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        ///A set of substrings in the place's description that match elements in the user's input, suitable for use in highlighting those substrings. Each substring is identified by an offset and a length, expressed in unicode characters.
        /// </summary>
        public JsArray<PredictionSubstring> matched_substrings { get; set; }
        /// <summary>
        ///A reference that can be used to retrieve details about this place using the place details service (see PlacesService.getDetails()).
        /// </summary>
        public JsString reference { get; set; }
        /// <summary>
        ///Information about individual terms in the above description, from most to least specific. For example, "Taco Bell", "Willitis", and "CA".
        /// </summary>
        public JsArray<PredictionTerm> terms { get; set; }
        /// <summary>
        ///An array of types that the prediction belongs to, for example 'establishment' or 'geocode'.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PredictionTerm
    {
        /// <summary>
        ///The offset, in unicode characters, of the start of this term in the description of the place.
        /// </summary>
        public JsNumber offset { get; set; }
        /// <summary>
        ///The value of this term, e.g. "Taco Bell".
        /// </summary>
        public JsString value { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PredictionSubstring
    {
        /// <summary>
        ///The length of the substring.
        /// </summary>
        public JsNumber length { get; set; }
        /// <summary>
        ///The offset to the substring's start within the description JsString.
        /// </summary>
        public JsNumber offset { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.places.AutocompleteService")]
    public class AutocompleteService
    {
        /// <summary>
        ///Creates a new instance of the AutocompleteService.
        /// </summary>
        public AutocompleteService() { }
        /// <summary>
        ///Retrieves place autocomplete predictions based on the supplied autocomplete request.
        /// </summary>
        public void getPlacePredictions() { }
        /// <summary>
        ///Retrieves query autocomplete predictions based on the supplied query autocomplete request.
        /// </summary>
        public void getQueryPredictions() { }
    }
    [JsType(JsMode.Json)]
    public class AutocompletionRequest
    {
        /// <summary>
        ///Bounds for prediction biasing. Predictions will be biased towards, but not restricted to, the given bounds. Both location and radius will be ignored if bounds is set.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///The component restrictions. Component restrictions are used to restrict predictions to only those within the parent component. E.g., the country.
        /// </summary>
        public ComponentRestrictions componentRestrictions { get; set; }
        /// <summary>
        ///The user entered input JsString.
        /// </summary>
        public JsString input { get; set; }
        /// <summary>
        ///Location for prediction biasing. Predictions will be biased towards the given location and radius. Alternatively, bounds can be used.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The character position in the input term at which the service uses text for predictions (the position of the cursor in the input field).
        /// </summary>
        public JsNumber offset { get; set; }
        /// <summary>
        ///The radius of the area used for prediction biasing. The radius is specified in meters, and must always be accompanied by a location property. Alternatively, bounds can be used.
        /// </summary>
        public JsNumber radius { get; set; }
        /// <summary>
        ///The types of predictions to be returned. Four types are supported: 'establishment' for businesses, 'geocode' for addresses, '(regions)' for administrative regions and '(cities)' for localities. If nothing is specified, all types are returned.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ComponentRestrictions
    {
        /// <summary>
        ///Restricts predictions to the specified country (ISO 3166-1 Alpha-2 country code, case insensitive). E.g., us, br, au.
        /// </summary>
        public JsString country { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceAspectRating
    {
        /// <summary>
        ///The rating of this aspect. For individual reviews this is an integer from 0 to 3. For aggregated ratings of a place this is an integer from 0 to 30.
        /// </summary>
        public JsNumber rating { get; set; }
        /// <summary>
        ///The aspect type, e.g. "food", "decor", "service", "overall".
        /// </summary>
        public JsString type { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceDetailsRequest
    {
        /// <summary>
        ///The reference of the Place for which details are being requested.
        /// </summary>
        public JsString reference { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceGeometry
    {
        /// <summary>
        ///The Place's position.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The preferred viewport when displaying this Place on a map. This property will be null if the preferred viewport for the Place is not known.
        /// </summary>
        public LatLngBounds viewport { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlacePhoto
    {
        /// <summary>
        ///Returns the image URL corresponding to the specified options. You must include a PhotoOptions object with at least one of maxWidth or maxHeight specified.
        /// </summary>
        public JsString getUrl(PhotoOptions opts) { return null; }
        /// <summary>
        ///The height of the photo in pixels.
        /// </summary>
        public JsNumber height { get; set; }
        /// <summary>
        ///Attribution text to be displayed for this photo.
        /// </summary>
        public JsArray<JsString> html_attributions { get; set; }
        /// <summary>
        ///The width of the photo in pixels.
        /// </summary>
        public JsNumber width { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PhotoOptions
    {
        /// <summary>
        ///The maximum height in pixels of the returned image.
        /// </summary>
        public JsNumber maxHeight { get; set; }
        /// <summary>
        ///The maximum width in pixels of the returned image.
        /// </summary>
        public JsNumber maxWidth { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceResult
    {
        /// <summary>
        ///The collection of address components for this Place's location.
        /// </summary>
        public JsArray<GeocoderAddressComponent> address_components { get; set; }
        /// <summary>
        ///The rated aspects of this Place, based on Google and Zagat user reviews. The ratings are on a scale of 0 to 30.
        /// </summary>
        public JsArray<PlaceAspectRating> aspects { get; set; }
        /// <summary>
        ///The Place's full address.
        /// </summary>
        public JsString formatted_address { get; set; }
        /// <summary>
        ///The Place's phone number, formatted according to the number's regional convention.
        /// </summary>
        public JsString formatted_phone_number { get; set; }
        /// <summary>
        ///The Place's geometry-related information.
        /// </summary>
        public PlaceGeometry geometry { get; set; }
        /// <summary>
        ///Attribution text to be displayed for this Place result.
        /// </summary>
        public JsArray<JsString> html_attributions { get; set; }
        /// <summary>
        ///URL to an image resource that can be used to represent this Place's category.
        /// </summary>
        public JsString icon { get; set; }
        /// <summary>
        ///A unique identifier denoting this Place. This identifier may not be used to retrieve information about this Place, and to verify the identity of a Place across separate searches. As ids can occasionally change, it is recommended that the stored id for a Place be compared with the id returned in later Details requests for the same Place, and updated if necessary.
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        ///The Place's phone number in international format. International format includes the country code, and is prefixed with the plus (+) sign.
        /// </summary>
        public JsString international_phone_number { get; set; }
        /// <summary>
        ///The Place's name. Note: In the case of user entered Places, this is the raw text, as typed by the user. Please exercise caution when using this data, as malicious users may try to use it as a vector for code injection attacks (See http://en.wikipedia.org/wiki/Code_injection).
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///A flag indicating whether the Place is permanently closed. If the place is not permanently closed, the flag is not present in search or details responses.
        /// </summary>
        public bool permanently_closed { get; set; }
        /// <summary>
        ///Photos of this Place. The collection will contain up to ten PlacePhoto objects.
        /// </summary>
        public JsArray<PlacePhoto> photos { get; set; }
        /// <summary>
        ///The price level of the Place, on a scale of 0 to 4. Price levels are interpreted as follows: Value Description 0 Free 1 Inexpensive 2 Moderate 3 Expensive 4 Very Expensive
        /// </summary>
        public JsNumber price_level { get; set; }
        /// <summary>
        ///The Place's rating, from 0.0 to 5.0, based on user reviews.
        /// </summary>
        public JsNumber rating { get; set; }
        /// <summary>
        ///An opaque JsString that may be used to retrieve up-to-date information about this Place (via PlacesService.getDetails()). reference contains a unique token that you can use to retrieve additional information about this Place in a Place Details request. You can store this token and use it at any time in future to refresh cached data about this Place, but the same token is not guaranteed to be returned for any given Place across different searches.
        /// </summary>
        public JsString reference { get; set; }
        /// <summary>
        ///The editorial review summary. Only visible in details responses, for customers of Maps API for Business and when extensions: 'review_summary' is specified in the details request.
        /// </summary>
        public JsString review_summary { get; set; }
        /// <summary>
        ///A list of reviews of this Place.
        /// </summary>
        public JsArray<PlaceReview> reviews { get; set; }
        /// <summary>
        ///An array of types for this Place (e.g., ["political",  "locality"] or ["restaurant", "establishment"]).
        /// </summary>
        public JsArray<JsString> types { get; set; }
        /// <summary>
        ///URL of the associated Google Place Page.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        ///A fragment of the Place's address for disambiguation (usually street name and locality).
        /// </summary>
        public JsString vicinity { get; set; }
        /// <summary>
        ///The authoritative website for this Place, such as a business' homepage.
        /// </summary>
        public JsString website { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceReview
    {
        /// <summary>
        ///The aspects rated by the review. The ratings on a scale of 0 to 3.
        /// </summary>
        public JsArray<PlaceAspectRating> aspects { get; set; }
        /// <summary>
        ///The name of the reviewer.
        /// </summary>
        public JsString author_name { get; set; }
        /// <summary>
        ///A link to the reviewer's profile. This will be undefined when the reviewer's profile is unavailable.
        /// </summary>
        public JsString author_url { get; set; }
        /// <summary>
        ///The text of a review.
        /// </summary>
        public JsString text { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceSearchPagination
    {
        /// <summary>
        ///Fetches the next page of results. Uses the same callback function that was provided to the first search request.
        /// </summary>
        public void nextPage() { }
        /// <summary>
        ///Indicates if further results are available. true when there is an additional results page.
        /// </summary>
        public bool hasNextPage { get; set; }
    }
    [JsType(JsMode.Json)]
    public class PlaceSearchRequest
    {
        /// <summary>
        ///The bounds within which to search for Places. Both location and radius will be ignored if bounds is set.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///A term to be matched against all available fields, including but not limited to name, type, and address, as well as customer reviews and other third-party content.
        /// </summary>
        public JsString keyword { get; set; }
        /// <summary>
        ///The location around which to search for Places.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///Restricts the Place search results to Places that include this text in the name.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The distance from the given location within which to search for Places, in meters. The maximum allowed value is 50â€‰000.
        /// </summary>
        public JsNumber radius { get; set; }
        /// <summary>
        ///Specifies the ranking method to use when returning results.
        /// </summary>
        public RankBy rankBy { get; set; }
        /// <summary>
        ///Restricts the Place search results to Places with a type matching at least one of the specified types in this array. Valid types are given here.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.places.PlacesService")]
    public class PlacesService
    {
        /// <summary>
        ///Creates a new instance of the PlacesService that renders attributions in the specified container.
        /// </summary>
        public PlacesService(object attrContainer) { }
        /// <summary>
        ///Retrieves details about the Place identified by the given reference.
        /// </summary>
        public void getDetails() { }
        /// <summary>
        ///Retrieves a list of Places in a given area. The PlaceResults passed to the callback are stripped-down versions of a full PlaceResult. A more detailed PlaceResult for each Place can be obtained by sending a Place Details request with the desired Place's reference value.
        /// </summary>
        public void nearbySearch() { }
        /// <summary>
        ///Similar to the nearbySearch function, with the following differences: the search response will include up to 200 Places, identified only by their geographic coordinates and Place reference.
        /// </summary>
        public void radarSearch() { }
        /// <summary>
        ///Similar to the nearbySearch function, with the following differences: it retrieves a list of Places based on the query attribute in the given request object; bounds or location + radius parameters are optional; and the region, when provided, will not restrict the results to places inside the area, only bias the response towards results near it.
        /// </summary>
        public void textSearch() { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.places.PlacesServiceStatus")]
    public class PlacesServiceStatus
    {
        /// <summary>
        ///This request was invalid.
        /// </summary>
        public static object INVALID_REQUEST { get; private set; }
        /// <summary>
        ///The response contains a valid result.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The application has gone over its request quota.
        /// </summary>
        public static object OVER_QUERY_LIMIT { get; private set; }
        /// <summary>
        ///The application is not allowed to use the PlacesService.
        /// </summary>
        public static object REQUEST_DENIED { get; private set; }
        /// <summary>
        ///The PlacesService request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
        /// <summary>
        ///No result was found for this request.
        /// </summary>
        public static object ZERO_RESULTS { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class QueryAutocompletePrediction
    {
        /// <summary>
        ///This is the unformatted version of the query suggested by the Places service.
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///A set of substrings in the place's description that match elements in the user's input, suitable for use in highlighting those substrings. Each substring is identified by an offset and a length, expressed in unicode characters.
        /// </summary>
        public JsArray<PredictionSubstring> matched_substrings { get; set; }
        /// <summary>
        ///Information about individual terms in the above description. Categorical terms come first (e.g., "restaurant"). Address terms appear from most to least specific. For example, "San Francisco", and "CA".
        /// </summary>
        public JsArray<PredictionTerm> terms { get; set; }
    }
    [JsType(JsMode.Json)]
    public class QueryAutocompletionRequest
    {
        /// <summary>
        ///Bounds for prediction biasing. Predictions will be biased towards, but not restricted to, the given bounds. Both location and radius will be ignored if bounds is set.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///The user entered input JsString.
        /// </summary>
        public JsString input { get; set; }
        /// <summary>
        ///Location for prediction biasing. Predictions will be biased towards the given location and radius. Alternatively, bounds can be used.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The character position in the input term at which the service uses text for predictions (the position of the cursor in the input field).
        /// </summary>
        public JsNumber offset { get; set; }
        /// <summary>
        ///The radius of the area used for prediction biasing. The radius is specified in meters, and must always be accompanied by a location property. Alternatively, bounds can be used.
        /// </summary>
        public JsNumber radius { get; set; }
    }
    [JsType(JsMode.Json)]
    public class RadarSearchRequest
    {
        /// <summary>
        ///Bounds used to bias results when searching for Places (optional). Both location and radius will be ignored if bounds is set. Results will not be restricted to those inside these bounds; but, results inside it will rank higher.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///A term to be matched against all available fields, including but not limited to name, type, and address, as well as customer reviews and other third-party content.
        /// </summary>
        public JsString keyword { get; set; }
        /// <summary>
        ///The center of the area used to bias results when searching for Places.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///Restricts results to Places that include this text in the name.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///The radius of the area used to bias results when searching for Places, in meters.
        /// </summary>
        public JsNumber radius { get; set; }
        /// <summary>
        ///Restricts the Place search results to Places with a type matching at least one of the specified types in this array. Valid types are given here.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.places.RankBy")]
    public class RankBy
    {
        /// <summary>
        ///Ranks place results by distance from the location.
        /// </summary>
        public static object DISTANCE { get; private set; }
        /// <summary>
        ///Ranks place results by their prominence.
        /// </summary>
        public static object PROMINENCE { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.places.SearchBox")]
    public class SearchBox
    {
        /// <summary>
        ///Creates a new instance of SearchBox that attaches to the specified input text field with the given options.
        /// </summary>
        public SearchBox(HtmlInputElement el, SearchBoxOptions opts = null) { }
        /// <summary>
        ///Returns the bounds to which query predictions are biased.
        /// </summary>
        public LatLngBounds getBounds() { return null; }
        /// <summary>
        ///Returns the query selected by the user, or null if no places have been found yet, to be used with places_changed event.
        /// </summary>
        public JsArray<PlaceResult> getPlaces() { return null; }
        /// <summary>
        ///Sets the region to use for biasing query predictions. Results will only be biased towards this area and not be completely restricted to it.
        /// </summary>
        public void setBounds(LatLngBounds bounds) { }
        /// <summary>
        ///This event is fired when the user selects a query, getPlaces should be used to get new places.
        /// </summary>
        public JsAction places_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class SearchBoxOptions
    {
    }
    [JsType(JsMode.Json)]
    public class TextSearchRequest
    {
        /// <summary>
        ///Bounds used to bias results when searching for Places (optional). Both location and radius will be ignored if bounds is set. Results will not be restricted to those inside these bounds; but, results inside it will rank higher.
        /// </summary>
        public LatLngBounds bounds { get; set; }
        /// <summary>
        ///The center of the area used to bias results when searching for Places.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The request's query term. e.g. the name of a place ('Eiffel Tower'), a category followed by the name of a location ('pizza in New York'), or the name of a place followed by a location disambiguator ('Starbucks in Sydney').
        /// </summary>
        public JsString query { get; set; }
        /// <summary>
        ///The radius of the area used to bias results when searching for Places, in meters.
        /// </summary>
        public JsNumber radius { get; set; }
        /// <summary>
        ///Restricts the Place search results to Places with a type matching at least one of the specified types in this array. Valid types are given here.
        /// </summary>
        public JsArray<JsString> types { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.drawing.DrawingManager")]
    public class DrawingManager
    {
        /// <summary>
        ///Creates a DrawingManager that allows users to draw overlays on the map, and switch between the type of overlay to be drawn with a drawing control.
        /// </summary>
        public DrawingManager(DrawingManagerOptions options = null) { }
        /// <summary>
        ///Returns the DrawingManager's drawing mode.
        /// </summary>
        public OverlayType getDrawingMode() { return null; }
        /// <summary>
        ///Returns the Map to which the DrawingManager is attached, which is the Map on which the overlays created will be placed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Changes the DrawingManager's drawing mode, which defines the type of overlay to be added on the map. Accepted values are MARKER, POLYGON, POLYLINE, RECTANGLE, CIRCLE, or null. A drawing mode of null means that the user can interact with the map as normal, and clicks do not draw anything.
        /// </summary>
        public void setDrawingMode(OverlayType drawingMode) { }
        /// <summary>
        ///Attaches the DrawingManager object to the specified Map.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Sets the DrawingManager's options.
        /// </summary>
        public void setOptions(DrawingManagerOptions options) { }
        /// <summary>
        ///This event is fired when the user has finished drawing a circle.
        /// </summary>
        public event JsAction<Circle> circlecomplete
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"circlecomplete\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"circlecomplete\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user has finished drawing a marker.
        /// </summary>
        public event JsAction<Marker> markercomplete
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"markercomplete\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"markercomplete\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user has finished drawing an overlay of any type.
        /// </summary>
        public event JsAction<OverlayCompleteEvent> overlaycomplete
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"overlaycomplete\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"overlaycomplete\"")]
            remove { }
        }
        /// <summary>
        ///This event is fired when the user has finished drawing a polygon.
        /// </summary>
        public event JsAction<Polygon> polygoncomplete
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"polygoncomplete\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"polygoncomplete\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user has finished drawing a polyline.
        /// </summary>
        public event JsAction<Polyline> polylinecomplete
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"polylinecomplete\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"polylinecomplete\"")]
            remove { }
        }

        /// <summary>
        ///This event is fired when the user has finished drawing a rectangle.
        /// </summary>
        public event JsAction<Rectangle> rectanglecomplete
        {
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.addListener", InsertArg0 = "\"rectanglecomplete\"")]
            add { }
            [JsMethod(InstanceImplementedAsExtension = true, Name = "google.maps.event.removeListener", InsertArg0 = "\"rectanglecomplete\"")]
            remove { }
        }

    }
    [JsType(JsMode.Json)]
    public class DrawingManagerOptions
    {
        /// <summary>
        ///Options to apply to any new circles created with this DrawingManager. The center and radius properties are ignored, and the map property of a new circle is always set to the DrawingManager's map.
        /// </summary>
        public CircleOptions circleOptions { get; set; }
        /// <summary>
        ///The enabled/disabled state of the drawing control. Defaults to true.
        /// </summary>
        public bool drawingControl { get; set; }
        /// <summary>
        ///The display options for the drawing control.
        /// </summary>
        public DrawingControlOptions drawingControlOptions { get; set; }
        /// <summary>
        ///The DrawingManager's drawing mode, which defines the type of overlay to be added on the map. Accepted values are MARKER, POLYGON, POLYLINE, RECTANGLE, CIRCLE, or null. A drawing mode of null means that the user can interact with the map as normal, and clicks do not draw anything.
        /// </summary>
        public OverlayType drawingMode { get; set; }
        /// <summary>
        ///The Map to which the DrawingManager is attached, which is the Map on which the overlays created will be placed.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///Options to apply to any new markers created with this DrawingManager. The position property is ignored, and the map property of a new marker is always set to the DrawingManager's map.
        /// </summary>
        public MarkerOptions markerOptions { get; set; }
        /// <summary>
        ///Options to apply to any new polygons created with this DrawingManager. The paths property is ignored, and the map property of a new polygon is always set to the DrawingManager's map.
        /// </summary>
        public PolygonOptions polygonOptions { get; set; }
        /// <summary>
        ///Options to apply to any new polylines created with this DrawingManager. The path property is ignored, and the map property of a new polyline is always set to the DrawingManager's map.
        /// </summary>
        public PolylineOptions polylineOptions { get; set; }
        /// <summary>
        ///Options to apply to any new rectangles created with this DrawingManager. The bounds property is ignored, and the map property of a new rectangle is always set to the DrawingManager's map.
        /// </summary>
        public RectangleOptions rectangleOptions { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DrawingControlOptions
    {
        /// <summary>
        ///The drawing modes to display in the drawing control, in the order in which they are to be displayed. The hand icon (which corresponds to the null drawing mode) is always available and is not to be specified in this array. Defaults to [MARKER, POLYLINE, RECTANGLE, CIRCLE, POLYGON].
        /// </summary>
        public JsArray<OverlayType> drawingModes { get; set; }
        /// <summary>
        ///Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition position { get; set; }
    }
    [JsType(JsMode.Json)]
    public class OverlayCompleteEvent
    {
        /// <summary>
        ///The completed overlay.
        /// </summary>
        public object overlay { get; set; }
        /// <summary>
        ///The completed overlay's type.
        /// </summary>
        public OverlayType type { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.drawing.OverlayType")]
    public class OverlayType
    {
        /// <summary>
        ///Specifies that the DrawingManager creates circles, and that the overlay given in the overlaycomplete event is a circle.
        /// </summary>
        public static OverlayType CIRCLE { get; private set; }
        /// <summary>
        ///Specifies that the DrawingManager creates markers, and that the overlay given in the overlaycomplete event is a marker.
        /// </summary>
        public static OverlayType MARKER { get; private set; }
        /// <summary>
        ///Specifies that the DrawingManager creates polygons, and that the overlay given in the overlaycomplete event is a polygon.
        /// </summary>
        public static OverlayType POLYGON { get; private set; }
        /// <summary>
        ///Specifies that the DrawingManager creates polylines, and that the overlay given in the overlaycomplete event is a polyline.
        /// </summary>
        public static OverlayType POLYLINE { get; private set; }
        /// <summary>
        ///Specifies that the DrawingManager creates rectangles, and that the overlay given in the overlaycomplete event is a rectangle.
        /// </summary>
        public static OverlayType RECTANGLE { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.weather.CloudLayer")]
    public class CloudLayer
    {
        /// <summary>
        ///Creates a new CloudLayer instance that displays a cloud overlay.
        /// </summary>
        public CloudLayer() { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.weather.WeatherLayer")]
    public class WeatherLayer
    {
        /// <summary>
        ///Creates a new WeatherLayer instance that displays weather icons.
        /// </summary>
        public WeatherLayer(WeatherLayerOptions opts = null) { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Sets the WeatherLayer's options.
        /// </summary>
        public void setOptions(WeatherLayerOptions options) { }
        /// <summary>
        ///This event is fired when a feature in the weather layer is clicked.
        /// </summary>
        public JsAction<WeatherMouseEvent> click { get; set; }
    }
    [JsType(JsMode.Json)]
    public class WeatherLayerOptions
    {
        /// <summary>
        ///If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///The color of labels on the weather layer. If this is not explicitly set, the label color is chosen automatically depending on the map type.
        /// </summary>
        public LabelColor labelColor { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows when weather icons are clicked.
        /// </summary>
        public bool suppressInfoWindows { get; set; }
        /// <summary>
        ///The units to use for temperature.
        /// </summary>
        public TemperatureUnit temperatureUnits { get; set; }
        /// <summary>
        ///The units to use for wind speed.
        /// </summary>
        public WindSpeedUnit windSpeedUnits { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.weather.TemperatureUnit")]
    public class TemperatureUnit
    {
        /// <summary>
        ///Specifies that temperatures should be displayed in degrees Celsius.
        /// </summary>
        public static object CELSIUS { get; private set; }
        /// <summary>
        ///Specifies that temperatures should be displayed in degrees Fahrenheit.
        /// </summary>
        public static object FAHRENHEIT { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.weather.WindSpeedUnit")]
    public class WindSpeedUnit
    {
        /// <summary>
        ///Specifies that wind speeds should be displayed in kilometers per hour.
        /// </summary>
        public static object KILOMETERS_PER_HOUR { get; private set; }
        /// <summary>
        ///Specifies that wind speeds should be displayed in meters per second.
        /// </summary>
        public static object METERS_PER_SECOND { get; private set; }
        /// <summary>
        ///Specifies that wind speeds should be displayed in miles per hour.
        /// </summary>
        public static object MILES_PER_HOUR { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.weather.LabelColor")]
    public class LabelColor
    {
        /// <summary>
        ///Weather labels will be displayed as black text with a white border.
        /// </summary>
        public static object BLACK { get; private set; }
        /// <summary>
        ///Weather labels will be displayed as white text with a black border.
        /// </summary>
        public static object WHITE { get; private set; }
    }
    [JsType(JsMode.Json)]
    public class WeatherMouseEvent
    {
        /// <summary>
        ///A WeatherFeature object containing information about the clicked feature.
        /// </summary>
        public WeatherFeature featureDetails { get; set; }
        /// <summary>
        ///Pre-rendered HTML content to display within a feature's InfoWindow when clicked.
        /// </summary>
        public JsString infoWindowHtml { get; set; }
        /// <summary>
        ///The position at which to anchor an info window on the clicked feature.
        /// </summary>
        public LatLng latLng { get; set; }
        /// <summary>
        ///The offset to apply to an info window anchored on the clicked feature.
        /// </summary>
        public Size pixelOffset { get; set; }
    }
    [JsType(JsMode.Json)]
    public class WeatherFeature
    {
        /// <summary>
        ///The current weather conditions at this location.
        /// </summary>
        public WeatherConditions current { get; set; }
        /// <summary>
        ///A forecast of weather conditions over the next four days. The forecast array is always in chronological order.
        /// </summary>
        public JsArray<WeatherForecast> forecast { get; set; }
        /// <summary>
        ///The location name of this feature, e.g. "San Francisco, California".
        /// </summary>
        public JsString location { get; set; }
        /// <summary>
        ///The temperature units being used.
        /// </summary>
        public TemperatureUnit temperatureUnit { get; set; }
        /// <summary>
        ///The wind speed units being used.
        /// </summary>
        public WindSpeedUnit windSpeedUnit { get; set; }
    }
    [JsType(JsMode.Json)]
    public class WeatherConditions
    {
        /// <summary>
        ///The current day of the week in long form, e.g. "Monday".
        /// </summary>
        public JsString day { get; set; }
        /// <summary>
        ///A description of the conditions, e.g. "Partly Cloudy".
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///The highest temperature reached during the day.
        /// </summary>
        public JsNumber high { get; set; }
        /// <summary>
        ///The current humidity, expressed as a percentage.
        /// </summary>
        public JsNumber humidity { get; set; }
        /// <summary>
        ///The lowest temperature reached during the day.
        /// </summary>
        public JsNumber low { get; set; }
        /// <summary>
        ///The current day of the week in short form, e.g. "M".
        /// </summary>
        public JsString shortDay { get; set; }
        /// <summary>
        ///The current temperature, in the specified temperature units.
        /// </summary>
        public JsNumber temperature { get; set; }
        /// <summary>
        ///The current wind direction.
        /// </summary>
        public JsString windDirection { get; set; }
        /// <summary>
        ///The current wind speed, in the specified wind speed units.
        /// </summary>
        public JsNumber windSpeed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class WeatherForecast
    {
        /// <summary>
        ///The day of the week in long form, e.g. "Monday".
        /// </summary>
        public JsString day { get; set; }
        /// <summary>
        ///A description of the conditions, e.g. "Partly Cloudy".
        /// </summary>
        public JsString description { get; set; }
        /// <summary>
        ///The highest temperature reached during the day.
        /// </summary>
        public JsNumber high { get; set; }
        /// <summary>
        ///The lowest temperature reached during the day.
        /// </summary>
        public JsNumber low { get; set; }
        /// <summary>
        ///The day of the week in short form, e.g. "M".
        /// </summary>
        public JsString shortDay { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.visualization.MapsEngineLayer")]
    public class MapsEngineLayer
    {
        /// <summary>
        ///Creates a new instance of MapsEngineLayer.
        /// </summary>
        public MapsEngineLayer(MapsEngineLayerOptions options) { }
        /// <summary>
        ///Returns the ID of the Maps Engine layer being displayed, if set.
        /// </summary>
        public JsString getLayerId() { return null; }
        /// <summary>
        ///Returns the key of the layer to be displayed.
        /// </summary>
        public JsString getLayerKey() { return null; }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns the ID of the Maps Engine map to which the layer belongs.
        /// </summary>
        public JsString getMapId() { return null; }
        /// <summary>
        ///Returns properties of the Maps Engine layer, which are available once the layer has loaded.
        /// </summary>
        public MapsEngineLayerProperties getProperties() { return null; }
        /// <summary>
        ///Returns the status of the layer, which is available once the requested layer has loaded.
        /// </summary>
        public MapsEngineStatus getStatus() { return null; }
        /// <summary>
        ///Sets the ID of a single Maps Engine layer to display. Changing this value will cause the layer to be redrawn.
        /// </summary>
        public void setLayerId(JsString layerId) { }
        /// <summary>
        ///Sets the key of the layer to be displayed. Maps Engine layer keys are only unique within a single map, and can be changed by map owners. Changing this value will cause the layer to be redrawn.
        /// </summary>
        public void setLayerKey(JsString layerKey) { }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
        /// <summary>
        ///Sets the ID of the Maps Engine map that contains the layer with the given layerKey. Changing this value will cause the layer to be redrawn.
        /// </summary>
        public void setMapId(JsString mapId) { }
        public void setOptions(MapsEngineLayerOptions options) { }
        /// <summary>
        ///This event is fired when a feature in the layer is clicked.
        /// </summary>
        public JsAction<MapsEngineMouseEvent> click { get; set; }
        /// <summary>
        ///This event is fired when the layer has finished loading, and the layer's properties are available for reading.
        /// </summary>
        public JsAction properties_changed { get; set; }
        /// <summary>
        ///This event is fired when the layer has finished loading, and the status is available to determine if the layer loaded successfully.
        /// </summary>
        public JsAction status_changed { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapsEngineLayerOptions
    {
        /// <summary>
        ///If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///The ID of a single Maps Engine layer to display.
        /// </summary>
        public JsString layerId { get; set; }
        /// <summary>
        ///The key of the layer to display. Maps Engine layer keys are only unique within a single map, and can be changed by map owners.
        /// </summary>
        public JsString layerKey { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The ID of the Maps Engine map that contains the layer with the given layerKey.
        /// </summary>
        public JsString mapId { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows when layer features are clicked.
        /// </summary>
        public bool suppressInfoWindows { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapsEngineLayerProperties
    {
        /// <summary>
        ///The name of the layer.
        /// </summary>
        public JsString name { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapsEngineMouseEvent
    {
        /// <summary>
        ///The feature ID, guaranteed to be unique within the layer.
        /// </summary>
        public JsString featureId { get; set; }
        /// <summary>
        ///Pre-rendered HTML content, as placed in the infowindow by the default UI.
        /// </summary>
        public JsString infoWindowHtml { get; set; }
        /// <summary>
        ///The position at which to anchor an infowindow on the clicked feature.
        /// </summary>
        public LatLng latLng { get; set; }
        /// <summary>
        ///The offset to apply to an infowindow anchored on the clicked feature.
        /// </summary>
        public Size pixelOffset { get; set; }
    }
    [JsType(JsMode.Json)]
    public class MapsEngineStatus
    {
        /// <summary>
        ///The requested layer is not a valid layer.
        /// </summary>
        public static object INVALID_LAYER { get; private set; }
        /// <summary>
        ///The layer loaded successfully.
        /// </summary>
        public static object OK { get; private set; }
        /// <summary>
        ///The layer failed to load for an unknown reason.
        /// </summary>
        public static object UNKNOWN_ERROR { get; private set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.visualization.HeatmapLayer")]
    public class HeatmapLayer
    {
        /// <summary>
        ///Creates a new instance of HeatmapLayer.
        /// </summary>
        public HeatmapLayer(HeatmapLayerOptions opts = null) { }
        /// <summary>
        ///Returns the data points currently displayed by this heatmap.
        /// </summary>
        public object getData() { return null; }
        public Map getMap() { return null; }
        /// <summary>
        ///Sets the data points to be displayed by this heatmap.
        /// </summary>
        public void setData(object data) { }
        /// <summary>
        ///Renders the heatmap on the specified map. If map is set to null, the heatmap will be removed.
        /// </summary>
        public void setMap(Map map) { }
    }
    [JsType(JsMode.Json)]
    public class HeatmapLayerOptions
    {
        /// <summary>
        ///The data points to display. Required.
        /// </summary>
        public MVCArray<LatLng> data { get; set; }
        /// <summary>
        ///Specifies whether heatmaps dissipate on zoom. By default, the radius of influence of a data point is specified by the radius option only. When dissipating is disabled, the radius option is intepreted as a radius at zoom level 0.
        /// </summary>
        public bool dissipating { get; set; }
        /// <summary>
        ///The color gradient of the heatmap, specified as an array of CSS color strings. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public JsArray<JsString> gradient { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///The maximum intensity of the heatmap. By default, heatmap colors are dynamically scaled according to the greatest concentration of points at any particular pixel on the map. This property allows you to specify a fixed maximum.
        /// </summary>
        public JsNumber maxIntensity { get; set; }
        /// <summary>
        ///The opacity of the heatmap, expressed as a number between 0 and 1. Defaults to 0.6.
        /// </summary>
        public JsNumber opacity { get; set; }
        /// <summary>
        ///The radius of influence for each data point, in pixels.
        /// </summary>
        public JsNumber radius { get; set; }
    }
    [JsType(JsMode.Json)]
    public class WeightedLocation
    {
        /// <summary>
        ///The location of data point.
        /// </summary>
        public LatLng location { get; set; }
        /// <summary>
        ///The weighting value of the data point.
        /// </summary>
        public JsNumber weight { get; set; }
    }
    [JsType(JsMode.Prototype, Name = "google.maps.visualization.DemographicsLayer")]
    public class DemographicsLayer
    {
        /// <summary>
        ///Creates a new instance of DemographicsLayer.
        /// </summary>
        public DemographicsLayer(DemographicsLayerOptions opts = null) { }
        /// <summary>
        ///Returns the map on which this layer is displayed.
        /// </summary>
        public Map getMap() { return null; }
        /// <summary>
        ///Returns the query that defines which regions are shown.
        /// </summary>
        public DemographicsQuery getQuery() { return null; }
        /// <summary>
        ///Returns the rules that define how regions are styled.
        /// </summary>
        public JsArray<DemographicsStyle> getStyle() { return null; }
        /// <summary>
        ///Renders the layer on the specified map. If map is set to null, the layer will be removed.
        /// </summary>
        public void setMap(Map map) { }
        public void setOptions(DemographicsLayerOptions options) { }
        /// <summary>
        ///Changes the query that defines which regions are shown.
        /// </summary>
        public void setQuery(DemographicsQuery query) { }
        /// <summary>
        ///Changes the rules that define how regions are styled.
        /// </summary>
        public void setStyle(JsArray<DemographicsStyle> style) { }
    }
    [JsType(JsMode.Json)]
    public class DemographicsLayerOptions
    {
        /// <summary>
        ///If true, the layer receives mouse events. Defaults to true.
        /// </summary>
        public bool clickable { get; set; }
        /// <summary>
        ///The map on which to display the layer.
        /// </summary>
        public Map map { get; set; }
        /// <summary>
        ///Specifies which regions to show on the map.
        /// </summary>
        public DemographicsQuery query { get; set; }
        /// <summary>
        ///Specifies how to style the regions matched.
        /// </summary>
        public JsArray<DemographicsStyle> style { get; set; }
        /// <summary>
        ///Suppress the rendering of info windows when layer features are clicked.
        /// </summary>
        public JsString suppressInfoWindows { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DemographicsQuery
    {
        /// <summary>
        ///The data set to display.
        /// </summary>
        public JsString from { get; set; }
        /// <summary>
        ///Expression to define the regions to show.
        /// </summary>
        public JsString where { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DemographicsStyle
    {
        /// <summary>
        ///Defines the styling applied to the region polygons selected by this styling rule.
        /// </summary>
        public DemographicsPolygonOptions polygonOptions { get; set; }
        /// <summary>
        ///Expression that defines the regions to which this style rule applies.
        /// </summary>
        public JsString where { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DemographicsPolygonOptions
    {
        /// <summary>
        ///The fill color, defined by a six-digit hexadecimal number in #RRGGBB format (e.g. #00AAFF).
        /// </summary>
        public JsString fillColor { get; set; }
        /// <summary>
        ///Advanced styling for fillColor.
        /// </summary>
        public DemographicsPropertyStyle fillColorStyle { get; set; }
        /// <summary>
        ///The fill opacity between 0.0 and 1.0.
        /// </summary>
        public JsNumber fillOpacity { get; set; }
        /// <summary>
        ///Advanced styling for fillOpacity.
        /// </summary>
        public DemographicsPropertyStyle fillOpacityStyle { get; set; }
        /// <summary>
        ///The fill color, defined by a six-digit hexadecimal number in #RRGGBB format (e.g. #00AAFF).
        /// </summary>
        public JsString strokeColor { get; set; }
        /// <summary>
        ///Advanced styling for strokeColor.
        /// </summary>
        public DemographicsPropertyStyle strokeColorStyle { get; set; }
        /// <summary>
        ///The stroke opacity between 0.0 and 1.0.
        /// </summary>
        public JsNumber strokeOpacity { get; set; }
        /// <summary>
        ///Advanced styling for strokeOpacity.
        /// </summary>
        public DemographicsPropertyStyle strokeOpacityStyle { get; set; }
        /// <summary>
        ///The stroke width in pixels, between 0 and 10.
        /// </summary>
        public JsNumber strokeWeight { get; set; }
    }
    [JsType(JsMode.Json)]
    public class DemographicsPropertyStyle
    {
        /// <summary>
        ///The expression used to determine the value that determines how to style a region.
        /// </summary>
        public JsString expression { get; set; }
        /// <summary>
        ///The sequence of colors that are mapped to the range of values for selected regions.
        /// </summary>
        public JsArray<JsString> gradient { get; set; }
        /// <summary>
        ///The maximum of the range of expression values across which the gradient of colors is mapped.
        /// </summary>
        public JsNumber max { get; set; }
        /// <summary>
        ///The minimum of the range of expression values across which the gradient of colors is mapped.
        /// </summary>
        public JsNumber min { get; set; }
    }
}