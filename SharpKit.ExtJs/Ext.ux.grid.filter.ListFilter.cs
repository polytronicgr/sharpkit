//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.ux.grid.filter
namespace Ext.ux.grid.filter
{
    #region ListFilter
    /// <inheritdocs />
    /// <summary>
    /// <p>List filters are able to be preloaded/backed by an <see cref="Ext.data.Store">Ext.data.Store</see> to load
    /// their options the first time they are shown. ListFilter utilizes the
    /// <see cref="Ext.ux.grid.menu.ListMenu">Ext.ux.grid.menu.ListMenu</see> component.</p>
    /// <p>Although not shown here, this class accepts all configuration options
    /// for <see cref="Ext.ux.grid.menu.ListMenu">Ext.ux.grid.menu.ListMenu</see>.</p>
    /// <p><b><u>Example Usage:</u></b></p>
    /// <pre><code>var filters = <see cref="Ext.ExtContext.create">Ext.create</see>('Ext.ux.grid.GridFilters', {
    /// ...
    /// filters: [{
    /// type: 'list',
    /// dataIndex: 'size',
    /// phpMode: true,
    /// // options will be used as data to implicitly creates an ArrayStore
    /// options: ['extra small', 'small', 'medium', 'large', 'extra large']
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ListFilter : Ext.ux.grid.filter.Filter
    {
        /// <summary>
        /// data to be used to implicitly create a data store
        /// to back this list when the data source is local. If the
        /// data for the list is remote, use the store
        /// config instead.
        /// Each item within the provided array may be in one of the
        /// <p>following formats:</p>
        /// <ul>
        /// <li><b>Array</b> :
        /// <pre><code>options: [
        /// [11, 'extra small'],
        /// [18, 'small'],
        /// [22, 'medium'],
        /// [35, 'large'],
        /// [44, 'extra large']
        /// ]
        /// </code></pre>
        /// </li>
        /// <li><b>Object</b> :
        /// <pre><code>labelField: 'name', // override default of 'text'
        /// options: [
        /// {id: 11, name:'extra small'},
        /// {id: 18, name:'small'},
        /// {id: 22, name:'medium'},
        /// {id: 35, name:'large'},
        /// {id: 44, name:'extra large'}
        /// ]
        /// </code></pre>
        /// </li>
        /// <li><b>String</b> :
        /// <pre><code>options: ['extra small', 'small', 'medium', 'large', 'extra large']
        /// </code></pre>
        /// </li>
        /// </ul>
        /// </summary>
        public JsArray options;
        /// <summary>
        /// Adjust the format of this filter. Defaults to false.
        /// When GridFilters <c> = false</c> (default):
        /// <code>// phpMode == false (default):
        /// filter[0][data][type] list
        /// filter[0][data][value] value1
        /// filter[0][data][value] value2
        /// filter[0][field] prod
        /// // phpMode == true:
        /// filter[0][data][type] list
        /// filter[0][data][value] value1, value2
        /// filter[0][field] prod
        /// </code>
        /// When GridFilters <c> = true</c>:
        /// <code>// phpMode == false (default):
        /// filter : [{"type":"list","value":["small","medium"],"field":"size"}]
        /// // phpMode == true:
        /// filter : [{"type":"list","value":"small,medium","field":"size"}]
        /// </code>
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool phpMode;
        /// <summary>
        /// The Ext.data.Store this list should use as its data source
        /// when the data source is remote. If the data for the list
        /// is local, use the options config instead.
        /// </summary>
        public Ext.data.Store store;
        /// <summary>
        /// Template method that is to initialize the filter.
        /// </summary>
        /// <param name="config">
        /// </param>
        private void init(object config){}
        /// <summary>
        /// </summary>
        private void onCheckChange(){}
        public ListFilter(ListFilterConfig config){}
        public ListFilter(){}
        public ListFilter(params object[] args){}
    }
    #endregion
    #region ListFilterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ListFilterConfig : Ext.ux.grid.filter.FilterConfig
    {
        /// <summary>
        /// data to be used to implicitly create a data store
        /// to back this list when the data source is local. If the
        /// data for the list is remote, use the store
        /// config instead.
        /// Each item within the provided array may be in one of the
        /// <p>following formats:</p>
        /// <ul>
        /// <li><b>Array</b> :
        /// <pre><code>options: [
        /// [11, 'extra small'],
        /// [18, 'small'],
        /// [22, 'medium'],
        /// [35, 'large'],
        /// [44, 'extra large']
        /// ]
        /// </code></pre>
        /// </li>
        /// <li><b>Object</b> :
        /// <pre><code>labelField: 'name', // override default of 'text'
        /// options: [
        /// {id: 11, name:'extra small'},
        /// {id: 18, name:'small'},
        /// {id: 22, name:'medium'},
        /// {id: 35, name:'large'},
        /// {id: 44, name:'extra large'}
        /// ]
        /// </code></pre>
        /// </li>
        /// <li><b>String</b> :
        /// <pre><code>options: ['extra small', 'small', 'medium', 'large', 'extra large']
        /// </code></pre>
        /// </li>
        /// </ul>
        /// </summary>
        public JsArray options;
        /// <summary>
        /// Adjust the format of this filter. Defaults to false.
        /// When GridFilters <c> = false</c> (default):
        /// <code>// phpMode == false (default):
        /// filter[0][data][type] list
        /// filter[0][data][value] value1
        /// filter[0][data][value] value2
        /// filter[0][field] prod
        /// // phpMode == true:
        /// filter[0][data][type] list
        /// filter[0][data][value] value1, value2
        /// filter[0][field] prod
        /// </code>
        /// When GridFilters <c> = true</c>:
        /// <code>// phpMode == false (default):
        /// filter : [{"type":"list","value":["small","medium"],"field":"size"}]
        /// // phpMode == true:
        /// filter : [{"type":"list","value":"small,medium","field":"size"}]
        /// </code>
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool phpMode;
        /// <summary>
        /// The Ext.data.Store this list should use as its data source
        /// when the data source is remote. If the data for the list
        /// is local, use the options config instead.
        /// </summary>
        public Ext.data.Store store;
        public ListFilterConfig(params object[] args){}
    }
    #endregion
    #region ListFilterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ListFilterEvents : Ext.ux.grid.filter.FilterEvents
    {
        public ListFilterEvents(params object[] args){}
    }
    #endregion
}
#endregion
