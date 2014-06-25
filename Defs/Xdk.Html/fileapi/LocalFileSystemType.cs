using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;

namespace SharpKit.DotNet.Html.fileapi
{
    /// <summary>
    /// LocalFileSystemType (TEMPORARY or PERSISTENT).
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#LocalFileSystem
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum LocalFileSystemType
    {
        TEMPORARY = 0,
        PERSISTENT = 1
    }
}
