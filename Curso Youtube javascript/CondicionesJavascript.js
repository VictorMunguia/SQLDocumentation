var numero_uno = 23;

var numero_dos = 30;

console.log("----Simple condicion de igualdad----")
if(numero_uno == numero_dos){
    console.log("Numeros iguales")
}
else{
    console.log("Numeros diferentes")
}

console.log("----Simple condicion de mayor que----")
if(numero_uno > numero_dos){
    console.log("La condicion es verdadera");
    
}
else{
    console.log("La condicion es falsa");
}


var NumeroComparacionIgualdadUno = 30;
var NumeroComparacionIgualdadDos = "30";

console.log("----Condicion de igualdad con 3 iguales----")
if(NumeroComparacionIgualdadUno === NumeroComparacionIgualdadDos){//En esta condicion utilizamos el triple igual, esto lo que hace es comparar los datos pero tomando en cuenta el tipo de dato que es.
    console.log("Los numeros son iguales");
}
else{
    console.log("Los numeros son diferentes")
}
/* Operadores logicos
> mayor que
< menor que
|| OR
&& AND
== Igual sin enbargo en javascrip convierte los datos al mismo tipo
=== Compara los valores, pero toma en cuenta los diferentes tipos de dato
!= Diferente
!==
!
*/