/*Generated by SharpKit 5 v4.29.8000*/
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var System$Collections$Generic$List$1=
{
    fullname:"System.Collections.Generic.List$1",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    interfaceNames:["System.Collections.Generic.IList$1","System.Collections.IList"],
    Kind:"Class",
    definition:
    {
        ctor:function(T)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
        },
        ctor$$IEnumerable$1:function(T,collection)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
            this.AddRange(collection);
        },
        RemoveRange:function(index,count)
        {
            this._list.splice(index,count);
        },
        Clear:function()
        {
            this._list.Clear();
        },
        Item$$:"`0",
        get_Item$$Int32:function(index)
        {
            if(index >= this._list.length || index < 0)
                throw $CreateException(new System.ArgumentOutOfRangeException.ctor$$String("index"),new Error());
            return this._list[index];
        },
        set_Item$$Int32:function(index,value)
        {
            if(index >= this._list.length || index < 0)
                throw $CreateException(new System.ArgumentOutOfRangeException.ctor$$String("index"),new Error());
            this._list[index] = value;
        },
        Count$$:"System.Int32",
        get_Count:function()
        {
            return this._list.length;
        },
        GetEnumerator:function()
        {
            return new System.Collections.IListEnumerator$1.ctor(this.T,this);
        },
        ToArray:function()
        {
            return this._list.Clone();
        },
        AddRange:function(items)
        {
            var $it1=items.GetEnumerator();
            while($it1.MoveNext())
            {
                var item=$it1.get_Current();
                this.Add(item);
            }
        },
        Add:function(item)
        {
            this._list.push(item);
        },
        Remove:function(item)
        {
            var index=this._list.indexOf(item);
            if(index == -1)
                return false;
            this._list.RemoveAt(index);
            return true;
        },
        Contains:function(item)
        {
            return this._list.contains(item);
        },
        SetItems:function(items)
        {
            this.Clear();
            if(items != null)
                this.AddRange(items);
        },
        IndexOf:function(item)
        {
            return this._list.indexOf(item);
        },
        Insert:function(index,item)
        {
            this._list.insert(index,item);
        },
        RemoveAt:function(index)
        {
            this._list.RemoveAt(index);
        },
        TryRemove:function(item)
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("TryRemove"),new Error());
        },
        CopyTo:function(array,arrayIndex)
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("JsImplList$T"),new Error());
        },
        IsReadOnly$$:"System.Boolean",
        get_IsReadOnly:function()
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("JsImplList$T"),new Error());
        },
        Sort:function(comparison)
        {
            this._list.sort(SharpKit.JavaScript.Utils.Js.ToJsFunction(comparison));
        }
    }
};
JsTypes.push(System$Collections$Generic$List$1);
