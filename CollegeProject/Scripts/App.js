var data1 = @ViewData["Test"];
   

$(function () {

        
    $("#grider").dxDataGrid({
        dataSource: data1,
        columns: ["GameID"]

    });


});