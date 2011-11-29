//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.file
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class FileReader
{

	// FileReader
	public void readAsBinaryString(Blob fileBlob) {}
	public void readAsText(Blob fileBlob) {}
	public void readAsText(Blob fileBlob, string encoding) {}
	public void readAsDataURL(File file) {}
	public void abort() {}
	public static short EMPTY = 0;
	public static short LOADING = 1;
	public static short DONE = 2;
	public short readyState {get { return default(short); } }
	public string result {get { return default(string); } }
	public FileError error {get { return default(FileError); } }
	public JsAction onloadstart {get { return default(JsAction); } set {}}
	public JsAction onprogress {get { return default(JsAction); } set {}}
	public JsAction onload {get { return default(JsAction); } set {}}
	public JsAction onabort {get { return default(JsAction); } set {}}
	public JsAction onerror {get { return default(JsAction); } set {}}
	public JsAction onloadend {get { return default(JsAction); } set {}}
}

}