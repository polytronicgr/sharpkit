using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    using DOMStringList = org.w3c.dom.DOMStringList;
    using Element = org.w3c.dom.Element;
    using File = org.w3c.dom.file.File;

    public interface DataTransfer
    {
        // DataTransfer
        JsString dropEffect {get;set;}
        JsString effectAllowed {get;set;}
        DOMStringList types {get;}
        void clearData();
        void clearData(string format);
        void setData(string format, JsString data);
        JsString getData(string format);
        File[] files {get;}
        void setDragImage(Element image, int x, int y);
        void addElement(Element element);
    }

}