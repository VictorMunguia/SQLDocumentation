//---- Crear Nodo 1
//crear elementos
var cajaCreada1 = document.createElement('div');
var contenido1 = document.createTextNode('Victor Munguia');
//Juntar el texto con la caja
cajaCreada1.appendChild(contenido1);
//Agregarle atributos a la caja
cajaCreada1.setAttribute('class', 'caja');
// Sacar la ubicacion del documento
var contenedor = document.getElementById('contenedorCaja');
//Meter la caja creada al contenedor
contenedor.appendChild(cajaCreada1);


function Suma(a,b) {
  return a + b;
}






var cajaCreada2 = document.createElement('div');
var contenido2 = document.createTextNode(Suma(10,15));
//Juntar el texto con la caja
cajaCreada2.appendChild(contenido2);
//Agregarle atributos a la caja
cajaCreada2.setAttribute('class', 'caja');
// Sacar la ubicacion del documento
var contenedor = document.getElementById('contenedorCaja');
//Meter la caja creada al contenedor
contenedor.appendChild(cajaCreada2);