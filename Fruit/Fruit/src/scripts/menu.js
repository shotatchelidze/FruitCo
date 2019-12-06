var menu = document.getElementById("menu");
var htmlbody = document.getElementById("htmlbody");
var btn = document.getElementById("menu-button");
var span = document.getElementsByClassName("close")[0];
btn.onclick = function () {
    menu.style.display = "block";
    htmlbody.style.overflowY = "hidden";
}
span.onclick = function () {
    menu.style.display = "none";
    htmlbody.style.overflowY = "visible";
}
window.onclick = function (event) {
    if (event.target == menu) {
        menu.style.display = "none";
        htmlbody.style.overflowY = "visible";
    }
}