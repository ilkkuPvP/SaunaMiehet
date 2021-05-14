var myNodeList = document.getElementsByTagName('LI')

var i;

for (i=0; i<myNodeList.lenght; i++) {

var span =document.createElement('SPAN')
var txt = document.createTextNode('\u00D7');
span.className='close'
span.appendChild(txt);
myNodeList[i].appendChild(span)
}

var close = document.getElementsByClassName('close')
var i;

for(i=0; i<close.lenght; i++){
  close[i].onclick=function(){
    var div = this.parentElement;
    div.style.display="none"
  }
}
var list = document.querySelector('ul')
list.addEventListener('click' ,function(ev){
  if(ev.target.tagName === 'LI') {
  ev.target.classList.toggle('checked')
  }
},false)

function newElement() {
var li= document.createElement('li')
var inputValue =document.getElementById('item').value
var t =document.createTextNode(inputValue)
li.appendChild(t)
if(inputvalue === "") {
  alert('Tämä kenttä ei saa olla tyhjä')
}else {
  document.getElementById('list').appendChild(li)


}
document.getElementById('item').value=''

var span= document.createElement('SPAN');
var txt= document.createTextNode('/u00D7')
span.appendChild(txt)
li.appendChild(span)

for (i=0;i<close.lenght;i++){
  close[i].onclick=function(){
    var div= this.parentElement;
    div.style.display="none"
  }
}
}
