var edad = 19; //No es necesario poner el tipo de variable en lenguajes de programacion modernos como javascript, automaticamente infieren el tipo de dato que tiene
edad++ ; //Esto suma 1 a la variable

var total = edad + 3;//dentro de una variable sumamos la otra variable con 3

console.log("Suma edad: " + total);//Podemos sumar valores de esta manera, poniendo que nos imprima el resultado de la variable edad y un +


var punto_Flotante = 12.5;

console.log(edad + punto_Flotante); //imprime una suma de un objeto entero y un decimal, recordar que a 19 le estamos sumando 1 en edad++ por lo que es igual a 20 y 20 + 12.5 es igual a 32.5

/*
Operadores aritmeticos
Division = /
Multiplicacion = *
Suma = +
Resta = -
Modulo(Nos devuelve el residuo) = % 
*/

console.log(edad - punto_Flotante);
console.log(edad * punto_Flotante);

var Residuo = edad % 3;//De esta forma almacenamos el residuo en una variable
console.log(Residuo); //Imprimimos el residuo de la division entre edad entre 3


function EsParONo (numero) {
	
	return
}