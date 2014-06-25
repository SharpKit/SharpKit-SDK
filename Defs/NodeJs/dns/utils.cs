using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.dns
{
    [JsType(JsMode.Prototype, Export = false, Name = "dns")]
    public partial class utils
    {
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into the first found A (IPv4) or AAAA (IPv6) record. 
        /// On error, err is an Error object, where err.code is the error code. 
        /// Keep in mind that err.code will be set to 'ENOENT' not only when the domain does not exist but also when the lookup fails in other ways such as no available file descriptors.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">The callback has arguments (err, address, family). 
        /// The address argument is a string representation of a IP v4 or v6 address. T
        /// he family argument is either the integer 4 or 6 and denotes the family of address (not necessarily the value initially passed to lookup).</param>
        /// <returns></returns>
        public object lookup(JsString domain, JsAction<JsNumber, JsString, JsNumber> callback) { return null; }
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into the first found A (IPv4) or AAAA (IPv6) record. 
        /// On error, err is an Error object, where err.code is the error code. 
        /// Keep in mind that err.code will be set to 'ENOENT' not only when the domain does not exist but also when the lookup fails in other ways such as no available file descriptors.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="family">The family can be the integer 4 or 6. Defaults to null that indicates both Ip v4 and v6 address family.</param>
        /// <param name="callback">The callback has arguments (err, address, family). 
        /// The address argument is a string representation of a IP v4 or v6 address. T
        /// he family argument is either the integer 4 or 6 and denotes the family of address (not necessarily the value initially passed to lookup).</param>
        /// <returns></returns>
        public object lookup(JsString domain, object family, JsAction<JsNumber, JsString, JsNumber> callback) { return null; }
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into an array of the record types specified by rrtype.
        /// On error, err is an Error object, where err.code is one of the error codes listed below.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">
        /// The callback has arguments (err, addresses). The type of each item in addresses is determined by the record type, 
        /// and described in the documentation for the corresponding lookup methods below.
        /// </param>
        /// <returns></returns>
        public object resolve(JsString domain, JsAction<JsNumber, JsString> callback) { return null; }
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into an array of the record types specified by rrtype.
        /// On error, err is an Error object, where err.code is one of the error codes listed below.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="rrtype">
        ///  Valid rrtypes are 'A' (IPV4 addresses, default), 'AAAA' (IPV6 addresses), 'MX' (mail exchange records), 
        ///  'TXT' (text records), 'SRV' (SRV records), 'PTR' (used for reverse IP lookups), 'NS' (name server records) and 'CNAME' (canonical name records).
        /// </param>
        /// <param name="callback">
        /// The callback has arguments (err, addresses). The type of each item in addresses is determined by the record type, 
        /// and described in the documentation for the corresponding lookup methods below.
        /// </param>
        /// <returns></returns>
        public object resolve(JsString domain, JsString rrtype, JsAction<JsNumber, object> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for IPv4 queries (A records). 
        /// addresses is an array of IPv4 addresses (e.g. ['74.125.79.104', '74.125.79.105', '74.125.79.106']).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object resolve4(JsString domain, JsAction<JsNumber, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve4() except for IPv6 queries (an AAAA query).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object resolve6(JsString domain, JsAction<JsNumber, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for mail exchange queries (MX records).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of MX records, each with a priority and an exchange attribute (e.g. [{'priority': 10, 'exchange': 'mx.example.com'},...]).
        /// </param>
        /// <returns></returns>
        public object resolveMx(JsString domain, JsAction<JsNumber, JsArray<MxRecordsOptions>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for text queries (TXT records). addresses is an array of the text records available for domain (e.g., ['v=spf1 ip4:0.0.0.0 ~all']).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object resolveTxt(JsString domain, JsAction<JsNumber, JsString> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for service records (SRV records).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of the SRV records available for domain. 
        /// Properties of SRV records are priority, weight, port, and name (e.g., [{'priority': 10, {'weight': 5, 'port': 21223, 'name': 'service.example.com'}, ...]).
        /// </param>
        /// <returns></returns>
        public object resolveSrv(JsString domain, JsAction<JsNumber, SrvRecordsOptions> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for name server records (NS records). 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of the name server records available for domain 
        /// (e.g., ['ns1.example.com', 'ns2.example.com']).
        /// </param>
        /// <returns></returns>
        public object resolveNs(JsString domain, JsAction<JsNumber, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for canonical name records (CNAME records). 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of the canonical name records available for domain (e.g., ['bar.example.com']).
        /// </param>
        /// <returns></returns>
        public object resolveCname(JsString domain, JsAction<JsNumber, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// Reverse resolves an ip address to an array of domain names.
        /// On error, err is an Error object, where err.code is one of the error codes listed below.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="callback">The callback has arguments (err, domains).</param>
        /// <returns></returns>
        public object reverse(JsString ip, JsAction<JsNumber, JsArray<JsString>> callback) { return null; }
    }
    [JsType(JsMode.Json)]
    public partial class SrvRecordsOptions
    {
        public JsNumber priority { get; set; }
        public JsNumber weight { get; set; }
        public JsNumber port { get; set; }
        public JsString name { get; set; }
    }

    [JsType(JsMode.Json)]
    public partial class MxRecordsOptions
    {
        public JsNumber priority { get; set; }
        public JsString exchange { get; set; }
    }
    /// <summary>
    ///     Each DNS query can return one of the following error codes:
    /// </summary>
    //TODO: json mode?
    public partial class dns
    {
        /// <summary>
        /// DNS server returned answer with no data.
        /// </summary>
        public static int NODATA { get; set; }
        /// <summary>
        /// DNS server claims query was misformatted.
        /// </summary>
        public static int FORMERR { get; set; }
        /// <summary>
        ///  DNS server returned general failure.
        /// </summary>
        public static int SERVFAIL { get; set; }
        /// <summary>
        /// Domain name not found.
        /// </summary>
        public static int NOTFOUND { get; set; }
        /// <summary>
        /// DNS server does not implement requested operation.
        /// </summary>
        public static int NOTIMP { get; set; }
        /// <summary>
        /// DNS server refused query.
        /// </summary>
        public static int REFUSED { get; set; }
        /// <summary>
        /// Misformatted DNS query.
        /// </summary>
        public static int BADQUERY { get; set; }
        /// <summary>
        /// Misformatted domain name.
        /// </summary>
        public static int BADNAME { get; set; }
        /// <summary>
        /// Unsupported address family.
        /// </summary>
        public static int BADFAMILY { get; set; }
        /// <summary>
        /// Misformatted DNS reply.
        /// </summary>
        public static int BADRESP { get; set; }
        /// <summary>
        /// Could not contact DNS servers.
        /// </summary>
        public static int CONNREFUSED { get; set; }
        /// <summary>
        /// Timeout while contacting DNS servers.
        /// </summary>
        public static int TIMEOUT { get; set; }
        /// <summary>
        /// End of file.
        /// </summary>
        public static int EOF { get; set; }
        /// <summary>
        /// Error reading file.
        /// </summary>
        public static int FILE { get; set; }
        /// <summary>
        /// Out of memory.
        /// </summary>
        public static int NOMEM { get; set; }
        /// <summary>
        /// Channel is being destroyed.
        /// </summary>
        public static int DESTRUCTION { get; set; }
        /// <summary>
        /// Misformatted string.
        /// </summary>
        public static int BADSTR { get; set; }
        /// <summary>
        /// Illegal flags specified.
        /// </summary>
        public static int BADFLAGS { get; set; }
        /// <summary>
        /// Given hostname is not numeric.
        /// </summary>
        public static int NONAME { get; set; }
        /// <summary>
        /// Illegal hints flags specified.
        /// </summary>
        public static int BADHINTS { get; set; }
        /// <summary>
        /// c-ares library initialization not yet performed.
        /// </summary>
        public static int NOTINITIALIZED { get; set; }
        /// <summary>
        /// Error loading iphlpapi.dll.
        /// </summary>
        public static int LOADIPHLPAPI { get; set; }
        /// <summary>
        /// Could not find GetNetworkParams function.
        /// </summary>
        public static int ADDRGETNETWORKPARAMS { get; set; }
        /// <summary>
        /// DNS query cancelled.
        /// </summary>
        public static int CANCELLED { get; set; }
    }
}
