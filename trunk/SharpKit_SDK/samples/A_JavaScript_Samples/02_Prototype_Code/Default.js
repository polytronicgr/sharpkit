/*Generated by SharpKit v4.26.5000*/
PrototypeCodeSample = function()
{
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
