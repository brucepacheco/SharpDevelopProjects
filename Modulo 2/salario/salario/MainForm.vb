'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 27/10/2014
' Hora: 11:43 p.m.
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
		'Zona0=México, Puebla, Monterrey, Jalisco, con un salario de 300
		'Zona2=Veracruz, Tamaulipas, con un salario de 270
		'Zona3=Cualquier otro estado, con un salario de 250
		Dim Zona0 As Integer = 0
		Dim Zona1 As Integer = 1
		Dim Zona2 As Integer = 2
		Dim Salario0 As Integer = 300
		Dim Salario1 As Integer = 270
		Dim Salario2 As Integer = 250
		Dim opcionUsuario As Integer
		
		opcionusuario=Me.txtEstado.Text
		
		If opcionUsuario=Zona0 Then
			Me.txtSalario.Text=CStr(Salario0)
		Else If opcionUsuario=Zona1 Then
			Me.txtSalario.Text=CStr(Salario1)
		Else If opcionUsuario=Zona2 Then
			Me.txtSalario.Text=CStr(Salario2)
		End If
		
	End Sub
	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub TxtSalarioTextChanged(sender As Object, e As EventArgs)
				
		
	End Sub
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		calculo()
		
	End Sub
End Class
