'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 30/09/2014
' Hora: 11:06 a.m.
' 
' Leer un vector de 10 elementos enteros
' y escribir cuantas veces aparece el número 0.
'
Module Program
	Dim v(9) As Integer		
	Sub Main()
		Dim i As Integer
		Dim elementos As Integer=0
		console.Write("Indique el primer elemento: ")
		v(0)=CInt(console.ReadLine())
		console.Write("Indique el segundo elemento: ")
		v(1)=CInt(console.ReadLine())
		console.Write("Indique el tercer elemento: ")
		v(2)=CInt(console.ReadLine())
		console.Write("Indique el cuarto elemento: ")
		v(3)=CInt(console.ReadLine())
		console.Write("Indique el quinto elemento: ")
		v(4)=CInt(console.ReadLine())
		console.Write("Indique el sexto elemento: ")
		v(5)=CInt(console.ReadLine())
		console.Write("Indique el septimo elemento: ")
		v(6)=CInt(console.ReadLine())
		console.Write("Indique el octavo elemento: ")
		v(7)=CInt(console.ReadLine())
		console.Write("Indique el noveno elemento: ")
		v(8)=CInt(console.ReadLine())
		console.Write("Indique el decimo elemento: ")
		v(9)=cint(console.ReadLine())
		For i=0 To 9
			If v(i)=0 
				elementos=elementos+1
					console.WriteLine("EL cero aparece en las posiciones {0}",i)
			End If			
		Next i
			console.ReadLine()
	End Sub
End Module
