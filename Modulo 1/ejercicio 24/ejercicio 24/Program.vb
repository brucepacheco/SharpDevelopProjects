'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 30/09/2014
' Hora: 08:58 p.m.
'
' Hallar el valor que más se aproxime a un número dado, dentro del vector de 20 elementos que se muestra:
' dim valores() as integer={5,6,19,20,21,23,34,35,47,58,61,79,42,100,200,230,240,500,600,620}
Module Program
	Dim valores() As Integer={5,6,19,20,21,23,34,35,47,58,61,79,42,100,200,230,240,500,600,620}
	Dim hallar As Integer
	Dim posicion As Integer=0
	
	Sub darNumero()
		console.Write("Escriba el valor: ")
		hallar=CInt(console.ReadLine())
	End Sub
	
	Sub hallarValor()
		For i As Integer=0 To 19
			If valores(i)=hallar-1 
				console.WriteLine("El valor que más se aproxima es {0}",valores(i))
			End If
		Next i		
	End Sub
		
	Sub Main()
		darNumero()
		hallarValor()
				
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
