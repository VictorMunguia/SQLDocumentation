function nombre_funcion(){
    //creas la funcion con la palabra reservada funcion, seguido del nombre de la funcion, despues los
    //parametros que podria llevar o no, finalizado de las llaves.
}


function suma(a,b){//basica funcion que pide dos parametros que va a sumar
    return a+b;
}

function resta(a,b){//Basica funcion de resta que pide dos parametros
    return a-b;
}

function multiplicacion(){//Basica funcion de multiplacion que no pide parametros
    var x = 6;
    var y = 4;

    return x*y;
}
//Si no pasamos parametros a una funcion no da erro, pero retornara Nah.
//Si pasamos solo 1 valor la funcion nos retornara undefined , estos dos solo aplican con ES5.
var ResultadoResta = resta(10,5);

console.log("Funcion mandada a llamar y almacenada en una variable.");
console.log(ResultadoResta);

console.log("Mandando a llamar la funcion suma con un console.log");
console.log(suma(8,2));//al poner la funcion aqui nos va a retornar el valor de suma


//Funciones ejecutadas dentro de otras funciones

//Almacenamos la funcion multilpicar en una variable
var variableAlmacenaFuncion = multiplicacion();

//creamos una funcion que resiva como parametros una funcion y retornamos esa funcion que resive
function EjecutarFuncion(funcion){
    return funcion;
}

console.log("Funcion siendo llamada por otra funcion");
console.log(EjecutarFuncion(variableAlmacenaFuncion))//Mandamos a llamar la fucnion que ejecuta funciones y dentro de parametros ponemos la variable que trae guardada la otra funcion