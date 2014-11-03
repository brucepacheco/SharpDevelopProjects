'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 08:55 a.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class MainForm
		Dim calM1, calP1, calB1 As double
		Dim calM2, calP2, calB2 As Double
		Dim calM3, calP3, calB3 As double
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
	End Sub
	Sub promedioLuis()
		Dim proxalumno As Double
		calM1=Cdbl(Me.txtMatLuis.Text)
		calP1=Cdbl(Me.txtProLuis.Text)
		calB1=Cdbl(Me.txtBioLuis.Text)
		proxalumno=(calM1+calP1+CalB1)/3
		Me.txtPLuis.Text=CStr(proxalumno)
	End Sub
	Sub promedioJuan()
		Dim proxalumno As Double
		calM2=Cdbl(Me.txtMatJuan.Text)
		calP2=Cdbl(Me.txtProJuan.Text)
		calB2=Cdbl(Me.txtBioJuan.Text)
		proxalumno=(calM2+calP2+CalB2)/3
		Me.txtPJuan.Text=CStr(proxalumno)
	End Sub
	Sub promedioRosa()
		Dim proxalumno As Double
		calM3=Cdbl(Me.txtMatRosa.Text)
		calP3=Cdbl(Me.txtProRosa.Text)
		calB3=Cdbl(Me.txtBioRosa.Text)
		proxalumno=(calM3+calP3+CalB3)/3
		Me.txtPRosa.Text=CStr(proxalumno)
	End Sub
	
	Sub BtnPxaClick(sender As Object, e As EventArgs)
		promedioLuis()
		promedioJuan()
		promedioRosa()
		
		
		
	End sub
	Sub proMat()
		Dim proxmat As Double
		calM1=Cdbl(Me.txtMatLuis.Text)
		calM2=Cdbl(Me.txtMatJuan.Text)
		calM3=Cdbl(Me.txtMatRosa.Text)
		proxmat=(calM1+calM2+CalM3)/3
		Me.txtPMat.Text=CStr(proxmat)
	End Sub
	Sub proPro()
		Dim proxmat As Double
		calP1=Cdbl(Me.txtProLuis.Text)
		calP2=Cdbl(Me.txtProJuan.Text)
		calP3=Cdbl(Me.txtProRosa.Text)
		proxmat=(calP1+calP2+CalP3)/3
		Me.txtPPro.Text=CStr(proxmat)
	End Sub
	Sub proBio()
		Dim proxmat As Double
		calB1=Cdbl(Me.txtBioLuis.Text)
		calB2=Cdbl(Me.txtBioJuan.Text)
		calB3=Cdbl(Me.txtBioRosa.Text)
		proxmat=(calB1+calB2+CalB3)/3
		Me.txtPBio.Text=CStr(proxmat)
	End Sub
	
	
	
	Sub BtnPxmClick(sender As Object, e As EventArgs)
		proMat()
		proPro()
		proBio()
	End Sub
End Class
