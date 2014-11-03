'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 28/09/2014
' Hora: 09:04 p.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Imports System.IO
Module Program
	Dim valores() As Integer={3,2,4,1,5,2,6,7,2,3,4,5,6,1,2,3,4,5,6,2}
	Dim digitos(10) As Integer
	Sub Main()
		Dim i As Integer
		For i=0 To digitos.Length-1
			'limpiar los contadores
			digitos(i)=0
		Next i
		For i=0 To valores.Length-1
			digitos(valores(i))=digitos(valores(i))+1
		Next i
		For i=0 To 9
			console.writeline("Son {0} ocurrencias de {1}", digitos(i),i)
		Next i
			console.ReadLine()
	End Sub
End Module
