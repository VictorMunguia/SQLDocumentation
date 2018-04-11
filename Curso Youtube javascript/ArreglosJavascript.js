var arregloEjemplo = [20,15,7];//De esta forma es como se tienen que declarar arreglos, puedes almacenar cualquier cosa en el arrelgo, este guarda numeros.

console.log("Elemento 0 del arreglo");
console.log(arregloEjemplo[0]);//De esta forma accedemos a los elementos del atributo uno por uno

console.log("Tamaño del arreglo");
console.log(arregloEjemplo.length);//Este metodo nos permite sacar el tamaño del arreglo iniciando con el numeor 1

console.log("Arreglo originar sin modificaciones");
console.log(arregloEjemplo);

arregloEjemplo.push(69);//Este metodo nos permite agregar un elemento al final del arreglo
console.log("Agregando elementos al final 69 con el metodo push");
console.log(arregloEjemplo);//De esta forma imprimimos todo el arreglo

arregloEjemplo.unshift(77);//Este metodo nos permite agregar un elemento al inicio del arreglo
console.log("Agregar elemento al inicio del 77 arrelgo");
console.log(arregloEjemplo);


//Metodos inversos de push y unshift

arregloEjemplo.shift();//Este metodo elimina el primer objeto del arreglo
console.log("Elimina el primer objeto del arreglo");
console.log(arregloEjemplo);


arregloEjemplo.pop();//Nos permite eliminar el ultimo objeto del arreglo
console.log("Elimina el ultimo objeto del arreglo");
console.log(arregloEjemplo);

console.log("--------------Iteracion de un arrelgo----------------")
//Iteracion de los arreglos

var ArregloParaIteracion = [1,2,3]
for(var a = 0; a<ArregloParaIteracion.length; a++){
    console.log("Pocision numero " + a + " del arreglo." )
    console.log(ArregloParaIteracion[a]);
}