//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region JsonStore
    /// <inheritdocs />
    /// <summary>
    /// <p>Small helper class to make creating <see cref="Ext.data.Store">Ext.data.Store</see>s from JSON data easier.
    /// A JsonStore will be automatically configured with a <see cref="Ext.data.reader.Json">Ext.data.reader.Json</see>.</p>
    /// <p>A store configuration would be something like:</p>
    /// <pre><code>var store = new <see cref="Ext.data.JsonStore">Ext.data.JsonStore</see>({
    /// // store configs
    /// storeId: 'myStore',
    /// proxy: {
    /// type: 'ajax',
    /// url: 'get-images.php',
    /// reader: {
    /// type: 'json',
    /// root: 'images',
    /// idProperty: 'name'
    /// }
    /// },
    /// //alternatively, a <see cref="Ext.data.Model">Ext.data.Model</see> name can be given (see <see cref="Ext.data.Store">Ext.data.Store</see> for an example)
    /// fields: ['name', 'url', {name:'size', type: 'float'}, {name:'lastmod', type:'date'}]
    /// });
    /// </code></pre>
    /// <p>This store is configured to consume a returned object of the form:
    /// <pre><code>{
    /// images: [
    /// {name: 'Image one', url:'/GetImage.php?id=1', size:46.5, lastmod: new Date(2007, 10, 29)},
    /// {name: 'Image Two', url:'/GetImage.php?id=2', size:43.2, lastmod: new Date(2007, 10, 30)}
    /// ]
    /// }
    /// </code></pre>
    /// <p>An object literal of this form could also be used as the <see cref="Ext.data.JsonStoreConfig.data">data</see> config option.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class JsonStore : Ext.data.Store
    {
        public JsonStore(JsonStoreConfig config){}
        public JsonStore(){}
        public JsonStore(params object[] args){}
    }
    #endregion
    #region JsonStoreConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class JsonStoreConfig : Ext.data.StoreConfig
    {
        public JsonStoreConfig(params object[] args){}
    }
    #endregion
    #region JsonStoreEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class JsonStoreEvents : Ext.data.StoreEvents
    {
        public JsonStoreEvents(params object[] args){}
    }
    #endregion
}