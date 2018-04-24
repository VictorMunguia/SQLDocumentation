#Recordar que gets recoge el valor del usuario, chomp le quita el espacio que se mete y to_i lo convierte a int por que el valor es string
puts "Inserte 1 numero: "

numero_1 = gets.chomp.to_i

puts "Inserte otr numero: "

numero_2 = gets.chomp.to_i

#Este es el if de toda la vida
if numero_1 > numero_2
  puts "El numero #{numero_1} es mayor que #{numero_2}"
else
  puts "El numero #{numero_2} es mayor que #{numero_1}"
end
#------------------------------------------
#el unless es... almenos que, utilizado solo en 1 sola linea de codigo, el if puede trabajar igual pero no es
#recomendable usarlo asi, unless solo se ejecuta si retorna falso, en el caso de abajo se ejecutara la linea
#puts solo si unless es falso
puts "Inserte su edad"
edad = gets.chomp.to_i

puts "No puedes pasar eres menor de edad" unless edad > 18
