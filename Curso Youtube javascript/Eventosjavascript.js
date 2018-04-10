function clic(){//Esto es una funcion de llavascript que mandamos a llamar con el evento onlclic en el html
    alert(":3");
}

function outClic(){//Esta funcion condiciona que cuando el mouce salga se agregara texto dentro del div
    document.getElementById("parrafo").innerHTML="Hola Mundo";
}

function onClic(){
    document.getElementById("parrafo").innerHTML="";//Esto borra el texto que abria dentro del div, lo que significa que esta funcion innerhtml sustituye lo que hay entro del div
}

//Aqui termina el ejemplo de los liceners del HTML

document.getElementById("mi_btn").addEventListener("click",clic,false);//Este metodo nos permite....
//Obtener un elemento con su id, una vez que lo tenemos agregamos un eventolistener, el primer atributo es el evento que tiene que cumplirse, los siguiente es la funcion y el ultimo es para meter un orden

document.getElementById("mi_btnOrden").addEventListener("click",clic,true);//El metodo de abajo y el de arriba , el primero que lelva true es el que se va a ejecutar primero

document.getElementById("miDiv").addEventListener("click",another_clic,false);

function another_clic(){
    alert("Esto Fue disparado por el div");
}