Imports system.IO
Module uno
	Sub main
		'Programa que lee 10 números e indica cual es el menor de los 10..
		Dim n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 As Integer
		console.WriteLine("Programa que lee 10 números e indica cual es el menor de los 10.")
		console.write("Escriba el primer numero:")
			n1=console.ReadLine()
		console.Write("Escriba el segundo numero:")
			n2=console.ReadLine()
		console.write("Escriba el tercer numero:")
			n3=console.ReadLine()
		console.Write("Escriba el cuarto numero:")
			n4=console.ReadLine()
		console.write("Escriba el quinto numero:")
			n5=console.ReadLine()
		console.Write("Escriba el sexto numero:")
			n6=console.ReadLine()
		console.write("Escriba el septimo numero:")
			n7=console.ReadLine()
		console.Write("Escriba el octavo numero:")
			n8=console.ReadLine()
		console.write("Escriba el noveno numero:")
			n9=console.ReadLine()
		console.Write("Escriba el decimo numero:")
			n10=console.ReadLine()
		If(n1<=n2, n3, n4, n5, n6, n7, n8, n9, n10) Then
			console.WriteLine("El Primer numero es el menor")
		End If	
		console.WriteLine("Gracias por ayudarnos.")
		console.ReadLine()
	End Sub
End Module

