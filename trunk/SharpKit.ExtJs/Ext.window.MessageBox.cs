//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.window
{
    #region MessageBox
    /// <inheritdocs />
    /// <summary>
    /// <p>Utility class for generating different styles of message boxes.  The singleton instance, <see cref="Ext.MessageBox">Ext.MessageBox</see>
    /// alias <c><see cref="Ext.MessageBox">Ext.Msg</see></c> can also be used.</p>
    /// <p>Note that a MessageBox is asynchronous.  Unlike a regular JavaScript <c>alert</c> (which will halt
    /// browser execution), showing a MessageBox will not cause the code to stop.  For this reason, if you have code
    /// that should only run <em>after</em> some user feedback from the MessageBox, you must use a callback function
    /// (see the <c>function</c> parameter for <see cref="Ext.window.MessageBox.show">show</see> for more details).</p>
    /// <p>Basic alert</p>
    /// <pre><code><see cref="Ext.MessageBox.alert">Ext.Msg.alert</see>('Status', 'Changes saved successfully.');
    /// </code></pre>
    /// <p>Prompt for user data and process the result using a callback</p>
    /// <pre><code><see cref="Ext.MessageBox.prompt">Ext.Msg.prompt</see>('Name', 'Please enter your name:', function(btn, text){
    /// if (btn == 'ok'){
    /// // process text value and close...
    /// }
    /// });
    /// </code></pre>
    /// <p>Show a dialog using config options</p>
    /// <pre><code><see cref="Ext.MessageBoxEvents.show">Ext.Msg.show</see>({
    /// title:'Save Changes?',
    /// msg: 'You are closing a tab that has unsaved changes. Would you like to save your changes?',
    /// buttons: <see cref="Ext.MessageBox.YESNOCANCEL">Ext.Msg.YESNOCANCEL</see>,
    /// icon: <see cref="Ext.MessageBox.QUESTION">Ext.Msg.QUESTION</see>
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class MessageBox : Window
    {
        /// <summary>
        /// Button config that displays a single Cancel button
        /// Defaults to: <c>8</c>
        /// </summary>
        public JsNumber CANCEL{get;set;}
        /// <summary>
        /// The CSS class that provides the ERROR icon image
        /// Defaults to: <c>&quot;x-message-box-error&quot;</c>
        /// </summary>
        public JsString ERROR{get;set;}
        /// <summary>
        /// The CSS class that provides the INFO icon image
        /// Defaults to: <c>&quot;x-message-box-info&quot;</c>
        /// </summary>
        public JsString INFO{get;set;}
        /// <summary>
        /// Button config that displays a single No button
        /// Defaults to: <c>4</c>
        /// </summary>
        public JsNumber NO{get;set;}
        /// <summary>
        /// Button config that displays a single OK button
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber OK{get;set;}
        /// <summary>
        /// Button config that displays OK and Cancel buttons
        /// Defaults to: <c>9</c>
        /// </summary>
        public JsNumber OKCANCEL{get;set;}
        /// <summary>
        /// The CSS class that provides the QUESTION icon image
        /// Defaults to: <c>&quot;x-message-box-question&quot;</c>
        /// </summary>
        public JsString QUESTION{get;set;}
        /// <summary>
        /// The CSS class that provides the WARNING icon image
        /// Defaults to: <c>&quot;x-message-box-warning&quot;</c>
        /// </summary>
        public JsString WARNING{get;set;}
        /// <summary>
        /// Button config that displays a single Yes button
        /// Defaults to: <c>2</c>
        /// </summary>
        public JsNumber YES{get;set;}
        /// <summary>
        /// Button config that displays Yes and No buttons
        /// Defaults to: <c>6</c>
        /// </summary>
        public JsNumber YESNO{get;set;}
        /// <summary>
        /// Button config that displays Yes, No and Cancel buttons
        /// Defaults to: <c>14</c>
        /// </summary>
        public JsNumber YESNOCANCEL{get;set;}
        /// <summary>
        /// An object containing the default button text strings that can be overriden for localized language support.
        /// Supported properties are: ok, cancel, yes and no.  Generally you should include a locale-specific
        /// resource file for handling language support across the framework.
        /// Customize the default text like so:
        /// <code>Ext.window.MessageBox.buttonText.yes = "oui"; //french
        /// </code>
        /// Defaults to: <c>{ok: &quot;OK&quot;, yes: &quot;Yes&quot;, no: &quot;No&quot;, cancel: &quot;Cancel&quot;}</c>
        /// </summary>
        public JsObject buttonText{get;set;}
        /// <summary>
        /// The default height in pixels of the message box's multiline textarea if displayed.
        /// Defaults to: <c>75</c>
        /// </summary>
        public JsNumber defaultTextHeight{get;set;}
        /// <summary>
        /// The minimum width in pixels of the message box if it is a progress-style dialog.  This is useful
        /// for setting a different minimum width than text-only dialogs may need.
        /// Defaults to: <c>250</c>
        /// </summary>
        public JsNumber minProgressWidth{get;set;}
        /// <summary>
        /// The minimum width in pixels of the message box if it is a prompt dialog.  This is useful
        /// for setting a different minimum width than text-only dialogs may need.
        /// Defaults to: <c>250</c>
        /// </summary>
        public JsNumber minPromptWidth{get;set;}
        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt).
        /// If a callback function is passed it will be called after the user clicks the button, and the
        /// id of the button that was clicked will be passed as the only parameter to the callback
        /// (could also be the top-right close button, which will always report as "cancel").
        /// </summary>
        /// <param name="title"><p>The title bar text</p>
        /// </param>
        /// <param name="msg"><p>The message box body text</p>
        /// </param>
        /// <param name="fn"><p>The callback function invoked after the message box is closed.
        /// See <see cref="Ext.window.MessageBox.show">show</see> method for details.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the callback is executed.</p>
        /// <p>Defaults to: <c>window</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox alert(JsString title, JsString msg, System.Delegate fn=null, object scope=null){return null;}
        /// <summary>
        /// Displays a confirmation message box with Yes and No buttons (comparable to JavaScript's confirm).
        /// If a callback function is passed it will be called after the user clicks either button,
        /// and the id of the button that was clicked will be passed as the only parameter to the callback
        /// (could also be the top-right close button, which will always report as "cancel").
        /// </summary>
        /// <param name="title"><p>The title bar text</p>
        /// </param>
        /// <param name="msg"><p>The message box body text</p>
        /// </param>
        /// <param name="fn"><p>The callback function invoked after the message box is closed.
        /// See <see cref="Ext.window.MessageBox.show">show</see> method for details.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the callback is executed.</p>
        /// <p>Defaults to: <c>window</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox confirm(JsString title, JsString msg, System.Delegate fn=null, object scope=null){return null;}
        /// <summary>
        /// Displays a message box with a progress bar.
        /// You are responsible for updating the progress bar as needed via <see cref="Ext.window.MessageBox.updateProgress">updateProgress</see>
        /// and closing the message box when the process is complete.
        /// </summary>
        /// <param name="title"><p>The title bar text</p>
        /// </param>
        /// <param name="msg"><p>The message box body text</p>
        /// </param>
        /// <param name="progressText"><p>The text to display inside the progress bar</p>
        /// <p>Defaults to: <c>&quot;&quot;</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox progress(JsString title, JsString msg, object progressText=null){return null;}
        /// <summary>
        /// Displays a message box with OK and Cancel buttons prompting the user to enter some text (comparable to JavaScript's prompt).
        /// The prompt can be a single-line or multi-line textbox.  If a callback function is passed it will be called after the user
        /// clicks either button, and the id of the button that was clicked (could also be the top-right
        /// close button, which will always report as "cancel") and the text that was entered will be passed as the two parameters to the callback.
        /// </summary>
        /// <param name="title"><p>The title bar text</p>
        /// </param>
        /// <param name="msg"><p>The message box body text</p>
        /// </param>
        /// <param name="fn"><p>The callback function invoked after the message box is closed.
        /// See <see cref="Ext.window.MessageBox.show">show</see> method for details.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the callback is executed.</p>
        /// <p>Defaults to: <c>window</c></p></param>
        /// <param name="multiline"><p>True to create a multiline textbox using the defaultTextHeight
        /// property, or the height in pixels to create the textbox/</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="value"><p>Default value of the text input element</p>
        /// <p>Defaults to: <c>&quot;&quot;</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox prompt(JsString title, JsString msg, System.Delegate fn=null, object scope=null, object multiline=null, object value=null){return null;}
        /// <summary>
        /// Displays a new message box, or reinitializes an existing message box, based on the config options passed in. All
        /// display functions (e.g. prompt, alert, etc.) on MessageBox call this function internally, although those calls
        /// are basic shortcuts and do not support all of the config options allowed here.
        /// Example usage:
        /// <code><see cref="Ext.MessageBoxEvents.show">Ext.Msg.show</see>({
        /// title: 'Address',
        /// msg: 'Please enter your address:',
        /// width: 300,
        /// buttons: <see cref="Ext.MessageBox.OKCANCEL">Ext.Msg.OKCANCEL</see>,
        /// multiline: true,
        /// fn: saveAddress,
        /// animateTarget: 'addAddressBtn',
        /// icon: <see cref="Ext.window.MessageBox.INFO">Ext.window.MessageBox.INFO</see>
        /// });
        /// </code>
        /// </summary>
        /// <param name="config"><p>The following config options are supported:</p>
        /// <ul><li><span>animateTarget</span> : <see cref="String">String</see>/<see cref="Ext.dom.Element">Ext.dom.Element</see><div><p>An id or Element from which the message box should animate as it opens and closes.</p>
        /// </div></li><li><span>buttons</span> : <see cref="Number">Number</see> (optional)<div><p>A bitwise button specifier consisting of the sum of any of the following constants:</p>
        /// <ul>
        /// <li><see cref="Ext.MessageBox.OK">Ext.MessageBox.OK</see></li>
        /// <li><see cref="Ext.MessageBox.YES">Ext.MessageBox.YES</see></li>
        /// <li><see cref="Ext.MessageBox.NO">Ext.MessageBox.NO</see></li>
        /// <li><see cref="Ext.MessageBox.CANCEL">Ext.MessageBox.CANCEL</see></li>
        /// </ul>
        /// <p>Some common combinations have already been predefined:</p>
        /// <ul>
        /// <li><see cref="Ext.MessageBox.OKCANCEL">Ext.MessageBox.OKCANCEL</see></li>
        /// <li><see cref="Ext.MessageBox.YESNO">Ext.MessageBox.YESNO</see></li>
        /// <li><see cref="Ext.MessageBox.YESNOCANCEL">Ext.MessageBox.YESNOCANCEL</see></li>
        /// </ul>
        /// <p>Or false to not show any buttons.</p>
        /// <p>This may also be specified as an object hash containing custom button text in the same format as the
        /// <see cref="Ext.window.MessageBox.buttonText">buttonText</see> config. Button IDs present as property names will be made visible.</p>
        /// <p>Defaults to: <c>false</c></p></div></li><li><span>closable</span> : <see cref="bool">Boolean</see><div><p>False to hide the top-right close button (defaults to true). Note that progress and wait dialogs will ignore this
        /// property and always hide the close button as they can only be closed programmatically.</p>
        /// </div></li><li><span>cls</span> : <see cref="String">String</see><div><p>A custom CSS class to apply to the message box's container element</p>
        /// </div></li><li><span>defaultTextHeight</span> : <see cref="Number">Number</see> (optional)<div><p>The default height in pixels of the message box's multiline textarea if displayed.</p>
        /// <p>Defaults to: <c>75</c></p></div></li><li><span>fn</span> : <see cref="Function">Function</see><div><p>A callback function which is called when the dialog is dismissed either by clicking on the configured buttons, or
        /// on the dialog close button, or by pressing the return button to enter input.</p>
        /// <p>Progress and wait dialogs will ignore this option since they do not respond to user actions and can only be
        /// closed programmatically, so any required function should be called by the same code after it closes the dialog.
        /// Parameters passed:</p>
        /// <h3>Parameters</h3><ul><li><span>buttonId</span> : <see cref="String">String</see><div><p>The ID of the button pressed, one of:</p>
        /// <ul>
        /// <li>ok</li>
        /// <li>yes</li>
        /// <li>no</li>
        /// <li>cancel</li>
        /// </ul>
        /// </div></li><li><span>text</span> : <see cref="String">String</see><div><p>Value of the input field if either <c>prompt</c> or <c>multiline</c> is true</p>
        /// </div></li><li><span>opt</span> : <see cref="Object">Object</see><div><p>The config object passed to show.</p>
        /// </div></li></ul></div></li><li><span>buttonText</span> : <see cref="Object">Object</see><div><p>An object containing string properties which override the system-supplied button text values just for this
        /// invocation. The property names are:</p>
        /// <ul>
        /// <li>ok</li>
        /// <li>yes</li>
        /// <li>no</li>
        /// <li>cancel</li>
        /// </ul>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope (<c>this</c> reference) in which the function will be executed.</p>
        /// </div></li><li><span>icon</span> : <see cref="String">String</see><div><p>A CSS class that provides a background image to be used as the body icon for the dialog.
        /// One can use a predefined icon class:</p>
        /// <ul>
        /// <li><see cref="Ext.MessageBox.INFO">Ext.MessageBox.INFO</see></li>
        /// <li><see cref="Ext.MessageBox.WARNING">Ext.MessageBox.WARNING</see></li>
        /// <li><see cref="Ext.MessageBox.QUESTION">Ext.MessageBox.QUESTION</see></li>
        /// <li><see cref="Ext.MessageBox.ERROR">Ext.MessageBox.ERROR</see></li>
        /// </ul>
        /// <p>or use just any <c>'custom-class'</c>. Defaults to empty string.</p>
        /// </div></li><li><span>iconCls</span> : <see cref="String">String</see><div><p>The standard <see cref="Ext.window.WindowConfig.iconCls">Ext.window.Window.iconCls</see> to add an optional header icon (defaults to '')</p>
        /// </div></li><li><span>maxWidth</span> : <see cref="Number">Number</see><div><p>The maximum width in pixels of the message box (defaults to 600)</p>
        /// </div></li><li><span>minWidth</span> : <see cref="Number">Number</see><div><p>The minimum width in pixels of the message box (defaults to 100)</p>
        /// </div></li><li><span>modal</span> : <see cref="bool">Boolean</see><div><p>False to allow user interaction with the page while the message box is displayed (defaults to true)</p>
        /// </div></li><li><span>msg</span> : <see cref="String">String</see><div><p>A string that will replace the existing message box body text (defaults to the XHTML-compliant non-breaking space
        /// character '&#160;')</p>
        /// </div></li><li><span>multiline</span> : <see cref="bool">Boolean</see><div><p>True to prompt the user to enter multi-line text (defaults to false)</p>
        /// </div></li><li><span>progress</span> : <see cref="bool">Boolean</see><div><p>True to display a progress bar (defaults to false)</p>
        /// </div></li><li><span>progressText</span> : <see cref="String">String</see><div><p>The text to display inside the progress bar if progress = true (defaults to '')</p>
        /// </div></li><li><span>prompt</span> : <see cref="bool">Boolean</see><div><p>True to prompt the user to enter single-line text (defaults to false)</p>
        /// </div></li><li><span>proxyDrag</span> : <see cref="bool">Boolean</see><div><p>True to display a lightweight proxy while dragging (defaults to false)</p>
        /// </div></li><li><span>title</span> : <see cref="String">String</see><div><p>The title text</p>
        /// </div></li><li><span>value</span> : <see cref="String">String</see><div><p>The string value to set into the active textbox element if displayed</p>
        /// </div></li><li><span>wait</span> : <see cref="bool">Boolean</see><div><p>True to display a progress bar (defaults to false)</p>
        /// </div></li><li><span>waitConfig</span> : <see cref="Object">Object</see><div><p>A <see cref="Ext.ProgressBar.wait">Ext.ProgressBar.wait</see> config object (applies only if wait = true)</p>
        /// </div></li><li><span>width</span> : <see cref="Number">Number</see><div><p>The width of the dialog in pixels</p>
        /// </div></li></ul></param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox show(object config=null){return null;}
        /// <summary>
        /// Set button text according to current buttonText property object
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The buttons bitwise flag based upon the button IDs specified in the buttonText property.</p>
        /// </div>
        /// </returns>
        private JsNumber updateButtonText(){return null;}
        /// <summary>
        /// Updates a progress-style message box's text and progress bar. Only relevant on message boxes
        /// initiated via progress or wait,
        /// or by calling show with progress: true.
        /// </summary>
        /// <param name="value"><p>Any number between 0 and 1 (e.g., .5)</p>
        /// <p>Defaults to: <c>0</c></p></param>
        /// <param name="progressText"><p>The progress text to display inside the progress bar.</p>
        /// <p>Defaults to: <c>&quot;&quot;</c></p></param>
        /// <param name="msg"><p>The message box's body text is replaced with the specified string (defaults to undefined
        /// so that any existing body text will not get overwritten by default unless a new value is passed in)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox updateProgress(object value=null, object progressText=null, object msg=null){return null;}
        /// <summary>
        /// Displays a message box with an infinitely auto-updating progress bar.  This can be used to block user
        /// interaction while waiting for a long-running process to complete that does not have defined intervals.
        /// You are responsible for closing the message box when the process is complete.
        /// </summary>
        /// <param name="msg"><p>The message box body text</p>
        /// </param>
        /// <param name="title"><p>The title bar text</p>
        /// </param>
        /// <param name="config"><p>A <see cref="Ext.ProgressBar.wait">Ext.ProgressBar.wait</see> config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.window.MessageBox">Ext.window.MessageBox</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.window.MessageBox wait(JsString msg, object title=null, object config=null){return null;}
        public MessageBox(Ext.window.MessageBoxConfig config){}
        public MessageBox(){}
        public MessageBox(params object[] args){}
    }
    #endregion
    #region MessageBoxConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MessageBoxConfig : WindowConfig
    {
        public MessageBoxConfig(params object[] args){}
    }
    #endregion
    #region MessageBoxEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MessageBoxEvents : WindowEvents
    {
        public MessageBoxEvents(params object[] args){}
    }
    #endregion
}