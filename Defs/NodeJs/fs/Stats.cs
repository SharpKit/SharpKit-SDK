using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.fs
{
    /// <summary>
    /// <p>Objects returned from <code>fs.stat()</code>, <code>fs.lstat()</code> and <code>fs.fstat()</code> and their
    /// synchronous counterparts are of this type.
    /// </p>
    /// <ul>
    /// <li><code>stats.isFile()</code></li>
    /// <li><code>stats.isDirectory()</code></li>
    /// <li><code>stats.isBlockDevice()</code></li>
    /// <li><code>stats.isCharacterDevice()</code></li>
    /// <li><code>stats.isSymbolicLink()</code> (only valid with  <code>fs.lstat()</code>)</li>
    /// <li><code>stats.isFIFO()</code></li>
    /// <li><code>stats.isSocket()</code></li>
    /// </ul>
    /// <p>For a regular file <code>util.inspect(stats)</code> would return a string very
    /// similar to this:
    /// </p>
    /// <pre><code>{ dev: 2114,
    /// ino: 48064969,
    /// mode: 33188,
    /// nlink: 1,
    /// uid: 85,
    /// gid: 100,
    /// rdev: 0,
    /// size: 527,
    /// blksize: 4096,
    /// blocks: 8,
    /// atime: Mon, 10 Oct 2011 23:24:11 GMT,
    /// mtime: Mon, 10 Oct 2011 23:24:11 GMT,
    /// ctime: Mon, 10 Oct 2011 23:24:11 GMT }</code></pre>
    /// <p>Please note that <code>atime</code>, <code>mtime</code> and <code>ctime</code> are instances
    /// of [Date][MDN-Date] object and to compare the values of
    /// these objects you should use appropriate methods. For most
    /// general uses [getTime()][MDN-Date-getTime] will return
    /// the number of milliseconds elapsed since <em>1 January 1970
    /// 00:00:00 UTC</em> and this integer should be sufficient for
    /// any comparison, however there additional methods which can
    /// be used for displaying fuzzy information. More details can
    /// be found in the [MDN JavaScript Reference][MDN-Date] page.
    /// </p>
    /// </summary>
    public partial class Stats
    {
        //TODO
    }
}
