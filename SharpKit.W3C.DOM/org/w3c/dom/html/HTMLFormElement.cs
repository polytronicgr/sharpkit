using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface HTMLFormElement : HTMLElement
    {
        // HTMLFormElement
        JsString acceptCharset {get;set;}
        JsString action {get;set;}
        bool autocomplete {get;set;}
        JsString enctype {get;set;}
        JsString method {get;set;}
        JsString name {get;set;}
        bool noValidate {get;set;}
        JsString target {get;set;}
        HTMLFormControlsCollection elements {get;}
        int length {get;}
        [JsProperty(NativeIndexer = true)]
        object this[int index] { get; }
        object namedItem(string name);
        void submit();
        void reset();
        bool checkValidity();
        void dispatchFormInput();
        void dispatchFormChange();
    }

}