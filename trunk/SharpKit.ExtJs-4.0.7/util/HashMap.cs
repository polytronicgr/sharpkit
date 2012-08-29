//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region HashMap
    /// <summary>
    /// Represents a collection of a set of key and value pairs. Each key in the HashMap
    /// must be unique, the same key cannot exist twice. Access to items is provided via
    /// the key only. Sample usage:
    /// var map = new Ext.util.HashMap();
    /// map.add(&#39;key1&#39;, 1);
    /// map.add(&#39;key2&#39;, 2);
    /// map.add(&#39;key3&#39;, 3);
    /// map.each(function(key, value, length){
    /// console.log(key, value, length);
    /// });
    /// The HashMap is an unordered class,
    /// there is no guarantee when iterating over the items that they will be in any particular
    /// order. If this is required, then use a Ext.util.MixedCollection.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class HashMap : Ext.Base
    {
        /// <summary>
        /// Creates new HashMap. ...
        /// </summary>
        public HashMap(object config=null){}
        /// <summary>
        /// Adds an item to the collection. ...
        /// </summary>
        public object add(JsString key, object o){return null;}
        /// <summary>
        /// Removes all items from the hash. ...
        /// </summary>
        public HashMap clear(object initial){return null;}
        /// <summary>
        /// Performs a shallow copy on this hash. ...
        /// </summary>
        public HashMap clone(){return null;}
        /// <summary>
        /// Checks whether a value exists in the hash. ...
        /// </summary>
        public bool contains(object value){return false;}
        /// <summary>
        /// Checks whether a key exists in the hash. ...
        /// </summary>
        public bool containsKey(JsString key){return false;}
        /// <summary>
        /// Executes the specified function once for each item in the hash. ...
        /// </summary>
        public HashMap each(JsAction fn, object scope){return null;}
        /// <summary>
        /// Retrieves an item with a particular key. ...
        /// </summary>
        public object get(JsString key){return null;}
        /// <summary>
        /// Gets the number of items in the hash. ...
        /// </summary>
        public JsNumber getCount(){return null;}
        /// <summary>
        /// Extracts the key from an object. ...
        /// </summary>
        public JsString getKey(object o){return null;}
        /// <summary>
        /// Return all of the keys in the hash. ...
        /// </summary>
        public JsArray getKeys(){return null;}
        /// <summary>
        /// Return all of the values in the hash. ...
        /// </summary>
        public JsArray getValues(){return null;}
        /// <summary>
        /// Remove an item from the hash. ...
        /// </summary>
        public bool remove(object o){return false;}
        /// <summary>
        /// Remove an item from the hash. ...
        /// </summary>
        public bool removeAtKey(JsString key){return false;}
        /// <summary>
        /// Replaces an item in the hash. ...
        /// </summary>
        public object replace(JsString key, object value){return null;}
        public HashMap(HashMapConfig config){}
    }
    #endregion
    #region HashMapConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HashMapConfig : Ext.BaseConfig
    {
        /// <summary>
        /// A function that is used to retrieve a default key for a passed object. ...
        /// </summary>
        public JsAction keyFn{get;set;}
    }
    #endregion
    #region HashMapEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HashMapEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when a new item is added to the hash ...
        /// </summary>
        public static JsString add="add";
        /// <summary>
        /// Fires when the hash is cleared. ...
        /// </summary>
        public static JsString clear="clear";
        /// <summary>
        /// Fires when an item is removed from the hash. ...
        /// </summary>
        public static JsString remove="remove";
        /// <summary>
        /// Fires when an item is replaced in the hash. ...
        /// </summary>
        public static JsString replace="replace";
    }
    #endregion
}
#endregion