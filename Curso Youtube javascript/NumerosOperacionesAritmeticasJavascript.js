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

var Residuo = edad % 3;//De esta manera metemos en una variable el residuo de la division edad entre 3
console.log(Residuo);

function esPar(numero){ //Esta funcion nos retornara verdadero o falso dependiendo si el numero que metamos deja un residuo o no
    if(numero%2 == 0){
        return true;
    }
    else{
        return false;
    } 
}


console.log(esPar(2));//El valor dos entre dos deja un residuo de 0 por lo que el valor va a retornar verdadero


//Javascript cuenta con unas librerias para operaciones aritmeticas mas complejas.

console.log(Math.pow(2,3));//pow nos permite elevar un numero a n potencia, en este caso elevamos 2 a la tercera potencia
console.log(Math.round(0.6));//round nos permite redondear valores al entero mas cercano
console.log(Math.ceil(0.6))//Nos redondea siempre al entero que esta hacia arriba
console.log(Math.floor(0.6))//Siempre redondea hacia abajo
console.log(Math.PI)//Devuelve valor de pi
console.log((Math.random() * 10) + 1)//Devuelve valor aleatorio pero valores por debajo del 0, por lo que hay que multiplicar por 10 para que nos de enteros