function main(callback/*Esto que resive aqui tiene que ser una funcion, en este caso es la funcion greeting*/){
    alert("Primero hago algo y luego ejecuto el callback");
    callback();//Aqui mandamos a llamar la funcion callback que como se inicialiso abajo es la funcion greeting
}

function greeting(){//Este es el callback que se ejecuta cuando neustra primera funcion termina de hacer todo
    alert("Yo soy un callback!");
}


main(greeting);//En esta funcion le estamos pasando de aprametro

//--------------------------------------------------------------------------------------------------------------------------
//Esto es lo mismo que arriba pero la funcion la pasamos mas directo
function main2(callback){
    alert("Primero hago algo y luego ejecuto el callback");
    callback();
}

main2(function(){//Dentro del parentecis donde metemos los parametros literalmente metemos la funcion, asi le pasamos de parametro una funcion a nuestra funcion principal
    alert("Otro Callback");
})


//--------------------------------------------------------------------------------------------------------------------------

function userName(callback){
    var name = prompt("Cual es tu nombre ? ");
    callback(name);
}

function buildGreeting(name){
    alert("Hola " + name);
}

userName(buildGreeting);


//--------------------------------------------------------------------------------------------------------------------

function math(a,b,callback){
    var res = a + b;

    callback(res);
}

function suma(res){
    if(res > 10){
        alert("El resultado es mayor a 10: "+ res)
    }
    else{
        alert("El resultado es menor a 10: " + res)
    }
}


math(5,3,suma)
