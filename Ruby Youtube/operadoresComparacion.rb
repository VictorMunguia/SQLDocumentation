#Mayor que o menor que, devuelve falso o verdadero.

puts 5 > 3

puts 5 < 3

#Mayor o igual que, menor o igual que.

puts 5 <= 5

#Esto devuelve 3 posibles valores. en caso de que ambos sean iguales da 0, el primero sea mayor devuelve 1 y el segundo mayor que el primero -1.

puts 5 <=> 5
puts 6 <=> 5
puts 5 <=> 6

#Igual que pero solo comparan valor no mismo tipo

puts 10 == 10
puts 10 == 11
puts "Hola" == "Hola"

#Comparar que contengan el mismo valor y que sean del mismo tipo

puts 1.eql?(1.0) #Esto retorna falso por que no son del mismo tipo

