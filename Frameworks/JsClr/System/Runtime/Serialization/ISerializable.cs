using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization;
namespace SharpKit.JavaScript.Private
{
    /// <summary>Allows an object to control its own serialization and deserialization.</summary>
    [JsType(Name = "System.Runtime.Serialization.ISerializable", Filename = "~/res/System.Ext.js")]
    internal interface ISerializable
    {
        /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
        /// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization. </param>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
