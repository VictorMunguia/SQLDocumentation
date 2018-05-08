#Declaramos una variable y esta misma se compara para comprobar si el usuario es visitante o tutor
user = "victor"

if user == "victor"
  puts "Tutor"
else
  puts "visitante"
end


#De esta forma rescribimos el codigo de arriba utilizando if y then, de esta forma tenemos todo en una sola linea


puts (if user == "victor" then "Tutor" else "Visitante" end)


#Tambien ponemos meter el resultado en una variable, esta variable puede ser impresa mas adelante
#Podemos ordenar el if como nosotros queramos y sea mas entendible

respuesta = if user = "victor" then "Tutor"
else
  "Visitante"
end

puts respuesta


#operador ternario: si_condicion_verdadero ? entonces_resultado : si_no_esto

puts user = "Corey" ? "Tutor" : "Visitante"
