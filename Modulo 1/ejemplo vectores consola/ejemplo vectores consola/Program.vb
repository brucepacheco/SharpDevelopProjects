'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 28/09/2014
' Hora: 08:38 p.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Imports System.IO
Module Program
	Sub Main()
		Dim v(10) As Integer
		Dim i,x As Integer
		'ejemplo 1
		v(0)=10 'asigna 10 a la posicion 0
		'muestra todas las posiciones del vector
			console.WriteLine("Ejemplo 1, el vector contiene: ")
		For i=0 To 9
			console.WriteLine("Posicion {0} tiene {1}",i,v(i))
		Next i
			console.WriteLine("presione enter para continuar...")
			console.ReadLine()
		'ejemplo 2
		console.Write("de un numero (entre 0 y 9)")
		console.Write("que sera la posicion donde se guardara un 24 :")
		Dim j As Integer
		j=CInt(console.ReadLine()) 'Lee
		v(j)=24 'asigna 24 a las posiciones del vector
		console.WriteLine("ejemplo 2 El vector contiene: ")
		For i=0 To 9
			console.WriteLine("Posicion {0} tienes {1}",i,v(i))
		Next i
		console.WriteLine("Presione enter para continuar...")
		console.ReadLine()
		'
		console.writeline("Otro ejemplo para mostrar el contenido del vector")
		For Each x In v
			console.WriteLine("{0}",x) 'muestra todo
		Next
		console.ReadLine()
	End Sub
End Module
