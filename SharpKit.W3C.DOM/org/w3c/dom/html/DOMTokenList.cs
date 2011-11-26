using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface DOMTokenList
    {
        // DOMTokenList
        int length {get;}
        [JsProperty(NativeIndexer = true)]
        JsString this[int index] { get; }
        bool contains(string token);
        void add(string token);
        void remove(string token);
        bool toggle(string token);
        JsString ToString();
    }

}