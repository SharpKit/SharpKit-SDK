using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>This class is primarily for internal use.  JavaScript programs should
    /// use Buffer instead of using SlowBuffer.
    /// </p>
    /// <p>In order to avoid the overhead of allocating many C++ Buffer objects for
    /// small blocks of memory in the lifetime of a server, Node allocates memory
    /// in 8Kb (8192 byte) chunks.  If a buffer is smaller than this size, then it
    /// will be backed by a parent SlowBuffer object.  If it is larger than this,
    /// then Node will allocate a SlowBuffer slab for it directly.
    /// </p>
    /// </summary>
    public partial class SlowBuffer
    {
    }
}
