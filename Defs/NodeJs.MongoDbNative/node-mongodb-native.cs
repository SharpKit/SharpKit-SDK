using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.MongoDbNative
{
    [JsType(JsMode.Json, Name = "mongodb")]
    public class MongoDbPlugin : IRequirable
    {
        public MongoClient MongoClient { get; set; }
    }
    [JsType(JsMode.Prototype)]
    public class MongoClient
    {
        public void connect(JsString url, JsAction<Error, Db> callback)
        {
        }
    }

    [JsType(JsMode.Prototype)]
    public class Error : JsError
    {
    }
    [JsType(JsMode.Prototype)]
    public class Db
    {
        public void collection<T>(JsString name, object options, JsAction<Error, Collection<T>> cb) {}
        public void collection(JsString name, object options, JsAction<Error, Collection<dynamic>> cb) {}
        public void collection<T>(JsString name, JsAction<Error, Collection<T>> cb) {}
        public void collection(JsString name, JsAction<Error, Collection<dynamic>> cb) {}
        public void close() { }
    }
    [JsType(JsMode.Prototype)]
    public class Collection<T>
    {
        public void save(T value, JsAction<Error, object> callback) { }
        public void save(T value, object options, JsAction<Error, object> callback) { }
        public void insert(T value, JsAction<Error, JsArray<T>> callback) { }
        public Cursor<T> find(object query) { return null; }

        //public void findOne(object query, object options, JsAction<Error, T> callback) { }
        public void findOne(object query, JsAction<Error, T> callback) { }
    }
    [JsType(JsMode.Prototype)]
    public class Cursor<T>
    {
        public void toArray(JsAction<Error, JsArray<T>> callback) { }
    }
}
