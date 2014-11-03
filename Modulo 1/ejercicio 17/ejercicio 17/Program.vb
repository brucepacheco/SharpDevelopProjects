'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 30/09/2014
' Hora: 04:48 p.m.
' 
' Leer un vector de 10 elementos enteros
' y ubicar el más pequeño en la primera posición.
'
Module Program
			
	Sub Main()										
		Dim valores(9) As Integer
		Dim i As Integer
		Dim k As Integer
		
		For k=0 To 9
			console.Write("Escriba un valor en {0}:",k)
			valores(k)=CInt(console.ReadLine())
		Next k	
		Dim menor As Integer=valores(0)
		For i=0 To 9
				If valores(i)<menor Then
					menor=valores(i)
				End If
		Next i
		Dim j As Integer
		j=(menor=valores(0))
			Console.WriteLine("El numero mas pequeño es {0} y la posicion en la que se coloco es {1}",menor,j)

			Console.Write("Press any key to continue . . . ")
			Console.ReadKey(True)
	End Sub
End Module

