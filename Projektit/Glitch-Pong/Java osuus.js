
/* tehtävää; kulmna säätö, parempi ohjaus ja parempi ai
*/

var canvas = document.getElementById("Peli");
var context = canvas.getContext("2d");




/* näissä kolmessa functiossa on tehty pohjat valmiiksi, joita käytetään
 piirtäessä eri grafiikoita canvasiin
  */
var h = canvas.width;
var f = canvas.height;





function drawCircle(x, y, r, color){
context.beginPath();
context.fillStyle = color;
context.arc(x, y, r, 0, Math.PI*2, false);
context.clearRect(0, 0, h, f);
context.fill();
context.closePath();
}


function drawRect(x, y, w, h, color){
context.fillStyle = color;
context.fillRect(x, y, w,  h);
}

function drawText(text, x, y, color){
context.fillStyle = color;
context.fillText(text, x, y);
}





/* tässä on määritelty käyttäjä ja vastustaja ulkonäöllisesti. Tässä on syötetty arvot käyttöjäänn ja
vastustajaana.*/
const käyttäjä = {
x : 0,
y : canvas.height/2 - 100/2,
width : 10,
height : 100,
color : "black",
score : 0
}


function liikutus(){
if(käyttäjä.y >= canvas.height){
käyttäjä.y += -100;
}
if(käyttäjä.y < canvas.height - canvas.height){
käyttäjä.y += 100;
}
}


  document.addEventListener('keydown', function(event) {
      if(event.keyCode == 	38) {
  käyttäjä.y += -100

      }
      else if(event.keyCode == 	40) {
  käyttäjä.y += 100

      }
  });




const vastustaja = {
x : canvas.width - 10,
y : canvas.height/2 - 100/2,
width : 10,
height : 100,
color : "black",
score : 0
}




/* Tässä on määritelty verkko, jolle on annettu määritellyt arvot. For loopin avulla (joka ei ole pakollinen)
piirretään 15 pixelin välein 2 pixelin leveä ja 10 pixelin pitkä linja. for looppi on laitettu piirtämään koko canvaysin pituuden
pitkä linja. */
const verkko = {
x : canvas.width/2 - 2/2,
y : 0,
width : 2,
height : 10,
color : "BLACK",
}


var ball = {
x : canvas.width/2,
y : canvas.height/2,
r : 10,
color : "BLACK",
}




var vx = 15;
var vy = 12;

var arvontav4 = 10;
var luvut;
var kerto;
var jako;

function pallonliike(){



ball.x += vx;
ball.y += vy;


if((ball.x + ball.r < 0) && (ball.x + ball.r < käyttäjä.width)){
vastustaja.score += 1;
lukujav2 = ["10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "150", "160", "170", "180"];
arvontav3 = Math.floor(Math.random(lukujav2) * lukujav2.length);
arvontav4 = Math.floor(arvontav3 * 10);
console.log(arvontav4);
console.log("seinään osu");
vx *= -1;
}

// tää pitää saaha epä trueks
if((ball.x + ball.r > h) && (ball.y - ball.r > vastustaja.y + vastustaja.height  || ball.y + ball.r < vastustaja.y - 12)){
käyttäjä.score += 1;
vx *= 1;
}

// lattia
if (ball.y + ball.r > canvas.height){

vy *= -1;
}

// katto

if (ball.y + ball.r < canvas.height - canvas.height){

vy *= -1;
}
}


function törmäys(){
/* Huhhuh tää oli hankakala, (ymmärtämisen kannalta) mutta tän video avulla opin
https://www.youtube.com/watch?v=GpM8yvDP21o mite collision detection tehää
(Huom video o eri koodi kielellä, mutta ymmärsin miten asia toimii käytännössä
ja pystyin helposti poimimaan pää asiat javascriptiin).*/


if(ball.x > käyttäjä.x && ball.x < käyttäjä.x + käyttäjä.width)
{
  lukujav2 = ["10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "150", "160", "170", "180"];
  arvontav3 = Math.floor(Math.random(lukujav2) * lukujav2.length);
  arvontav4 = Math.floor(arvontav3 * 10);
  console.log(arvontav4);
  console.log("yläosu");
vx *= 1;
if(ball.y + ball.r > käyttäjä.y && ball.y < käyttäjä.y + käyttäjä.height)
{
vx *= -1;



 }
}

if(ball.x  > vastustaja.x && ball.x < vastustaja.x + vastustaja.width)
{
vx *= -1;
  console.log("yläosuma");
if(ball.y + ball.r  > vastustaja.y  && ball.y - ball.r < vastustaja.y + vastustaja.height)
{
vx *= 1
  console.log("osu");

 }
}

if( ball.x < käyttäjä.x + käyttäjä.width && ball.y < käyttäjä.y && ball.y + ball.r > käyttäjä.y){
console.log("ylä k touch");
vy *= -1;
vx *= 1;
}
if ( ball.x < käyttäjä.x + käyttäjä.width && ball.y > käyttäjä.y + käyttäjä.height && ball.y - ball.r < käyttäjä.y + käyttäjä.height){
console.log("ala ktouch")
vy *= 1;
vx *= -1;
}
if (ball.x < käyttäjä.x + käyttäjä.width && ball.y > käyttäjä.y && ball.y < käyttäjä.y + käyttäjä.height){
console.log("clitch");

vx *= -1;

console.log(vy);
}
}
function käyttäjäliike(){

vastustaja.y = ball.y + ball.r - arvontav4;

}

function renderöinti(){
  drawCircle(ball.x, ball.y, ball.r, ball.color);
drawText(käyttäjä.score, canvas.width/5, canvas.height/5, "BLACK");
drawText(vastustaja.score, 3*canvas.width/4, canvas.height/5, "BLACK");

for(var i = 0; i <= canvas.height; i+=15){
drawRect(verkko.x, verkko.y + i,verkko.width, verkko.height, verkko.color);
}

drawRect(käyttäjä.x, käyttäjä.y, käyttäjä.width, käyttäjä.height, käyttäjä.color);
törmäys();
drawRect(vastustaja.x, vastustaja.y, vastustaja.width, vastustaja.height, vastustaja.color);
käyttäjäliike();
pallonliike();
}
function Uusi(){
vx *= 1;
vy *= 1;

ball.x = canvas.width/2;
ball.y = canvas.height/2;
käyttäjä.score = 0;
vastustaja.score = 0;
}

if (ball.x + ball.r < 0){
vx *= -1;
}
function peli(){
  if(vastustaja.score < 5 && käyttäjä.score < 5){

renderöinti();

}
}


const framePerSecond = 50;


var aika = setInterval(peli, 1000/framePerSecond);
