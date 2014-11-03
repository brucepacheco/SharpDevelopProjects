'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 30/09/2014
' Hora: 06:49 p.m.
'
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Module Program
	Sub Main()
		Dim r As Boolean=True
		
		For x As Integer = 1 To 100
		r=True
			For i As Integer = 2 To x - 1
				If x Mod i=0 Then
					r=False
				End If
			Next
				If r=True Then
					console.WriteLine(x)
				End If
			Next
				Console.Write("Press any key to continue . . . ")
				Console.ReadKey(True)
	End Sub
End Module
