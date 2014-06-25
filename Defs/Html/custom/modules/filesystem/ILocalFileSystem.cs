using SharpKit.JavaScript;

namespace SharpKit.Html.filesystem
{
    /// <summary>
    /// LocalFileSystem
    /// </summary>
    public interface ILocalFileSystem
    {
        //const ushort Temporary = 0;
        //const ushort Persistant = 1;

        [JsMethod(Name = "requestFileSystem")]
        void RequestFileSystem(ushort type, ulong size, FileSystemCallback successCallback, ErrorCallback errorCallback = null);

        [JsMethod(Name = "resolveLocalFileSystemURL")]
        void ResolveLocalFileSystemUrl(string url, EntryCallback successCallback, ErrorCallback errorCallback = null);
    }
}
