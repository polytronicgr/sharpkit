//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region StoreManager
    /// <summary>
    /// Contains a collection of all stores that are created that have an identifier.
    /// An identifier can be assigned by setting the storeId
    /// property. When a store is in the StoreManager, it can be referred to via it&#39;s identifier:
    /// Ext.create(&#39;Ext.data.Store&#39;, {
    /// model: &#39;SomeModel&#39;,
    /// storeId: &#39;myStore&#39;
    /// });
    /// var store = Ext.data.StoreManager.lookup(&#39;myStore&#39;);
    /// Also note that the lookup method is aliased to Ext.getStore for convenience.
    /// If a store is registered with the StoreManager, you can also refer to the store by it&#39;s identifier when
    /// registering it with any Component that consumes data from a store:
    /// Ext.create(&#39;Ext.data.Store&#39;, {
    /// model: &#39;SomeModel&#39;,
    /// storeId: &#39;myStore&#39;
    /// });
    /// Ext.create(&#39;Ext.view.View&#39;, {
    /// store: &#39;myStore&#39;,
    /// // other configuration here
    /// });
    /// TODO: Make this an AbstractMgr
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class StoreManager : Ext.util.MixedCollection, Ext.util.Sortable, Ext.util.Observable
    {
        /// <summary>
        /// Gets a registered Store by id ...
        /// </summary>
        public static Ext.data.Store lookup(object id){return null;}
        /// <summary>
        /// Registers one or more Stores with the StoreManager. ...
        /// </summary>
        public static object register(Ext.data.Store store1, Ext.data.Store store2=null, Ext.data.Store etc=null){return null;}
        /// <summary>
        /// Unregisters one or more Stores with the StoreManager ...
        /// </summary>
        public static object unregister(object id1, object id2=null, object etc=null){return null;}
        public StoreManager(StoreManagerConfig config){}
        public StoreManager(){}
    }
    #endregion
    #region StoreManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class StoreManagerConfig : Ext.util.MixedCollectionConfig
    {
    }
    #endregion
    #region StoreManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class StoreManagerEvents : Ext.util.MixedCollectionEvents
    {
    }
    #endregion
}
#endregion
