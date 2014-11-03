'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 03:36 p.m.
'
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class MainForm
	Dim memoria As Integer=0
	Dim b, resultado As Integer
	Dim operador As String="nada"
			
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Btn1Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="1"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "1"
		End if 
	End Sub
	
	Sub BtnCClick(sender As Object, e As EventArgs)
		Me.memoria="0"
		me.txtResultado.Text="0"
		
	End Sub
	
	Sub Btn0Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="0"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "0"
		End if 
	End Sub
	
	Sub Btn2Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="2"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "2"
		End if 
	End Sub
	
	Sub Btn3Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="3"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "3"
		End if 
	End Sub
	
	Sub Btn4Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="4"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "4"
		End if 
	End Sub
	
	Sub Btn5Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="5"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "5"
		End if 
	End Sub
	
	Sub Btn6Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="6"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "6"
		End if 
	End Sub
	
	Sub Btn7Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="7"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "7"
		End if 
	End Sub
	
	Sub Btn8Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="8"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "8"
		End if 
	End Sub
	
	Sub Btn9Click(sender As Object, e As EventArgs)
		If Me.txtResultado.Text="0" Then
			me.txtResultado.Text="9"
		Else
			Me.txtResultado.Text=Me.txtResultado.Text & "9"
		End if 
	End Sub
	
	Sub BtnMasClick(sender As Object, e As EventArgs)
		Me.memoria=CInt(Me.txtResultado.Text)
		Me.txtResultado.Text="0"
		me.operador="mas"
		
	End Sub
	
	Sub BtnMenosClick(sender As Object, e As EventArgs)
		Me.memoria=CInt(Me.txtResultado.Text)
		Me.txtResultado.Text="0"
		me.operador="menos"
	End Sub
	
	Sub BtnIgualClick(sender As Object, e As EventArgs)
		b=CInt(Me.txtResultado.Text)
			If Me.operador="mas" Then
				resultado=memoria+b
			End If
			If Me.operador="menos" Then
				resultado=memoria-b
			End If
		Me.txtResultado.Text=CStr(resultado)
						
	End Sub
	
End Class
