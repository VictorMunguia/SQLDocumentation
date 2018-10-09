puts "Ingresa tu calificacion (1-10)"

calificacion = gets.chomp.to_i

#Puedes omitir todos los puts de esta forma....

=begin
puts case calificacion
when 10,9
     "Muy bien, eres cabron"
when 8
     "Puedes mejorar"
when 7
     "Estas medio wey pero pasaste"
when 6
     "Te mamaste, muy mal"
else
     "Reprobaste u.u"
end
=end

case calificacion
when 10,9
    puts "Muy bien, eres cabron"
when 8
    puts "Puedes mejorar"
when 7
    puts "Estas medio wey pero pasaste"
when 6
    puts "Te mamaste, muy mal"
else
    puts "Reprobaste u.u"
end