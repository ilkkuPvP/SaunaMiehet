function nappula(){
  var nimi = document.getElementById("nimi").value;
  var salasana = document.getElementById("salasana").value;
  var email = document.getElementById("email").value;
  var ika = document.getElementById("ika").value;
  var pelaaja1 = document.getElementById("pelaaja").checked;
  var pelaaja2 = document.getElementById("opiskeluun").checked;
  var pelaaja3 = document.getElementById("eiKonetta").checked;
  var mielipide1 = document.getElementById("tosiHieno").checked;
  var mielipide2 = document.getElementById("ammattimainen").checked;
  var mielipide3 = document.getElementById("ostan").checked;
  var lempiaine = document.getElementById("lempiAine").value;
  var palaute = document.getElementById("palaute").value;

  var kysymys1 = false;
  var kysymys2 = false;
  var kysymys3 = false;
  var kysymys4 = false;
  var kysymys5 = false;
  var kysymys6 = false;
  var kysymys7 = false;
  var kysymys8 = false;




//1 Nimen tarkistus
  var ehdot = /^[a-zA-Z]+\s[a-zA-Z]+$/;
  if(nimi == "") {
  alert("Kirjoita nimesi ja älä käytä numeroita.");
  }

//1 Nimen välilyönnit
  else if (!ehdot.test(nimi)) {
  alert("Kirjoita etu- ja sukunimi, vain yksi välilyönti niiden välissä. Äläkä käytä numeroita.")
  }

//1 Nimen pituus
  else if (nimi.length < 8) {
  alert("Nimesi on liian lyhyt. Sen täytyy olla vähintään 8-merkkiä pitkä.");
  }
  else {
  console.log("Nimi: OK");
  kysymys1 = true;
  }

  console.log("-------");

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
  kysymys2 = true;
  }

  console.log("-------");

// ---------------------------
//3 Sähköpostin tarkistus
  var ehdot = /^.+@.+\..+$/;
  if (!ehdot.test(email)) {
  alert("Sähköpostisi on virheellisessä muodossa.");
  }
  else {
  console.log("Email: OK");
  kysymys3 = true;
  }

  console.log("-------");

// ---------------------------
//4 Iän numeron tarkistus
  var ehdot = /\d/;
  if (!ehdot.test(ika)) {
  alert("Ikä pitää kirjoittaa numeroina.")
  }
  else {
  console.log("Ikä: OK");
  kysymys4 = true;
  }

  console.log("-------");

// -----------------------------------------------------
//5. minkälainen koneen käyttäjä olet olet tarkistus
  if(pelaaja1 === true) {
  console.log("Koneen käyttötapa: OK")
  kysymys5 = true;
  }
  else if (pelaaja2 === true) {
  console.log("Koneen käyttötapa: OK")
  kysymys5 = true;
  }
  else if (pelaaja3 === true) {
  console.log("Koneen käyttötapa: OK")
  kysymys5 = true;
  }
  else {
  alert("Valitse minkälainen koneen käyttäjä olet.")
  }

  console.log("-------");

// -----------------------------------
//6. mitä mieltä olet sivustamme
  if(mielipide1 === true){
  console.log("Mielipide: OK")
  kysymys6 = true;
  }
  if(mielipide2 === true){
  console.log("Mielipide: OK")
  kysymys6 = true;
  }
  if(mielipide3 === true){
  console.log("Mielipide: OK")
  kysymys6 = true;
  }
  else if ((mielipide1 === false) && (mielipide2 === false) && (mielipide3 === false)) {
  alert("Valitse mielipiteesi sivustamme.")
  }

  console.log("-------");

// -------------------------
//7. Lempiaine tarkistus
  if(lempiaine == "empty"){
  alert("Valitse valikosta lempi aineesi.")
  }
  else {
  console.log("Lempiaine: OK");
  kysymys7 = true;
  }

  console.log("-------");

// ------------------------
//8. Palaute talletus
  if (palaute == "") {
  alert("Kirjoita myös jotain muuta kerrottavaa.")
  }
  else {
  console.log("Tekstipalaute: OK");
  kysymys8 = true;
  }
  console.log("Asiakkaan palaute: " + palaute);

  console.log("-------");

// ------------------------
//Lopullinen tarkistus ja kiitoskset
  if (kysymys1 === true && kysymys2 === true && kysymys3 === true && kysymys4 === true && kysymys5 === true && kysymys6 === true && kysymys7 === true && kysymys8 === true) {
  console.log("Kaikki tiedot syötetty onnistuneesti.");
  console.log("-------");

  alert("Kiitos lomakkeen täytöstä!")
  window.location.href = "LomakeKiitos.htm";
  }
}
