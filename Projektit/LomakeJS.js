function nappula(){
  var nimi = document.getElementById("nimi").value;
  var salasana = document.getElementById("salasana").value;
  var email = document.getElementById("email").value;
  var ika = document.getElementById("ika").value;

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
}
