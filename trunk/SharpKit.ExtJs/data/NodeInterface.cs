//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext.data
namespace Ext.data
{
    #region NodeInterface
    /// <summary>
    /// This class is meant to be used as a set of methods that are applied to the prototype of a
    /// Record to decorate it with a Node API. This means that models used in conjunction with a tree
    /// will have all of the tree related methods available on the model. In general this class will
    /// not be used directly by the developer.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class NodeInterface : Ext.Base
    {
        /// <summary>
        /// Insert node(s) as the last child node of this node. ...
        /// </summary>
        public Node appendChild(object node, object suppressEvents, object suppressNodeUpdate){return null;}
        /// <summary>
        /// Bubbles up the tree from this node, calling the specified function with each node. ...
        /// </summary>
        public object bubble(JsAction fn, object scope=null, JsArray args=null){return null;}
        /// <summary>
        /// Cascades down the tree from this node, calling the specified function with each node. ...
        /// </summary>
        public object cascadeBy(JsAction fn, object scope=null, JsArray args=null){return null;}
        /// <summary>
        /// Collapse this node. ...
        /// </summary>
        public object collapse(JsAction recursive, JsAction callback, object scope){return null;}
        /// <summary>
        /// Collapse all the children of this node. ...
        /// </summary>
        public object collapseChildren(JsAction recursive, JsAction callback, object scope){return null;}
        /// <summary>
        /// Returns true if this node is an ancestor (at any point) of the passed node. ...
        /// </summary>
        public bool contains(Node node){return false;}
        /// <summary>
        /// Creates a copy (clone) of this Node. ...
        /// </summary>
        public Node copy(JsString id=null, bool deep=false){return null;}
        /// <summary>
        /// Ensures that the passed object is an instance of a Record with the NodeInterface applied ...
        /// </summary>
        public bool createNode(object node){return false;}
        /// <summary>
        /// Destroys the node. ...
        /// </summary>
        public object destroy(object silent){return null;}
        /// <summary>
        /// Interates the child nodes of this node, calling the specified function with each node. ...
        /// </summary>
        public object eachChild(JsAction fn, object scope=null, JsArray args=null){return null;}
        /// <summary>
        /// Expand this node. ...
        /// </summary>
        public object expand(JsAction recursive, JsAction callback, object scope){return null;}
        /// <summary>
        /// Expand all the children of this node. ...
        /// </summary>
        public object expandChildren(JsAction recursive, JsAction callback, object scope){return null;}
        /// <summary>
        /// Finds the first child that has the attribute with the specified value. ...
        /// </summary>
        public Node findChild(JsString attribute, object value, bool deep){return null;}
        /// <summary>
        /// Returns the child node at the specified index. ...
        /// </summary>
        public Node getChildAt(JsNumber index){return null;}
        /// <summary>
        /// Returns depth of this node (the root node has a depth of 0) ...
        /// </summary>
        public JsNumber getDepth(){return null;}
        /// <summary>
        /// Returns true if this node has one or more child nodes, else false. ...
        /// </summary>
        public bool hasChildNodes(){return false;}
        /// <summary>
        /// Returns the index of a child node ...
        /// </summary>
        public JsNumber indexOf(Node node){return null;}
        /// <summary>
        /// Inserts the first node before the second node in this nodes childNodes collection. ...
        /// </summary>
        public Node insertBefore(Node node, Node refNode, object suppressEvents){return null;}
        /// <summary>
        /// Insert a node into this node ...
        /// </summary>
        public Ext.data.Record insertChild(JsNumber index, Ext.data.Model node){return null;}
        /// <summary>
        /// Returns true if the passed node is an ancestor (at any point) of this node. ...
        /// </summary>
        public bool isAncestor(Node node){return false;}
        /// <summary>
        /// Returns true if this node has one or more child nodes, or if the expandable
        /// node attribute is explicitly specified as...
        /// </summary>
        public bool isExpandable(){return false;}
        /// <summary>
        /// Returns true if this node is expaned ...
        /// </summary>
        public bool isExpanded(){return false;}
        /// <summary>
        /// Returns true if this node is the first child of its parent ...
        /// </summary>
        public bool isFirst(){return false;}
        /// <summary>
        /// Returns true if this node is the last child of its parent ...
        /// </summary>
        public bool isLast(){return false;}
        /// <summary>
        /// Returns true if this node is a leaf ...
        /// </summary>
        public bool isLeaf(){return false;}
        /// <summary>
        /// Returns true if this node is loaded ...
        /// </summary>
        public bool isLoaded(){return false;}
        /// <summary>
        /// Returns true if this node is loading ...
        /// </summary>
        public bool isLoading(){return false;}
        /// <summary>
        /// Returns true if this node is the root node ...
        /// </summary>
        public bool isRoot(){return false;}
        /// <summary>
        /// Returns true if this node is visible ...
        /// </summary>
        public bool isVisible(){return false;}
        /// <summary>
        /// Removes this node from its parent ...
        /// </summary>
        public Node remove(bool destroy, object suppressEvents){return null;}
        /// <summary>
        /// Removes all child nodes from this node. ...
        /// </summary>
        public Node removeAll(bool destroy, object suppressEvents){return null;}
        /// <summary>
        /// Removes a child node from this node. ...
        /// </summary>
        public Node removeChild(Node node, bool destroy, object suppressEvents, object suppressNodeUpdate){return null;}
        /// <summary>
        /// Replaces one child node in this node with another. ...
        /// </summary>
        public Node replaceChild(Node newChild, Node oldChild, object suppressEvents){return null;}
        /// <summary>
        /// Sorts this nodes children using the supplied sort function. ...
        /// </summary>
        public object sort(JsAction fn, bool recursive, bool suppressEvent){return null;}
        /// <summary>
        /// Updates general data of this node like isFirst, isLast, depth. ...
        /// </summary>
        public bool updateInfo(object silent){return false;}
        public NodeInterface(NodeInterfaceConfig config){}
        public NodeInterface(){}
    }
    #endregion
    #region NodeInterfaceConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class NodeInterfaceConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region NodeInterfaceEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class NodeInterfaceEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when a new child node is appended ...
        /// </summary>
        public static JsString append="append";
        /// <summary>
        /// Fires before a new child is appended, return false to cancel the append. ...
        /// </summary>
        public static JsString beforeappend="beforeappend";
        /// <summary>
        /// Fires before this node is collapsed. ...
        /// </summary>
        public static JsString beforecollapse="beforecollapse";
        /// <summary>
        /// Fires before this node is expanded. ...
        /// </summary>
        public static JsString beforeexpand="beforeexpand";
        /// <summary>
        /// Fires before a new child is inserted, return false to cancel the insert. ...
        /// </summary>
        public static JsString beforeinsert="beforeinsert";
        /// <summary>
        /// Fires before this node is moved to a new location in the tree. ...
        /// </summary>
        public static JsString beforemove="beforemove";
        /// <summary>
        /// Fires before a child is removed, return false to cancel the remove. ...
        /// </summary>
        public static JsString beforeremove="beforeremove";
        /// <summary>
        /// Fires when this node is collapsed. ...
        /// </summary>
        public static JsString collapse="collapse";
        /// <summary>
        /// Fires when this node is expanded. ...
        /// </summary>
        public static JsString expand="expand";
        /// <summary>
        /// Fires when a new child node is inserted. ...
        /// </summary>
        public static JsString insert="insert";
        /// <summary>
        /// Fires when this node is moved to a new location in the tree ...
        /// </summary>
        public static JsString move="move";
        /// <summary>
        /// Fires when a child node is removed ...
        /// </summary>
        public static JsString remove="remove";
        /// <summary>
        /// Fires when this node's childNodes are sorted. ...
        /// </summary>
        public static JsString sort="sort";
    }
    #endregion
}
#endregion
