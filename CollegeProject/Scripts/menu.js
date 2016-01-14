var dxMenu = $("#menu").dxMenu({
    dataSource: menuData,
    onItemClick: function (data) {
        var item = data.itemData;

    }
}).dxMenu("instance");

$("#show-submenu-mode").dxSelectBox({
    items: ["onHover", "onClick"],
    value: "onClick",
    onValueChanged: function (data) {
        dxMenu.option("showFirstSubmenuMode", data.selectedItem);
    }
});

$("#orientation").dxSelectBox({
    items: ["horizontal", "vertical"],
    value: "horizontal",
    onValueChanged: function (data) {
        dxMenu.option("orientation", data.selectedItem);
    }
})

$("#submenu-direction").dxSelectBox({
    items: ["auto", "rightOrBottom", "leftOrTop"],
    value: "auto",
    onValueChanged: function (data) {
        dxMenu.option("submenuDirection", data.selectedItem);
    }
})