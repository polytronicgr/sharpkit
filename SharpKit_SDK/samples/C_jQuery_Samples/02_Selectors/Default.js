/*@Generated by SharpKit v4.23.0000*/
function jQuerySelectorsSample_Load()
{
    $(".MyExpander > #Header").mousedown(function(e)
    {
        $(this).siblings(".MyExpander > #Content").toggle();
    });
}