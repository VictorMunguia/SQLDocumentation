=begin
-Las cadebas son el grupo de informacion que estan encerradas en comillas simples
o entre doble comilla.
=end

nombre_usuario = "Víctor Munguia";


puts nombre_usuario;

=begin
-Concatenar cadenas funciona igual, ponemos primero el texto y despues con el
operador suma ponemos la otra variable y concatenamos el nombre.
=end

puts "Munguia Enciso " + nombre_usuario;

=begin
-Podemos interpolar informacion, es algo popular en ruby
para interpolar tenemos que poner #{} dentro de una cadena string

-Podemos interpolar cualquier tipo de informacion
=end
numero_interpolar = 21

puts "Munguía Enciso #{nombre_usuario}, Mi edad es: #{numero_interpolar}";

=begin
-Podemos usar upcase para poner todo en mayuscula una variable que contiene informacion
en formato texto
=end
puts "Munguia Enciso #{nombre_usuario.upcase}, Mi edad es: #{numero_interpolar}";

=begin
-Cuando imrpimimos con comilla doble los caracteres especiales se interpretan,\n nos permite
hacer un corte de linea hacia abajo y el \t nos permite realizar un tabulador.

-Cuando imrpmimos con comillas simples nos permite no darle valor a los caracteres especiales
lo que permite imprimir los como si fuerantexto
=end
puts "Esta es la prueba de caracters inprimibles \n \n \n \t Hola"
puts 'Esta es la prueba de caracters inprimibles \n \n \n \t Hola'
