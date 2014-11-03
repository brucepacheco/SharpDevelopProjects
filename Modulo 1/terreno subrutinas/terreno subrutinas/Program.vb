Imports System.IO
Module uno
	dim base, altura, area As Single
	Sub leerLongitudes()
		console.Write("deme la longitud de frente del terreno ")
		base=Convert.ToInt32(Console.ReadLine())
		console.Write("deme la longitud del lado del terreno ")
		altura=Convert.ToInt32(Console.ReadLine())
	End Sub
	Sub calcularArea()
		area=base*altura
	End sub
	sub escribirResultado()
			console.writeline("resultado = {0}",area)
	End Sub
	Sub main()
		leerLongitudes()
		calcularArea()
		escribirResultado()
		console.ReadLine()
	End Sub
End Module