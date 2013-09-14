// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.menu
{
    /// <summary>
	/// <para>The real menu button class which supports a command and an icon. All
	/// other features are inherited from the <see cref="qx.ui.menu.AbstractButton"/>
	/// class.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.menu.Button", OmitOptionalParameters = true, Export = false)]
    public partial class Button : qx.ui.menu.AbstractButton
    {
		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		#endregion Properties

		#region Methods

		public Button() { throw new NotImplementedException(); }

		/// <param name="label">Initial label</param>
		/// <param name="icon">Initial icon</param>
		/// <param name="command">Initial command (shortcut)</param>
		/// <param name="menu">Initial sub menu</param>
		public Button(string label, string icon, qx.ui.core.Command command, qx.ui.menu.Menu menu) { throw new NotImplementedException(); }

		#endregion Methods
    }
}