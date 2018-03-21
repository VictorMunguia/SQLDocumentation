var contador = 0;
var contador2 = 0;
var contador3= 0;

console.log("----While imprecion de los numeros del 1 al 10 ----");
while(contador < 10){
    contador ++;
    console.log(contador);
}

console.log("----While utilizando palabra reservada continuo ----");
while(contador2 < 10){
    contador2 ++;
    if(contador2 % 2 != 0){
        continue;// continue lo que hace es saltar el resto de codigo del ciclo para pasar ala siguiente iteracion.
    }
    else{
        console.log(contador2); 
    }

}


console.log("----DO WHILE----");

do{
    contador3 ++;
    console.log(contador3);
}while(contador3 < 10);//En este ciclo al menos 1 vez lee todo el contenido del ciclo.