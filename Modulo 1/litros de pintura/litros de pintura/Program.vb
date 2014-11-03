'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 14/09/2014
' Hora: 11:02 a.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Module Program
	Dim litrosPintura As Double = 2.5
	Dim totalDeparedes as Integer = 4
	Dim altoCuarto, anchoCuarto, areaDeunapared, areaDelosmuros, pinturaTotal as Double
	Sub mensajePrograma()
		console.WriteLine("Programa que calcula los litros de pintura necesaria para pintar un cuarto, sabiendo que un litro de pintura cubre 2.5mts cuadrados y el numero de paredes son 4. ")
	End Sub
	Sub leerAreapared()
		console.Write("Escriba el alto del cuarto: ")
		altoCuarto=cdbl(console.ReadLine())
		console.Write("Escriba el ancho del cuarto: ")
		anchoCuarto=cdbl(console.ReadLine())
	End Sub	
	Sub calcularAreadeunapared()
		areaDeunapared=altoCuarto*anchoCuarto
	End Sub	
	sub calcularAreadelosmuros()
		areaDelosmuros=areaDeunapared*totalDeparedes
	End Sub	
	Sub calcularPinturatotal()
		pinturaTotal=areaDelosmuros/litrosPintura
	End Sub
	Sub escribirLitrosnecesarios()
			console.writeline("Los litros necesarios de pintura son = {0}", pinturatotal)
	End Sub
	Sub Main()
		mensajePrograma()
		leerAreapared()
		calcularAreadeunapared()
		calcularAreadelosmuros()
		calcularPinturatotal()
		escribirLitrosnecesarios()
			console.Write("Presione una tecla para salir del programa...")
			console.ReadLine()
	End Sub
End Module
