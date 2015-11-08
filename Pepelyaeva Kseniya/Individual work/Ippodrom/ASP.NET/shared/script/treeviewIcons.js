$(document).ready(function () {
    setTreeViewIcons();
});

// Добавить иконки в дерево навигации.
function setTreeViewIcons() {
    var $trElem;
    for (i = 0; i < 4; i++) {
        $trElem = $("#TreeView1n6Nodes").find("table:eq(" + i + ")").find("tbody:first").find("tr:first").find("td:eq(1)");
        $trElem.css("background-image", "url('../../App_Themes/Spring/Images/TreeView" + i + ".png')");
        $trElem.css("background-position", "center");
    }
}
