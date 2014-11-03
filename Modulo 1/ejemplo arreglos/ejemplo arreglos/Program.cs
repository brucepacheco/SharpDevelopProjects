Imports System.io
module ejemplo
sub main()
dim v(10) as integer
Dim i,x As Integer
'ejemplo 1
v(0)=10 'asigna 10 a la posicion 0
'muestra todas las posiciones del vector
console.WriteLine("ejemplo 1 El vector v contiene:")
for i=0 to 9
console.writeline("posicion {0} tiene {1}",i,v(i))
Next i
console.WriteLine("presione enter para continuar...")
console.ReadLine()
'ejemplo2
console.write("de un número (entre 0 y 9)”)
console.write(" que será la posición donde se guardará un 24 :")
dim j as integer
j=CInt(console.readline()) 'lee
v(j)=24 'asigna 24 a la posicion que indique j
'muestra todas las posiciones del vector
console.WriteLine("ejemplo 2 El vector v contiene:")
for i=0 to 9
console.writeline("posicion {0} tiene {1}",i,v(i))
Next i
console.WriteLine("presione enter para continuar...")
console.ReadLine()
'
console.writeline("Otro ejemplo para mostrar el contenido del vector")
for each x in v
console.writeline("{0}",x) 'muestra todo
Next
console.ReadLine()
end sub
end module