#Los arreglos son estructuras de datos muy basicas.

#Asi se inicialisa arreglos vacios
arregglo = []

#Al inicializar un arreglo utilizando el %w no tienes que poner comas.
arreglo_sin_comas = %w[ 1 50 "Hola mundo"]

#Puedes meterle de todo en un arreglo
arregglo2 = [3,"Perro", true]

#Inicialisando arreglo como objeto, recordar que todo en ruby es un objeto, esto inicializa un arreglo de 5 posiciones vacias.
arregglo_Objeto = Array.new(5)

#Para acceder a cada parte del arreglose hace de esta forma.

puts arregglo2[1] #Recordar que siempre se inicia por 0, 1, 2, en este caso retornara "Perro"

#En ruby las dimenciones del arreglo no son definidas, si tu retornas o guardas informacion en espacios que no fueron definidos al inicio, el arreglo crece.

arregglo2[3] = 69
arregglo_Objeto[8] = 69

puts arregglo2
puts arregglo_Objeto 


