'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 30/09/2014
' Hora: 08:40 p.m.
' 
' En un vector de 20 elementos enteros
' que contiene cada elemento un digito entre 0 y 9,
' cuente cuantas veces aparece cada digito
' en el vector.
'
Module Program
	Dim elementos() As Integer={5,8,9,7,8,8,7,2,2,4,7,9,1,4,5,7,1,3,1,5}
	Dim digitos(19) As Integer
	Sub contar()
		Dim i As Integer
		For i=0 To digitos.Length-1
			digitos(i)=0
		Next i
		For i=0 To elementos.Length-1
			digitos(elementos(i))=digitos(elementos(i))+1
		Next i
	End Sub
	Sub mostrar()
		For i=0 To 9
			console.WriteLine("aparece {0} veces el numero {1}",digitos(i),i)
		Next
	End Sub
	Sub Main()
		contar()
		mostrar()
			Console.Write("Press any key to continue . . . ")
			Console.ReadKey(True)
	End Sub
End Module
