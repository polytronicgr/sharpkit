using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.workers
{

    using Function = org.w3c.dom.html.Function;
    using MessagePort = org.w3c.dom.html.MessagePort;

    public interface Worker : AbstractWorker
    {
        // Worker
        void terminate();
        void postMessage(object message);
        void postMessage(object message, MessagePort[] ports);
        Function onmessage {get;set;}
    }

}