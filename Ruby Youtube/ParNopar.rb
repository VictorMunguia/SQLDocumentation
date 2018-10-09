puts "Escriba un numero"

#quitamos el ultimo caracter de la cadea que es un salto de linea
numero = gets.chomp
#convertimos el numero a int ya que todo lo que se mete por gets es string.
numero = numero.to_i

decision_par_nopar = numero % 2

if decision_par_nopar == 0
    puts "#{numero} es par"
else
    puts "#{numero} no es par"
#Ponerlo al final de cada if
end