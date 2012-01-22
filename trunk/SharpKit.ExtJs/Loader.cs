//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Loader
    /// <summary>
    /// Ext.Loader is the heart of the new dynamic dependency loading capability in Ext JS 4+. It is most commonly used
    /// via the Ext.require shorthand. Ext.Loader supports both asynchronous and synchronous loading
    /// approaches, and leverage their advantages for the best development flow. We&#39;ll discuss about the pros and cons
    /// of each approach: Asynchronous Loading  Advantages:   Cross-domain  No web server needed: you can run the application via the file system protocol
    /// (i.e: file://path/to/your/index.html)  Best possible debugging experience: error messages come with the exact file name and line number   Disadvantages:   Dependencies need to be specified before-hand    Method 1: Explicitly include what you need: // Syntax
    /// Ext.require({String/Array} expressions);
    /// // Example: Single alias
    /// Ext.require(&#39;widget.window&#39;);
    /// // Example: Single class name
    /// Ext.require(&#39;Ext.window.Window&#39;);
    /// // Example: Multiple aliases / class names mix
    /// Ext.require([&#39;widget.window&#39;, &#39;layout.border&#39;, &#39;Ext.data.Connection&#39;]);
    /// // Wildcards
    /// Ext.require([&#39;widget.*&#39;, &#39;layout.*&#39;, &#39;Ext.data.*&#39;]);
    /// Method 2: Explicitly exclude what you don&#39;t need: // Syntax: Note that it must be in this chaining format.
    /// Ext.exclude({String/Array} expressions)
    /// .require({String/Array} expressions);
    /// // Include everything except Ext.data.*
    /// Ext.exclude(&#39;Ext.data.*&#39;).require(&#39;*&#39;);&#160;
    /// // Include all widgets except widget.checkbox*,
    /// // which will match widget.checkbox, widget.checkboxfield, widget.checkboxgroup, etc.
    /// Ext.exclude(&#39;widget.checkbox*&#39;).require(&#39;widget.*&#39;);
    /// Synchronous Loading on Demand  Advantages:   There&#39;s no need to specify dependencies before-hand, which is always the convenience of including
    /// ext-all.js before   Disadvantages:   Not as good debugging experience since file name won&#39;t be shown (except in Firebug at the moment)  Must be from the same domain due to XHR restriction  Need a web server, same reason as above    There&#39;s one simple rule to follow: Instantiate everything with Ext.create instead of the new keyword Ext.create(&#39;widget.window&#39;, { ... }); // Instead of new Ext.window.Window({...});
    /// Ext.create(&#39;Ext.window.Window&#39;, {}); // Same as above, using full class name instead of alias
    /// Ext.widget(&#39;window&#39;, {}); // Same as above, all you need is the traditional `xtype`
    /// Behind the scene, Ext.ClassManager will automatically check whether the given class name / alias has already
    /// existed on the page. If it&#39;s not, Ext.Loader will immediately switch itself to synchronous mode and automatic load
    /// the given class and all its dependencies. Hybrid Loading - The Best of Both Worlds It has all the advantages combined from asynchronous and synchronous loading. The development flow is simple: Step 1: Start writing your application using synchronous approach. Ext.Loader will automatically fetch all dependencies on demand as they&#39;re needed during run-time. For example: Ext.onReady(function(){
    /// var window = Ext.createWidget(&#39;window&#39;, {
    /// width: 500,
    /// height: 300,
    /// layout: {
    /// type: &#39;border&#39;,
    /// padding: 5
    /// },
    /// title: &#39;Hello Dialog&#39;,
    /// items: [{
    /// title: &#39;Navigation&#39;,
    /// collapsible: true,
    /// region: &#39;west&#39;,
    /// width: 200,
    /// html: &#39;Hello&#39;,
    /// split: true
    /// }, {
    /// title: &#39;TabPanel&#39;,
    /// region: &#39;center&#39;
    /// }]
    /// });
    /// window.show();
    /// })
    /// Step 2: Along the way, when you need better debugging ability, watch the console for warnings like these: [Ext.Loader] Synchronously loading &#39;Ext.window.Window&#39;; consider adding Ext.require(&#39;Ext.window.Window&#39;) before your application&#39;s code ClassManager.js:432
    /// [Ext.Loader] Synchronously loading &#39;Ext.layout.container.Border&#39;; consider adding Ext.require(&#39;Ext.layout.container.Border&#39;) before your application&#39;s code
    /// Simply copy and paste the suggested code above Ext.onReady, e.g.: Ext.require(&#39;Ext.window.Window&#39;);
    /// Ext.require(&#39;Ext.layout.container.Border&#39;);
    /// Ext.onReady(...);
    /// Everything should now load via asynchronous mode. Deployment It&#39;s important to note that dynamic loading should only be used during development on your local machines.
    /// During production, all dependencies should be combined into one single JavaScript file. Ext.Loader makes
    /// the whole process of transitioning from / to between development / maintenance and production as easy as
    /// possible. Internally Ext.Loader.history maintains the list of all dependencies
    /// your application needs in the exact loading sequence. It&#39;s as simple as concatenating all files in this
    /// array into one, then include it on top of your application. This process will be automated with Sencha Command, to be released and documented towards Ext JS 4 Final.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Loader
    {
        /// <summary>
        /// Explicitly exclude files from being loaded. ...
        /// </summary>
        public static object exclude(object excludes){return null;}
        /// <summary>
        /// Get the config value corresponding to the specified name. ...
        /// </summary>
        public static object getConfig(JsString name){return null;}
        /// <summary>
        /// Translates a className to a file path by adding the the proper prefix and converting the .'s to /'s. ...
        /// </summary>
        public static JsString getPath(JsString className){return null;}
        /// <summary>
        /// Adds new listener to be executed when all required scripts are fully loaded. ...
        /// </summary>
        public static object onReady(JsAction fn, object scope, bool withDomReady, object options){return null;}
        /// <summary>
        /// Loads all classes by the given names and all their direct dependencies;
        /// optionally executes the given callback functi...
        /// </summary>
        public static object require(object expressions, JsAction fn, object scope, object excludes){return null;}
        /// <summary>
        /// Set the configuration for the loader. ...
        /// </summary>
        public static Loader setConfig(object name, object value=null){return null;}
        /// <summary>
        /// Sets the path of a namespace. ...
        /// </summary>
        public static Loader setPath(object name, JsString path){return null;}
        /// <summary>
        /// Synchronously loads all classes by the given names and all their direct dependencies;
        /// optionally executes the given c...
        /// </summary>
        public static object syncRequire(object expressions, JsAction fn, object scope, object excludes){return null;}
        /// <summary>
        /// An array of class names to keep track of the dependency loading order. ...
        /// </summary>
        public static JsString history{get;set;}
        public Loader(LoaderConfig config){}
        public Loader(){}
    }
    #endregion
    #region LoaderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LoaderConfig
    {
        public bool disableCaching{get;set;}
        /// <summary>
        /// The get parameter name for the cache buster's timestamp. ...
        /// </summary>
        public JsString disableCachingParam{get;set;}
        public bool enabled{get;set;}
        /// <summary>
        /// The mapping from namespaces to file paths
        /// {
        /// 'Ext': '.', // This is set by default, Ext.layout.container.Containe...
        /// </summary>
        public object paths{get;set;}
    }
    #endregion
    #region LoaderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LoaderEvents
    {
    }
    #endregion
}
#endregion
