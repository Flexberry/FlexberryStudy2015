var trElem;
for (i = 0; i < 4; i++) {
    trElem = document.getElementById("TreeView1n6Nodes").getElementsByTagName("table")[i].getElementsByTagName("tbody")[0].getElementsByTagName("tr")[0];
    trElem.getElementsByTagName("td")[1].style.backgroundImage = "url('../../App_Themes/Spring/Images/TreeView" + i + ".png')";
    trElem.getElementsByTagName("td")[1].style.backgroundPosition = "center";
}