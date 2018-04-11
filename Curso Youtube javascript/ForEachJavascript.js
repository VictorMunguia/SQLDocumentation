var numeros = [2,4,6,8];


numeros.forEach(function(elemento,index,arreglo){//FoerEach funciona igual que los anteriores metodos, pide 3 parametros los cuales se usaran en la funcion
    arreglo[index] = Math.pow(elemento,2);//Sustituimos el nombre del arreglo con los elementos que tenemos
});


console.log(numeros);