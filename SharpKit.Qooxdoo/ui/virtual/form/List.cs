// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.form
{
    /// <summary>
	/// <para>Experimental virtual list widget.</para>
	/// <para>This widget can either use HTML or widget cell renderer.</para>
	/// <para>EXPERIMENTAL!</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.form.List", OmitOptionalParameters = true, Export = false)]
    public partial class List : qx.ui.virtualx.core.Scroller
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="CellRenderer"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeCellRenderer;

		/// <summary>
		/// Fired on change of the property <see cref="Delegate"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeDelegate;

		/// <summary>
		/// Fired on change of the property <see cref="RowCount"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeRowCount;

		/// <summary>
		/// Fired on change of the property <see cref="RowHeight"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeRowHeight;

		/// <summary>
		/// Fired on change of the property <see cref="ShowGridLines"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeShowGridLines;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>The cell renderer to use</para>
		/// </summary>
		[JsProperty(Name = "cellRenderer", NativeField = true)]
		public object CellRenderer { get; set; }

		/// <summary>
		/// <para>List delegate to customize the widget. The delegate can implement any
		/// subset of the methods defined in the <see cref="qx.ui.virtual.form.IListDelegate"/>
		/// interface.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "delegate", NativeField = true)]
		public object Delegate { get; set; }

		/// <summary>
		/// <para>The number of rows in the list</para>
		/// </summary>
		[JsProperty(Name = "rowCount", NativeField = true)]
		public double RowCount { get; set; }

		/// <summary>
		/// <para>The row height</para>
		/// </summary>
		[JsProperty(Name = "rowHeight", NativeField = true)]
		public double RowHeight { get; set; }

		/// <summary>
		/// <para>Whether to display grid lines</para>
		/// </summary>
		[JsProperty(Name = "showGridLines", NativeField = true)]
		public bool ShowGridLines { get; set; }

		/// <summary>
		/// <para>Whether to use widgets to render the cells.</para>
		/// </summary>
		[JsProperty(Name = "useWidgetCells", NativeField = true)]
		public bool UseWidgetCells { get; set; }

		#endregion Properties

		#region Methods

		public List() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property cellRenderer.</para>
		/// </summary>
		[JsMethod(Name = "getCellRenderer")]
		public object GetCellRenderer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delegate.</para>
		/// </summary>
		[JsMethod(Name = "getDelegate")]
		public object GetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property rowCount.</para>
		/// </summary>
		[JsMethod(Name = "getRowCount")]
		public double GetRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property rowHeight.</para>
		/// </summary>
		[JsMethod(Name = "getRowHeight")]
		public double GetRowHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the selection manager</para>
		/// </summary>
		/// <returns>The selection manager</returns>
		[JsMethod(Name = "getSelectionManager")]
		public qx.ui.virtualx.selection.Row GetSelectionManager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showGridLines.</para>
		/// </summary>
		[JsMethod(Name = "getShowGridLines")]
		public bool GetShowGridLines() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property useWidgetCells.</para>
		/// </summary>
		[JsMethod(Name = "getUseWidgetCells")]
		public bool GetUseWidgetCells() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property cellRenderer
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property cellRenderer.</param>
		[JsMethod(Name = "initCellRenderer")]
		public void InitCellRenderer(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delegate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delegate.</param>
		[JsMethod(Name = "initDelegate")]
		public void InitDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property rowCount
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property rowCount.</param>
		[JsMethod(Name = "initRowCount")]
		public void InitRowCount(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property rowHeight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property rowHeight.</param>
		[JsMethod(Name = "initRowHeight")]
		public void InitRowHeight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showGridLines
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showGridLines.</param>
		[JsMethod(Name = "initShowGridLines")]
		public void InitShowGridLines(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property useWidgetCells
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property useWidgetCells.</param>
		[JsMethod(Name = "initUseWidgetCells")]
		public void InitUseWidgetCells(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showGridLines equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowGridLines")]
		public void IsShowGridLines() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property useWidgetCells equals true.</para>
		/// </summary>
		[JsMethod(Name = "isUseWidgetCells")]
		public void IsUseWidgetCells() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property cellRenderer.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCellRenderer")]
		public void ResetCellRenderer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delegate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelegate")]
		public void ResetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property rowCount.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRowCount")]
		public void ResetRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property rowHeight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRowHeight")]
		public void ResetRowHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showGridLines.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowGridLines")]
		public void ResetShowGridLines() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property useWidgetCells.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUseWidgetCells")]
		public void ResetUseWidgetCells() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property cellRenderer.</para>
		/// </summary>
		/// <param name="value">New value for property cellRenderer.</param>
		[JsMethod(Name = "setCellRenderer")]
		public void SetCellRenderer(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delegate.</para>
		/// </summary>
		/// <param name="value">New value for property delegate.</param>
		[JsMethod(Name = "setDelegate")]
		public void SetDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property rowCount.</para>
		/// </summary>
		/// <param name="value">New value for property rowCount.</param>
		[JsMethod(Name = "setRowCount")]
		public void SetRowCount(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property rowHeight.</para>
		/// </summary>
		/// <param name="value">New value for property rowHeight.</param>
		[JsMethod(Name = "setRowHeight")]
		public void SetRowHeight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showGridLines.</para>
		/// </summary>
		/// <param name="value">New value for property showGridLines.</param>
		[JsMethod(Name = "setShowGridLines")]
		public void SetShowGridLines(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property useWidgetCells.</para>
		/// </summary>
		/// <param name="value">New value for property useWidgetCells.</param>
		[JsMethod(Name = "setUseWidgetCells")]
		public void SetUseWidgetCells(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called during the flush of the
		/// <see cref="qx.ui.core.queue.Widget widget queue"/>.</para>
		/// </summary>
		/// <param name="jobs">A map of jobs.</param>
		[JsMethod(Name = "syncWidget")]
		public void SyncWidget(object jobs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showGridLines.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowGridLines")]
		public void ToggleShowGridLines() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property useWidgetCells.</para>
		/// </summary>
		[JsMethod(Name = "toggleUseWidgetCells")]
		public void ToggleUseWidgetCells() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the displayed list data</para>
		/// </summary>
		[JsMethod(Name = "update")]
		public void Update() { throw new NotImplementedException(); }

		#endregion Methods
    }
}