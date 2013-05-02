// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.list.renderer
{
    /// <summary>
	/// <para>Base class for all list item renderer.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.list.renderer.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.ui.mobile.container.Composite
    {
		#region Properties

		/// <summary>
		/// <para>Whether the widget can be activated or not. When the widget is activated
		/// a css class active is automatically added to the widget, which
		/// can indicate the acitvation status.</para>
		/// </summary>
		[JsProperty(Name = "activatable", NativeField = true)]
		public bool Activatable { get; set; }

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		/// <summary>
		/// <para>Whether the row is selectable.</para>
		/// </summary>
		[JsProperty(Name = "selectable", NativeField = true)]
		public bool Selectable { get; set; }

		/// <summary>
		/// <para>Whether the row is selected.</para>
		/// </summary>
		[JsProperty(Name = "selected", NativeField = true)]
		public bool Selected { get; set; }

		/// <summary>
		/// <para>Whether to show an arrow in the row.</para>
		/// </summary>
		[JsProperty(Name = "showArrow", NativeField = true)]
		public bool ShowArrow { get; set; }

		#endregion Properties

		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		public Abstract(object layout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the row index of a certain DOM element in the list.</para>
		/// </summary>
		/// <param name="element">DOM element to retrieve the index from.</param>
		/// <returns>the index of the row.</returns>
		[JsMethod(Name = "getRowIndex")]
		public double GetRowIndex(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the row index of a certain DOM element in the list from the given event.</para>
		/// </summary>
		/// <param name="evt">The causing event.</param>
		/// <returns>the index of the row.</returns>
		[JsMethod(Name = "getRowIndexFromEvent")]
		public double GetRowIndexFromEvent(qx.eventx.type.Event evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selectable.</para>
		/// </summary>
		[JsMethod(Name = "getSelectable")]
		public bool GetSelectable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selected.</para>
		/// </summary>
		[JsMethod(Name = "getSelected")]
		public bool GetSelected() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showArrow.</para>
		/// </summary>
		[JsMethod(Name = "getShowArrow")]
		public bool GetShowArrow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selectable
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selectable.</param>
		[JsMethod(Name = "initSelectable")]
		public void InitSelectable(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selected
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selected.</param>
		[JsMethod(Name = "initSelected")]
		public void InitSelected(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showArrow
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showArrow.</param>
		[JsMethod(Name = "initShowArrow")]
		public void InitShowArrow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property selectable equals true.</para>
		/// </summary>
		[JsMethod(Name = "isSelectable")]
		public void IsSelectable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property selected equals true.</para>
		/// </summary>
		[JsMethod(Name = "isSelected")]
		public void IsSelected() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showArrow equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowArrow")]
		public void IsShowArrow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets all defined child widgets. Override this method in your custom
		/// list item renderer and reset all widgets displaying data. Needed as the
		/// renderer is used for every row and otherwise data of a different row
		/// might be displayed, when not all data displaying widgets are used for the row.
		/// Gets called automatically by the <see cref="qx.ui.mobile.list.provider.Provider"/>.</para>
		/// </summary>
		[JsMethod(Name = "reset")]
		public void Reset() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selectable.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelectable")]
		public void ResetSelectable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selected.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelected")]
		public void ResetSelected() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showArrow.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowArrow")]
		public void ResetShowArrow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selectable.</para>
		/// </summary>
		/// <param name="value">New value for property selectable.</param>
		[JsMethod(Name = "setSelectable")]
		public void SetSelectable(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selected.</para>
		/// </summary>
		/// <param name="value">New value for property selected.</param>
		[JsMethod(Name = "setSelected")]
		public void SetSelected(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showArrow.</para>
		/// </summary>
		/// <param name="value">New value for property showArrow.</param>
		[JsMethod(Name = "setShowArrow")]
		public void SetShowArrow(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property selectable.</para>
		/// </summary>
		[JsMethod(Name = "toggleSelectable")]
		public void ToggleSelectable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property selected.</para>
		/// </summary>
		[JsMethod(Name = "toggleSelected")]
		public void ToggleSelected() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showArrow.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowArrow")]
		public void ToggleShowArrow() { throw new NotImplementedException(); }

		#endregion Methods
    }
}