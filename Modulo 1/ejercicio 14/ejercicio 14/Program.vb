'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 28/09/2014
' Hora: 09:45 p.m.
' 
' Leer un vector v de 10 elementos del tipo entero y
' un escalar k del tipo entero, calcular k*v
' (multiplicación por escalar, significa multiplicar
' cada elemento del vector por el valor de k).
'
Module Program
	Sub Main()
		Dim v(9) As Integer
		Dim k As Integer
		dim resultado as Integer=0
		Dim i As Integer
			console.Write("Escriba el primer elemento: ")
			v(0)=CInt(console.ReadLine())
			console.Write("Escriba el segundo elemento: ")
			v(1)=CInt(console.ReadLine())
			console.Write("Escriba el tercer elemento: ")
			v(2)=CInt(console.ReadLine())
			console.Write("Escriba el cuarto elemento: ")
			v(3)=CInt(console.ReadLine())
			console.Write("Escriba el quinto elemento: ")
			v(4)=CInt(console.ReadLine())
			console.Write("Escriba el sexto elemento: ")
			v(5)=CInt(console.ReadLine())
			console.Write("Escriba el septimo elemento: ")
			v(6)=CInt(console.ReadLine())
			console.Write("Escriba el octavo elemento: ")
			v(7)=CInt(console.ReadLine())
			console.Write("Escriba el noveno elemento: ")
			v(8)=CInt(console.ReadLine())
			console.Write("Escriba el decimo elemento: ")
			v(9)=CInt(console.ReadLine())
			console.Write("Escriba el valor del escalar: ")
			k=Cint(console.ReadLine())
			
		For i=0 To 9
			resultado=k*v(i)
			
				console.Writeline("El resultado es : " & resultado)			
		Next i
				console.ReadLine()
	End Sub
End Module
