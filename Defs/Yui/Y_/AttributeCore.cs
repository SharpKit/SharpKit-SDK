//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// <p>
    /// AttributeCore provides the lightest level of configurable attribute support. It is designed to be
    /// augmented on to a host class, and provides the host with the ability to configure
    /// attributes to store and retrieve state, <strong>but without support for attribute change events</strong>.
    /// </p>
    /// <p>For example, attributes added to the host can be configured:</p>
    /// <ul>
    /// <li>As read only.</li>
    /// <li>As write once.</li>
    /// <li>With a setter function, which can be used to manipulate
    /// values passed to Attribute's <a href="#method_set">set</a> method, before they are stored.</li>
    /// <li>With a getter function, which can be used to manipulate stored values,
    /// before they are returned by Attribute's <a href="#method_get">get</a> method.</li>
    /// <li>With a validator function, to validate values before they are stored.</li>
    /// </ul>
    /// <p>See the <a href="#method_addAttr">addAttr</a> method, for the complete set of configuration
    /// options available for attributes.</p>
    /// <p>Object/Classes based on AttributeCore can augment <a href="AttributeEvents.html">AttributeEvents</a>
    /// (with true for overwrite) and <a href="AttributeExtras.html">AttributeExtras</a> to add attribute event and
    /// additional, less commonly used attribute methods, such as `modifyAttr`, `removeAttr` and `reset`.</p>
    /// </summary>
    public partial class AttributeCore
    {
        /// <summary>
        /// Provides the common implementation for the public get method,
        /// allowing Attribute hosts to over-ride either method.
        /// See <a href="#method_get">get</a> for argument details.
        /// </summary>
        protected object _getAttr(object name){return null;}
        /// <summary>
        /// Implementation behind the public getAttrs method, to get multiple attribute values.
        /// </summary>
        protected object _getAttrs(object attrs){return null;}
        /// <summary>
        /// Utility method to set up initial attributes defined during construction, either through the constructor.ATTRS property, or explicitly passed in.
        /// </summary>
        protected void _initAttrs(object attrs, object values, object lazy){}
        /// <summary>
        /// Utility method to protect an attribute configuration
        /// hash, by merging the entire object and the individual
        /// attr config objects.
        /// </summary>
        protected object _protectAttrs(object attrs){return null;}
        /// <summary>
        /// Allows setting of readOnly/writeOnce attributes. See <a href="#method_set">set</a> for argument details.
        /// </summary>
        protected object _set(object name, object val){return null;}
        /// <summary>
        /// Provides the common implementation for the public set and protected _set methods.
        /// See <a href="#method_set">set</a> for argument details.
        /// </summary>
        protected object _setAttr(object name, object value, object opts, object force){return null;}
        /// <summary>
        /// Implementation behind the public setAttrs method, to set multiple attribute values.
        /// </summary>
        protected object _setAttrs(object attrs){return null;}
        /// <summary>
        /// <p>
        /// Adds an attribute with the provided configuration to the host object.
        /// </p>
        /// <p>
        /// The config argument object supports the following properties:
        /// </p>
        /// <dl>
        /// <dt>value &#60;Any&#62;</dt>
        /// <dd>The initial value to set on the attribute</dd>
        /// <dt>valueFn &#60;Function | String&#62;</dt>
        /// <dd>
        /// <p>A function, which will return the initial value to set on the attribute. This is useful
        /// for cases where the attribute configuration is defined statically, but needs to
        /// reference the host instance ("this") to obtain an initial value. If both the value and valueFn properties are defined,
        /// the value returned by the valueFn has precedence over the value property, unless it returns undefined, in which
        /// case the value property is used.</p>
        /// <p>valueFn can also be set to a string, representing the name of the instance method to be used to retrieve the value.</p>
        /// </dd>
        /// <dt>readOnly &#60;boolean&#62;</dt>
        /// <dd>Whether or not the attribute is read only. Attributes having readOnly set to true
        /// cannot be modified by invoking the set method.</dd>
        /// <dt>writeOnce &#60;boolean&#62; or &#60;string&#62;</dt>
        /// <dd>
        /// Whether or not the attribute is "write once". Attributes having writeOnce set to true,
        /// can only have their values set once, be it through the default configuration,
        /// constructor configuration arguments, or by invoking set.
        /// <p>The writeOnce attribute can also be set to the string "initOnly", in which case the attribute can only be set during initialization
        /// (when used with Base, this means it can only be set during construction)</p>
        /// </dd>
        /// <dt>setter &#60;Function | String&#62;</dt>
        /// <dd>
        /// <p>The setter function used to massage or normalize the value passed to the set method for the attribute.
        /// The value returned by the setter will be the final stored value. Returning
        /// <a href="#property_Attribute.INVALID_VALUE">Attribute.INVALID_VALUE</a>, from the setter will prevent
        /// the value from being stored.
        /// </p>
        /// <p>setter can also be set to a string, representing the name of the instance method to be used as the setter function.</p>
        /// </dd>
        /// <dt>getter &#60;Function | String&#62;</dt>
        /// <dd>
        /// <p>
        /// The getter function used to massage or normalize the value returned by the get method for the attribute.
        /// The value returned by the getter function is the value which will be returned to the user when they
        /// invoke get.
        /// </p>
        /// <p>getter can also be set to a string, representing the name of the instance method to be used as the getter function.</p>
        /// </dd>
        /// <dt>validator &#60;Function | String&#62;</dt>
        /// <dd>
        /// <p>
        /// The validator function invoked prior to setting the stored value. Returning
        /// false from the validator function will prevent the value from being stored.
        /// </p>
        /// <p>validator can also be set to a string, representing the name of the instance method to be used as the validator function.</p>
        /// </dd>
        /// <dt>lazyAdd &#60;boolean&#62;</dt>
        /// <dd>Whether or not to delay initialization of the attribute until the first call to get/set it.
        /// This flag can be used to over-ride lazy initialization on a per attribute basis, when adding multiple attributes through
        /// the <a href="#method_addAttrs">addAttrs</a> method.</dd>
        /// </dl>
        /// <p>The setter, getter and validator are invoked with the value and name passed in as the first and second arguments, and with
        /// the context ("this") set to the host object.</p>
        /// <p>Configuration properties outside of the list mentioned above are considered private properties used internally by attribute,
        /// and are not intended for public use.</p>
        /// </summary>
        public object addAttr(object name, object config, object lazy){return null;}
        /// <summary>
        /// Configures a group of attributes, and sets initial values.
        /// <p>
        /// <strong>NOTE:</strong> This method does not isolate the configuration object by merging/cloning.
        /// The caller is responsible for merging/cloning the configuration object if required.
        /// </p>
        /// </summary>
        public object addAttrs(object cfgs, object values, object lazy){return null;}
        /// <summary>
        /// Checks if the given attribute has been added to the host
        /// </summary>
        public object attrAdded(object name){return null;}
        /// <summary>
        /// Returns the current value of the attribute. If the attribute
        /// has been configured with a 'getter' function, this method will delegate
        /// to the 'getter' to obtain the value of the attribute.
        /// </summary>
        public object get(object name){return null;}
        /// <summary>
        /// Gets multiple attribute values.
        /// </summary>
        public object getAttrs(object attrs){return null;}
        /// <summary>
        /// Sets the value of an attribute.
        /// </summary>
        public object set(object name, object value){return null;}
        /// <summary>
        /// Sets multiple attribute values.
        /// </summary>
        public object setAttrs(object attrs){return null;}
        /// <summary>
        /// The list of properties which can be configured for
        /// each attribute (e.g. setter, getter, writeOnce etc.).
        /// This property is used internally as a whitelist for faster
        /// Y.mix operations.
        /// </summary>
        protected Y_.Array _ATTR_CFG{get;set;}
        /// <summary>
        /// <p>The value to return from an attribute setter in order to prevent the set from going through.</p>
        /// <p>You can return this value from your setter if you wish to combine validator and setter
        /// functionality into a single setter function, which either returns the massaged value to be stored or
        /// AttributeCore.INVALID_VALUE to prevent invalid values from being stored.</p>
        /// </summary>
        public object INVALID_VALUE{get;set;}
    }
}
