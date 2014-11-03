'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 30/09/2014
' Hora: 10:39 p.m.
' 
' suponga dos vectores de tamaño 10 (A[] y B[]), 
'escriba un programa que sume las posiciones.
'Pares del vector a con las impares del vector b
'y muestre el resultado en pantalla. 
Module Program
	Dim a() As Integer = {15,10,22,31,54,66,31,55,88,61}
	Dim b() As Integer = {1,5,45,12,17,21,31,25,61,2}
	Dim c(9) As Integer
	
	Sub sumar()
		Dim i As Integer
		For i=0 To 9
			c(i)=a(i)+b(i)
				console.WriteLine("La suma es {0}",c(i))
		Next i 
			
	End Sub
	
	
	Sub Main()
		sumar()
				
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
