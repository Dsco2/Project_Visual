var x = 0;
var s = "";

console.log("Hola Mundo!");
var form = $("#form");
form.hide();

var button = $("#Login_Button");
button.on("click", function () {
  console.log("xxx");
  button.hide();
  form.show();




});
