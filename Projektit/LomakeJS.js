function nappula(){
  var nimi = document.getElementById("nimi").value;
  var salasana = document.getElementById("salasana").value;
  var email = document.getElementById("email").value;
  var ika = document.getElementById("ika").value;
  var pelaaja = document.getElementById("pelaaja").checked;
  var pelaajav2 = document.getElementById("opiskeluun").checked;
  var pelaajav3 = document.getElementById("eiKonetta").checked;
  var mielipide = document.getElementById("tosiHieno").checked;
  var mielipide2 = document.getElementById("ammattimainen").checked;
  var mielipide3 = document.getElementById("ostan").checked;
  var lempiaine = document.getElementById("lempiAine").value;

//1 Nimen tarkistus
var ehdot = /^[a-zA-Z]+\s[a-zA-Z]+$/;
  if(nimi == "") {
    alert("Kirjoita nimesi.");
  }

//1 Nimen välilyönnit
  else if (!ehdot.test(nimi)) {
    alert("Kirjoita etu- ja sukunimi, vain yksi välilyönti niiden välissä.")
  }

//1 Nimen pituus
  else if (nimi.length < 8) {
    alert("Nimesi on liian lyhyt. Sen täytyy olla vähintään 8-merkkiä pitkä.");
  }
  else {
    console.log("Nimi: OK");
  }
// ---------------------------
//2 Salasanan tarkistus
  if(salasana  == "") {
    alert("Kirjoita Salasana.");
  }
//2 Salasanan pituus
  else if (salasana.length < 10) {
    alert("Salasana on liian lyhyt. Sen täytyy olla vähintään 12-merkkiä pitkä.");
  }

  else {
    console.log("Salasana: OK");
  }

// ---------------------------
//3 Sähköpostin tarkistus
var ehdot = /^.+@.+\..+$/;
  if (!ehdot.test(email)) {
    alert("Sähköpostisi on virheellisessä muodossa.");
  }
  else {
    console.log("Email: OK");
  }

// ---------------------------
//4 Iän numeron tarkistus
var ehdot = /\d/;
  if (!ehdot.test(ika))
  alert("Ikä pitää kirjoittaa numeroina.")

  else {
    console.log("Ikä: OK");
  }
// -----------------------------------------------------
//5. minkälainen koneen käyttäjä olet olet tarkistus
if(pelaaja === true){
console.log("koneen käyttäjä on ok")
} else if (pelaajav2 === true){
console.log("koneen käyttäjä on ok")
} else if (pelaajav3 === true) {
console.log("Koneen käyttäjä on ok")
} else {
alert("Valitse minkälainen koneen käyttäjä olet.")
}
// -----------------------------------
//6. mitä mieltä olet sivustamme
if(mielipide === true){
console.log("Mielipide ok")

}if(mielipide2 === true){
console.log("Mielipidev2 ok")

}if(mielipide3 === true){
console.log("Mielipidev3 ok")

} else if ((mielipide === false) && (mielipide2 === false) && (mielipide2 === false)) {
alert("Valitse mielipiteesi sivustamme.")

} // -------------------------
  //7. Lempiaine tarkistus

  if(lempiaine == "empty"){
  alert("Valitse valikosta lempi aineesi.")
} else {
console.log("Lempiaine ok");
}
}
