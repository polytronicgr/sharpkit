/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#accordion").accordion({header:">div > h3"}).sortable(
    {
        axis:"y",
        handle:"h3",
        stop:function(e,ui)
        {
            ui.item.children("h3").triggerHandler("focusout");
        }
    });
};