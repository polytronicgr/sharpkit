using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.traversal
{

    using DOMException = org.w3c.dom.DOMException;
    using Node = org.w3c.dom.Node;

    public interface NodeIterator
    {
        // NodeIterator
        Node root {get;}
        int whatToShow {get;}
        NodeFilter filter {get;}
        bool expandEntityReferences {get;}
//TODO:
//ORIGINAL LINE: public org.w3c.dom.Node nextNode() throws org.w3c.dom.DOMException;
        Node nextNode();
//TODO:
//ORIGINAL LINE: public org.w3c.dom.Node previousNode() throws org.w3c.dom.DOMException;
        Node previousNode();
        void detach();
    }

}
