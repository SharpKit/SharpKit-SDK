using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.crypto
{
    //TODO: compile name crypto.
    class Utils
    {
        /// <summary>
        /// Creates and returns a hmac object, a cryptographic hmac with the given algorithm and key.
        ///
        /// algorithm is dependent on the available algorithms supported by OpenSSL - see createHash above. key is the hmac key to be used.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Hmac createHmac(object algorithm, JsString key) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm and password.
        /// </summary>
        /// <param name="algorithm">algorithm is dependent on OpenSSL, examples are 'aes192', etc. On recent releases, openssl list-cipher-algorithms will display the available cipher algorithms. </param>
        /// <param name="password">password is used to derive key and IV, which must be a 'binary' encoded string or a buffer.</param>
        /// <returns></returns>
        public Cipher createCipher(JsString algorithm, JsString password) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm and password.
        /// </summary>
        /// <param name="algorithm">algorithm is dependent on OpenSSL, examples are 'aes192', etc. On recent releases, openssl list-cipher-algorithms will display the available cipher algorithms. </param>
        /// <param name="password">password is used to derive key and IV, which must be a 'binary' encoded string or a buffer.</param>
        /// <returns></returns>
        public Cipher createCipher(JsString algorithm, Buffer password) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm, key and iv.
        /// </summary>
        /// <param name="algorithm">algorithm is the same as the argument to createCipher().</param>
        /// <param name="key">key is the raw key used by the algorithm. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <param name="iv">iv is an initialization vector. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <returns></returns>
        public Cipher createCipheriv(JsString algorithm, JsString key, JsString iv) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm, key and iv.
        /// </summary>
        /// <param name="algorithm">algorithm is the same as the argument to createCipher().</param>
        /// <param name="key">key is the raw key used by the algorithm. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <param name="iv">iv is an initialization vector. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <returns></returns>
        public Cipher createCipheriv(JsString algorithm, Buffer key, Buffer iv) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm and key. This is the mirror of the createCipher() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Decipher createDecipher(JsString algorithm, JsString password) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm and key. This is the mirror of the createCipher() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Decipher createDecipher(JsString algorithm, Buffer password) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm, key and iv. This is the mirror of the createCipheriv() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public Decipher createfDecipheriv(JsString algorithm, JsString key, JsString iv) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm, key and iv. This is the mirror of the createCipheriv() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public Decipher createfDecipheriv(JsString algorithm, Buffer key, Buffer iv) { return null; }
        /// <summary>
        /// Creates and returns a signing object, with the given algorithm. On recent OpenSSL releases, openssl list-public-key-algorithms will display the available signing algorithms.
        /// Examples are 'RSA-SHA256'.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        public Signer createSign(JsString algorithm) { return null; }
        /// <summary>
        /// Class for verifying signatures.
        ///
        /// Returned by crypto.createVerify.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        public Verify createVerify(JsString algorithm) { return null; }
        /// <summary>
        /// Creates a Diffie-Hellman key exchange object and generates a prime of the given bit length. The generator used is 2.
        /// </summary>
        /// <param name="prime_length"></param>
        /// <returns></returns>
        public DiffieHellman createDiffieHallman(JsNumber prime_length) { return null; }
        /// <summary>
        /// Creates a Diffie-Hellman key exchange object using the supplied prime. The generator used is 2. 
        /// </summary>
        /// <param name="prime"></param>
        /// <param name="encoding">Encoding can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        /// <returns></returns>
        public DiffieHellman createDiffieHallman(JsNumber prime, JsString encoding) { return null; }
        /// <summary>
        /// Creates a predefined Diffie-Hellman key exchange object.   
        /// The advantage of using this routine is that the parties don't have to generate nor exchange group modulus beforehand, saving both processor and communication time.
        /// </summary>
        /// <param name="group_name">
        /// The supported groups are: 'modp1', 'modp2', 'modp5' (defined in RFC 2412) and 'modp14', 'modp15', 'modp16', 'modp17', 'modp18' (defined in RFC 3526).
        /// </param>
        /// <returns>The returned object mimics the interface of objects created by crypto.createDiffieHellman() above, 
        /// but will not allow to change the keys (with diffieHellman.setPublicKey() for example).</returns>
        /// <example>
        /// Example (obtaining a shared secret):
        /// <code>
        /// var crypto = require('crypto');
        /// var alice = crypto.getDiffieHellman('modp5');
        /// var bob = crypto.getDiffieHellman('modp5');
        ///
        /// alice.generateKeys();
        /// bob.generateKeys();
        ///
        /// var alice_secret = alice.computeSecret(bob.getPublicKey(), 'binary', 'hex');
        /// var bob_secret = bob.computeSecret(alice.getPublicKey(), 'binary', 'hex');
        ///
        /// /* alice_secret and bob_secret should be the same */
        /// console.log(alice_secret == bob_secret);
        /// </code>
        /// </example>
        public object getDiffieHallman(JsString group_name) { return null; }
        /// <summary>
        /// Asynchronous PBKDF2 applies pseudorandom function HMAC-SHA1 to derive a key of given length from the given password, salt and iterations. 
        /// The callback gets two arguments (err, derivedKey).
        /// </summary>
        /// <param name="passord"></param>
        /// <param name="salt"></param>
        /// <param name="iteration"></param>
        /// <param name="keylen"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object pdkf2(JsString passord, object salt, object iteration, JsNumber keylen, JsAction<JsError, JsString> callback) { return null; }
        /// <summary>
        /// Generates cryptographically strong pseudo-random data.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        /// <example>
        /// Usage:
        /// <code>
        /// // async
        /// crypto.randomBytes(256, function(ex, buf) {
        ///   if (ex) throw ex;
        ///   console.log('Have %d bytes of random data: %s', buf.length, buf);
        /// });
        ///
        /// //  sync
        /// try {
        ///   var buf = crypto.randomBytes(256);
        ///   console.log('Have %d bytes of random data: %s', buf.length, buf);
        /// } catch (ex) {
        ///   //  handle error
        /// }
        /// </code>
        /// </example>
        public object randomBytes(JsNumber size) { return null; }
        /// <summary>
        /// Generates cryptographically strong pseudo-random data.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Usage:
        /// <code>
        /// // async
        /// crypto.randomBytes(256, function(ex, buf) {
        ///   if (ex) throw ex;
        ///   console.log('Have %d bytes of random data: %s', buf.length, buf);
        /// });
        ///
        /// //  sync
        /// try {
        ///   var buf = crypto.randomBytes(256);
        ///   console.log('Have %d bytes of random data: %s', buf.length, buf);
        /// } catch (ex) {
        ///   //  handle error
        /// }
        /// </code>
        /// </example>
        public object randomBytes(JsNumber size, JsAction<JsError, Buffer> callback) { return null; }
    }
}
