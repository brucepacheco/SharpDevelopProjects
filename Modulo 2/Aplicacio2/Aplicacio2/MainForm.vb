'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 02:02 p.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	Sub calculo()
		Dim ancho, largo As Double
		Dim area As Double
		ancho=CDbl(Me.txtAncho.Text)
		largo=CDbl(Me.txtLargo.Text)
		area=ancho*largo
		Me.txtArea.Text=CStr(area)
	End Sub
	
	Sub BtnAreaClick(sender As Object, e As EventArgs)
		calculo()
		
	End Sub
	Sub convertir()
		Dim millas As double
		Dim kmequivale As double=1.16
		Dim km As double
		millas=Cdbl(Me.txtMillas.Text)
		km=millas*kmequivale
		Me.txtKm.Text=CStr(km)
				
	End Sub
	Sub BtnKmClick(sender As Object, e As EventArgs)
		convertir()
	End Sub
End Class
