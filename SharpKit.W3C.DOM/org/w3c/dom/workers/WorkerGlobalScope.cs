using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.workers
{

    using ApplicationCache = org.w3c.dom.html.ApplicationCache;
    using Function = org.w3c.dom.html.Function;
    using MessagePort = org.w3c.dom.html.MessagePort;
    using Database = org.w3c.dom.webdatabase.Database;
    using DatabaseCallback = org.w3c.dom.webdatabase.DatabaseCallback;
    using DatabaseSync = org.w3c.dom.webdatabase.DatabaseSync;

    public interface WorkerGlobalScope
    {
        // WorkerGlobalScope
        WorkerGlobalScope self {get;}
        WorkerLocation location {get;}
        void close();
        Function onerror {get;set;}
        // WorkerUtils
        void importScripts(params JsString[] urls);
        WorkerNavigator navigator {get;}
        // WorkerUtilsDatabase
        Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize);
        Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback);
        DatabaseSync openDatabaseSync(string name, JsString version, JsString displayName, int estimatedSize);
        DatabaseSync openDatabaseSync(string name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback);
        // WindowTimers
        int setTimeout(JsAction handler);
        int setTimeout(JsAction handler, object timeout, params object[] args);
        void clearTimeout(int handle);
        int setInterval(JsAction handler);
        int setInterval(JsAction handler, object timeout, params object[] args);
        void clearInterval(int handle);
        // DedicatedWorkerGlobalScope
        void postMessage(object message);
        void postMessage(object message, MessagePort[] ports);
        Function onmessage {get;set;}
        // SharedWorkerGlobalScope
        JsString name {get;}
        ApplicationCache applicationCache {get;}
        Function onconnect {get;set;}
    }

}