
var teksti = 0;
var lasku = 0;
var luku = 0;
function plussaus(){
var lisäys = document.getElementById("lvastaus").innerHTML += "+";
luku += 1;
}
function yhtäsuuri(){
if(luku == 1){
var lopputulos = +teksti + +lasku;
console.log(lopputulos);
document.getElementById("lvastaus").innerHTML = lopputulos;
luku = 0;
teksti = lopputulos;
lasku = 0;
}

}

function button1(){

var eka = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi1").value;
if(luku == 0){
 teksti += "1";
}

if(luku == 1){
lasku += "1";
console.log("nyt");

}
}
function button2(){
var toka = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi2").value;
if(luku == 0){
 teksti += "2";
}
if(luku == 1){
 lasku += "2";
console.log("nyt");

}
}
function button3(){
var kolmas = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi3").value;
if(luku == 0){
 teksti += "3";
}
if(luku == 1){
lasku += "3";
console.log("nyt");

}
}
function button4(){
var neljäs = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi4").value;
if(luku == 0){
 teksti += "4";
}
if(luku == 1){
lasku += "4";
console.log("nyt");

}
}
function button5(){
var viides = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi5").value;
if(luku == 0){
 teksti += "5";
}
if(luku == 1){
lasku += "5";
console.log("nyt");

}
}
function button6(){
var kuudes = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi6").value;
if(luku == 0){
 teksti += "6";
}
if(luku == 1){
lasku += "6";
console.log("nyt");

}
}
function button7(){
var seitsemäs = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi7").value;
if(luku == 0){
 teksti += "7";
}
if(luku == 1){
lasku += "7";
console.log("nyt");

}
}
function button8(){
var kahdeksas = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi8").value;
if(luku == 0){
 teksti += "8";
}
if(luku == 1){
lasku += "8";
console.log("nyt");

}
}
function button9(){
var yhdeksäs = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi9").value;
if(luku == 0){
 teksti += "9";
}
if(luku == 1){
lasku += "9";
console.log("nyt");

}
}

function clearButton() {
  var clear = document.getElementById("lvastaus").innerHTML = "";
  lasku = 0;
  teksti = 0;
  lopputulos = 0;
  luku = 0;
}
