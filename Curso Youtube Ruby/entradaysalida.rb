=begin
-El metodo puts nos permite imprimir informacion en ruby con la terminal

-print tambien nos permite imprimir informacion pero no imprime un salto de linea,
se le puede meter todo tipo de datos igual que puts
=end

nombre_usuario = "Victor Munguia"

puts nombre_usuario;

print nombre_usuario;

=begin
-gets es un metodo que nos permite recopilar informacion dle usuario
=end
puts "Escribe tu nombre: ";
nombre_usuario_personalisado = gets;


puts "Hola " + nombre_usuario_personalisado;

puts "----------------------------------------------------";

=begin
-De esta forma podemos decir le al usuario cuantas letras tiene tu nombre.
=end
puts "Hola, pon tu nombre y contaremos el tamaño";

nombre_usuario_personalisado_contar_letras = gets;
=begin
-El metodo chomp nos permite eliminar el espacio de linea que se hace cuando ponemos
nuestro nombre y haci el metodo length puede contar bien el tamaño del nombre.

-En este ejemplo estamos utilizando el otro metodo de concatenar datos
=end
nombre_usuario_personalisado_contar_letras = nombre_usuario_personalisado_contar_letras.chomp;

puts "Tu nombre es: #{nombre_usuario_personalisado_contar_letras}"
puts "Tu nombre tiene: #{nombre_usuario_personalisado_contar_letras.length} letras"
