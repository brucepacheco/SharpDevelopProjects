'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 14/09/2014
' Hora: 06:43 p.m.
' 
' 4. Dada un población p y una cantidad m de habitantes de sexo femenino
'escriba un algoritmo que calcule el porcentaje de la población de sexo masculino.
'Solución calcule la cantidad de hombres h=p-m, el porcentaje de hombres será h/p.


Module Program
	Dim poblacion As Integer
	Dim habitantesFemenino As Integer
	Dim habitantesMasculino As Integer
	
	Sub introducirPoblacion()
			Console.Write("CUAL ES EL NUMERO TOTAL DE HABITANTES: ")
		poblacion=cint(console.ReadLine())
	End Sub
	Sub introducirFemenino()
			Console.Write("CUAL ES EL NUMERO DE HABITANTES FEMENINOS: ")
		habitantesFemenino=cint(console.ReadLine())
	End Sub
	Sub calcularHabitantesmasculino()
		habitantesMasculino=poblacion-habitantesFemenino
	End Sub
	
	Sub Main()
		introducirPoblacion()
		introducirFemenino()
		calcularHabitantesmasculino()		
			Console.Write("EL NUMERO DE HABITANTES MASCULINO ES {0} ", habitantesMasculino)
			Console.ReadKey(True)
	End Sub
End Module
