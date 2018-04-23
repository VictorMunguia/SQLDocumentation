class Persona {
  constructor() {
    this.viva = true;
    this.Espada = false;
  }
}

function llenarArreglo(){
  var numeroPersonas = 10;//Este numero no debe ser estatico;
  var circuloPerosnas = [];

  for (var i = 0; i < numeroPersonas; i++) {

    circuloPerosnas[i] = new Persona();
  }

  console.log(circuloPerosnas);

  funcion guerra(arreglo){
      arreglo.forEach(funcion(elemento,index,arreglo){
        arreglo[index] = elemento.viva = false;

      });

      console.log(circuloPerosnas);
  }

  guerra(circuloPerosnas);
}

llenarArreglo();
