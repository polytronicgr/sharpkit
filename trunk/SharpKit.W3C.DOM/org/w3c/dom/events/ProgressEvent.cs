using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.events
{

    public interface ProgressEvent : Event
    {
        // ProgressEvent
        bool lengthComputable {get;}
        int loaded {get;}
        int total {get;}
        void initProgressEvent(string typeArg, bool canBubbleArg, bool cancelableArg, bool lengthComputableArg, int loadedArg, int totalArg);
        void initProgressEventNS(string namespaceURI, JsString typeArg, bool canBubbleArg, bool cancelableArg, bool lengthComputableArg, int loadedArg, int totalArg);
    }

}