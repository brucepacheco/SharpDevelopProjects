'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 28/09/2014
' Hora: 09:22 p.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Module Program
	Sub Main()
		Dim edades() As Integer={23,15,18,19,34,67,37,45,17,11,7,11}
		Dim buscar As Integer
		Dim posicion As Integer=0
			console.WriteLine("de la edad a buscar")
			buscar=console.ReadLine()
			For i As Integer=0 To 11
				If edades(i)=buscar 
					console.WriteLine("Se encontro en la posicion {0}",i)
				End If
			Next i
			console.ReadLine()
	End Sub
End Module
