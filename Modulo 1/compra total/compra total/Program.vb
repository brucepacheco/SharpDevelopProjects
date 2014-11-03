'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 14/09/2014
' Hora: 03:19 p.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar

'2.	Dado el precio de los artículos y dada una cantidad de artículos comprados, todos del mismo precio,
'escriba un programa que calcule el total de la compra, el iva y el total a pagar

Module Program
	Dim precioArticulos As Double 
	Dim articulosComprados As Double 
	Dim subtotalCompra As Double
	Dim totalCompra As Double
	Dim ivaDelacompra As Double
	Dim impuesto As Double = 0.16
	Dim totalDelacompra As Double
	dim signo as String = "$"
	Sub mensaje()
		console.Write("PROGRAMA PARA CALCULAR EL TOTAL DE COMPRA DE ARTICULOS:")
	End Sub
	Sub introcudirPreciodelarticulo()
		console.Write("CUAL ES EL PRECIO DEL ARTICULO: ")
		precioArticulos=cdbl(console.ReadLine())
	End Sub
	Sub introducirArticuloscomprados()
		console.Write("CUANTOS ARTICULOS NECESITA: ")
		articulosComprados=cint(console.ReadLine())
	End Sub
	Sub calcularSubtotalompra()
		subtotalCompra=precioArticulos*articuloscomprados		
	End Sub
	Sub calcularIvadelacompra()
		ivaDelacompra=subtotalCompra*impuesto
	End Sub
	Sub calcularTotaldelacompra()
		totalDelacompra=subtotalCompra+ivaDelacompra
	End Sub

	Sub Main()
		mensaje()
			console.ReadLine()
		introcudirPreciodelarticulo()	
		introducirArticuloscomprados()
		calcularSubtotalompra()
		calcularIvadelacompra()
		calcularTotaldelacompra()
			console.Write("EL SUBTOTAL ES: {0} {1} ", signo,subtotalCompra)
			console.ReadLine()
			console.Write("EL I.V.A. AL 16% ES: {0} {1}", signo,ivaDelacompra)
			console.ReadLine()
			console.Write("EL TOTAL ES: {0} {1}", signo,totalDelacompra)
			console.ReadLine()
			console.Write("Presione una tecla para cerrar el programa")
			console.ReadLine()
	End Sub
End Module
