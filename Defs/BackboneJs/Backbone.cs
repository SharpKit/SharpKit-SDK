using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html;

namespace SharpKit.BackboneJs
{

    //[JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.Model")]
    //public class BackboneModel<T>
    //{
    //    public T defaults { get; set; }

    //    [JsMethod(Name = "defaults")]
    //    public virtual T createDefaults()
    //    {
    //        return default(T);
    //    }
    //    public virtual void initialize()
    //    {
    //    }
    //    public virtual void save(T obj)
    //    {
    //    }
    //    public P get<P>(JsString name) { return default(P); }
    //    public void set<T>(T values) { }

    //    public virtual void bind(JsString eventName, Func<object> function, object @this)
    //    {

    //    }
    //}

    //[JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.Collection")]
    //public class BackboneCollection<T>
    //{

    //}

    //[JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.View")]
    //public class BackboneView<T>
    //{
    //    public T defaults { get; set; }
    //    [JsMethod(Name = "defaults")]
    //    public virtual T createDefaults()
    //    {
    //        return default(T);
    //    }

    //    //public virtual JsString tagName { get; set; }

    //    public virtual void initialize()
    //    {
    //    }
    //    public virtual void save(T obj)
    //    {
    //    }
    //    public P get<P>(JsString name) { return default(P); }
    //    public void set<T>(T values) { }




    //    public virtual T render()
    //    {
    //        return default(T);
    //    }

    //    public virtual T remove()
    //    {
    //        return default(T);
    //    }
    //}

    /// <summary>
    /// Models are the heart of any JavaScript application, containing the interactive data as well as a large part of the logic surrounding it: conversions, validations, computed properties, and access control.
    /// You extend Backbone.Model with your domain-specific methods, and Model provides a basic set of functionality for managing changes.
    /// The following is a contrived example, but it demonstrates defining a model with a custom method, setting an attribute, and firing an event keyed to changes in that specific attribute.
    /// After running this code once, sidebar will be available in your browser's console, so you can play around with it.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Backbone.Model", Export = false)]
    public class Model
    {
        /// <summary>
        /// When creating an instance of a model, you can pass in the initial values of the attributes, which will be set on the model.
        /// If you define an initialize function, it will be invoked when the model is created.
        /// In rare cases, if you're looking to get fancy, you may want to override constructor, which allows you to replace the actual constructor function for your model.
        /// </summary>
        public Model() { }
        /// <summary>
        /// When creating an instance of a model, you can pass in the initial values of the attributes, which will be set on the model.
        /// If you define an initialize function, it will be invoked when the model is created.
        /// In rare cases, if you're looking to get fancy, you may want to override constructor, which allows you to replace the actual constructor function for your model.
        /// </summary>
        public Model(object attributes) { }

        /// <summary>
        /// To create a Model class of your own, you extend Backbone.Model and provide instance properties,
        /// as well as optional classProperties to be attached directly to the constructor function.
        /// extend correctly sets up the prototype chain, so subclasses created with extend can be further extended and subclassed as far as you like.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="classProperties"></param>
        ///<example>
        ///usage
        ///<code>
        ///var Note = Backbone.Model.extend({
        /// 
        ///   initialize: function() { ... },
        /// 
        ///   author: function() { ... },
        /// 
        ///   coordinates: function() { ... },
        /// 
        ///   allowedToEdit: function(account) {
        ///     return true;
        ///   }
        /// 
        /// });
        /// 
        /// var PrivateNote = Note.extend({
        /// 
        ///   allowedToEdit: function(account) {
        ///     return account.owns(this);
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties, object classProperties) { }
        /// <summary>
        /// To create a Model class of your own, you extend Backbone.Model and provide instance properties,
        /// as well as optional classProperties to be attached directly to the constructor function.
        /// extend correctly sets up the prototype chain, so subclasses created with extend can be further extended and subclassed as far as you like.
        /// </summary>
        /// <param name="properties"></param>
        ///<example>
        ///usage
        ///<code>
        ///var Note = Backbone.Model.extend({
        /// 
        ///   initialize: function() { ... },
        /// 
        ///   author: function() { ... },
        /// 
        ///   coordinates: function() { ... },
        /// 
        ///   allowedToEdit: function(account) {
        ///     return true;
        ///   }
        /// 
        /// });
        /// 
        /// var PrivateNote = Note.extend({
        /// 
        ///   allowedToEdit: function(account) {
        ///     return account.owns(this);
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties) { }

        /// <summary>
        /// Get the current value of an attribute from the model. For example: note.get("title")
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public object get(JsString attribute) { return null; }

        /// <summary>
        /// Set a hash of attributes (one or many) on the model.
        /// If any of the attributes change the models state,a "change" event will be triggered, unless {silent: true} is passed as an option.
        /// Change events for specific attributes are also triggered, and you can bind to those as well,
        /// for example: change:title, and change:content. You may also pass individual keys and values.
        /// If the model has a validate method, it will be validated before the attributes are set, no changes will occur if the validation fails, and set will return false.
        /// Otherwise, set returns a reference to the model. You may also pass an error callback in the options, which will be invoked instead of triggering an "error" event,
        /// should validation fail. If {silent: true} is passed as an option, the validation is deferred until the next change.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="options"></param>
        public void set(object attributes, object options) { }
        /// <summary>
        /// Set a hash of attributes (one or many) on the model.
        /// If any of the attributes change the models state,a "change" event will be triggered, unless {silent: true} is passed as an option.
        /// Change events for specific attributes are also triggered, and you can bind to those as well,
        /// for example: change:title, and change:content. You may also pass individual keys and values.
        /// If the model has a validate method, it will be validated before the attributes are set, no changes will occur if the validation fails, and set will return false.
        /// Otherwise, set returns a reference to the model. You may also pass an error callback in the options, which will be invoked instead of triggering an "error" event,
        /// should validation fail. If {silent: true} is passed as an option, the validation is deferred until the next change.
        /// </summary>
        /// <param name="attributes"></param>
        public void set(JsString attributes) { }

        /// <summary>
        /// Similar to get, but returns the HTML-escaped version of a model's attribute.
        /// If you're interpolating data from the model into HTML, using escape to retrieve attributes will prevent XSS attacks.
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var hacker = new Backbone.Model({
        ///   name: "<script>alert('xss')</script>"
        /// });
        /// 
        /// alert(hacker.escape('name'));
        ///</code>
        ///</example>
        public object escape(JsString attribute) { return null; }
        //TODO: return type?

        /// <summary>
        /// Returns true if the attribute is set to a non-null or non-undefined value
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///if (note.has("title")) {
        ///   ...
        /// }
        ///</code>
        ///</example>
        public bool has(JsString attribute) { return false; }

        /// <summary>
        /// Remove an attribute by deleting it from the internal attributes hash. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="options"></param>
        public void unsetmodel(JsString attribute, object options) { }
        /// <summary>
        /// Remove an attribute by deleting it from the internal attributes hash. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        /// <param name="attribute"></param>
        public void unsetmodel(JsString attribute) { }

        /// <summary>
        /// Removes all attributes from the model. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        /// <param name="options"></param>
        public void clear(object options) { }
        /// <summary>
        /// Removes all attributes from the model. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        public void clear() { }

        /// <summary>
        ///A special property of models, the id is an arbitrary string (integer id or UUID).
        ///If you set the id in the attributes hash, it will be copied onto the model as a direct property.
        ///Models can be retrieved by id from collections, and the id is used to generate model URLs by default.
        /// </summary>
        [JsProperty(Name = "id")]
        public static JsString idString { get; set; }
        /// <summary>
        ///A special property of models, the id is an arbitrary string (integer id or UUID).
        ///If you set the id in the attributes hash, it will be copied onto the model as a direct property.
        ///Models can be retrieved by id from collections, and the id is used to generate model URLs by default.
        /// </summary>
        public static JsNumber id { get; set; }

        /// <summary>
        /// A model's unique identifier is stored under the id attribute.
        /// If you're directly communicating with a backend (CouchDB, MongoDB) that uses a different unique key,
        /// you may set a Model's idAttribute to transparently map from that key to id.
        /// </summary>
        public static JsString idAttribute { get; set; }

        /// <summary>
        /// A special property of models, the cid or client id is a unique identifier automatically assigned to all models when they're first created.
        /// Client ids are handy when the model has not yet been saved to the server, and does not yet have its eventual true id, but already needs to be visible in the UI.
        /// Client ids take the form: c1, c2, c3 ...
        /// </summary>
        public static JsString cid { get; set; }

        /// <summary>
        /// The attributes property is the internal hash containing the model's state. Please use set to update the attributes instead of modifying them directly.
        /// If you'd like to retrieve and munge a copy of the model's attributes, use toJSON instead.
        /// </summary>
        public static object attributes { get; set; }

        /// <summary>
        /// The changed property is the internal hash containing all the attributes that have changed since the last "change" event was triggered.
        /// Please do not update changed directly.
        /// Its state is maintained internally by set and change. A copy of changed can be acquired from changedAttributes.
        /// </summary>
        public static object changed { get; set; }

        /// <summary>
        /// The defaults hash (or function) can be used to specify the default attributes for your model.
        /// When creating an instance of the model, any unspecified attributes will be set to their default value.
        /// Remember that in JavaScript, objects are passed by reference, so if you include an object as a default value, it will be shared among all instances.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var Meal = Backbone.Model.extend({
        ///   defaults: {
        ///     "appetizer":  "caesar salad",
        ///     "entree":     "ravioli",
        ///     "dessert":    "cheesecake"
        ///   }
        /// });
        /// 
        /// alert("Dessert will be " + (new Meal).get('dessert'));
        ///</code>
        ///</example>
        public static object defaults { get; set; }
        //TODO: propertye or function?

        /// <summary>
        /// Return a copy of the model's attributes for JSON stringification.
        /// This can be used for persistence, serialization, or for augmentation before being handed off to a view.
        /// The name of this method is a bit confusing, as it doesn't actually return a JSON string —
        /// but I'm afraid that it's the way that the JavaScript API for JSON.stringify works.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var artist = new Backbone.Model({
        ///   firstName: "Wassily",
        ///   lastName: "Kandinsky"
        /// });
        /// 
        /// artist.set({birthday: "December 16, 1866"});
        /// 
        /// alert(JSON.stringify(artist));
        ///</code>
        ///</example>
        public object toJSON() { return null; }
        //TODO: return type

        /// <summary>
        /// Resets the model's state from the server by delegating to Backbone.sync. Returns a jqXHR.
        /// Useful if the model has never been populated with data, or if you'd like to ensure that you have the latest server state.
        /// A "change" event will be triggered if the server's state differs from the current attributes.
        /// Accepts success and error callbacks in the options hash, which are passed (model, response) as arguments.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // Poll every 10 seconds to keep the channel model up-to-date.
        /// setInterval(function() {
        ///   channel.fetch();
        /// }, 10000);
        ///</code>
        ///</example>
        public jqXHR fetch(object options) { return null; }

        /// <summary>
        /// Save a model to your database (or alternative persistence layer), by delegating to Backbone.sync.
        /// Returns a jqXHR if validation is successful and false otherwise.
        /// The attributes hash (as in set) should contain the attributes you'd like to change — keys that aren't mentioned won't be altered — but,
        /// a complete representation of the resource will be sent to the server. As with set, you may pass individual keys and values instead of a hash.
        /// If the model has a validate method, and validation fails, the model will not be saved.
        /// If the model isNew, the save will be a "create" (HTTP POST), if the model already exists on the server, the save will be an "update" (HTTP PUT).
        /// Calling save with new attributes will cause a "change" event immediately, and a "sync" event after the server has acknowledged the successful change.
        /// Pass {wait: true} if you'd like to wait for the server before setting the new attributes on the model.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///Backbone.sync = function(method, model) {
        ///   alert(method + ": " + JSON.stringify(model));
        ///   model.id = 1;
        /// };
        /// 
        /// var book = new Backbone.Model({
        ///   title: "The Rough Riders",
        ///   author: "Theodore Roosevelt"
        /// });
        /// 
        /// book.save();
        /// 
        /// book.save({author: "Teddy"});
        ///</code>
        ///</example>
        public object save(object attributes, object options) { return null; }
        //TODO: return type
        /// <summary>
        /// Save a model to your database (or alternative persistence layer), by delegating to Backbone.sync.
        /// Returns a jqXHR if validation is successful and false otherwise.
        /// The attributes hash (as in set) should contain the attributes you'd like to change — keys that aren't mentioned won't be altered — but,
        /// a complete representation of the resource will be sent to the server. As with set, you may pass individual keys and values instead of a hash.
        /// If the model has a validate method, and validation fails, the model will not be saved.
        /// If the model isNew, the save will be a "create" (HTTP POST), if the model already exists on the server, the save will be an "update" (HTTP PUT).
        /// Calling save with new attributes will cause a "change" event immediately, and a "sync" event after the server has acknowledged the successful change.
        /// Pass {wait: true} if you'd like to wait for the server before setting the new attributes on the model.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///Backbone.sync = function(method, model) {
        ///   alert(method + ": " + JSON.stringify(model));
        ///   model.id = 1;
        /// };
        /// 
        /// var book = new Backbone.Model({
        ///   title: "The Rough Riders",
        ///   author: "Theodore Roosevelt"
        /// });
        /// 
        /// book.save();
        /// 
        /// book.save({author: "Teddy"});
        ///</code>
        ///</example>
        public object save(object attributes) { return null; }
        //TODO: return type
        /// <summary>
        /// Save a model to your database (or alternative persistence layer), by delegating to Backbone.sync.
        /// Returns a jqXHR if validation is successful and false otherwise.
        /// The attributes hash (as in set) should contain the attributes you'd like to change — keys that aren't mentioned won't be altered — but,
        /// a complete representation of the resource will be sent to the server. As with set, you may pass individual keys and values instead of a hash.
        /// If the model has a validate method, and validation fails, the model will not be saved.
        /// If the model isNew, the save will be a "create" (HTTP POST), if the model already exists on the server, the save will be an "update" (HTTP PUT).
        /// Calling save with new attributes will cause a "change" event immediately, and a "sync" event after the server has acknowledged the successful change.
        /// Pass {wait: true} if you'd like to wait for the server before setting the new attributes on the model.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///Backbone.sync = function(method, model) {
        ///   alert(method + ": " + JSON.stringify(model));
        ///   model.id = 1;
        /// };
        /// 
        /// var book = new Backbone.Model({
        ///   title: "The Rough Riders",
        ///   author: "Theodore Roosevelt"
        /// });
        /// 
        /// book.save();
        /// 
        /// book.save({author: "Teddy"});
        ///</code>
        ///</example>
        public object save() { return null; }
        //TODO: return type

        /// <summary>
        /// Destroys the model on the server by delegating an HTTP DELETE request to Backbone.sync. Returns a jqXHR object, or false if the model isNew.
        /// Accepts success and error callbacks in the options hash.
        /// Triggers a "destroy" event on the model, which will bubble up through any collections that contain it, and a "sync" event, after the server has successfully acknowledged the model's deletion.
        /// Pass {wait: true} if you'd like to wait for the server to respond before removing the model from the collection.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public object destroy(object options) { return null; }
        /// <summary>
        /// Destroys the model on the server by delegating an HTTP DELETE request to Backbone.sync. Returns a jqXHR object, or false if the model isNew.
        /// Accepts success and error callbacks in the options hash.
        /// Triggers a "destroy" event on the model, which will bubble up through any collections that contain it, and a "sync" event, after the server has successfully acknowledged the model's deletion.
        /// Pass {wait: true} if you'd like to wait for the server to respond before removing the model from the collection.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// This method is left undefined, and you're encouraged to override it with your custom validation logic, if you have any that can be performed in JavaScript.
        /// validate is called before set and save, and is passed the model attributes updated with the values from set or save.
        /// If the attributes are valid, don't return anything from validate; if they are invalid, return an error of your choosing.
        /// It can be as simple as a string error message to be displayed, or a complete error object that describes the error programmatically.
        /// If validate returns an error, set and save will not continue, and the model attributes will not be modified. Failed validations trigger an "error" event.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Chapter = Backbone.Model.extend({
        ///   validate: function(attrs) {
        ///     if (attrs.end &lt; attrs.start) {
        ///       return "can't end before it starts";
        ///     }
        ///   }
        /// });
        /// 
        /// var one = new Chapter({
        ///   title : "Chapter One: The Beginning"
        /// });
        /// 
        /// one.on("error", function(model, error) {
        ///   alert(model.get("title") + " " + error);
        /// });
        /// 
        /// one.set({
        ///   start: 15,
        ///   end:   10
        /// });
        ///</code>
        ///</example>
        public object validate(object attributes) { return null; }

        /// <summary>
        /// Models may enter an invalid state if you make changes to them silently ... useful when dealing with form input.
        /// Call model.isValid() to check if the model is currently in a valid state, according to your validate function.
        /// </summary>
        /// <returns></returns>
        public bool isValid() { return false; }

        /// <summary>
        /// Returns the relative URL where the model's resource would be located on the server.
        /// If your models are located somewhere else, override this method with the correct logic.
        /// Generates URLs of the form: "/[collection.url]/[id]", falling back to "/[urlRoot]/id" if the model is not part of a collection.
        /// Delegates to Collection#url to generate the URL, so make sure that you have it defined, or a urlRoot property, if all models of this class share a common root URL.
        /// A model with an id of 101, stored in a Backbone.Collection with a url of "/documents/7/notes", would have this URL: "/documents/7/notes/101"
        /// </summary>
        /// <returns></returns>
        public JsString url() { return null; }

        /// <summary>
        /// Specify a urlRoot if you're using a model outside of a collection, to enable the default url function to generate URLs based on the model id. "/[urlRoot]/id"
        /// Note that urlRoot may also be defined as a function.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var Book = Backbone.Model.extend({urlRoot : '/books'});
        /// 
        /// var solaris = new Book({id: "1083-lem-solaris"});
        /// 
        /// alert(solaris.url());
        ///</code>
        ///</example>
        public static object urlRoot { get; set; }
        //TODO: Note that urlRoot may also be defined as a function.

        /// <summary>
        /// parse is called whenever a model's data is returned by the server, in fetch, and save.
        /// The function is passed the raw response object, and should return the attributes hash to be set on the model.
        /// The default implementation is a no-op, simply passing through the JSON response.
        /// Override this if you need to work with a preexisting API, or better namespace your responses.
        /// If you're working with a Rails backend, you'll notice that Rails' default to_json implementation includes a model's attributes under a namespace.
        /// To disable this behavior for seamless Backbone integration, set:
        /// </summary>
        /// <param name="response"></param>
        ///<example>
        ///usage
        ///<code>
        ///ActiveRecord::Base.include_root_in_json = false
        ///</code>
        ///</example>
        public void parse(object response) { }

        /// <summary>
        /// Returns a new instance of the model with identical attributes.
        /// </summary>
        /// <returns></returns>
        public Model clone() { return null; }

        /// <summary>
        /// Has this model been saved to the server yet? If the model does not yet have an id, it is considered to be new.
        /// </summary>
        /// <returns></returns>
        public bool isNew() { return false; }

        /// <summary>
        /// Manually trigger the "change" event and a "change:attribute" event for each attribute that has changed.
        /// If you've been passing {silent: true} to the set function in order to aggregate rapid changes to a model, you'll want to call model.change() when you're all finished.
        /// </summary>
        public void change() { }

        /// <summary>
        /// Has the model changed since the last "change" event? If an attribute is passed, returns true if that specific attribute has changed.
        /// Note that this method, and the following change-related ones, are only useful during the course of a "change" event.
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public bool hasChanged(object attribute) { return false; }
        /// <summary>
        ///     Has the model changed since the last "change" event? If an attribute is passed, returns true if that specific attribute has changed.
        /// Note that this method, and the following change-related ones, are only useful during the course of a "change" event.
        /// </summary>
        /// <returns></returns>
        public bool hasChanged() { return false; }

        /// <summary>
        /// Retrieve a hash of only the model's attributes that have changed.
        /// Optionally, an external attributes hash can be passed in, returning the attributes in that hash which differ from the model.
        /// This can be used to figure out which portions of a view should be updated, or what calls need to be made to sync the changes to the server.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="externalAttributes"></param>
        /// <returns></returns>
        public object changedAttributes(object attributes, object externalAttributes) { return null; }
        /// <summary>
        /// Retrieve a hash of only the model's attributes that have changed.
        /// Optionally, an external attributes hash can be passed in, returning the attributes in that hash which differ from the model.
        /// This can be used to figure out which portions of a view should be updated, or what calls need to be made to sync the changes to the server.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public object changedAttributes(object attributes) { return null; }
        /// <summary>
        /// Retrieve a hash of only the model's attributes that have changed.
        /// Optionally, an external attributes hash can be passed in, returning the attributes in that hash which differ from the model.
        /// This can be used to figure out which portions of a view should be updated, or what calls need to be made to sync the changes to the server.
        /// </summary>
        /// <returns></returns>
        public object changedAttributes() { return null; }

        /// <summary>
        /// During a "change" event, this method can be used to get the previous value of a changed attribute.
        /// </summary>
        /// <param name="attribute"></param>
        ///<example>
        ///usage
        ///<code>
        ///var bill = new Backbone.Model({
        ///   name: "Bill Smith"
        /// });
        /// 
        /// bill.on("change:name", function(model, name) {
        ///   alert("Changed name from " + bill.previous("name") + " to " + name);
        /// });
        /// 
        /// bill.set({name : "Bill Jones"});
        ///</code>
        ///</example>
        public void previous(JsString attribute) { }

        /// <summary>
        /// Return a copy of the model's previous attributes. Useful for getting a diff between versions of a model, or getting back to a valid state after an error occurs.
        /// </summary>
        /// <returns></returns>
        public object previousAttributes() { return null; }
    }

    /// <summary>
    /// Collections are ordered sets of models. You can bind "change" events to be notified when any model in the collection has been modified,
    /// listen for "add" and "remove" events, fetch the collection from the server, and use a full suite of Underscore.js methods.
    /// Any event that is triggered on a model in a collection will also be triggered on the collection directly, for convenience.
    /// This allows you to listen for changes to specific attributes in any model in a collection, for example: Documents.on("change:selected", ...)
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Backbone.Collection", Export = false)]
    public class Collection
    {
        /// <summary>
        /// When creating a Collection, you may choose to pass in the initial array of models. The collection's comparator function may be included as an option.
        /// If you define an initialize function, it will be invoked when the collection is created.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        public Collection(JsArray<Model> models, object options) { }
        /// <summary>
        /// When creating a Collection, you may choose to pass in the initial array of models. The collection's comparator function may be included as an option.
        /// If you define an initialize function, it will be invoked when the collection is created.
        /// </summary>
        /// <param name="models"></param>
        public Collection(JsArray<Model> models) { }
        /// <summary>
        /// When creating a Collection, you may choose to pass in the initial array of models. The collection's comparator function may be included as an option.
        /// If you define an initialize function, it will be invoked when the collection is created.
        /// </summary>
        public Collection() { }

        /// <summary>
        /// To create a Collection class of your own, extend Backbone.Collection,providing instance properties,
        /// as well as optional classProperties to be attached directly to the collection's constructor function.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="classProperties"></param>
        public void extend(object properties, object classProperties) { }
        /// <summary>
        /// To create a Collection class of your own, extend Backbone.Collection,providing instance properties,
        /// as well as optional classProperties to be attached directly to the collection's constructor function.
        /// </summary>
        /// <param name="properties"></param>
        public void extend(object properties) { }

        /// <summary>
        /// Override this property to specify the model class that the collection contains.
        /// If defined, you can pass raw attributes objects (and arrays) to add, create, and reset, and the attributes will be converted into a model of the proper type.
        /// </summary>
        public Model model { get; set; }

        /// <summary>
        /// Return an array containing the attributes hash of each model in the collection. This can be used to serialize and persist the collection as a whole.
        /// The name of this method is a bit confusing, because it conforms to JavaScript's JSON API.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var collection = new Backbone.Collection([
        ///   {name: "Tim", age: 5},
        ///   {name: "Ida", age: 26},
        ///   {name: "Rob", age: 55}
        /// ]);
        /// 
        /// alert(JSON.stringify(collection));
        ///</code>
        ///</example>
        public JsArray<JsString> toJSON() { return null; }

        //TODO: Underscore Methods 

        /// <summary>
        /// Add a model (or an array of models) to the collection. Fires an "add" event, which you can pass {silent: true} to suppress.
        /// If a model property is defined, you may also pass raw attributes objects, and have them be vivified as instances of the model.
        /// Pass {at: index} to splice the model into the collection at the specified index.
        /// Likewise, if you're a callback listening to a collection's "add" event, options.index will tell you the index at which the model is being added to the collection.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        ///<example>
        ///usage
        ///<code>
        ///var ships = new Backbone.Collection;
        /// 
        /// ships.on("add", function(ship) {
        ///   alert("Ahoy " + ship.get("name") + "!");
        /// });
        /// 
        /// ships.add([
        ///   {name: "Flying Dutchman"},
        ///   {name: "Black Pearl"}
        /// ]);
        ///</code>
        ///</example>
        public void add(Model models, object options) { }
        /// <summary>
        /// Add a model (or an array of models) to the collection. Fires an "add" event, which you can pass {silent: true} to suppress.
        /// If a model property is defined, you may also pass raw attributes objects, and have them be vivified as instances of the model.
        /// Pass {at: index} to splice the model into the collection at the specified index.
        /// Likewise, if you're a callback listening to a collection's "add" event, options.index will tell you the index at which the model is being added to the collection.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        ///<example>
        ///usage
        ///<code>
        ///var ships = new Backbone.Collection;
        /// 
        /// ships.on("add", function(ship) {
        ///   alert("Ahoy " + ship.get("name") + "!");
        /// });
        /// 
        /// ships.add([
        ///   {name: "Flying Dutchman"},
        ///   {name: "Black Pearl"}
        /// ]);
        ///</code>
        ///</example>
        public void add(JsArray<Model> models, object options) { }
        /// <summary>
        /// Add a model (or an array of models) to the collection. Fires an "add" event, which you can pass {silent: true} to suppress.
        /// If a model property is defined, you may also pass raw attributes objects, and have them be vivified as instances of the model.
        /// Pass {at: index} to splice the model into the collection at the specified index.
        /// Likewise, if you're a callback listening to a collection's "add" event, options.index will tell you the index at which the model is being added to the collection.
        /// </summary>
        /// <param name="models"></param>
        ///<example>
        ///usage
        ///<code>
        ///var ships = new Backbone.Collection;
        /// 
        /// ships.on("add", function(ship) {
        ///   alert("Ahoy " + ship.get("name") + "!");
        /// });
        /// 
        /// ships.add([
        ///   {name: "Flying Dutchman"},
        ///   {name: "Black Pearl"}
        /// ]);
        ///</code>
        ///</example>
        public void add(Model models) { }
        /// <summary>
        /// Add a model (or an array of models) to the collection. Fires an "add" event, which you can pass {silent: true} to suppress.
        /// If a model property is defined, you may also pass raw attributes objects, and have them be vivified as instances of the model.
        /// Pass {at: index} to splice the model into the collection at the specified index.
        /// Likewise, if you're a callback listening to a collection's "add" event, options.index will tell you the index at which the model is being added to the collection.
        /// </summary>
        /// <param name="models"></param>
        ///<example>
        ///usage
        ///<code>
        ///var ships = new Backbone.Collection;
        /// 
        /// ships.on("add", function(ship) {
        ///   alert("Ahoy " + ship.get("name") + "!");
        /// });
        /// 
        /// ships.add([
        ///   {name: "Flying Dutchman"},
        ///   {name: "Black Pearl"}
        /// ]);
        ///</code>
        ///</example>
        public void add(JsArray<Model> models) { }

        /// <summary>
        /// Remove a model (or an array of models) from the collection. Fires a "remove" event, which you can use silent to suppress.
        /// If you're a callback listening to the "remove" event, the index at which the model is being removed from the collection is available as options.index.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        public void remove(Model models, object options) { }
        /// <summary>
        /// Remove a model (or an array of models) from the collection. Fires a "remove" event, which you can use silent to suppress.
        /// If you're a callback listening to the "remove" event, the index at which the model is being removed from the collection is available as options.index.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        public void remove(JsArray<Model> models, object options) { }
        /// <summary>
        /// Remove a model (or an array of models) from the collection. Fires a "remove" event, which you can use silent to suppress.
        /// If you're a callback listening to the "remove" event, the index at which the model is being removed from the collection is available as options.index.
        /// </summary>
        /// <param name="models"></param>
        public void remove(Model models) { }
        /// <summary>
        /// Remove a model (or an array of models) from the collection. Fires a "remove" event, which you can use silent to suppress.
        /// If you're a callback listening to the "remove" event, the index at which the model is being removed from the collection is available as options.index.
        /// </summary>
        /// <param name="models"></param>
        public void remove(JsArray<Model> models) { }

        /// <summary>
        /// Get a model from a collection, specified by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var book = Library.get(110);
        ///</code>
        ///</example>
        public Model get(JsNumber id) { return null; }
        /// <summary>
        /// Get a model from a collection, specified by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var book = Library.get(110);
        ///</code>
        ///</example>
        public Model get(JsString id) { return null; }

        /// <summary>
        /// Get a model from a collection, specified by client id. The client id is the .cid property of the model, automatically assigned whenever a model is created.
        /// Useful for models which have not yet been saved to the server, and do not yet have true ids.
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public Model getByCid(JsNumber cid) { return null; }
        /// <summary>
        /// Get a model from a collection, specified by client id. The client id is the .cid property of the model, automatically assigned whenever a model is created.
        /// Useful for models which have not yet been saved to the server, and do not yet have true ids.
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public Model getByCid(JsString cid) { return null; }

        /// <summary>
        /// Get a model from a collection, specified by index.
        /// Useful if your collection is sorted, and if your collection isn't sorted, at will still retrieve models in insertion order.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Model at(JsNumber index) { return null; }

        /// <summary>
        /// Add a model at the end of a collection. Takes the same options as add.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        public void push(Model models, object options) { }
        /// <summary>
        /// Add a model at the end of a collection. Takes the same options as add.
        /// </summary>
        /// <param name="models"></param>
        public void push(Model models) { }

        /// <summary>
        /// Remove and return the last model from a collection. Takes the same options as remove.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Model pop(object options) { return null; }
        /// <summary>
        /// Remove and return the last model from a collection. Takes the same options as remove.
        /// </summary>
        /// <returns></returns>
        public Model pop() { return null; }

        /// <summary>
        /// Add a model at the beginning of a collection. Takes the same options as add.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="options"></param>
        public void unshift(Model model, object options) { }
        /// <summary>
        /// Add a model at the beginning of a collection. Takes the same options as add.
        /// </summary>
        /// <param name="model"></param>
        public void unshift(Model model) { }

        /// <summary>
        /// Remove and return the first model from a collection. Takes the same options as remove.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Model shift(object options) { return null; }
        /// <summary>
        /// Remove and return the first model from a collection. Takes the same options as remove.
        /// </summary>
        /// <returns></returns>
        public Model shift() { return null; }

        /// <summary>
        /// Like an array, a Collection maintains a length property, counting the number of models it contains.
        /// </summary>
        public JsNumber length { get; set; }

        /// <summary>
        /// By default there is no comparator function on a collection. If you define a comparator, it will be used to maintain the collection in sorted order.
        /// This means that as models are added, they are inserted at the correct index in collection.models.
        /// Comparator function can be defined as either a sortBy (pass a function that takes a single argument),
        /// or as a sort (pass a comparator function that expects two arguments).
        /// "sortBy" comparator functions take a model and return a numeric or string value by which the model should be ordered relative to others.
        /// "sort" comparator functions take two models, and return -1 if the first model should come before the second,
        /// 0 if they are of the same rank and 1 if the first model should come after.
        /// Collections with comparator functions will not automatically re-sort if you later change model attributes, so you may wish to call sort after changing model attributes that would affect the order.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var Chapter  = Backbone.Model;
        /// var chapters = new Backbone.Collection;
        /// 
        /// chapters.comparator = function(chapter) {
        ///   return chapter.get("page");
        /// };
        /// 
        /// chapters.add(new Chapter({page: 9, title: "The End"}));
        /// chapters.add(new Chapter({page: 5, title: "The Middle"}));
        /// chapters.add(new Chapter({page: 1, title: "The Beginning"}));
        /// 
        /// alert(chapters.pluck('title'));
        ///</code>
        ///</example>
        [JsProperty(Name = "comparator")]
        public JsFunc<Model, JsString> comparatorSortBy { get; set; }
        /// <summary>
        /// By default there is no comparator function on a collection. If you define a comparator, it will be used to maintain the collection in sorted order.
        /// This means that as models are added, they are inserted at the correct index in collection.models.
        /// Comparator function can be defined as either a sortBy (pass a function that takes a single argument),
        /// or as a sort (pass a comparator function that expects two arguments).
        /// "sortBy" comparator functions take a model and return a numeric or string value by which the model should be ordered relative to others.
        /// "sort" comparator functions take two models, and return -1 if the first model should come before the second,
        /// 0 if they are of the same rank and 1 if the first model should come after.
        /// Collections with comparator functions will not automatically re-sort if you later change model attributes, so you may wish to call sort after changing model attributes that would affect the order.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var Chapter  = Backbone.Model;
        /// var chapters = new Backbone.Collection;
        /// 
        /// chapters.comparator = function(chapter) {
        ///   return chapter.get("page");
        /// };
        /// 
        /// chapters.add(new Chapter({page: 9, title: "The End"}));
        /// chapters.add(new Chapter({page: 5, title: "The Middle"}));
        /// chapters.add(new Chapter({page: 1, title: "The Beginning"}));
        /// 
        /// alert(chapters.pluck('title'));
        ///</code>
        ///</example>
        [JsProperty(Name = "comparator")]
        public JsFunc<Model, Model, JsNumber> comparatorSort { get; set; }

        /// <summary>
        /// Force a collection to re-sort itself.
        /// You don't need to call this under normal circumstances, as a collection with a comparator function will maintain itself in proper sort order at all times.
        /// Calling sort triggers the collection's "reset" event, unless silenced by passing {silent: true}
        /// </summary>
        /// <param name="options"></param>
        public void sort(object options) { }

        /// <summary>
        /// Pluck an attribute from each model in the collection. Equivalent to calling map, and returning a single attribute from the iterator.
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var stooges = new Backbone.Collection([
        ///   {name: "Curly"},
        ///   {name: "Larry"},
        ///   {name: "Moe"}
        /// ]);
        /// 
        /// var names = stooges.pluck("name");
        /// 
        /// alert(JSON.stringify(names));
        ///</code>
        ///</example>
        public JsString pluck(JsString attribute) { return null; }

        /// <summary>
        /// Return an array of all the models in a collection that match the passed attributes. Useful for simple cases of filter.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var friends = new Backbone.Collection([
        ///   {name: "Athos",      job: "Musketeer"},
        ///   {name: "Porthos",    job: "Musketeer"},
        ///   {name: "Aramis",     job: "Musketeer"},
        ///   {name: "d'Artagnan", job: "Guard"},
        /// ]);
        /// 
        /// var musketeers = friends.where({job: "Musketeer"});
        /// 
        /// alert(musketeers.length);
        ///</code>
        ///</example>
        public JsArray<Model> where(object attributes) { return null; }

        /// <summary>
        /// Set the url property (or function) on a collection to reference its location on the server.
        /// Models within the collection will use url to construct URLs of their own.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var Notes = Backbone.Collection.extend({
        ///   url: '/notes'
        /// });
        /// 
        /// // Or, something more sophisticated:
        /// 
        /// var Notes = Backbone.Collection.extend({
        ///   url: function() {
        ///     return this.document.url() + '/notes';
        ///   }
        /// });
        ///</code>
        ///</example>
        public JsString url { get; set; }
        //TODO: propertye or function?

        /// <summary>
        /// parse is called by Backbone whenever a collection's models are returned by the server, in fetch.
        /// The function is passed the raw response object, and should return the array of model attributes to be added to the collection.
        /// The default implementation is a no-op, simply passing through the JSON response.
        /// Override this if you need to work with a preexisting API, or better namespace your responses
        /// Note that afterwards, if your model class already has a parse function, it will be run against each fetched model.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Tweets = Backbone.Collection.extend({
        ///   // The Twitter Search API returns tweets under "results".
        ///   parse: function(response) {
        ///     return response.results;
        ///   }
        /// });
        ///</code>
        ///</example>
        public JsArray<object> parse(object response) { return null; }

        /// <summary>
        /// Fetch the default set of models for this collection from the server, resetting the collection when they arrive.
        /// The options hash takes success and error callbacks which will be passed (collection, response) as arguments.
        /// When the model data returns from the server, the collection will reset.
        /// Delegates to Backbone.sync under the covers for custom persistence strategies and returns a jqXHR.
        /// The server handler for fetch requests should return a JSON array of models.
        /// If you'd like to add the incoming models to the current collection, instead of replacing the collection's contents, pass {add: true} as an option to fetch.
        /// jQuery.ajax options can also be passed directly as fetch options, so to fetch a specific page of a paginated collection: Documents.fetch({data: {page: 3}})
        /// Note that fetch should not be used to populate collections on page load — all models needed at load time should already be bootstrapped in to place.
        /// fetch is intended for lazily-loading models for interfaces that are not needed immediately:
        /// for example, documents with collections of notes that may be toggled open and closed.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public object fetch(object options) { return null; }
        //TODO: ?

        /// <summary>
        /// Adding and removing models one at a time is all well and good, but sometimes you have so many models to change that you'd rather just update the collection in bulk.
        /// Use reset to replace a collection with a new list of models (or attribute hashes), triggering a single "reset" event at the end.
        /// Pass {silent: true} to suppress the "reset" event. Using reset with no arguments is useful as a way to empty the collection.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///<script>
        ///   var Accounts = new Backbone.Collection;
        ///   Accounts.reset(&lt;%= @accounts.to_json %>);
        /// </script>
        ///</code>
        ///</example>
        public object reset(JsArray<Model> models, object options) { return null; }
        /// <summary>
        /// Adding and removing models one at a time is all well and good, but sometimes you have so many models to change that you'd rather just update the collection in bulk.
        /// Use reset to replace a collection with a new list of models (or attribute hashes), triggering a single "reset" event at the end.
        /// Pass {silent: true} to suppress the "reset" event. Using reset with no arguments is useful as a way to empty the collection.
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///<script>
        ///   var Accounts = new Backbone.Collection;
        ///   Accounts.reset(&lt;%= @accounts.to_json %>);
        /// </script>
        ///</code>
        ///</example>
        public object reset(JsArray<Model> models) { return null; }

        /// <summary>
        /// Convenience to create a new instance of a model within a collection.
        /// Equivalent to instantiating a model with a hash of attributes, saving the model to the server, and adding the model to the set after being successfully created.
        /// Returns the model, or false if a validation error prevented the model from being created.
        /// In order for this to work, you should set the model property of the collection.
        /// The create method can accept either an attributes hash or an existing, unsaved model object.
        /// Creating a model will cause an immediate "add" event to be triggered on the collection,as well as a "sync" event, once the model has been successfully created on the server.
        /// Pass {wait: true} if you'd like to wait for the server before adding the new model to the collection.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Library = Backbone.Collection.extend({
        ///   model: Book
        /// });
        /// 
        /// var NYPL = new Library;
        /// 
        /// var othello = NYPL.create({
        ///   title: "Othello",
        ///   author: "William Shakespeare"
        /// });
        ///</code>
        ///</example>
        public object create(object attributes, object options) { return null; }
        /// <summary>
        /// Convenience to create a new instance of a model within a collection.
        /// Equivalent to instantiating a model with a hash of attributes, saving the model to the server, and adding the model to the set after being successfully created.
        /// Returns the model, or false if a validation error prevented the model from being created.
        /// In order for this to work, you should set the model property of the collection.
        /// The create method can accept either an attributes hash or an existing, unsaved model object.
        /// Creating a model will cause an immediate "add" event to be triggered on the collection,as well as a "sync" event, once the model has been successfully created on the server.
        /// Pass {wait: true} if you'd like to wait for the server before adding the new model to the collection.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Library = Backbone.Collection.extend({
        ///   model: Book
        /// });
        /// 
        /// var NYPL = new Library;
        /// 
        /// var othello = NYPL.create({
        ///   title: "Othello",
        ///   author: "William Shakespeare"
        /// });
        ///</code>
        ///</example>
        public object create(object attributes) { return null; }
    }

    /// <summary>
    /// Backbone proxies to Underscore.js to provide 28 iteration functions on Backbone.Collection.
    /// They aren't all documented here, but you can take a look at the Underscore documentation for the full details…
    /// </summary>
    [JsType(JsMode.Json)]
    public class UnderscoreMethods
    {
        /// <summary>
        /// Iterates over a list of elements, yielding each in turn to an iterator function.
        /// The iterator is bound to the context object, if one is passed. Each invocation of iterator is called with three arguments: (element, index, list).
        /// If list is a JavaScript object, iterator's arguments will be (value, key, list). Delegates to the native forEach function if it exists.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        ///<example>
        ///usage
        ///<code>
        ///_.each([1, 2, 3], function(num){ alert(num); });
        /// => alerts each number in turn...
        /// _.each({one : 1, two : 2, three : 3}, function(num, key){ alert(num); });
        /// => alerts each number in turn...
        ///</code>
        ///</example>
        public static void forEach(JsArray list, JsAction<HtmlElement, JsNumber, JsArray> iterator, object context) { }
        /// <summary>
        /// Iterates over a list of elements, yielding each in turn to an iterator function.
        /// The iterator is bound to the context object, if one is passed. Each invocation of iterator is called with three arguments: (element, index, list).
        /// If list is a JavaScript object, iterator's arguments will be (value, key, list). Delegates to the native forEach function if it exists.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <example>
        ///usage
        ///<code>
        ///_.each([1, 2, 3], function(num){ alert(num); });
        /// => alerts each number in turn...
        /// _.each({one : 1, two : 2, three : 3}, function(num, key){ alert(num); });
        /// => alerts each number in turn...
        ///</code>
        ///</example>
        public static void forEach(JsArray list, JsAction<object, object, JsArray> iterator, object context) { }
        /// <summary>
        /// Iterates over a list of elements, yielding each in turn to an iterator function.
        /// The iterator is bound to the context object, if one is passed. Each invocation of iterator is called with three arguments: (element, index, list).
        /// If list is a JavaScript object, iterator's arguments will be (value, key, list). Delegates to the native forEach function if it exists.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <example>
        ///usage
        ///<code>
        ///_.each([1, 2, 3], function(num){ alert(num); });
        /// => alerts each number in turn...
        /// _.each({one : 1, two : 2, three : 3}, function(num, key){ alert(num); });
        /// => alerts each number in turn...
        ///</code>
        ///</example>
        public static void forEach(JsArray list, JsAction<HtmlElement, JsNumber, JsArray> iterator) { }

        /// <summary>
        /// Produces a new array of values by mapping each value in list through a transformation function (iterator).
        /// If the native map method exists, it will be used instead. If list is a JavaScript object, iterator's arguments will be (value, key, list).
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        public static void map(JsArray list, JsAction<object, object, JsArray> iterator, object context) { }
        /// <summary>
        /// Produces a new array of values by mapping each value in list through a transformation function (iterator).
        /// If the native map method exists, it will be used instead. If list is a JavaScript object, iterator's arguments will be (value, key, list).
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        public static void map(JsArray list, JsAction<object, object, JsArray> iterator) { }

        /// <summary>
        /// Also known as inject and foldl, reduce boils down a list of values into a single value.
        /// Memo is the initial state of the reduction, and each successive step of it should be returned by iterator.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="memo"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var sum = _.reduce([1, 2, 3], function(memo, num){ return memo + num; }, 0);
        ///=> 6
        ///</code>
        ///</example>
        public static object reduce(JsArray list, JsAction<object, object, JsArray> iterator, object memo, object context) { return null; }
        /// <summary>
        /// Also known as inject and foldl, reduce boils down a list of values into a single value.
        /// Memo is the initial state of the reduction, and each successive step of it should be returned by iterator.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var sum = _.reduce([1, 2, 3], function(memo, num){ return memo + num; }, 0);
        ///=> 6
        ///</code>
        ///</example>
        public static object reduce(JsArray list, JsAction<object, object, JsArray> iterator, object memo) { return null; }

        /// <summary>
        /// The right-associative version of reduce. Delegates to the JavaScript 1.8 version of reduceRight, if it exists.
        /// Foldr is not as useful in JavaScript as it would be in a language with lazy evaluation.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="memo"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static object reduceRight(JsArray list, JsAction<object, object, JsArray> iterator, object memo, object context) { return null; }
        /// <summary>
        /// The right-associative version of reduce. Delegates to the JavaScript 1.8 version of reduceRight, if it exists.
        /// Foldr is not as useful in JavaScript as it would be in a language with lazy evaluation.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public static object reduceRight(JsArray list, JsAction<object, object, JsArray> iterator, object memo) { return null; }

        /// <summary>
        /// Looks through each value in the list, returning the first one that passes a truth test (iterator).
        /// The function returns as soon as it finds an acceptable element, and doesn't traverse the entire list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        ///<example>
        ///usage
        ///<code>
        ///var even = _.find([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
        ///=> 2
        ///</code>
        ///</example>
        public static void find(JsArray list, JsAction<object, object, JsArray> iterator, object context) { }
        /// <summary>
        /// Looks through each value in the list, returning the first one that passes a truth test (iterator).
        /// The function returns as soon as it finds an acceptable element, and doesn't traverse the entire list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        ///<example>
        ///usage
        ///<code>
        ///var even = _.find([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
        ///=> 2
        ///</code>
        ///</example>
        public static void find(JsArray list, JsAction<object, object, JsArray> iterator) { }

        /// <summary>
        /// Looks through each value in the list, returning an array of all the values that pass a truth test (iterator). Delegates to the native filter method, if it exists.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var evens = _.filter([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
        ///=> [2, 4, 6]
        ///</code>
        ///</example>
        public static JsArray<object> filter(JsArray list, JsAction<object, object, JsArray> iterator, object context) { return null; }
        /// <summary>
        /// Looks through each value in the list, returning an array of all the values that pass a truth test (iterator). Delegates to the native filter method, if it exists.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        /// <example>
        ///usage
        ///<code>
        ///var evens = _.filter([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
        ///=> [2, 4, 6]
        ///</code>
        ///</example>
        public static JsArray<object> filter(JsArray list, JsAction<object, object, JsArray> iterator) { return null; }

        /// <summary>
        /// Returns the values in list without the elements that the truth test (iterator) passes.
        /// The opposite of filter.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var odds = _.reject([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
        ///=> [1, 3, 5]
        ///</code>
        ///</example>
        public static JsArray<object> reject(JsArray list, JsAction<object, object, JsArray> iterator, object context) { return null; }
        /// <summary>
        /// Returns the values in list without the elements that the truth test (iterator) passes.
        /// The opposite of filter.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var odds = _.reject([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
        ///=> [1, 3, 5]
        ///</code>
        ///</example>
        public static JsArray<object> reject(JsArray list, JsAction<object, object, JsArray> iterator) { return null; }

        /// <summary>
        /// Returns true if all of the values in the list pass the iterator truth test. Delegates to the native method every, if present.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.all([true, 1, null, 'yes'], _.identity);
        ///=> false
        ///</code>
        ///</example>
        public static bool every(JsArray list, JsAction<object, object, JsArray> iterator, object context) { return false; }
        /// <summary>
        /// Returns true if all of the values in the list pass the iterator truth test. Delegates to the native method every, if present.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.all([true, 1, null, 'yes'], _.identity);
        ///=> false
        ///</code>
        ///</example>
        public static bool every(JsArray list, JsAction<object, object, JsArray> iterator) { return false; }

        /// <summary>
        /// Returns true if the value is present in the list, using === to test equality. Uses indexOf internally, if list is an Array.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.include([1, 2, 3], 3);
        ///=> true
        ///</code>
        ///</example>
        public static bool contains(JsArray list, object value) { return false; }

        /// <summary>
        /// Calls the method named by methodName on each value in the list. Any extra arguments passed to invoke will be forwarded on to the method invocation.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="methodName"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.invoke([[5, 1, 7], [3, 2, 1]], 'sort');
        ///=> [[1, 5, 7], [1, 2, 3]]
        ///</code>
        ///</example>
        public static object invoke(JsArray list, JsString methodName, object arguments) { return null; }

        /// <summary>
        /// Returns the maximum value in list. If iterator is passed, it will be used on each value to generate the criterion by which the value is ranked.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var stooges = [{name : 'moe', age : 40}, {name : 'larry', age : 50}, {name : 'curly', age : 60}];
        /// _.max(stooges, function(stooge){ return stooge.age; });
        /// => {name : 'curly', age : 60};
        ///</code>
        ///</example>
        public static object max(JsArray list, JsAction<object, object> iterator, object context) { return null; }
        /// <summary>
        /// Returns the maximum value in list. If iterator is passed, it will be used on each value to generate the criterion by which the value is ranked.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var stooges = [{name : 'moe', age : 40}, {name : 'larry', age : 50}, {name : 'curly', age : 60}];
        /// _.max(stooges, function(stooge){ return stooge.age; });
        /// => {name : 'curly', age : 60};
        ///</code>
        ///</example>
        public static object max(JsArray list, JsAction<object, object> iterator) { return null; }
        /// <summary>
        /// Returns the maximum value in list. If iterator is passed, it will be used on each value to generate the criterion by which the value is ranked.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var stooges = [{name : 'moe', age : 40}, {name : 'larry', age : 50}, {name : 'curly', age : 60}];
        /// _.max(stooges, function(stooge){ return stooge.age; });
        /// => {name : 'curly', age : 60};
        ///</code>
        ///</example>
        public static object max(JsArray list) { return null; }

        /// <summary>
        /// Returns the minimum value in list. If iterator is passed, it will be used on each value to generate the criterion by which the value is ranked.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var numbers = [10, 5, 100, 2, 1000];
        /// _.min(numbers);
        /// => 2
        ///</code>
        ///</example>
        public static object min(JsArray list, JsAction<object, object> iterator, object context) { return null; }
        /// <summary>
        /// Returns the minimum value in list. If iterator is passed, it will be used on each value to generate the criterion by which the value is ranked.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var numbers = [10, 5, 100, 2, 1000];
        /// _.min(numbers);
        /// => 2
        ///</code>
        ///</example>
        public static object min(JsArray list, JsAction<object, object> iterator) { return null; }
        /// <summary>
        /// Returns the minimum value in list. If iterator is passed, it will be used on each value to generate the criterion by which the value is ranked.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var numbers = [10, 5, 100, 2, 1000];
        /// _.min(numbers);
        /// => 2
        ///</code>
        ///</example>
        public static object min(JsArray list) { return null; }

        /// <summary>
        /// Returns a sorted copy of list, ranked in ascending order by the results of running each value through iterator.
        /// Iterator may also be the string name of the property to sort by (eg. length).
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.sortBy([1, 2, 3, 4, 5, 6], function(num){ return Math.sin(num); });
        ///=> [5, 4, 6, 3, 1, 2]
        ///</code>
        ///</example>
        public static JsArray sortBy(JsArray list, JsAction<object, object> iterator, object context) { return null; }
        /// <summary>
        /// Returns a sorted copy of list, ranked in ascending order by the results of running each value through iterator.
        /// Iterator may also be the string name of the property to sort by (eg. length).
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.sortBy([1, 2, 3, 4, 5, 6], function(num){ return Math.sin(num); });
        ///=> [5, 4, 6, 3, 1, 2]
        ///</code>
        ///</example>
        public static JsArray sortBy(JsArray list, JsAction<object, object> iterator) { return null; }

        /// <summary>
        /// Splits a collection into sets, grouped by the result of running each value through iterator.
        /// If iterator is a string instead of a function, groups by the property named by iterator on each of the values.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.groupBy([1.3, 2.1, 2.4], function(num){ return Math.floor(num); });
        /// => {1: [1.3], 2: [2.1, 2.4]}
        /// 
        /// _.groupBy(['one', 'two', 'three'], 'length');
        /// => {3: ["one", "two"], 5: ["three"]}
        ///</code>
        ///</example>
        public static object groupBy(JsArray list, JsAction<object, object> iterator) { return null; }
        /// <summary>
        /// Splits a collection into sets, grouped by the result of running each value through iterator.
        /// If iterator is a string instead of a function, groups by the property named by iterator on each of the values.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.groupBy([1.3, 2.1, 2.4], function(num){ return Math.floor(num); });
        /// => {1: [1.3], 2: [2.1, 2.4]}
        /// 
        /// _.groupBy(['one', 'two', 'three'], 'length');
        /// => {3: ["one", "two"], 5: ["three"]}
        ///</code>
        ///</example>
        public static object groupBy(JsArray list, JsString iterator) { return null; }

        /// <summary>
        /// Uses a binary search to determine the index at which the value should be inserted into the list in order to maintain the list's sorted order.
        /// If an iterator is passed, it will be used to compute the sort ranking of each value.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.sortedIndex([10, 20, 30, 40, 50], 35);
        ///=> 3
        ///</code>
        ///</example>
        public static JsNumber sortedIndex(JsArray list, JsString iterator) { return null; }
        //TODO: CHECK

        /// <summary>
        /// Returns a shuffled copy of the list, using a version of the Fisher-Yates shuffle.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.shuffle([1, 2, 3, 4, 5, 6]);
        ///=> [4, 1, 6, 3, 5, 2]
        ///</code>
        ///</example>
        public static JsArray shuffle(JsArray list) { return null; }

        /// <summary>
        /// Converts the list (anything that can be iterated over), into a real Array. Useful for transmuting the arguments object.
        /// </summary>
        /// <param name="list"></param>
        ///<example>
        ///usage
        ///<code>
        ///(function(){ return _.toArray(arguments).slice(1); })(1, 2, 3, 4);
        ///=> [2, 3, 4]
        ///</code>
        ///</example>
        public static void toArray(JsArray list) { }

        /// <summary>
        /// Return the number of values in the list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.size({one : 1, two : 2, three : 3});
        ///=> 3
        ///</code>
        ///</example>
        public static JsNumber size(JsArray list) { return null; }

        /// <summary>
        /// Returns the first element of an array. Passing n will return the first n elements of the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.first([5, 4, 3, 2, 1]);
        ///=> 5
        ///</code>
        ///</example>
        public static object first(JsArray array, object n) { return null; }
        /// <summary>
        /// Returns the first element of an array. Passing n will return the first n elements of the array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.first([5, 4, 3, 2, 1]);
        ///=> 5
        ///</code>
        ///</example>
        public static object first(JsArray array) { return null; }

        /// <summary>
        /// Returns everything but the last entry of the array. Especially useful on the arguments object. Pass n to exclude the last n elements from the result.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.initial([5, 4, 3, 2, 1]);
        ///=> [5, 4, 3, 2]
        ///</code>
        ///</example>
        public static JsArray initial(JsArray array, object n) { return null; }
        /// <summary>
        /// Returns everything but the last entry of the array. Especially useful on the arguments object. Pass n to exclude the last n elements from the result.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.initial([5, 4, 3, 2, 1]);
        ///=> [5, 4, 3, 2]
        ///</code>
        ///</example>
        public static JsArray initial(JsArray array) { return null; }

        /// <summary>
        /// Returns the rest of the elements in an array. Pass an index to return the values of the array from that index onward.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.rest([5, 4, 3, 2, 1]);
        ///=> [4, 3, 2, 1]
        ///</code>
        ///</example>
        public static JsArray rest(JsArray array, JsNumber index) { return null; }

        /// <summary>
        /// Returns the last element of an array. Passing n will return the last n elements of the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.last([5, 4, 3, 2, 1]);
        ///=> 1
        ///</code>
        ///</example>
        public static object last(JsArray array, object n) { return null; }
        /// <summary>
        /// Returns the last element of an array. Passing n will return the last n elements of the array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.last([5, 4, 3, 2, 1]);
        ///=> 1
        ///</code>
        ///</example>
        public static object last(JsArray array) { return null; }

        /// <summary>
        /// Returns a copy of the array with all instances of the values removed. === is used for the equality test.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.without([1, 2, 1, 0, 3, 1, 4], 0, 1);
        ///=> [2, 3, 4]
        ///</code>
        ///</example>
        public static JsArray without(JsArray array, object values) { return null; }
        /// <summary>
        /// Returns a copy of the array with all instances of the values removed. === is used for the equality test.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.without([1, 2, 1, 0, 3, 1, 4], 0, 1);
        ///=> [2, 3, 4]
        ///</code>
        ///</example>
        public static JsArray without(JsArray array) { return null; }

        /// <summary>
        /// Returns the index at which value can be found in the array, or -1 if value is not present in the array. Uses the native indexOf function unless it's missing.
        /// If you're working with a large array, and you know that the array is already sorted, pass true for isSorted to use a faster binary search.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <param name="isSorted"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.indexOf([1, 2, 3], 2);
        ///=> 1
        ///</code>
        ///</example>
        public static JsNumber indexOf(JsArray array, object value, bool isSorted) { return null; }
        /// <summary>
        /// Returns the index at which value can be found in the array, or -1 if value is not present in the array. Uses the native indexOf function unless it's missing.
        /// If you're working with a large array, and you know that the array is already sorted, pass true for isSorted to use a faster binary search.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.indexOf([1, 2, 3], 2);
        ///=> 1
        ///</code>
        ///</example>
        public static JsNumber indexOf(JsArray array, object value) { return null; }

        /// <summary>
        /// Returns the index of the last occurrence of value in the array, or -1 if value is not present. Uses the native lastIndexOf function if possible.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.lastIndexOf([1, 2, 3, 1, 2, 3], 2);
        ///=> 4
        ///</code>
        ///</example>
        public static JsNumber lastIndexOf(JsArray array, object value) { return null; }

        /// <summary>
        /// Returns true if object contains no values.
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///_.isEmpty([1, 2, 3]);
        /// => false
        /// _.isEmpty({}k;k
        /// => true
        ///</code>
        ///</example>
        public static bool isEmpty(object @object) { return false; }

        /// <summary>
        /// Returns a wrapped object. Calling methods on this object will continue to return wrapped objects until value is used.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var stooges = [{name : 'curly', age : 25}, {name : 'moe', age : 21}, {name : 'larry', age : 23}];
        /// var youngest = _.chain(stooges)
        ///   .sortBy(function(stooge){ return stooge.age; })
        ///   .map(function(stooge){ return stooge.name + ' is ' + stooge.age; })
        ///   .first()
        ///   .value();
        /// => "moe is 21"
        ///</code>
        ///</example>
        public static object chain(object obj) { return null; }
    }

    /// <summary>
    /// Web applications often provide linkable, bookmarkable, shareable URLs for important locations in the app.
    /// Until recently, hash fragments (#page) were used to provide these permalinks, but with the arrival of the History API,
    /// it's now possible to use standard URLs (/page). Backbone.Router provides methods for routing client-side pages, and connecting them to actions and events.
    /// For browsers which don't yet support the History API, the Router handles graceful fallback and transparent translation to the fragment version of the URL.
    /// During page load, after your application has finished creating all of its routers, be sure to call Backbone.history.start(),
    /// or Backbone.history.start({pushState: true}) to route the initial URL.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Backbone.Router", Export = false)]
    public class Router
    {
        /// <summary>
        /// When creating a new router, you may pass its routes hash directly as an option, if you choose.
        /// All options will also be passed to your initialize function, if defined.
        /// </summary>
        /// <param name="options"></param>
        public Router(object options) { }
        /// <summary>
        /// When creating a new router, you may pass its routes hash directly as an option, if you choose.
        /// All options will also be passed to your initialize function, if defined.
        /// </summary>
        public Router() { }


        /// <summary>
        /// Get started by creating a custom router class. Define actions that are triggered when certain URL fragments are matched,
        /// and provide a routes hash that pairs routes to actions.
        /// Note that you'll want to avoid using a leading slash in your route definitions:
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="classProperties"></param>
        ///<example>
        ///usage
        ///<code>
        /// var Workspace = Backbone.Router.extend({
        /// 
        ///   routes: {
        ///     "help":                 "help",    // #help
        ///     "search/:query":        "search",  // #search/kiwis
        ///     "search/:query/p:page": "search"   // #search/kiwis/p7
        ///   },
        /// 
        ///   help: function() {
        ///     ...
        ///   },
        /// 
        ///   search: function(query, page) {
        ///     ...
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties, object classProperties) { }
        /// <summary>
        /// Get started by creating a custom router class. Define actions that are triggered when certain URL fragments are matched,
        /// and provide a routes hash that pairs routes to actions.
        /// Note that you'll want to avoid using a leading slash in your route definitions:
        /// </summary>
        /// <param name="properties"></param>
        ///<example>
        ///usage
        ///<code>
        /// var Workspace = Backbone.Router.extend({
        /// 
        ///   routes: {
        ///     "help":                 "help",    // #help
        ///     "search/:query":        "search",  // #search/kiwis
        ///     "search/:query/p:page": "search"   // #search/kiwis/p7
        ///   },
        /// 
        ///   help: function() {
        ///     ...
        ///   },
        /// 
        ///   search: function(query, page) {
        ///     ...
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties) { }

        /// <summary>
        /// The routes hash maps URLs with parameters to functions on your router, similar to the View's events hash.
        /// Routes can contain parameter parts, :param, which match a single URL component between slashes; and splat parts *splat, which can match any number of URL components.
        /// For example, a route of "search/:query/p:page" will match a fragment of #search/obama/p2, passing "obama" and "2" to the action.
        /// A route of "file/*path" will match #file/nested/folder/file.txt, passing "nested/folder/file.txt" to the action.
        /// When the visitor presses the back button, or enters a URL, and a particular route is matched, the name of the action will be fired as an event,
        /// so that other objects can listen to the router, and be notified. In the following example, visiting #help/uploading will fire a route:help event from the router.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///routes: {
        ///   "help/:page":         "help",
        ///   "download/*path":     "download",
        ///   "folder/:name":       "openFolder",
        ///   "folder/:name-:mode": "openFolder"
        /// }
        /// router.on("route:help", function(page) {
        ///   ...
        /// });
        ///</code>
        ///</example>
        public static object routes { get; set; }

        /// <summary>
        /// Manually create a route for the router, The route argument may be a routing string or regular expression.
        /// Each matching capture from the route or regular expression will be passed as an argument to the callback.
        /// The name argument will be triggered as a "route:name" event whenever the route is matched.
        /// If the callback argument is omitted router[name] will be used instead.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="name"></param>
        /// <param name="callback"></param>
        ///<example>
        ///usage
        ///<code>
        ///initialize: function(options) {
        /// 
        ///   // Matches #page/10, passing "10"
        ///   this.route("page/:number", "page", function(number){ ... });
        /// 
        ///   // Matches /117-a/b/c/open, passing "117-a/b/c" to this.open
        ///   this.route(/^(.*?)\/open$/, "open");
        /// 
        /// },
        /// 
        /// open: function(id) { ... }
        ///</code>
        ///</example>
        public void route(object route, object name, JsAction callback) { }
        /// <summary>
        /// Manually create a route for the router, The route argument may be a routing string or regular expression.
        /// Each matching capture from the route or regular expression will be passed as an argument to the callback.
        /// The name argument will be triggered as a "route:name" event whenever the route is matched.
        /// If the callback argument is omitted router[name] will be used instead.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="name"></param>
        ///<example>
        ///usage
        ///<code>
        ///initialize: function(options) {
        /// 
        ///   // Matches #page/10, passing "10"
        ///   this.route("page/:number", "page", function(number){ ... });
        /// 
        ///   // Matches /117-a/b/c/open, passing "117-a/b/c" to this.open
        ///   this.route(/^(.*?)\/open$/, "open");
        /// 
        /// },
        /// 
        /// open: function(id) { ... }
        ///</code>
        ///</example>
        public void route(object route, object name) { }

        /// <summary>
        /// Whenever you reach a point in your application that you'd like to save as a URL, call navigate in order to update the URL.
        /// If you wish to also call the route function, set the trigger option to true.
        /// To update the URL without creating an entry in the browser's history, set the replace option to true.
        /// </summary>
        /// <param name="fragment"></param>
        /// <param name="options"></param>
        ///<example>
        ///usage
        ///<code>
        ///openPage: function(pageNumber) {
        ///   this.document.pages.at(pageNumber).open();
        ///   this.navigate("page/" + pageNumber);
        /// }
        /// 
        /// # Or ...
        /// 
        /// app.navigate("help/troubleshooting", {trigger: true});
        /// 
        /// # Or ...
        /// 
        /// app.navigate("help/troubleshooting", {trigger: true, replace: true});
        ///</code>
        ///</example>
        public void navigate(object fragment, object options) { }
        /// <summary>
        /// Whenever you reach a point in your application that you'd like to save as a URL, call navigate in order to update the URL.
        /// If you wish to also call the route function, set the trigger option to true.
        /// To update the URL without creating an entry in the browser's history, set the replace option to true.
        /// </summary>
        /// <param name="fragment"></param>
        ///<example>
        ///usage
        ///<code>
        ///openPage: function(pageNumber) {
        ///   this.document.pages.at(pageNumber).open();
        ///   this.navigate("page/" + pageNumber);
        /// }
        /// 
        /// # Or ...
        /// 
        /// app.navigate("help/troubleshooting", {trigger: true});
        /// 
        /// # Or ...
        /// 
        /// app.navigate("help/troubleshooting", {trigger: true, replace: true});
        ///</code>
        ///</example>
        public void navigate(object fragment) { }
    }

    /// <summary>
    /// History serves as a global router (per frame) to handle hashchange events or pushState, match the appropriate route, and trigger callbacks.
    /// You shouldn't ever have to create one of these yourself — you should use the reference to Backbone.history that will be created for you automatically
    /// if you make use of Routers with routes.
    /// pushState support exists on a purely opt-in basis in Backbone. Older browsers that don't support pushState will continue to use hash-based URL fragments,
    /// and if a hash URL is visited by a pushState-capable browser, it will be transparently upgraded to the true URL.
    /// Note that using real URLs requires your web server to be able to correctly render those pages, so back-end changes are required as well.
    /// For example, if you have a route of /documents/100, your web server must be able to serve that page, if the browser visits that URL directly.
    /// For full search-engine crawlability, it's best to have the server generate the complete HTML for the page ... but if it's a web application,
    /// just rendering the same content you would have for the root URL, and filling in the rest with Backbone Views and JavaScript works fine.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Backbone.history", Export = false)]
    public class History
    {
        /// <summary>
        /// When all of your Routers have been created, and all of the routes are set up properly,
        /// call Backbone.history.start() to begin monitoring hashchange events, and dispatching routes.
        /// 
        /// To indicate that you'd like to use HTML5 pushState support in your application, use Backbone.history.start({pushState: true}).
        /// 
        /// If your application is not being served from the root url / of your domain, be sure to tell History where the root really is,
        /// as an option: Backbone.history.start({pushState: true, root: "/public/search/"})
        /// 
        /// When called, if a route succeeds with a match for the current URL, Backbone.history.start() returns true. If no defined route matches the current URL, it returns false.
        /// 
        /// If the server has already rendered the entire page, and you don't want the initial route to trigger when starting History, pass silent: true.
        /// 
        /// Because hash-based history in Internet Explorer relies on an &lt;iframe>, be sure to only call start() after the DOM is ready.
        /// </summary>
        /// <param name="options"></param>
        ///<example>
        ///usage
        ///<code>
        ///$(function(){
        ///   new WorkspaceRouter();
        ///   new HelpPaneRouter();
        ///   Backbone.history.start({pushState: true});
        /// });
        ///</code>
        ///</example>
        public static void start(object options) { }
        /// <summary>
        /// When all of your Routers have been created, and all of the routes are set up properly,
        /// call Backbone.history.start() to begin monitoring hashchange events, and dispatching routes.
        /// 
        /// To indicate that you'd like to use HTML5 pushState support in your application, use Backbone.history.start({pushState: true}).
        /// 
        /// If your application is not being served from the root url / of your domain, be sure to tell History where the root really is,
        /// as an option: Backbone.history.start({pushState: true, root: "/public/search/"})
        /// 
        /// When called, if a route succeeds with a match for the current URL, Backbone.history.start() returns true. If no defined route matches the current URL, it returns false.
        /// 
        /// If the server has already rendered the entire page, and you don't want the initial route to trigger when starting History, pass silent: true.
        /// 
        /// Because hash-based history in Internet Explorer relies on an &lt;iframe>, be sure to only call start() after the DOM is ready.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$(function(){
        ///   new WorkspaceRouter();
        ///   new HelpPaneRouter();
        ///   Backbone.history.start({pushState: true});
        /// });
        ///</code>
        ///</example>
        public static void start() { }
    }

    //TODO: Backbone.sync

    /// <summary>
    /// Backbone views are almost more convention than they are code — they don't determine anything about your HTML or CSS for you,
    /// and can be used with any JavaScript templating library.
    /// The general idea is to organize your interface into logical views, backed by models,
    /// each of which can be updated independently when the model changes, without having to redraw the page.
    /// Instead of digging into a JSON object, looking up an element in the DOM, and updating the HTML by hand,
    /// you can bind your view's render function to the model's "change" event — and now everywhere that model data is displayed in the UI, it is always immediately up to date.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Backbone.View", Export = false)]
    public class View
    {
        /// <summary>
        /// Get started with views by creating a custom view class.
        /// You'll want to override the render function, specify your declarative events, and perhaps the tagName, className, or id of the View's root element.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="classProperties"></param>
        ///<example>
        ///usage
        ///<code>
        ///var DocumentRow = Backbone.View.extend({
        /// 
        ///   tagName: "li",
        /// 
        ///   className: "document-row",
        /// 
        ///   events: {
        ///     "click .icon":          "open",
        ///     "click .button.edit":   "openEditDialog",
        ///     "click .button.delete": "destroy"
        ///   },
        /// 
        ///   render: function() {
        ///     ...
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties, object classProperties) { }
        /// <summary>
        /// Get started with views by creating a custom view class.
        /// You'll want to override the render function, specify your declarative events, and perhaps the tagName, className, or id of the View's root element.
        /// </summary>
        /// <param name="properties"></param>
        ///<example>
        ///usage
        ///<code>
        ///var DocumentRow = Backbone.View.extend({
        /// 
        ///   tagName: "li",
        /// 
        ///   className: "document-row",
        /// 
        ///   events: {
        ///     "click .icon":          "open",
        ///     "click .button.edit":   "openEditDialog",
        ///     "click .button.delete": "destroy"
        ///   },
        /// 
        ///   render: function() {
        ///     ...
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties) { }

        /// <summary>
        /// When creating a new View, the options you pass are attached to the view as this.options, for future reference.
        /// There are several special options that, if passed, will be attached directly to the view: model, collection, el, id, className, tagName and attributes.
        /// If the view defines an initialize function, it will be called when the view is first created.
        /// If you'd like to create a view that references an element already in the DOM, pass in the element as an option: new View({el: existingElement})
        /// </summary>
        /// <param name="options"></param>
        ///<example>
        ///usage
        ///<code>
        ///var doc = Documents.first();
        /// new DocumentRow({
        ///   model: doc,
        ///   id: "document-row-" + doc.id
        /// });
        ///</code>
        ///</example>
        public View(object options) { }
        /// <summary>
        /// When creating a new View, the options you pass are attached to the view as this.options, for future reference.
        /// There are several special options that, if passed, will be attached directly to the view: model, collection, el, id, className, tagName and attributes.
        /// If the view defines an initialize function, it will be called when the view is first created.
        /// If you'd like to create a view that references an element already in the DOM, pass in the element as an option: new View({el: existingElement})
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var doc = Documents.first();
        /// new DocumentRow({
        ///   model: doc,
        ///   id: "document-row-" + doc.id
        /// });
        ///</code>
        ///</example>
        public View() { }

        /// <summary>
        /// All views have a DOM element at all times (the el property), whether they've already been inserted into the page or not.
        /// In this fashion, views can be rendered at any time, and inserted into the DOM all at once,
        /// in order to get high-performance UI rendering with as few reflows and repaints as possible.
        /// this.el is created from the view's tagName, className, id and attributes properties, if specified. If not, el is an empty div.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var ItemView = Backbone.View.extend({
        ///   tagName: 'li'
        /// });
        /// 
        /// var BodyView = Backbone.View.extend({
        ///   el: 'body'
        /// });
        /// 
        /// var item = new ItemView();
        /// var body = new BodyView();
        /// 
        /// alert(item.el + ' ' + body.el);
        ///</code>
        ///</example>
        public HtmlElement el { get; set; }

        /// <summary>
        /// A cached jQuery (or Zepto) object for the view's element.
        /// A handy reference instead of re-wrapping the DOM element all the time.
        /// </summary>
        [JsProperty(Name = "$el")]
        public jQuery.jQuery Jel { get; set; }

        /// <summary>
        /// If you'd like to apply a Backbone view to a different DOM element, use setElement,
        /// which will also create the cached $el reference and move the view's delegated events from the old element to the new one.
        /// </summary>
        /// <param name="element"></param>
        public void setElement(HtmlElement element) { }

        /// <summary>
        /// A hash of attributes that will be set as HTML DOM element attributes on the view's el (id, class, data-properties, etc.), or a function that returns such a hash.
        /// </summary>
        public HtmlElement attributes { get; set; }

        /// <summary>
        /// If jQuery or Zepto is included on the page, each view has a $ function that runs queries scoped within the view's element.
        /// If you use this scoped jQuery function, you don't have to use model ids as part of your query to pull out specific elements in a list,
        /// and can rely much more on HTML class attributes. It's equivalent to running: view.$el.find(selector)
        /// </summary>
        /// <param name="selector"></param>
        ///<example>
        ///usage
        ///<code>
        ///ui.Chapter = Backbone.View.extend({
        ///   serialize : function() {
        ///     return {
        ///       title: this.$(".title").text(),
        ///       start: this.$(".start-page").text(),
        ///       end:   this.$(".end-page").text()
        ///     };
        ///   }
        /// });
        ///</code>
        ///</example>
        public void jQuery(JsString selector) { }
        //TODO: ???

        /// <summary>
        /// The default implementation of render is a no-op.
        /// Override this function with your code that renders the view template from model data, and updates this.el with the new HTML.
        /// A good convention is to return this at the end of render to enable chained calls.
        /// Backbone is agnostic with respect to your preferred method of HTML templating.
        /// Your render function could even munge together an HTML string, or use document.createElement to generate a DOM tree.
        /// However, we suggest choosing a nice JavaScript templating library. Mustache.js, Haml-js, and Eco are all fine alternatives.
        /// Because Underscore.js is already on the page, _.template is available, and is an excellent choice if you've already XSS-sanitized your interpolated data.
        /// Whatever templating strategy you end up with, it's nice if you never have to put strings of HTML in your JavaScript.
        /// At DocumentCloud, we use Jammit in order to package up JavaScript templates stored in /app/views as part of our main core.js asset package.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Bookmark = Backbone.View.extend({
        ///   render: function() {
        ///     $(this.el).html(this.template(this.model.toJSON()));
        ///     return this;
        ///   }
        /// });
        ///</code>
        ///</example>
        public object render() { return null; }

        /// <summary>
        /// Convenience function for removing the view from the DOM. Equivalent to calling $(view.el).remove();
        /// </summary>
        public void remove() { }

        /// <summary>
        /// Convenience function for creating a DOM element of the given type (tagName), with optional attributes and HTML content.
        /// Used internally to create the initial view.el.
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="attributes"></param>
        /// <param name="content"></param>
        ///<example>
        ///usage
        ///<code>
        ///var view = new Backbone.View;
        /// var el = view.make("b", {"class": "bold"}, "Bold! ");
        /// $("#make-demo").append(el);
        ///</code>
        ///</example>
        public void make(object tagName, object attributes, object content) { }
        /// <summary>
        /// Convenience function for creating a DOM element of the given type (tagName), with optional attributes and HTML content.
        /// Used internally to create the initial view.el.
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="attributes"></param>
        ///<example>
        ///usage
        ///<code>
        ///var view = new Backbone.View;
        /// var el = view.make("b", {"class": "bold"}, "Bold! ");
        /// $("#make-demo").append(el);
        ///</code>
        ///</example>
        public void make(object tagName, object attributes) { }
        /// <summary>
        /// Convenience function for creating a DOM element of the given type (tagName), with optional attributes and HTML content.
        /// Used internally to create the initial view.el.
        /// </summary>
        /// <param name="tagName"></param>
        ///<example>
        ///usage
        ///<code>
        ///var view = new Backbone.View;
        /// var el = view.make("b", {"class": "bold"}, "Bold! ");
        /// $("#make-demo").append(el);
        ///</code>
        ///</example>
        public void make(object tagName) { }


        //TODO: delegateEvents, undelegateEvents
    }

    //TODO: Utility Functions
}


/*
 * // Our basic **Todo** model has `title`, `order`, and `done` attributes.
  var Todo = Backbone.Model.extend({

    // Default attributes for the todo item.
    defaults: function() {
      return {
        title: "empty todo...",
        order: Todos.nextOrder(),
        done: false
      };
    },

    // Ensure that each todo created has `title`.
    initialize: function() {
      if (!this.get("title")) {
        this.set({"title": this.defaults.title});
      }
    },

    // Toggle the `done` state of this todo item.
    toggle: function() {
      this.save({done: !this.get("done")});
    },

    // Remove this Todo from *localStorage* and delete its view.
    clear: function() {
      this.destroy();
    }

  });*/
