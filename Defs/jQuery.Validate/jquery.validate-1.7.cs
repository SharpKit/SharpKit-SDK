using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.jQuery
{
    public partial class jQuery
    {
        public static Validator validator { get; private set; }
        /// <summary>
        /// Validates the selected form.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Validator validate(ValidationOptions options) { return null; }
        /// <summary>
        /// Validates the selected form.
        /// </summary>
        /// <returns></returns>
        public Validator validate() { return null; }
        /// <summary>
        /// Checks whether the selected form is valid or whether all selected elements are valid.
        /// </summary>
        /// <returns></returns>
        public bool valid() { return false; }

        /// <summary>
        /// Return the validations rules for the first selected element.
        /// </summary>
        /// <returns></returns>
        public object rules() { return null; }

        /// <summary>
        /// Adds the specified rules and returns all rules for the first matched element. Requires that the parent form is validated, that is, $("form").validate() is called first.
        /// or
        /// Removes the specified rules and returns all rules for the first matched element.
        /// </summary>
        /// <param name="addOrRemove"></param>
        /// <param name="rules"></param>
        public object rules(JsString addOrRemove, object rules) { return null; }//Returns: Options


        //Remove the specified attributes from the first matched element and return them.
        public void removeAttrs(object attributes) { }//Returns: Options

        #region Uncodable

        //[edit]
        //Custom selectors

        //Custom selectors:
        //:blank	{}//Returns: Array<Element>
        //Matches elements with a blank value

        //:filled	{}//Returns: Array<Element>
        //Matches elements with a value.

        //:unchecked	{}//Returns: Array<Element>
        //Matches all elements that are unchecked.

        //[edit]
        //Utilities

        #endregion

        //String utilities:

        //TODO: public void jQuery.validator.format( template, argument, argumentN... )	{}//Returns: String
        //Replaces {n} placeholders with arguments.
        //[edit]
        //Validator

        //The validate method returns a Validator object that has a few public methods that you can use trigger validation programmatically or change the contents of the form. The validator object has more methods, but only those documented here are intended for usage.

    }


    [JsType(JsMode.Prototype, Export=false)]
    public partial class Validator
    {
        //Validator methods:

        public bool form() { return false;}
        //Validates the form, returns true if it is valid, false otherwise.

        public bool element(HtmlElement element) { return false; }
        //Validates a single element, returns true if it is valid, false otherwise.

        public void resetForm() { }//Returns: undefined
        //Resets the controlled form.

        public void showErrors(object errors) { }//Returns: undefined
        //Show the specified messages.

        public void numberOfInvalids() { }//Returns: Integer
        //Returns the number of invalid fields.
        //There are a few static methods on the validator object:

        //Validator functions:

        public void setDefaults(object defaults) { }//Returns: undefined
        //Modify default settings for validation.

        /// <summary>
        /// Add a custom validation method. It must consist of a name (must be a legal javascript identifier), a javascript based function and a default string message.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="method"></param>
        /// <param name="message"></param>
        public void addMethod(JsString name, object method, JsString message) { }//Returns: undefined

        public void addClassRules(JsString name, object rules) { }//Returns: undefined
        //Add a compound class method - useful to refactor common combinations of rules into a single class.

        public void addClassRules(object rules) { }//Returns: undefined
        //Add compound class methods - useful to refactor common combinations of rules.
        //[edit]
        //List of built-in Validation methods

        //A set of standard validation methods is provided:

        //Methods:

        public bool required() { return false; }
        //Makes the element always required.

        public bool required(object dependencyExpression) { return false; }
        //Makes the element required, depending on the result of the given expression.

        public bool required(JsAction dependencyCallback) { return false; }
        //Makes the element required, depending on the result of the given callback.

        public bool remote(object options) { return false; }
        //Requests a resource to check the element for validity.


        public bool minlength(JsNumber length) { return false; }
        //Makes the element require a given minimum length.

        public bool maxlength(JsNumber length) { return false; }
        //Makes the element require a given maxmimum length.

        public bool rangelength(object range) { return false; }
        //Makes the element require a given value range.

        public bool min(JsNumber value) { return false; }
        //Makes the element require a given minimum.

        public bool max(JsNumber value) { return false; }
        //Makes the element require a given maximum.

        public bool range(object range) { return false; }
        //Makes the element require a given value range.

        public bool email() { return false; }
        //Makes the element require a valid email

        public bool url() { return false; }
        //Makes the element require a valid url

        public bool date() { return false; }
        //Makes the element require a date.

        public bool dateISO() { return false; }
        //Makes the element require a ISO date.

        public bool dateDE() { return false; }
        //Makes the element require a german date.

        public bool number() { return false; }
        //Makes the element require a decimal number.

        public bool numberDE() { return false; }
        //Makes the element require a decimal number with german format.

        public bool digits() { return false; }
        //Makes the element require digits only.

        public bool creditcard() { return false; }
        //Makes the element require a creditcard number.

        public bool accept(object extension) { return false; }
        //Makes the element require a certain file extension.

        public bool equalTo(object other) { return false; }
        //Requires the element to be the same as another one

    }
    [JsType(JsMode.Json)]
    public partial class ValidationOptions
    {
        public bool debug { get; set; }
        public JsAction submitHandler { get; set; }
        public JsAction invalidHandler { get; set; }
        public JsString ignore { get; set; }
        public object rules { get; set; }
        public object messages { get; set; }
        public object groups { get; set; }
        public bool onsubmit { get; set; }
        public bool onfocusout { get; set; }
        public bool onkeyup { get; set; }
        public bool onclick { get; set; }
        public bool focusInvalid { get; set; }
        public bool focusCleanup { get; set; }
        public JsString meta { get; set; }
        public JsString errorClass { get; set; }
        public JsString validClass { get; set; }
        public JsString errorElement { get; set; }
        public JsString wrapper { get; set; }
        public JsString errorLabelContainer { get; set; }
        public JsString errorContainer { get; set; }
        public JsAction showErrors { get; set; }
        public JsAction errorPlacement { get; set; }
        public JsString success { get; set; }
        //public JsAction success { get; set; }
        public JsAction highlight { get; set; }
        public JsAction unhighlight { get; set; }
        public bool ignoreTitle { get; set; }

    }

}

