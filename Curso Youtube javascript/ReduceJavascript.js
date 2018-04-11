var letras = ["H","0","L", "A"];


var PalabraCompleta = letras.join("");//Recordar que join es para unir letras en un arreglo

console.log("Arreglo unido con join")
console.log(PalabraCompleta);

var letras2 = ["H","0","L", "A"];



var PalabraCompleta2 = letras2.reduce(function(valor_anterior_retornado,valor_actual,index,arreglo){
    return valor_anterior_retornado + valor_actual;//Esto funciona con iteracion.
})


console.log("Metodo con reduce para unir palabras")
console.log(PalabraCompleta2);


//---------------------Sumar todos los valores de un arreglo


var Numeros = [20,1,23,1,5];

var SumaArreglo = Numeros.reduce(function(valor_anterior_retornado,valor_actual,index,arreglo){
    return valor_anterior_retornado + valor_actual;//El primer valor es como unas migas de pan, obtiene el rastro que llevamos de la anterior iteracion, si en la primera sumaste 5 + 5 en la siguiente va a sumar 10 + 5
})

console.log("Meotdo para sumar los valores d eun arreglo");
console.log(SumaArreglo);


var Numeros2 = [20,1,23,1,5];

var SumaArreglo2 = Numeros2.reduce(function(valor_anterior_retornado,valor_actual,index,arreglo){
    return valor_anterior_retornado + valor_actual;//El primer valor es como unas migas de pan, obtiene el rastro que llevamos de la anterior iteracion, si en la primera sumaste 5 + 5 en la siguiente va a sumar 10 + 5
},50)
//De esta forma podemos darle un valor a valor anterior retornado la primera vez que hacemos la iteracion, ya que al inicio no vale nada

console.log("Meotdo para sumar los valores d eun arreglo");
console.log(SumaArreglo2);