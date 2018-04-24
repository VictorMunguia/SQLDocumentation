#el operador && significa AND , ambas cosas tienen que estar en verdadero para retirnar verdadero
resultadoOperador = (10 > 5) && (5 < 8)

puts resultadoOperador

#este operador, con cualquiera que de verdadero returna un verdadero, en este caso ambas son falsas retorna falso
resultadoOperador = (10 < 5) || (5 > 8)

puts resultadoOperador

#Funciona igual que el && pero es recomendable usar los simbolos no la palabra
resultadoOperador = (10 > 5) and (5 < 8)

puts resultadoOperador

#Utilizar el ! en un resultado de verdadero o falso lo engamos, si es verdadero sera falso y viceversa
resultadoOperador = (10 < 5) or (5 > 8)

puts resultadoOperador

resultadoOperador = (10 > 5) && (20 > 10)

puts !resultadoOperador;
