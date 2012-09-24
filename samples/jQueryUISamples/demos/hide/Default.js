/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#button").click(function(e)
    {
        runEffect();
        return false;
    });
};
function runEffect()
{
    var selectedEffect=$("#effectTypes").val();
    var options=new Object();
    if(selectedEffect === "scale")
    {
         options = { percent: 0 };;
    }
    else if(selectedEffect === "size")
    {
         options = { to: { width: 200, height: 60 } };;
    }
    $("#effect").hide(selectedEffect,options,1000,callback);
};
function callback(e,ui)
{
    window.setTimeout(function()
    {
        $("#effect").removeAttr("style").hide().fadeIn();
    },1000);
};