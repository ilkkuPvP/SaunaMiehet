


// arvonta kone
var vHistoria = 0, vHistoriaText = "Voitot: ";

var numerot = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];
var arvonta = Math.floor(Math.random() * numerot.length + 1);
  var h = 0;
console.log(arvonta);
function Nappula(){




  arvov1 = document.getElementById("nappiv1").value;
  if(arvov1 < arvonta && (h < 3)){
    h += 1;
  alert("Luku on suurempi.");
} else if (arvov1 > arvonta && (h < 3)) {
  alert("Luku on pienempi.");
h += 1;
} else if (arvov1 == arvonta){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;

}
if(h == 3){
alert("Hävisit pelin saatanan runkkari");

}
console.log(h);
}


function Nappula2(){

  arvov2 = document.getElementById("nappiv2").value;

  if(arvov2 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.");
} else if (arvov2 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov2 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");
  }
}
function Nappula3(){
  arvov3 = document.getElementById("nappiv3").value;
  if(arvov3 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov3 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov3 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}
function Nappula4(){
  arvov4 = document.getElementById("nappiv4").value;
  if(arvov4 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov4 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov4 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}

function Nappula5(){
  arvov5 = document.getElementById("nappiv5").value;
  if(arvov5 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov5 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov5 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}
function Nappula6(){
  arvov6 = document.getElementById("nappiv6").value;
  if(arvov6 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov6 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov6 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}
function Nappula7(){
  arvov7 = document.getElementById("nappiv7").value;
  if(arvov7 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov7 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov7 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}
function Nappula8(){
  arvov8 = document.getElementById("nappiv8").value;
  if(arvov8 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov8 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov8 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}
function Nappula9(){
  arvov9 = document.getElementById("nappiv9").value;
  if(arvov9 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov9 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");
} else if (arvov9 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
  if(h == 3){
alert("Hävisit pelin saatanan runkkari");

  }
}
function Nappula10(){
  arvov10 = document.getElementById("nappiv10").value;
  if(arvov10 < arvonta && (h < 3)){
        h += 1;
  alert("Luku on suurempi.")
} else if (arvov10 > arvonta && (h < 3)) {
      h += 1;
  alert("Luku on pienempi.");

  } else if (arvov10 == arvonta && (h < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    document.getElementById("textVHistoria").innerHTML = "Voitot: " + vHistoria;
  }
    if(h == 3){
  alert("Hävisit pelin saatanan runkkari");

    }

console.log(h)
}
