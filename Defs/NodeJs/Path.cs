using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    class Path
    {
        /// <summary>
        /// Join all arguments together and normalize the resulting path. Non-string arguments are ignored.
        /// </summary>
        /// <param name="path1"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// path.join('/foo', 'bar', 'baz/asdf', 'quux', '..')
        /// //  returns
        /// '/foo/bar/baz/asdf'
        /// path.join('foo', {}, 'bar')
        /// //  returns
        /// 'foo/bar'
        /// </code>
        /// </example>
        public JsString join(JsString path1) { return null; }
        /// <summary>
        /// Join all arguments together and normalize the resulting path. Non-string arguments are ignored.
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        /// /// <example>
        /// Example:
        /// <code>
        /// path.join('/foo', 'bar', 'baz/asdf', 'quux', '..')
        /// //  returns
        /// '/foo/bar/baz/asdf'
        /// path.join('foo', {}, 'bar')
        /// //  returns
        /// 'foo/bar'
        /// </code>
        /// </example>
        public JsString join(JsString path1, JsString path2) { return null; }
        /// <summary>
        /// Join all arguments together and normalize the resulting path. Non-string arguments are ignored.
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="paths"></param>
        /// <returns></returns>
        /// /// <example>
        /// Example:
        /// <code>
        /// path.join('/foo', 'bar', 'baz/asdf', 'quux', '..')
        /// //  returns
        /// '/foo/bar/baz/asdf'
        /// path.join('foo', {}, 'bar')
        /// //  returns
        /// 'foo/bar'
        /// </code>
        /// </example>
        public JsString join(JsString path1, JsString path2, params JsString[] paths) { return null; }
        /// <summary>
        /// Normalize a string path, taking care of '..' and '.' parts.
        /// When multiple slashes are found, they're replaced by a single one; when the path contains a trailing slash, it is preserved. On windows backslashes are used.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// path.normalize('/foo/bar//baz/asdf/quux/..')
        /// // returns
        /// '/foo/bar/baz/asdf'
        /// </code>
        /// </example>
        public JsString normalize(JsString path) { return null; }
        /// <summary>
        /// Resolves to to an absolute path.
        /// If to isn't already absolute from arguments are prepended in right to left order, until an absolute path is found. 
        /// If after using all from paths still no absolute path is found, the current working directory is used as well. 
        /// The resulting path is normalized, and trailing slashes are removed unless the path gets resolved to the root directory. Non-string arguments are ignored.
        /// Another way to think of it is as a sequence of cd commands in a shell.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// path.resolve('foo/bar', '/tmp/file/', '..', 'a/../subfile')
        /// </code>
        /// </example>
        /// <example>
        /// Is similar to:
        /// <code>
        /// cd foo/bar
        /// cd /tmp/file/
        /// cd ..
        /// cd a/../subfile
        /// pwd
        /// </code>
        /// The difference is that the different paths don't need to exist and may also be files.
        /// Examples:
        /// <code>
        ///         // path.resolve('/foo/bar', './baz')
        /// // returns
        /// '/foo/bar/baz'
        ///
        /// path.resolve('/foo/bar', '/tmp/file/')
        /// // returns
        /// '/tmp/file'
        ///
        /// path.resolve('wwwroot', 'static_files/png/', '../gif/image.gif')
        /// // if currently in /home/myself/node, it returns
        /// '/home/myself/node/wwwroot/static_files/gif/image.gif'
        /// </code>
        /// </example>
        public JsString resolve(JsString to) { return null; }
        /// <summary>
        /// Resolves to to an absolute path.
        /// If to isn't already absolute from arguments are prepended in right to left order, until an absolute path is found. 
        /// If after using all from paths still no absolute path is found, the current working directory is used as well. 
        /// The resulting path is normalized, and trailing slashes are removed unless the path gets resolved to the root directory. Non-string arguments are ignored.
        /// Another way to think of it is as a sequence of cd commands in a shell.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// path.resolve('foo/bar', '/tmp/file/', '..', 'a/../subfile')
        /// </code>
        /// </example>
        /// <example>
        /// Is similar to:
        /// <code>
        /// cd foo/bar
        /// cd /tmp/file/
        /// cd ..
        /// cd a/../subfile
        /// pwd
        /// </code>
        /// The difference is that the different paths don't need to exist and may also be files.
        /// Examples:
        /// <code>
        ///         // path.resolve('/foo/bar', './baz')
        /// // returns
        /// '/foo/bar/baz'
        ///
        /// path.resolve('/foo/bar', '/tmp/file/')
        /// // returns
        /// '/tmp/file'
        ///
        /// path.resolve('wwwroot', 'static_files/png/', '../gif/image.gif')
        /// // if currently in /home/myself/node, it returns
        /// '/home/myself/node/wwwroot/static_files/gif/image.gif'
        /// </code>
        /// </example>
        public JsString resolve(JsString from, JsString to) { return null; }
        /// <summary>
        /// Solve the relative path from from to to.
        /// At times we have two absolute paths, and we need to derive the relative path from one to the other. 
        /// This is actually the reverse transform of path.resolve, which means we see that:
        /// <code>
        /// path.resolve(from, path.relative(from, to)) == path.resolve(to)
        /// </code>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        /// <example>
        /// Examples:
        /// <code>
        /// path.relative('C:\\orandea\\test\\aaa', 'C:\\orandea\\impl\\bbb')
        /// // returns
        /// '..\\..\\impl\\bbb'
        /// path.relative('/data/orandea/test/aaa', '/data/orandea/impl/bbb')
        /// // returns
        /// '../../impl/bbb'
        /// </code>
        /// </example>
        public JsString relative(JsString from, JsString to) { return null; }
        /// <summary>
        /// Return the directory name of a path. Similar to the Unix dirname command.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Return the directory name of a path. </returns>
        /// <example>
        /// Example:
        /// <code>
        /// path.dirname('/foo/bar/baz/asdf/quux')
        /// // returns
        /// '/foo/bar/baz/asdf'
        /// path.basename(p, [ext])#
        /// Return the last portion of a path. Similar to the Unix basename command.
        ///</code>
        /// Example:
        ///<code>
        /// path.basename('/foo/bar/baz/asdf/quux.html')
        /// // returns
        /// 'quux.html'
        ///</code>
        ///<code>
        /// path.basename('/foo/bar/baz/asdf/quux.html', '.html')
        /// // returns
        ///'quux'
        /// </code>
        /// </example>
        public JsString dirname(JsString p) { return null; }
        /// <summary>
        /// Return the extension of the path, from the last '.' to end of string in the last portion of the path. 
        /// If there is no '.' in the last portion of the path or the first character of it is '.', then it returns an empty string. Examples: 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        ///path.extname('index.html')
        /// // returns
        /// '.html'
        ///
        /// path.extname('index.')
        /// // returns
        /// '.'
        ///
        /// path.extname('index')
        /// // returns
        /// ''
        /// </code>
        /// </example>
        public JsString extname(JsString p) { return null; }
        /// <summary>
        /// The platform-specific file separator. '\\' or '/'.
        /// </summary>
        /// <example>
        /// An example on linux:
        /// <code>
        /// 'foo/bar/baz'.split(path.sep)
        /// // returns
        /// ['foo', 'bar', 'baz']
        /// </code>
        /// An example on windows:
        /// <code>
        /// 'foo\\bar\\baz'.split(path.sep)
        /// // returns
        /// ['foo', 'bar', 'baz']
        /// </code>
        /// </example>
        public JsFunc<JsString> sep { get; set; }
    }
}
