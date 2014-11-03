Imports system.IO
Module uno
	Sub main
		'Programa que lee 2 números e indica cual es el mayor de los 2.
		Dim numero1, numero2 As Integer
		console.write("Escriba un numero entero:")
		numero1=console.ReadLine()
		console.Write("Escriba otro numero entero:")
		numero2=console.ReadLine()
		If(numero1>=numero2) Then
			console.WriteLine("El primer numero es el mayor")
		Elseif(numero2>=numero1) Then
			console.WriteLine("El segundo numero es el mayor")
		End If	
		console.WriteLine("Gracias por ayudarnos.")
		console.ReadLine()
	End Sub
End Module
