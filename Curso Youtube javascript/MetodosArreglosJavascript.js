var arreglo1 = [6,2,9,3,5,1,10];

arreglo1.sort();//Este metodo ordena los valores de un arreglo pero por orden alfabetico.

console.log("Ordenado de arreglo con sort sin funcion, solo el puro metodo sort")
console.log(arreglo1);


//Ordenado de un arreglo con una funcion y de manera tradicional

var arreglo2 = [6,2,9,3,5,1,10];

function ordenarParaSort(a,b){
    if(a > b){
        return 1;
    }
    else if(b > a){
        return -1;
    }
    else if(a == b ){
        return 0;
    }
}


function ordenarParaSort2(a,b){//Este metodo funciona igual que el primero pero es mas lijero
    return a-b;
}

console.log("Metodo sort con la funcion que necesita para imprimir el arreglo de manera ordenada");
arreglo2.sort(ordenarParaSort2);//Para que sort funcione con ordenacion por los numeros necesitamos proporcionarle esa funcion.
console.log(arreglo2);



console.log("Metodo para voltear el arrelgo")
arreglo2.reverse();//Metodo para darle la vuelta a un arrelgo
console.log(arreglo2);


//Declaracion de un arreglo desde un string proporcionado

var ArregloDesdeUnString = "Victor,Corey,Willer".split(",");//split pone una separacion entre cada parte del string para detectar cada objeto del arrelgo

console.log("Arrelgo que antes fue una cadena string");
console.log(ArregloDesdeUnString);

//El metodo join nos permite convertir lo que es un arreglo en string, poniendo entre comillas la separacion por la que se va a definir cada objeto
ArregloDesdeUnString = ArregloDesdeUnString.join("-");

console.log("Arreglo que ahora es una cadena string.");
console.log(ArregloDesdeUnString);