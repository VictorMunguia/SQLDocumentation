puts "Escribe un numero"
numero_dividir = gets.chomp

numero_dividir = numero_dividir.to_i

residuo = numero_dividir % 2


if residuo == 0
  puts "#{numero_dividir} es par"
else
  puts "Nel #{numero_dividir} no es par"
end
