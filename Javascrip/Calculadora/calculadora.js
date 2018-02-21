var numero1 = 0;
var numero2 = 0;
var resultado = 0;


function suma(){
	numero1 = parseFloat(document.getElementById('numero1').value);
	numero2 = parseFloat(document.getElementById('numero2').value);
	resultado = numero1 + numero2;

	document.getElementById('resultado').value = resultado;
}