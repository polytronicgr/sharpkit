/*Generated by SharpKit 5 v4.29.0000*/
var PrototypeCodeSample=function()
{
    this.InstanceProperty = null;
    this.InstanceProperty = "some default value";
};
PrototypeCodeSample.prototype.InstanceFunction = function(value)
{
    this.InstanceProperty = value;
};
PrototypeCodeSample.StaticFunction = function(value)
{
    PrototypeCodeSample.StaticProperty = value;
};
function btn_onclick()
{
    PrototypeCodeSample.StaticFunction("some static value");
    alert("PrototypeCodeSample.StaticProperty: \"" + PrototypeCodeSample.StaticProperty + "\"");
    var obj=new PrototypeCodeSample();
    obj.InstanceFunction("some instance value");
    alert("obj.InstanceProperty: \"" + obj.InstanceProperty + "\"");
};
