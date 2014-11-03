'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 01:11 p.m.
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
	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub LblMAlumClick(sender As Object, e As EventArgs)
		
	End Sub
	Sub promedio()
		Dim m1, m2, m3 As Double
		Dim promedio As Double
		m1=CDbl(Me.txtMI.Text)
		m2=CDbl(Me.txtMII.Text)
		m3=CDbl(Me.txtMIII.text)
		promedio=(m1+m2+m3)/3
		Me.txtPromedio.Text=CStr(promedio)
			
	End Sub
	Sub BtnPromedioClick(sender As Object, e As EventArgs)
		promedio()
	End Sub
End Class
