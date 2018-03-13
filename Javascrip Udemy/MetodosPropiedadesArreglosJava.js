var amigos = ['Victor','Corey','Samanta','Sam'];

// -- Metodo lenght para medir arreglos
document.write(amigos.length);
document.write('<br>');

// -- Metodo join juntar todo el arreglo y mostrarlo en una cadena de texto
//document.write(amigos.join('-'));

//Podemos meter en una variable el valor de los metodos
var cadenaTodosLosAmigos = amigos.join('<br>');
document.write(cadenaTodosLosAmigos);


// -- Metodo Pop y push: pop nos permite eliminar el ultimo elemento de un arreglo y push podemos agregar un elemento al final del arreglo

//amigos.pop();
//amigos.push('Reiben');
//console.log(amigos);

// -- Metodo shift y unshift son elementos que funcionan igual que pop y push pero con los elementos del inicio

//amigos.shift();
//amigos.unshift();
//console.log(amigos);

// -- Metodo concat Nos permite concateniar dos arreglos

//var amigos2 = ['Felipe', 'Oscar'];
//var todosMisAmigos = amigos.concat(amigos2);
//console.log(todosMisAmigos);

// -- Metodo Sort Reverse nos permite ordenar nuestros elementos de forma alfabetica

amigos.sort();
//Pone los elemento al reves, es decir de inicio a fin
amigos.reverse();
console.log(amigos);