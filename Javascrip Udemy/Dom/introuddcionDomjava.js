//document= se refiere a todo el documento
//getElementsByTagName se refiere a sacar las etiquetas.

//var caja = document.getElementsByTagName('div');
var caja = document.getElementsByClassName('caja');

var caja1 = document.getElementById('primeraCaja');

//caja1.textContent = 'Hola Mundo';

//caja1.innerHTML = '<h1> Hola </>';

//---- Crear Nodos
//crear elementos
var cajaCreada = document.createElement('div');
var contenido = document.createTextNode('Hola Mundo');
//Juntar el texto con la caja
cajaCreada.appendChild(contenido);
//Agregarle atributos a la caja
cajaCreada.setAttribute('class', 'caja naranja');
// Sacar la ubicacion del documento
var contenedor = document.getElementById('contenedorCaja');
//Meter la caja creada al contenedor
contenedor.appendChild(cajaCreada);
