var Nombre = "Victor";//Una simple variable con mi nombre

var cadena = "Hola " + Nombre ;//En esta variable estamos concatenando mi nombre con el texto Hola

console.log("----Imprecion de la cadena----");
console.log(cadena);//Imprimimos la variable

console.log("----Imprecion del tamaño de la cadena----");
console.log(cadena.length)//Esta funcion cuenta el tamaño de la cadena, en esta suma tambien cuenta los espacios en blanco

console.log("----Condicion de indexOf----");
if(Nombre.indexOf("Victor") != -1){ //IndexOf es un metodo que nos permite comprobar si el texto que pongamos dentro es igual al que tenemos en la variable, si no se encuentra imprime -1, si si se encuentra no imprime nada, esto compara toda la cadena de texto, si algo se parece entonces lo da como que lo encontro.
    console.log("Eres Victor Munguia")
}
else{
    console.log("No eres Victor Munguia")
}

/* Las variables que son cadenas tienen la posibilidad de ser arreglos realmente*/
console.log("----Primera letra de mi variable Nombre----");
console.log(Nombre[0]);
console.log("----Segunda letra de mi variable Nombre----");
console.log(Nombre[1]);
console.log("----Ulima letra de mi variable Nombre----");
console.log(Nombre[Nombre.length-1]);
console.log("----Ulima letra de mi variable Nombre----");
console.log(Nombre[Nombre.length-1]);
console.log("----Obtener segunda posicion con el metodo charAT----");
console.log(Nombre.charAt(1));


console.log("----Sustitucion de la letra V en victor por S----");
var NombreModificado = Nombre.replace("V","S");
console.log(NombreModificado);

console.log("----Sustraccion de cadena----");
console.log(Nombre.slice(3,4));//No imprime la t ya que inicia a contar desde 0, el primer valor es donde vamos a comenzar y el segundo hasta donde vamos a llegar

console.log("----Todo a mayusculas----");
console.log(Nombre.toUpperCase());//LowerCase y Uppercase son metodos para convertir el contedio del texto en mayusculas o minusculas
console.log("----Todo a minusculas----");
console.log(Nombre.toLowerCase());