var matris ; 
var sumaDiagonalPrincipal = 0;
var sumaDiagonalSecundaria = 0;


matris = [[4,7,8,1],[5,4,8,4],[7,1,1,9],[1,8,1,1]];


//Suma de la primera diagonal
for(var i = 0; i <matris.length ; i++){
	sumaDiagonalPrincipal = sumaDiagonalPrincipal + matris[i][i];
	//Suma de la segunda diagonal
	sumaDiagonalSecundaria = sumaDiagonalSecundaria + matris[matris.length-1-i][i];
}

document.write("La suma de la diagona principal es: ",sumaDiagonalPrincipal);


//Salto de linea
document.write('<br>');




document.write("La suma de la diagona secundaria es: ",sumaDiagonalSecundaria);

//Salto de linea
document.write('<br>');

var ValorTotal = Math.abs(sumaDiagonalPrincipal - sumaDiagonalSecundaria);

//Resta de ambas diagonales
document.write("La resta de ambas diagonales es: ", ValorTotal);






