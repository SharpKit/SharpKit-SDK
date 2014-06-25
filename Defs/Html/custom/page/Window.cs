using System;
using SharpKit.Html.filesystem;
using SharpKit.Html.quota;
using SharpKit.JavaScript;
using SharpKit.Html.indexeddb;

namespace SharpKit.Html
{
    //[JsType(JsMode.Prototype, Export = true, Name = "Window")]
    [JsType(PropertiesAsFields = true)]
    partial class Window : ILocalFileSystem
    {
        public StorageInfo StorageInfo { get; private set; }

        [JsField(Name = "webkitStorageInfo")]
        [Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        public StorageInfo WebkitStorageInfo;

        //[JsMethod(Name = "requestFileSystem", Code = "(requestFileSystem||webkitRequestFileSystem)(type, size, successCallback, errorCallback);")]
        [JsMethod(Name = "requestFileSystem")]
        public void RequestFileSystem(ushort type, ulong size, FileSystemCallback successCallback, ErrorCallback errorCallback = null) { }

        [JsMethod(Name = "resolveLocalFileSystemURL")]
        public void ResolveLocalFileSystemUrl(string url, EntryCallback successCallback, ErrorCallback errorCallback = null) { }

        [JsMethod(Name = "webkitRequestFileSystem")]
        [Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        public void WebkitRequestFileSystem(ushort type, ulong size, FileSystemCallback successCallback, ErrorCallback errorCallback = null) { }

        [JsMethod(Name = "WebkitResolveLocalFileSystemURL")]
        [Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        public void WebkitResolveLocalFileSystemUrl(string url, EntryCallback successCallback, ErrorCallback errorCallback = null) { }

        public int setTimeout(JsAction handler, int timeout) { return default(int); }
        public int setInterval(JsAction handler, int timeout) { return default(int); }
        public Window open() { return null; }

        [JsProperty(NativeIndexer = true)]
        public virtual JsObject this[string index] {
            get { return null; }
            set { }
        }

        public Performance performance { get; private set; }


        
    }
}
