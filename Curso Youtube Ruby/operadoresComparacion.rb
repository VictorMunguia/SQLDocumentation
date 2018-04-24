numero_1 = 10;
numero_2 = 5;

#Operador > es mayor que. < menor que.
if numero_1 > numero_2
  puts "Numero #{numero_1} es mayor que #{numero_2}"
else
  puts "Numero #{numero_2} es mayor que #{numero_2}"
end

#Operador >= es mayor o igual que. <= menor o igual que.
if numero_1 >= numero_2
  puts "Numero #{numero_1} es mayor o igual que que #{numero_2}"
else
  puts "Numero #{numero_2} es mayor o igual que #{numero_2}"
end


#Operador <=> en caso de que los nuemros sean iguales devuelve 0, si el primer numero es mayor devuelve 1, si el segundo es mayor devuelve -1.
numero_3 = 11
numero_4 = 9

resultadoComparacion = numero_3 <=> numero_4

if resultadoComparacion == 0
  puts "Los numeros son iguales"
elsif resultadoComparacion == 1
  puts "El #{numero_3} es mayor que #{numero_4}"
elsif resultadoComparacion == -1
  puts "El #{numero_4} es mayor que #{numero_3}"
end


#Operador == compara si los valores son iguales o en caso de string compara si las palabras son iguales y el != en caso de que sean diferentes.
if numero_1 == numero_2
  puts "Numero #{numero_1} es igual que #{numero_2}"
else
  puts "Numero #{numero_2} es diferente #{numero_2}"
end
