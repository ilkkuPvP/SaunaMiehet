
var teksti = 0;
var lasku = 0;
var luku = 0;
var vastaus;
function plussaus(plussaus){
  if(luku == 0){
var lisäys = document.getElementById("lvastaus").innerHTML += "+";
luku += 1;
}
vastaus = +teksti + +plussaus;
}
function miinus(miinus){
if(luku == 0){
var lisäysv2 = document.getElementById("lvastaus").innerHTML += "-";
luku += 2;
}
vastaus = +teksti - +miinus;
}


function jako(jako){
if(luku == 0){
var lisäysv3 = document.getElementById("lvastaus").innerHTML += "/";
luku += 3;
}
vastaus = +teksti / +jako;
}
function kerto(kerto){
if(luku == 0){
var lisäys = document.getElementById("lvastaus").innerHTML += "*";
luku += 4;

}
vastaus = +teksti * +kerto;
}
function desi(){
if(luku == 0){
var lisäys = document.getElementById("lvastaus").innerHTML += ".";
teksti += ".";
}
if(luku > 0){
  var lisäys = document.getElementById("lvastaus").innerHTML += ".";
lasku += ".";


}
}
function yhtäsuuri(){
var lopputulos = vastaus;
console.log(lopputulos);
document.getElementById("lvastaus").innerHTML = lopputulos;
luku = 0;
teksti = lopputulos;
lasku = 0;

if(lopputulos == 0){
document.getElementById("lvastaus").innerHTML = "";

}
}

function button0(){
  if(luku == 0){
alert("älä pistä nollaa ekaks luvuks");
  }

  if(luku == 1){
  lasku += "0";
  plussaus(lasku);
  }
  if(luku == 2){
  lasku += "0";
  miinus(lasku);
  }
  if(luku == 3){
  lasku += "0";
  jako(lasku);
  }
  if(luku == 4){
  lasku += "0";
  kerto(lasku);

  }
  }




function button1(){
var eka = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi1").value;
if(luku == 0){
 teksti += "1";
 luku = 0;
}

if(luku == 1){
lasku += "1";
plussaus(lasku);
}
if(luku == 2){
lasku += "1";
miinus(lasku);
}
if(luku == 3){
lasku += "1";
jako(lasku);
}
if(luku == 4){
lasku += "1";
kerto(lasku);

}
}
function button2(){
var toka = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi2").value;
if(luku == 0){
 teksti += "2";
}
if(luku == 1){
 lasku += "2";
 plussaus(lasku);
}
if(luku == 2){
lasku += "2";
miinus(2);
}
if(luku == 3){
lasku += "2";
jako(lasku);
}
if(luku == 4){
lasku += "2";
kerto(lasku);

}
}
function button3(){
var kolmas = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi3").value;
if(luku == 0){
 teksti += "3";
}
if(luku == 1){
lasku += "3";
plussaus(lasku);
}
if(luku == 2){
lasku += "3";
miinus(lasku);
}
if(luku == 3){
lasku += "3";
jako(lasku);
}
if(luku == 4){
lasku += "3";
kerto(lasku);

}
}
function button4(){
var neljäs = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi4").value;
if(luku == 0){
 teksti += "4";

}
if(luku == 1){
lasku += "4";
plussaus(lasku);

}
if(luku == 2){
lasku += "4";
miinus(lasku);
}
if(luku == 3){
lasku += "4";
jako(lasku);

}
if(luku == 4){
lasku += "4";
kerto(lasku);

}
}
function button5(){
var viides = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi5").value;
if(luku == 0){
 teksti += "5";
}
if(luku == 1){
lasku += "5";
plussaus(lasku);
}
if(luku == 2){
lasku += "5";
miinus(lasku);
}
if(luku == 3){
lasku += "5";
jako(lasku);

}
if(luku == 4){
lasku += "5";
kerto(lasku);

}
}
function button6(){
var kuudes = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi6").value;
if(luku == 0){
 teksti += "6";
}
if(luku == 1){
lasku += "6";
plussaus(lasku);
}
if(luku == 2){
lasku += "6";
miinus(lasku);
}
if(luku == 3){
lasku += "6";
jako(lasku);

}
if(luku == 4){
lasku += "6";
kerto(lasku);

}
}
function button7(){
var seitsemäs = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi7").value;
if(luku == 0){
 teksti += "7";

}
if(luku == 1){
lasku += "7";
plussaus(lasku);

}
if(luku == 2){
lasku += "7";
miinus(lasku);
}
if(luku == 3){
lasku += "7";
jako(lasku);

}
if(luku == 4){
lasku += "7";
kerto(lasku);

}
}
function button8(){
var kahdeksas = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi8").value;
if(luku == 0){
 teksti += "8";
}
if(luku == 1){
lasku += "8";
plussaus(lasku);
}
if(luku == 2){
lasku += "8";
miinus(lasku);
}
if(luku == 3){
lasku += "8";
jako(lasku);

}
if(luku == 4){
lasku += "8";
kerto(lasku);

}
}
function button9(){
var yhdeksäs = document.getElementById("lvastaus").innerHTML += document.getElementById("nappi9").value;
if(luku == 0){
 teksti += "9";
}
if(luku == 1){
lasku += "9";
plussaus(lasku);

}
if(luku == 2){
lasku += "9";
miinus(lasku);
}
if(luku == 3){
lasku += "9";
jako(lasku);

}
if(luku == 4){
lasku += "9";
kerto(lasku);

}
}

function clearButton() {
  var clear = document.getElementById("lvastaus").innerHTML = "";
  lasku = 0;
  teksti = 0;
  lopputulos = 0;
  luku = 0;
}
