using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;

namespace SharpKit.DotNet.Html.fileapi
{
    /// <summary>
    /// This object provides a way to obtain root file systems.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#LocalFileSystem
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class LocalFileSystem : ILocalFileSystem
    {
        [JsMethod(Name = "requestFileSystem")]
        public void RequestFileSystem(LocalFileSystemType type, ulong size, FileSystemCallback successCallback, FileErrorCallback errorCallback = null) { }
        [JsMethod(Name = "resolveLocalFileSystemURL")]
        public void ResolveLocalFileSystemUrl(JsString url, EntryCallback successCallback, FileErrorCallback errorCallback = null) { }
    }
}
