'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 14/09/2014
' Hora: 05:18 p.m.
' 
'Si la fórmula de interés simple es: dada una tasa t, un período de tiempo n y un monto p,
'el interés ganado por ese monto p a esa tasa t en el período de tiempo n es:
'i=p*t*n
'Por ejemplo el interés para un monto p=100 pesos a una taza del 2.5 mensual por un tiempo de 3 meses es:
'i=100*(2.5/100)*3, Solución: lea, el monto, la taza y el número de periodos,
'y calcule el interés con la formula.
'Escriba un algoritmo para cálculo del interés.


Module Program
	Dim tasa, tiempo, monto,tasadeinteres, interes, ganancia As Double 	
	
	Sub introducirTasa()
		console.Write("CUAL ES EL MONTO: ")
		monto=cdbl(console.ReadLine())
	End Sub
	Sub introducirTiempo()
		console.write("TASA DE INTERES: ")
		tasa=cdbl(console.ReadLine())
	End Sub
	Sub introducirMonto()
		console.Write("NUMERO DE PERIODOS: ")
		tiempo=cdbl(console.ReadLine())
	End Sub
	Sub calcularTasadeinteres()
		tasadeinteres=tasa/100
	End Sub
	Sub calcularInteres()
		interes=monto*(tasadeinteres)*tiempo
	End Sub
	
	Sub Main()
		introducirTasa()
		introducirTiempo()
		introducirMonto()
		calcularTasadeinteres()
		calcularInteres()
		console.WriteLine("El total de interes sobre el monto calculado es: {0}", interes)
		console.ReadLine()
			
	End Sub
End Module
