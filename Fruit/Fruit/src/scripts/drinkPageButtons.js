var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var textbox1 = document.getElementById("txtbox1");
var textbox2 = document.getElementById("txtbox2");
var textbox3 = document.getElementById("txtbox3");
var textbox4 = document.getElementById("txtbox4");
var icon1 = document.getElementById("img1");
var icon2 = document.getElementById("img2");
var icon3 = document.getElementById("img3");
var icon4 = document.getElementById("img4");
btn1.onclick = function () {
    textbox1.style.zIndex="4";
    textbox2.style.zIndex="3";
    icon1.style.fill="yellow";
}
btn2.onclick = function () {
    textbox1.style.zIndex="3";
    textbox2.style.zIndex="4";
    icon2.style.fill="yellow";
}
btn3.onclick = function () {
    textbox3.style.zIndex="4";
    textbox4.style.zIndex="3";
    icon3.style.fill="yellow";
}
btn4.onclick = function () {
    textbox3.style.zIndex="3";
    textbox4.style.zIndex="4";
    icon4.style.fill="yellow";
}