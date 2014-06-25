using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;

namespace SharpKit.DotNet.Html.fileapi
{
    /// <summary>
    /// This interface is for LocalFileSystem objects to provide a way to obtain root file systems.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#LocalFileSystem
    /// </remarks>
    public interface ILocalFileSystem
    {
        //const->enum// public  static int TEMPORARY = 0;
        //const->enum// public  static int PERSISTENT = 1;
        /// <summary>
        /// Requests a filesystem.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="size"></param>
        /// <param name="successCallback"></param>
        /// <param name="errorCallback"></param>
        [JsMethod(Name = "requestFileSystem")]
        void RequestFileSystem(LocalFileSystemType type, ulong size, FileSystemCallback successCallback, FileErrorCallback errorCallback = null);
        /// <summary>
        /// Retrieve a <see cref="DirectoryEntry"/> or <see cref="FileEntry"/> using local URI.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="successCallback"></param>
        /// <param name="errorCallback"></param>
        [JsMethod(Name = "resolveLocalFileSystemURL")]
        void ResolveLocalFileSystemUrl(JsString url, EntryCallback successCallback, FileErrorCallback errorCallback = null);
    }
}
