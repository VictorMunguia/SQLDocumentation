#Crearemos un sistema donde veamos las calificaciones primero con if


print "Dame tu calificacion"
calificacion = gets.chomp.to_i

if calificacion == 10 || calificacion == 9
  puts "Muy bien!!!!"
elsif calificacion == 8
  puts "Bien pero puedes mejorar"
elsif calificacion == 7
  puts "Esperaba mas de ti"
elsif calificacion == 6
  puts "Vales verga en la vida"
elsif calificacion <= 5
  puts "Maldito aborto estas en la primaria no mames"
end



#Ahora vamos a creear este mismo sistema pero utilizando el case

case calificacion
when 10
  puts "Muy bieeeeen"
when 9
  puts "Muy bieeeeen"
when 8
  puts "Bien echo pero puedes mejorar"
when 7
  puts "esperaba mas de ti"
when 6
  puts "Vales verga en la vida"
when 5
  puts "Maldito reprobaste la primaria"
else
  puts "u.u"
end
