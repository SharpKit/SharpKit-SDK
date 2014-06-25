using System;
using SharpKit.JavaScript;
using SharpKit.JavaScript.Private;

namespace SharpKit.JsClr.System.Collections.Generic
{
    /// <summary>
    /// The exception that is thrown when the key specified for accessing an element in a collection does not match any key in the collection.
    /// </summary>
    [JsType(Name = "System.Collections.Generic.KeyNotFoundException", Filename = "~/res/System.Collections.js")]
    internal class JsImplArgumentException : JsImplSystemException
    {
        #region Constants
        private const int COR_E_KEYNOTFOUND = -2146232969;
        #endregion

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="JsImplArgumentException" /> class.
        /// </summary>
        public JsImplArgumentException()
            : base(JsImplEnvironment.GetResourceString("Arg_ArgumentException"))
        {
            SetErrorCode(COR_E_KEYNOTFOUND);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsImplArgumentException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public JsImplArgumentException(string message)
            : base(message)
        {
            SetErrorCode(COR_E_KEYNOTFOUND);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsImplArgumentException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public JsImplArgumentException(string message, Exception innerException)
            : base(message, innerException)
        {
            SetErrorCode(COR_E_KEYNOTFOUND);
        }
        #endregion
    }
}
