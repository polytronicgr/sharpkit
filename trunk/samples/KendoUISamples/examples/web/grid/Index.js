/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#grid").kendoGrid(
    {
        dataSource:{data:createRandomData(50),pageSize:10},
        groupable:true,
        sortable:true,
        pageable:true,
        columns: [{field:"FirstName",width:"90",title:"FirstName"},{field:"LastName",width:"90",title:"Last Name"},{width:"100",field:"City"},{field:"Title"},{field:"BirthDate",title:"Birth Date",template:"#= kendo.toString(BirthDate,\'dd MMMM yyyy\') #"},{width:"50",field:"Age"}]
    });
};