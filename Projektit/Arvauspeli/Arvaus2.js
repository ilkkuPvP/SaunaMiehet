/*function arvonta() {
  var numerot = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];
  var arvottu = Math.floor(Math.random() * numerot.length) + 1;
  console.log(arvottu);
}
arvonta();


function Nappula() {

}
*/



// arvonta kone
var vHistoria = 0;

var numerot = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];
var arvonta = Math.floor(Math.random() * numerot.length + 1);
  var yritykset = 0;
console.log(arvonta);

var vHistoriaLataus = 0;

function uusiPeli() {
  var vHistoriaTemp = localStorage.getItem(vHistoria);
  //window.location.reload(false);
  if(vHistoriaTemp == undefined){
    localStorage.setItem(vHistoria, 0);
    vHistoriaLataus = 0;
  }
  else{
    vHistoriaLataus = parseInt(vHistoriaTemp);
  }
  document.getElementById("textVHistoria").innerHTML = vHistoriaLataus;

  console.log("Uusi peli aloitettu!");
  //window.location.reload(false);
}

function Nappula(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov1 = document.getElementById("nappiv1").value;
  if(arvov1 < arvonta && (yritykset < 3)){
    yritykset += 1;
  alert("Luku on suurempi.");
  } else if (arvov1 > arvonta && (yritykset < 3)) {
  alert("Luku on pienempi.");
yritykset += 1;
  } else if (arvov1 == arvonta){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoriaLataus, vHistoria);
    uusiPeli();

  }
  if(yritykset == 3){
  alert("Hävisit pelin saatanan runkkari");
  }
}

function Nappula2(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";

  arvov2 = document.getElementById("nappiv2").value;

  if(arvov2 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.");
} else if (arvov2 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov2 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula3(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov3 = document.getElementById("nappiv3").value;
  if(arvov3 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov3 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov3 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula4(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov4 = document.getElementById("nappiv4").value;
  if(arvov4 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov4 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov4 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula5(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov5 = document.getElementById("nappiv5").value;
  if(arvov5 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov5 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov5 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula6(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov6 = document.getElementById("nappiv6").value;
  if(arvov6 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov6 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov6 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula7(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov7 = document.getElementById("nappiv7").value;
  if(arvov7 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov7 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov7 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula8(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov8 = document.getElementById("nappiv8").value;
  if(arvov8 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov8 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov8 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula9(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov9 = document.getElementById("nappiv9").value;
  if(arvov9 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov9 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");
} else if (arvov9 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoria, vHistoriaLataus);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
  if(yritykset == 3){
alert("Hävisit pelin saatanan runkkari");
  }

}

function Nappula10(){
document.getElementById("textYritysNro").innerHTML = "Yritys: " + (yritykset + 1) + "/3";
  arvov10 = document.getElementById("nappiv10").value;
  if(arvov10 < arvonta && (yritykset < 3)){
        yritykset += 1;
  alert("Luku on suurempi.")
} else if (arvov10 > arvonta && (yritykset < 3)) {
      yritykset += 1;
  alert("Luku on pienempi.");

  } else if (arvov10 == arvonta && (yritykset < 3)){
    alert("Hienoa! Arvasit oikein! Vai huijasitko?");
    vHistoria += 1;
    localStorage.setItem(vHistoriaLataus, vHistoria);
    document.getElementById("textVHistoria").innerHTML = vHistoria; "Voitot: " + vHistoria;

    uusiPeli();
  }
    if(yritykset == 3){
  alert("Hävisit pelin saatanan runkkari");
    }

}












//
