//Los closures son funciones padres que dentro manejan otras funciones, las avriables que se definen dentro no pueden ser usadas fuera.
function padre(nombreReceptor){//Paso dos se ejecuta esta funcion junto a lo ultimo

    function hija(){//Paso tres se ejecuta est funcion

        alert("Hola " + nombreReceptor)

    }

    hija()//Esto es parte del paso dos
}

padre("Corey Wilde");//Paso uno mandamos a llamar la funcion padre y mandamos el parametro