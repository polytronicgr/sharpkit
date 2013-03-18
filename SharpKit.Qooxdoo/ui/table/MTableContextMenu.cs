// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table
{
    /// <summary>
	/// <para>This mixin allows easily adding handlers for context menus on table columns.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.MTableContextMenu", OmitOptionalParameters = true, Export = false)]
    public partial class MTableContextMenu 
    {
		#region Methods

		public MTableContextMenu() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the registered context menu handler for a column.</para>
		/// </summary>
		/// <param name="col">The column number for which the context menu handler is requested</param>
		/// <returns>The handler function which has been registered for the specified column. The arguments of the handler is documented in #setContextMenuHandler.</returns>
		[JsMethod(Name = "getContextMenuHandler")]
		public Action<object> GetContextMenuHandler(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a handler for a context menu which is initiated in a specific
		/// column.</para>
		/// </summary>
		/// <param name="col">The column number in which the context menu request originated</param>
		/// <param name="handler">The function to call when a context menu request originates in the specified column. The handler is called with the following arguments:   column: (Integer) The number of the column in which the right click was issued   row: (Integer) The number of the row in which the right click was issued   table: qx.ui.table.Table The table in which the right click was issued   dataModel: qx.ui.table.model.Abstract Complete data model of the table   contextMenu: qx.ui.menu.Menu Menu in which buttons can be added to implement this context menu   The function must return a (Boolean), indicating whether the context menu should be shown or not. The context menu will be shown when the handler function returns true. When the handler function returns false the context menu will not be shown.</param>
		/// <param name="context">Optional execution context for the callback (i.e. &#8220;this&#8221;). If not provided, the qx.ui.table.Table object this mixin is applied to is used.</param>
		[JsMethod(Name = "setContextMenuHandler")]
		public void SetContextMenuHandler(double col, Action<object> handler, object context = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}