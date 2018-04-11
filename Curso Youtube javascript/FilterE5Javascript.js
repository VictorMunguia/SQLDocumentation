var numeros  = [10,2,3,5,9,20,22] ;


var numerosPares = [];
//De esta forma sacariamos los numeros pares de un arreglo de manera normal
for(var i = numeros.length; i >=0 ; i--){//Este ciclo va de arriba hacia abajo, utiliza el tamaño del arreglo como i y le vamos restando
    var numeroDeArreglo =  numeros[i];//En una variable metemos el valor en turno de i
    if(numeroDeArreglo%2 == 0){//Sacamos el residuo y si es divisible entre dos....
        numerosPares.push(numeroDeArreglo);//Hacemos un push al arreglo para guardarlo
    }
}

console.log("Numeros pares del primer arreglo en otro arreglo (Metodo rudimentario)");
console.log(numerosPares);




//---------------------------Metodo mas sencillo con el metodo filter---------------------------------------
var numeros2  = [10,2,3,5,9,20,22] ;
var numerosPares2 = [];


var numerosPares2= numeros2.filter(function(numeros2){//filter resive como parametro una funcion, si esa funcion retorna verdadero se hace el guardado en el arreglo, de lo contrario se descarta
    return numeros2 % 2 === 0;
});


console.log("Numeros pares con la funcion sencilla")
console.log(numerosPares2);
