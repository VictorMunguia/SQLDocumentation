#IO es igual a input y Output es salida.

#Programa que pide tu nombre y lo imprime. puts imprime y agrega un salto de linea y print no, print solo imprime. 

puts "Ingresa tu nombre" 

nombre = gets
#chomp permite quitar el ultimo caracter de un string
nombre = nombre.chomp

puts "Hola #{nombre}"

puts "#{nombre} tiene #{nombre.length} letras"