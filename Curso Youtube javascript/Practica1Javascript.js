var NumeroMaximo = 100;//Declaramos numero maximo
var NumeroMinimo = 1;//Declaramos numero minimo

var NumeroSecreto = Math.random() * (NumeroMaximo-NumeroMinimo) + NumeroMinimo;//Creamos un numero randon, sabemos que por als variables este numero estara entre  1 y 100

NumeroSecreto = parseInt(NumeroSecreto);//Convertimos el resultado en un numero entero

console.log(NumeroSecreto);//Imprimimos el numero magico en la consola

var Mensaje = "Ingresa un numero";//Esta es una variable tipo string que representara el mensaje del prompt(como una alerta pero con una caja de texto)

while(true){//Este es un ciclo while infinito
    var NumeroDelUsuario = prompt(Mensaje,"0");//Lo primero es crear una variable que va a almacenar lo que el usuario ponga en el prompt

    NumeroDelUsuario = parseInt(NumeroDelUsuario);//El prompt retorna objetos tipo string por lo que es necesario convertilos a int

    if(NumeroDelUsuario === NumeroSecreto){//Comparamos el numero que el usuario escribio con el magico, si son iguales quebramos el ciclo con break
        alert("AAAAAAHHHHHHH PERRO GANASTE, ESE ERA EL NUMERO SECRETO");
        break;
    }
    else if(NumeroDelUsuario > NumeroSecreto)//Si el numero es mayor al numeor magico cambiamos el valor dle mensaje del promp por el siguiente
    {
        Mensaje = "Lo sentimos, este numero es mayor que el numero magico"
    }
    else if(NumeroDelUsuario < NumeroSecreto){//Lo mismo que arirba pero en caso de que sea menor
        Mensaje = "Lo sentimos, el numero que ingresaste es menor al numero magico"
    }
}