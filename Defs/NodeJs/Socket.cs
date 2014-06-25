using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    //TODO: ask about UDP/ DatagramSockets
    /// <summary>
    /// <p>The dgram Socket class encapsulates the datagram functionality.  It
    /// should be created via <code>dgram.createSocket(type, [callback])</code>.
    /// </p>
    /// </summary>
    public partial class Socket
    {
        /// <summary>
        /// <p>Tells the kernel to join a multicast group with <code>IP_ADD_MEMBERSHIP</code> socket option.
        /// </p>
        /// <p>If <code>multicastInterface</code> is not specified, the OS will try to add membership to all valid
        /// interfaces.
        /// </p>
        /// </summary>
        public object addMembership(object multicastAddress){return null;}
        /// <summary>
        /// <p>Tells the kernel to join a multicast group with <code>IP_ADD_MEMBERSHIP</code> socket option.
        /// </p>
        /// <p>If <code>multicastInterface</code> is not specified, the OS will try to add membership to all valid
        /// interfaces.
        /// </p>
        /// </summary>
        public object addMembership(object multicastAddress, object multicastInterface){return null;}
        /// <summary>
        /// <p>Returns an object containing the address information for a socket.  For UDP sockets,
        /// this object will contain <code>address</code> , <code>family</code> and <code>port</code>.
        /// </p>
        /// </summary>
        public object address(){return null;}
        /// <summary>
        /// <p>For UDP sockets, listen for datagrams on a named <code>port</code> and optional <code>address</code>. If
        /// <code>address</code> is not specified, the OS will try to listen on all addresses.
        /// </p>
        /// <p>Example of a UDP server listening on port 41234:
        /// </p>
        /// <pre><code>var dgram = require(&quot;dgram&quot;);
        /// var server = dgram.createSocket(&quot;udp4&quot;);
        /// server.on(&quot;message&quot;, function (msg, rinfo) {
        /// console.log(&quot;server got: &quot; + msg + &quot; from &quot; +
        /// rinfo.address + &quot;:&quot; + rinfo.port);
        /// });
        /// server.on(&quot;listening&quot;, function () {
        /// var address = server.address();
        /// console.log(&quot;server listening &quot; +
        /// address.address + &quot;:&quot; + address.port);
        /// });
        /// server.bind(41234);
        /// // server listening 0.0.0.0:41234</code></pre>
        /// </summary>
        public object bind(object port){return null;}
        /// <summary>
        /// <p>For UDP sockets, listen for datagrams on a named <code>port</code> and optional <code>address</code>. If
        /// <code>address</code> is not specified, the OS will try to listen on all addresses.
        /// </p>
        /// <p>Example of a UDP server listening on port 41234:
        /// </p>
        /// <pre><code>var dgram = require(&quot;dgram&quot;);
        /// var server = dgram.createSocket(&quot;udp4&quot;);
        /// server.on(&quot;message&quot;, function (msg, rinfo) {
        /// console.log(&quot;server got: &quot; + msg + &quot; from &quot; +
        /// rinfo.address + &quot;:&quot; + rinfo.port);
        /// });
        /// server.on(&quot;listening&quot;, function () {
        /// var address = server.address();
        /// console.log(&quot;server listening &quot; +
        /// address.address + &quot;:&quot; + address.port);
        /// });
        /// server.bind(41234);
        /// // server listening 0.0.0.0:41234</code></pre>
        /// </summary>
        public object bind(object port, object address){return null;}
        /// <summary>
        /// <p>Close the underlying socket and stop listening for data on it.
        /// </p>
        /// </summary>
        public object close(){return null;}
        /// <summary>
        /// <p>Opposite of <code>addMembership</code> - tells the kernel to leave a multicast group with
        /// <code>IP_DROP_MEMBERSHIP</code> socket option. This is automatically called by the kernel
        /// when the socket is closed or process terminates, so most apps will never need to call
        /// this.
        /// </p>
        /// <p>If <code>multicastInterface</code> is not specified, the OS will try to drop membership to all valid
        /// interfaces.
        /// </p>
        /// </summary>
        public object dropMembership(object multicastAddress){return null;}
        /// <summary>
        /// <p>Opposite of <code>addMembership</code> - tells the kernel to leave a multicast group with
        /// <code>IP_DROP_MEMBERSHIP</code> socket option. This is automatically called by the kernel
        /// when the socket is closed or process terminates, so most apps will never need to call
        /// this.
        /// </p>
        /// <p>If <code>multicastInterface</code> is not specified, the OS will try to drop membership to all valid
        /// interfaces.
        /// </p>
        /// </summary>
        public object dropMembership(object multicastAddress, object multicastInterface){return null;}
        /// <summary>
        /// <p>For UDP sockets, the destination port and IP address must be specified.  A string
        /// may be supplied for the <code>address</code> parameter, and it will be resolved with DNS.  An
        /// optional callback may be specified to detect any DNS errors and when <code>buf</code> may be
        /// re-used.  Note that DNS lookups will delay the time that a send takes place, at
        /// least until the next tick.  The only way to know for sure that a send has taken place
        /// is to use the callback.
        /// </p>
        /// <p>If the socket has not been previously bound with a call to <code>bind</code>, it&#39;s
        /// assigned a random port number and bound to the &quot;all interfaces&quot; address
        /// (0.0.0.0 for <code>udp4</code> sockets, ::0 for <code>udp6</code> sockets).
        /// </p>
        /// <p>Example of sending a UDP packet to a random port on <code>localhost</code>;
        /// </p>
        /// <pre><code>var dgram = require(&#39;dgram&#39;);
        /// var message = new Buffer(&quot;Some bytes&quot;);
        /// var client = dgram.createSocket(&quot;udp4&quot;);
        /// client.send(message, 0, message.length, 41234, &quot;localhost&quot;, function(err, bytes) {
        /// client.close();
        /// });</code></pre>
        /// <p><strong>A Note about UDP datagram size</strong>
        /// </p>
        /// <p>The maximum size of an <code>IPv4/v6</code> datagram depends on the <code>MTU</code> (<em>Maximum Transmission Unit</em>)
        /// and on the <code>Payload Length</code> field size.
        /// </p>
        /// <ul>
        /// <li><p>The <code>Payload Length</code> field is <code>16 bits</code> wide, which means that a normal payload
        /// cannot be larger than 64K octets including internet header and data
        /// (65,507 bytes = 65,535 − 8 bytes UDP header − 20 bytes IP header);
        /// this is generally true for loopback interfaces, but such long datagrams
        /// are impractical for most hosts and networks.</p>
        /// </li>
        /// <li><p>The <code>MTU</code> is the largest size a given link layer technology can support for datagrams.
        /// For any link, <code>IPv4</code> mandates a minimum <code>MTU</code> of <code>68</code> octets, while the recommended <code>MTU</code>
        /// for IPv4 is <code>576</code> (typically recommended as the <code>MTU</code> for dial-up type applications),
        /// whether they arrive whole or in fragments.</p>
        /// <p>For <code>IPv6</code>, the minimum <code>MTU</code> is <code>1280</code> octets, however, the mandatory minimum
        /// fragment reassembly buffer size is <code>1500</code> octets.
        /// The value of <code>68</code> octets is very small, since most current link layer technologies have
        /// a minimum <code>MTU</code> of <code>1500</code> (like Ethernet).</p>
        /// </li>
        /// </ul>
        /// <p>Note that it&#39;s impossible to know in advance the MTU of each link through which
        /// a packet might travel, and that generally sending a datagram greater than
        /// the (receiver) <code>MTU</code> won&#39;t work (the packet gets silently dropped, without
        /// informing the source that the data did not reach its intended recipient).
        /// </p>
        /// </summary>
        public object send(object buf, object offset, object length, object port, object address){return null;}
        /// <summary>
        /// <p>For UDP sockets, the destination port and IP address must be specified.  A string
        /// may be supplied for the <code>address</code> parameter, and it will be resolved with DNS.  An
        /// optional callback may be specified to detect any DNS errors and when <code>buf</code> may be
        /// re-used.  Note that DNS lookups will delay the time that a send takes place, at
        /// least until the next tick.  The only way to know for sure that a send has taken place
        /// is to use the callback.
        /// </p>
        /// <p>If the socket has not been previously bound with a call to <code>bind</code>, it&#39;s
        /// assigned a random port number and bound to the &quot;all interfaces&quot; address
        /// (0.0.0.0 for <code>udp4</code> sockets, ::0 for <code>udp6</code> sockets).
        /// </p>
        /// <p>Example of sending a UDP packet to a random port on <code>localhost</code>;
        /// </p>
        /// <pre><code>var dgram = require(&#39;dgram&#39;);
        /// var message = new Buffer(&quot;Some bytes&quot;);
        /// var client = dgram.createSocket(&quot;udp4&quot;);
        /// client.send(message, 0, message.length, 41234, &quot;localhost&quot;, function(err, bytes) {
        /// client.close();
        /// });</code></pre>
        /// <p><strong>A Note about UDP datagram size</strong>
        /// </p>
        /// <p>The maximum size of an <code>IPv4/v6</code> datagram depends on the <code>MTU</code> (<em>Maximum Transmission Unit</em>)
        /// and on the <code>Payload Length</code> field size.
        /// </p>
        /// <ul>
        /// <li><p>The <code>Payload Length</code> field is <code>16 bits</code> wide, which means that a normal payload
        /// cannot be larger than 64K octets including internet header and data
        /// (65,507 bytes = 65,535 − 8 bytes UDP header − 20 bytes IP header);
        /// this is generally true for loopback interfaces, but such long datagrams
        /// are impractical for most hosts and networks.</p>
        /// </li>
        /// <li><p>The <code>MTU</code> is the largest size a given link layer technology can support for datagrams.
        /// For any link, <code>IPv4</code> mandates a minimum <code>MTU</code> of <code>68</code> octets, while the recommended <code>MTU</code>
        /// for IPv4 is <code>576</code> (typically recommended as the <code>MTU</code> for dial-up type applications),
        /// whether they arrive whole or in fragments.</p>
        /// <p>For <code>IPv6</code>, the minimum <code>MTU</code> is <code>1280</code> octets, however, the mandatory minimum
        /// fragment reassembly buffer size is <code>1500</code> octets.
        /// The value of <code>68</code> octets is very small, since most current link layer technologies have
        /// a minimum <code>MTU</code> of <code>1500</code> (like Ethernet).</p>
        /// </li>
        /// </ul>
        /// <p>Note that it&#39;s impossible to know in advance the MTU of each link through which
        /// a packet might travel, and that generally sending a datagram greater than
        /// the (receiver) <code>MTU</code> won&#39;t work (the packet gets silently dropped, without
        /// informing the source that the data did not reach its intended recipient).
        /// </p>
        /// </summary>
        public object send(object buf, object offset, object length, object port, object address, object callback){return null;}
        /// <summary>
        /// <p>Sets or clears the <code>SO_BROADCAST</code> socket option.  When this option is set, UDP packets
        /// may be sent to a local interface&#39;s broadcast address.
        /// </p>
        /// </summary>
        public object setBroadcast(object flag){return null;}
        /// <summary>
        /// <p>Sets or clears the <code>IP_MULTICAST_LOOP</code> socket option.  When this option is set, multicast
        /// packets will also be received on the local interface.
        /// </p>
        /// </summary>
        public object setMulticastLoopback(object flag){return null;}
        /// <summary>
        /// <p>Sets the <code>IP_MULTICAST_TTL</code> socket option.  TTL stands for &quot;Time to Live,&quot; but in this
        /// context it specifies the number of IP hops that a packet is allowed to go through,
        /// specifically for multicast traffic.  Each router or gateway that forwards a packet
        /// decrements the TTL. If the TTL is decremented to 0 by a router, it will not be forwarded.
        /// </p>
        /// <p>The argument to <code>setMulticastTTL()</code> is a number of hops between 0 and 255.  The default on most
        /// systems is 1.
        /// </p>
        /// </summary>
        public object setMulticastTTL(object ttl){return null;}
        /// <summary>
        /// <p>Sets the <code>IP_TTL</code> socket option.  TTL stands for &quot;Time to Live,&quot; but in this context it
        /// specifies the number of IP hops that a packet is allowed to go through.  Each router or
        /// gateway that forwards a packet decrements the TTL.  If the TTL is decremented to 0 by a
        /// router, it will not be forwarded.  Changing TTL values is typically done for network
        /// probes or when multicasting.
        /// </p>
        /// <p>The argument to <code>setTTL()</code> is a number of hops between 1 and 255.  The default on most
        /// systems is 64.
        /// </p>
        /// </summary>
        public object setTTL(object ttl){return null;}
    }
}
