function nappula(){
  var nimi = document.getElementById("nimi").value;
  var salasana = document.getElementById("salasana").value;

//Nimen tarkistus
  if(nimi == "") {
  console.log("Kirjoita nimesi.");
  }

  else if (nimi.length < 8) {
    console.log("Nimesi on liian lyhyt.");
  }
  else {
  console.log("Nimi: OK")
  }

//Salasanan tarkistus
  if(salasana  == "") {
  console.log("Kirjoita Salasana.");
  }

  else if (salasana.length < 12) {
    console.log("Salasana on liian lyhyt.");
  }

  else {
  console.log("Salasana: OK")
  }


}
