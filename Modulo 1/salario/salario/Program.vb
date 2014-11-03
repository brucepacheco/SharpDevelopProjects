'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 14/09/2014
' Hora: 06:55 p.m.
' 
' 5. Dado el salario base y los días trabajados por un empleado,
'calcule su salario. Solución: lea el salario base, lea los días trabajados,
'Multiplique el salario base por los días trabajados.

Module Program
	Dim salarioBase As Double
	Dim diasTrabajados As Integer
	Dim salario As Double
	
	Sub introducirSalariobase()
		console.Write("ESCRIBA EL SALARIO BASE DEL TRABAJADOR: ")
		salarioBase=cdbl(console.ReadLine())
	End Sub
	Sub introducirDiastrabajados()
		console.Write("CUANTOS DIAS LABORO EL TRABAJADOR: ")
		diasTrabajados=cint(console.ReadLine())
	End Sub
	Sub calcularSalario()
		salario=salarioBase*diasTrabajados
	End Sub
	
	Sub Main()
		introducirSalariobase()
		introducirDiastrabajados()
		calcularSalario()
			Console.WriteLine("EL SALARIO DEL TRABAJADOR ES {0}", salario)
		
		
		Console.Write("Presiona una tecla para salir . . . ")
		Console.ReadKey(True)
	End Sub
End Module
