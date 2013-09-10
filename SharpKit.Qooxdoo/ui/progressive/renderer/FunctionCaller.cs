// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive.renderer
{
    /// <summary>
	/// <para>Function &#8220;renderer&#8221; for Progressive.
	/// This is a renderer that simply calls the function provided by the data
	/// element.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.renderer.FunctionCaller", OmitOptionalParameters = true, Export = false)]
    public partial class FunctionCaller : qx.ui.progressive.renderer.Abstract
    {
		#region Methods

		public FunctionCaller() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Render the provided element in the renderer&#8217;s unique way.</para>
		/// </summary>
		/// <param name="state">Data relevant to the current rendering session.</param>
		/// <param name="element">An object containing at least the following members:   renderer  The name of a renderer.  That name is used by qx.ui.progressive.Progressive to select the renderer to be used to render this element.  The name should match one provided to qx.ui.progressive.Progressive#addRenderer.    data   The data to be passed to the renderer.  The data may be of any type that the renderer knows how to render.  </param>
		[JsMethod(Name = "render")]
		public void Render(qx.ui.progressive.State state, object element) { throw new NotImplementedException(); }

		#endregion Methods
    }
}