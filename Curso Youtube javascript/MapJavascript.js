var numeros = [1,5,6,8];

var numerosCuadrados = [];

//Este es el metodo nos permite sacar la potencia a la dos de un arreglo
for( var i = numeros.length-1; i >= 0; i-- ){
    var numero = numeros[i];
    numerosCuadrados.push(Math.pow(numero,2));//Lo de arriba es recorrer todo el arreglo y finalmente usamos el metodo match.pow metemos como parametros el numero a elevar y el numero la cual sera la potencia a la que lo elevaremos.
}

console.log("Forma de sacar numeros elevados utilizando metodo tradicional");
console.log(numerosCuadrados);


var numeros2 = [1,5,6,8];

var numerosCuadrados2 = [];


var numerosCuadrados2 =  numeros2.map(function(elemento){//Funcion similar a filter
    return elemento * elemento;
});

console.log("Numeros al cuadrado con metodo sencillo");
console.log(numerosCuadrados2);